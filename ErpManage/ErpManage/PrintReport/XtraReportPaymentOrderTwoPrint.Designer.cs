namespace ErpManage.PrintReport
{
    partial class XtraReportPaymentOrderTwoPrint
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 6;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2,
            this.xrSubreport1});
            this.ReportHeader.Height = 844;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.Location = new System.Drawing.Point(17, 392);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.Size = new System.Drawing.Size(683, 400);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Location = new System.Drawing.Point(17, 8);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.Size = new System.Drawing.Size(683, 375);
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTableCell2.Size = new System.Drawing.Size(46, 25);
            // 
            // XtraReportPaymentOrderTwoPrint
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader});
            this.Margins = new System.Drawing.Printing.Margins(69, 49, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "8.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
    }
}
