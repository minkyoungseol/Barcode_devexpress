using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLIB;

namespace Barcode
{
    public partial class Print_Barcode : Form
    {
        clsDBLib db = new clsDBLib();
        // 바코드 번호
        List<string> barcode_List = new List<string>();
        public static string MB;
        public static string SB1;
        public static string SB2;
        // 발행일
        string conDate;
        // 메모
        string remark;
        // 발행인
        string createUser;

        public Print_Barcode()
        {
            InitializeComponent();
            App_Main.Read_INI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string defaultPrinter = ConfigurationManager.AppSettings["DEFAULTPRINTER"];

            conDate = System.DateTime.Now.ToString("yyyyMMdd");
            txt_ConDate.Text = conDate;
            PrinterSettings ps = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                ps.PrinterName = printer;
                combo_Printer.Items.Add(printer);

                combo_Printer.SelectedItem = defaultPrinter;
                /*
                if (ps.IsDefaultPrinter)
                    defaultPrinter = printer;*/
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
           
            conDate = txt_ConDate.Text.Replace("-", "");
            MB = Create_BarcodeNum("MB", conDate);
            SB1 = Create_BarcodeNum("SB", conDate);
            SB2 = Create_BarcodeNum("SB", conDate);

            barcode_List = new List<string>();
            barcode_List.Add(SB1);
            barcode_List.Add(SB2);

            remark = txt_Remark.Text;
            createUser = txt_CreateUser.Text;

            /// 메모, 발행인 빈칸 검증
            if (remark.Trim().Length == 0)
            {
                MessageBox.Show("메모를 입력해주세요!", "알림");
                return;
            }
            else if (createUser.Trim().Length == 0)
            {
                MessageBox.Show("발행인을 입력해주세요!", "알림");
                return;
            }

            try
            {
                Barcode barcode = new Barcode(MB, SB1, SB2);
                barcode.PrintDialog();

                listBox1.Items.Add("출력시간 : " + DateTime.Now.ToString());
                listBox1.Items.Add("바코드 NO : " + MB);                                                   // 리스트 박스에 메인 바코드 정보 출력
                Insert_MBarcode_Info(MB, remark, conDate, createUser);                                     // DB에 메인 바코드 정보 입력
                for (int i = 0; i < barcode_List.Count; i++)
                {
                    listBox1.Items.Add("바코드 NO : " + barcode_List[i]);                                  // 리스트 박스에 서브 바코드 정보 출력
                    Insert_SBarcode_Info(MB, barcode_List[i].ToString(), remark, conDate, createUser);     // DB에 서브 바코드 정보 입력
                }
                listBox1.Items.Add("발행인 : " + createUser);
                listBox1.Items.Add("메  모 : " + remark + "\r\n");

                txt_CreateUser.Text = string.Empty;
                txt_Remark.Text = string.Empty;
            }           
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        #region >>>>> DB 채번Table에서 채번해오기
        private string Create_BarcodeNum(string gubun, string conDate)
        {
            string BARCODENUM = "";
            try
            {
                string sQuery = "";

                sQuery = "EXEC SP_MD_GETNO_R @HEADER, @SEQLENGTH, @CONDATE"; // 채번 프로시저 실행

                SqlParameter[] sPrm = new SqlParameter[3]
                {
                      new SqlParameter("@HEADER", gubun)
                    , new SqlParameter("@SEQLENGTH", 5)
                    , new SqlParameter("@CONDATE", conDate)
                };

                BARCODENUM = db.selectParmQuery(sQuery, sPrm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return BARCODENUM;
        }
        #endregion

        #region >>>>> DB에 출력한 바코드 정보 넣기

        /// <summary>
        /// 메인 바코드 정보 넣기
        /// </summary>
        /// <param name="mBarcode"></param>     메인바코드 번호
        /// <param name="remark"></param>       메모
        /// <param name="conDate"></param>      사용자 지정 발행 기준일
        /// <param name="createUser"></param>   발행인
        private void Insert_MBarcode_Info(string mBarcode, string remark, string conDate, string createUser)
        {
            try
            {
                string sQuery = "";

                sQuery = "EXEC SP_MBARCODE_C @MBARCODEINFO, @REMARK, @CONDATE, @CREATUSER";

                SqlParameter[] sPrm = new SqlParameter[4]
                {
                      new SqlParameter("@MBARCODEINFO", mBarcode)
                    , new SqlParameter("@REMARK", remark)
                    , new SqlParameter("@CONDATE", conDate)
                    , new SqlParameter("@CREATUSER", createUser)
                };

                db.NonQueryParams(sQuery, sPrm);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 서브 바코드 정보 넣기
        /// </summary>
        /// <param name="mBarcode"></param>     메인바코드 번호
        /// <param name="sBarcode"></param>     서브바코드 번호
        /// <param name="remark"></param>       메모
        /// <param name="conDate"></param>      사용자 지정 발행 기준일
        /// <param name="createUser"></param>   발행인
        private void Insert_SBarcode_Info(string mBarcode, string sBarcode, string remark, string conDate, string createUser)
        {
            try
            {
                string sQuery = "";

                sQuery = "EXEC SP_SBARCODE_C @MBARCODEINFO, @SBARCODEINFO, @REMARK, @CONDATE, @CREATEUSER";

                SqlParameter[] sPrm = new SqlParameter[5]
                {
                      new SqlParameter("@MBARCODEINFO", mBarcode)
                    , new SqlParameter("@SBARCODEINFO", sBarcode)
                    , new SqlParameter("@REMARK", remark)
                    , new SqlParameter("@CONDATE", conDate)
                    , new SqlParameter("@CREATEUSER", createUser)
                };

                db.NonQueryParams(sQuery, sPrm);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void btn_Status_Click(object sender, EventArgs e)
        {
            //Status_Board status_Board = new Status_Board();
            //status_Board.ShowDialog();
        }
    }
}
