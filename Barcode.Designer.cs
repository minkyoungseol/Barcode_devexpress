namespace Barcode
{
    partial class Barcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.DataMatrixGenerator dataMatrixGenerator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.barcode_Sub2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.pictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
            this.barcode_Sub1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.lb_MainBarcodeInfo = new DevExpress.XtraReports.UI.XRLabel();
            this.barcode_Main = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 1075F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.barcode_Sub2,
            this.pictureBox,
            this.barcode_Sub1,
            this.lb_MainBarcodeInfo,
            this.barcode_Main,
            this.xrLabel2,
            this.xrLabel1});
            this.xrPanel1.Dpi = 254F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(100, 100, 20, 20, 254F);
            this.xrPanel1.SizeF = new System.Drawing.SizeF(2020F, 1075F);
            this.xrPanel1.StylePriority.UsePadding = false;
            // 
            // barcode_Sub2
            // 
            this.barcode_Sub2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.barcode_Sub2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.barcode_Sub2.Dpi = 254F;
            this.barcode_Sub2.LocationFloat = new DevExpress.Utils.PointFloat(449.7917F, 429.0484F);
            this.barcode_Sub2.Module = 5.08F;
            this.barcode_Sub2.Name = "barcode_Sub2";
            this.barcode_Sub2.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.barcode_Sub2.ShowText = false;
            this.barcode_Sub2.SizeF = new System.Drawing.SizeF(452.4375F, 251.7224F);
            this.barcode_Sub2.StylePriority.UseBorders = false;
            this.barcode_Sub2.StylePriority.UseTextAlignment = false;
            dataMatrixGenerator1.MatrixSize = DevExpress.XtraPrinting.BarCode.DataMatrixSize.Matrix32x32;
            this.barcode_Sub2.Symbology = dataMatrixGenerator1;
            this.barcode_Sub2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.pictureBox.Dpi = 254F;
            this.pictureBox.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.pictureBox.LocationFloat = new DevExpress.Utils.PointFloat(0F, 680.7708F);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.SizeF = new System.Drawing.SizeF(902.2294F, 394.2293F);
            this.pictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.pictureBox.StylePriority.UseBorders = false;
            // 
            // barcode_Sub1
            // 
            this.barcode_Sub1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.barcode_Sub1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.barcode_Sub1.Dpi = 254F;
            this.barcode_Sub1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_Sub1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 429.0484F);
            this.barcode_Sub1.Module = 7F;
            this.barcode_Sub1.Name = "barcode_Sub1";
            this.barcode_Sub1.Padding = new DevExpress.XtraPrinting.PaddingInfo(70, 70, 5, 5, 254F);
            this.barcode_Sub1.ShowText = false;
            this.barcode_Sub1.SizeF = new System.Drawing.SizeF(449.7917F, 251.7224F);
            this.barcode_Sub1.StylePriority.UseBorders = false;
            this.barcode_Sub1.StylePriority.UseFont = false;
            this.barcode_Sub1.StylePriority.UsePadding = false;
            this.barcode_Sub1.StylePriority.UseTextAlignment = false;
            this.barcode_Sub1.Symbology = qrCodeGenerator1;
            this.barcode_Sub1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lb_MainBarcodeInfo
            // 
            this.lb_MainBarcodeInfo.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lb_MainBarcodeInfo.Dpi = 254F;
            this.lb_MainBarcodeInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MainBarcodeInfo.LocationFloat = new DevExpress.Utils.PointFloat(224.8958F, 354.9651F);
            this.lb_MainBarcodeInfo.Multiline = true;
            this.lb_MainBarcodeInfo.Name = "lb_MainBarcodeInfo";
            this.lb_MainBarcodeInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lb_MainBarcodeInfo.SizeF = new System.Drawing.SizeF(677.3334F, 74.0834F);
            this.lb_MainBarcodeInfo.StylePriority.UseBorders = false;
            this.lb_MainBarcodeInfo.StylePriority.UseFont = false;
            this.lb_MainBarcodeInfo.StylePriority.UseTextAlignment = false;
            this.lb_MainBarcodeInfo.Text = "lb_MainBarcodeInfo";
            this.lb_MainBarcodeInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // barcode_Main
            // 
            this.barcode_Main.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.barcode_Main.Dpi = 254F;
            this.barcode_Main.LocationFloat = new DevExpress.Utils.PointFloat(224.8958F, 87.52422F);
            this.barcode_Main.Module = 2.5F;
            this.barcode_Main.Name = "barcode_Main";
            this.barcode_Main.Padding = new DevExpress.XtraPrinting.PaddingInfo(75, 26, 40, 40, 254F);
            this.barcode_Main.ShowText = false;
            this.barcode_Main.SizeF = new System.Drawing.SizeF(677.3334F, 267.4409F);
            this.barcode_Main.StylePriority.UseBorders = false;
            this.barcode_Main.StylePriority.UsePadding = false;
            this.barcode_Main.StylePriority.UseTextAlignment = false;
            this.barcode_Main.Symbology = code128Generator1;
            this.barcode_Main.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 87.52422F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(224.8958F, 341.5243F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "LOT ID";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(902.2292F, 87.52422F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "RUN SHEET";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 40F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 40F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // barManager1
            // 
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barWorkspaceMenuItem1,
            this.barButtonItem1,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barCheckItem3});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 0;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 3;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "barCheckItem2";
            this.barCheckItem2.Id = 4;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.Caption = "barCheckItem3";
            this.barCheckItem3.Id = 5;
            this.barCheckItem3.Name = "barCheckItem3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Barcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel lb_MainBarcodeInfo;
        private DevExpress.XtraReports.UI.XRBarCode barcode_Main;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox;
        private DevExpress.XtraReports.UI.XRBarCode barcode_Sub1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraReports.UI.XRBarCode barcode_Sub2;
    }
}
