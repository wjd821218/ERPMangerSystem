using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 领料单
    /// </summary>
    public partial class XtraReportDrawOrder: DevExpress.XtraReports.UI.XtraReport
    {

        public XtraReportDrawOrder()
        {
            InitializeComponent();

            IniControl_CN();

         }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind()
        {

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


            xrDrawOrderID.DataBindings.Add("Text", this.DataSource, "DrawOrder.DrawOrderID");
            xrDrawOrderDate.DataBindings.Add("Text", this.DataSource, "DrawOrder.DrawOrderDate");
            xrDrawPerson.DataBindings.Add("Text", this.DataSource, "DrawOrder.DrawPerson");
            xrEmitPerson.DataBindings.Add("Text", this.DataSource, "DrawOrder.EmitPerson");
            xrOutStorage.DataBindings.Add("Text", this.DataSource, "DrawOrder.OutStorage");
            xrRemark.DataBindings.Add("Text", this.DataSource, "DrawOrder.Remark");

            xrCreateName.DataBindings.Add("Text", this.DataSource, "DrawOrder.CreateGuid");
            xrCreateDate.DataBindings.Add("Text", this.DataSource, "DrawOrder.CreateDate");
            xrCheckName.DataBindings.Add("Text", this.DataSource, "DrawOrder.CheckGuid");
            xrCheckDate.DataBindings.Add("Text", this.DataSource, "DrawOrder.CheckDate");



            //明细表
            xrMaterialID.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.Unit");
            xrMaterialSum.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.MaterialSum");
            xrApplyMaterialSum.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.ApplyMaterialSum");
            xrConsumeSum.DataBindings.Add("Text", this.DataSource, "DrawOrderDetail.ConsumeSum");
            

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "DrawOrderDetail.MaterialSum", "{0:0.###}") });
            xrApplyMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "DrawOrderDetail.ApplyMaterialSum", "{0:0.###}") });
            xrConsumeSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "DrawOrderDetail.ConsumeSum", "{0:0.####}") });
         

            xrPrintTime.DataBindings.Add("Text", this.DataSource, "DrawOrder.PrintTime");
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

        private void xrMaterialSum_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string str = ((XRTableCell)sender).Text;
            ((XRTableCell)sender).Text = decimal.Parse(str).ToString("g0");


        }


        private void XtraReportDrawOrder1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataBind();
        }

    }



}
