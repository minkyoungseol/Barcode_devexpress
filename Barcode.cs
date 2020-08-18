using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.BarCode;

namespace Barcode
{
    public partial class Barcode : DevExpress.XtraReports.UI.XtraReport
    {
        public Barcode(string MB, string SB1, string SB2)
        {
            InitializeComponent();

           // ((DataMatrixGenerator)barcode_Sub2.Symbology).MatrixSize = DataMatrixSize.Matrix12x12;
            lb_MainBarcodeInfo.Text = MB;
            barcode_Main.Text = MB;
            barcode_Sub1.Text = SB1;
            barcode_Sub2.Text = SB2;
            pictureBox.ImageUrl = "C:\\Users\\seol\\Desktop\\seol\\미니언즈_바탕화면_(17).jpg";
        }

    }
}
