using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 超领单
    /// </summary>
    public partial class XtraReportExcessOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportExcessOrder(DataSet ds1, string ExcessOrderID, string ExcessOrderDate, string DrawPerson, string EmitPerson,
            string OutStorage, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, ExcessOrderID, ExcessOrderDate, DrawPerson, EmitPerson,
             OutStorage, Remark
            , CreateName, CreateDate, CheckName, CheckDate, CheckName2, CheckDate2);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string ExcessOrderID, string ExcessOrderDate, string DrawPerson, string EmitPerson,
            string OutStorage, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2)
        {
            this.DataSource = ds1;

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


            xrExcessOrderID.Text = ExcessOrderID;
            xrExcessOrderDate.Text = DateTime.Parse(ExcessOrderDate).ToString("yyyy-MM-dd");
            xrDrawPerson.Text = DrawPerson;
            xrEmitPerson.Text = EmitPerson;
            xrOutStorage.Text = OutStorage;
            xrRemark.Text = Remark;
        
          

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;

            xrCheckName2.Text = CheckName2;
            xrCheckDate2.Text = CheckDate2;
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.Unit");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.MaterialSum");
            xrMaterialOutSum.DataBindings.Add("Text", DataSource, "ExcessOrderDetail.MaterialOutSum");
         

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "ExcessOrderDetail.MaterialSum", "{0:0.###}") });
            xrMaterialOutSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "ExcessOrderDetail.MaterialOutSum", "{0:0.###}") });


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
