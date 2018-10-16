using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 付款单
    /// </summary>
    public partial class XtraReportPaymentOrderChild2: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportPaymentOrderChild2(DataSet ds1)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind( ds1);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1)
        {
            this.DataSource = ds1;

            //明细表
            xrPaymentID.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.PayName");
            xrPayMoney.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.PayMoney");
            xrCNY.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.CNYName");
            xrPayType.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.PayTypeName");
            xrRemark.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.Remark");


            xrPayMoney.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "PaymentOrderDetail1.PayMoney", "{0:0.###}") });

            //增加列合计
            XRSummary xrye = new XRSummary();
            xrTotalCount.DataBindings.Add("Text", DataSource, "PaymentOrderDetail1.PayMoney");
            xrye.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
            xrye.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            xrye.FormatString = "{0:0.###}";
            xrTotalCount.Summary = xrye;
       
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
