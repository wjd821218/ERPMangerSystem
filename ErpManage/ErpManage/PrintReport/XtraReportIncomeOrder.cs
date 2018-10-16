using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 收款单
    /// </summary>
    public partial class XtraReportIncomeOrder: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportIncomeOrder(DataSet ds1, string IncomeOrderID, string IncomeOrderDate, string ClientGuid, string IncomePerson, string Remark
             , string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, IncomeOrderID, IncomeOrderDate, ClientGuid, IncomePerson, Remark , CreateName,  CreateDate,  CheckName,  CheckDate);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string IncomeOrderID, string IncomeOrderDate, string ClientGuid, string IncomePerson, string Remark
             , string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            this.DataSource = ds1;

            XtraReportIncomeOrderChild XtraReportIncomeOrderChild = new XtraReportIncomeOrderChild(ds1);
            xrSubreport1.ReportSource = XtraReportIncomeOrderChild;


            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


            xrIncomeOrderID.Text = IncomeOrderID;
            xrIncomeOrderDate.Text = DateTime.Parse(IncomeOrderDate).ToString("yyyy-MM-dd");
            xrClientGuid.Text = ClientGuid;
            xrIncomePerson.Text = IncomePerson;
            xrRemark.Text = Remark;

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;
           
            
            
            //明细表
            this.DataSource = ds.Tables[1];
            xrSellOrderID.DataBindings.Add("Text", DataSource, "IncomeOrderDetail2.SellOrderID");
            xrSellOrderDate.DataBindings.Add("Text", DataSource, "IncomeOrderDetail2.SellOrderDate");
            xrSellOrderMoney.DataBindings.Add("Text", DataSource, "IncomeOrderDetail2.SellOrderMoney");
            xrRemark2.DataBindings.Add("Text", DataSource, "IncomeOrderDetail2.Remark");

            //日期格式的绑定
            xrSellOrderDate.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "IncomeOrderDetail2.SellOrderDate", "{0:yyyy-MM-dd}") });

            xrSellOrderMoney.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "IncomeOrderDetail2.SellOrderMoney", "{0:0.###}") });


            //增加列合计
            XRSummary xrye = new XRSummary();
            xrTotalCount.DataBindings.Add("Text", DataSource, "IncomeOrderDetail2.SellOrderMoney");
            xrye.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
            xrye.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            xrye.FormatString = "{0:0.###}";
            xrTotalCount.Summary = xrye;

            xrPrintTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
/*
            decimal decCTNS = 0;
            decimal decCBM = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                decCTNS = decCTNS + decimal.Parse(ds.Tables[0].Rows[i]["CTNS"].ToString());
                decCBM = decCBM + decimal.Parse(ds.Tables[0].Rows[i]["CBM"].ToString());
            }

            xrCTNSSum.Text = decCTNS.ToString();
            xtCBMSum.Text = decCBM.ToString();
*/

        }


        #region 控件汉化
        /// <summary>
        /// 将控件汉化
        /// </summary>
        private void IniControl_CN()
        {

            DevExpress.XtraBars.Localization.BarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraBarsLocalizationCHS();
            //DevExpress.XtraCharts.Localization.ChartLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraChartsLocalizationCHS();
            DevExpress.XtraEditors.Controls.Localizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraEditorsLocalizationCHS();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraGridLocalizationCHS();
            DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraLayoutLocalizationCHS();
            DevExpress.XtraNavBar.NavBarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraNavBarLocalizationCHS();
            //DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPivotGridLocalizationCHS();
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();
            DevExpress.XtraReports.Localization.ReportLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraReportsLocalizationCHS();
            //DevExpress.XtraRichTextEdit.Localization.XtraRichTextEditLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichTextEditLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerExtensionsLocalizationCHS();
            //DevExpress.XtraSpellChecker.Localization.SpellCheckerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSpellCheckerLocalizationCHS();
            //DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraTreeListLocalizationCHS();
            //DevExpress.XtraVerticalGrid.Localization.VGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraVerticalGridLocalizationCHS();
            //DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraWizardLocalizationCHS();
        }
        #endregion

    }



}
