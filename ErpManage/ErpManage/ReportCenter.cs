using System;
using System.Data;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.Drawing.Printing;

namespace ErpManage
{

    /// <summary>
    /// DevExpress Grid 打印通用类.
    /// </summary>
    public class ReportCenter
    {
   
        private PrintingSystem printSystem;
        private string mReportName;
        private string mCondition;

        public ReportCenter(IPrintable Printable)
        {
            printSystem = new PrintingSystem();
            mReportName = "";
            mCondition = "";
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = false;
            pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 2;
            printSystem.PageSettings.RightMargin = 2;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }
        public ReportCenter(IPrintable Printable, string ReportName)
        {
            printSystem = new PrintingSystem();
            mReportName = ReportName;
            mCondition = "";
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = false;
            pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 2;
            printSystem.PageSettings.RightMargin = 2;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }
        public ReportCenter(IPrintable Printable, string ReportName, string Condition)
        {
            printSystem = new PrintingSystem();
            mReportName = ReportName;
            mCondition = Condition;
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = true;
            //pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 30;
            printSystem.PageSettings.RightMargin = 30;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }

        public ReportCenter(IPrintable Printable, string ReportName, string Condition, bool Landscape)
        {
            printSystem = new PrintingSystem();
            mReportName = ReportName;
            mCondition = Condition;
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = true;
            //pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printSystem.PageSettings.Landscape = Landscape;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 30;
            printSystem.PageSettings.RightMargin = 30;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }

        public ReportCenter(IPrintable Printable, PaperKind paperKind)
        {
            printSystem = new PrintingSystem();
            mReportName = "";
            mCondition = "";
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = false;
            pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = paperKind;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 2;
            printSystem.PageSettings.RightMargin = 2;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }
        public ReportCenter(IPrintable Printable, string ReportName, PaperKind paperKind)
        {
            printSystem = new PrintingSystem();
            mReportName = ReportName;
            mCondition = "";
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = true;
            //pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = paperKind;
            printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 30;
            printSystem.PageSettings.RightMargin = 30;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }
        public ReportCenter(IPrintable Printable, string ReportName, string Condition, PaperKind paperKind)
        {
            printSystem = new PrintingSystem();
            mReportName = ReportName;
            mCondition = Condition;
            PrintableComponentLink pcl = new PrintableComponentLink();
            pcl.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalHeaderArea);
            pcl.CreateMarginalFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(link_CreateMarginalFooterArea);
            pcl.Component = Printable;
            printSystem.Links.Add(pcl);
            pcl.CreateDocument();

            PrinterSettingsUsing pst = new PrinterSettingsUsing();
            pst.UseMargins = true;
            //pst.UsePaperKind = false;
            printSystem.PageSettings.PaperKind = paperKind;
            //printSystem.PageSettings.PaperName = "A4";
            printSystem.PageSettings.LeftMargin = 30;
            printSystem.PageSettings.RightMargin = 30;
            printSystem.PageSettings.AssignDefaultPrinterSettings(pst);
        }

        private void link_CreateMarginalHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            if (mReportName != "")
            {
                e.Graph.Font = new Font("宋体", 15, FontStyle.Bold);
                e.Graph.BackColor = Color.Transparent;
               // RectangleF r = new RectangleF(0, 20, 0, e.Graph.Font.Height + 20);
                RectangleF r = new RectangleF(0, 50, 0, e.Graph.Font.Height + 20);
                PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, mReportName, Color.Black, r, BorderSide.None);
                brick.Alignment = BrickAlignment.Center;
                brick.AutoWidth = true;
            }

            if (mCondition != "")
            {
                e.Graph.Font = new Font("宋体", 10);
                e.Graph.BackColor = Color.Transparent;
                RectangleF r = new RectangleF(0, 50, 0, e.Graph.Font.Height + 20);
                PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, mCondition, Color.Black, r, BorderSide.None);
                brick.Alignment = BrickAlignment.Center;
                brick.AutoWidth = true;
            }
        }
        private void link_CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
        {
            string format = "第{0}页 共{1}页";
            e.Graph.Font = new Font("宋体", 10);
            e.Graph.BackColor = Color.Transparent;

            RectangleF r = new RectangleF(0, 5, 0, e.Graph.Font.Height + 20);

            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, format, Color.Black, r, BorderSide.None);
            brick.Alignment = BrickAlignment.Far;
            brick.AutoWidth = true;

            brick = e.Graph.DrawPageInfo(PageInfo.DateTime, "打印时间:" + DateTime.Today.ToLongDateString(), Color.Black, r, BorderSide.None);
            brick.Alignment = BrickAlignment.Near;
            brick.AutoWidth = true;
        }

        public void Print()
        {
            printSystem.Print();
        }

        public void Preview()
        {

            printSystem.PreviewFormEx.Show();

        }

        public void Designe()
        { }


    }
}
