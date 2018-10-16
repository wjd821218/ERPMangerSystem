using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 报废单
    /// </summary>
    public partial class XtraReportRejectOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportRejectOrder(DataSet ds1, string RejectOrderID, string RejectOrderDate,string ProductType,string ClientOrderID,string StoragePerson,
                 string QualityPerson, string ProjectPerson, string StockPerson, string ProducePerson, string Remark, string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, RejectOrderID,  RejectOrderDate, ProductType, ClientOrderID, StoragePerson,
                  QualityPerson,  ProjectPerson,  StockPerson,  ProducePerson,  Remark,  CreateName,  CreateDate,  CheckName,  CheckDate,  CheckName2,  CheckDate2);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string RejectOrderID, string RejectOrderDate, string ProductType, string ClientOrderID, string StoragePerson,
                 string QualityPerson, string ProjectPerson, string StockPerson, string ProducePerson, string Remark, string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2)
        {
            this.DataSource = ds1;


            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


            xrRejectOrderID.Text = RejectOrderID;
            xrRejectOrderDate.Text = DateTime.Parse(RejectOrderDate).ToString("yyyy-MM-dd");


            xrProductType.Text = ProductType;
            xrClientOrderID.Text = ClientOrderID;
            xrStoragePerson.Text = StoragePerson;
            xrQualityPerson.Text = QualityPerson;
            xrProjectPerson.Text = ProjectPerson;
            xrStockPerson.Text = StockPerson;
            xrProducePerson.Text = ProducePerson;
            xrRemark.Text = Remark;

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;

            xrCheckName2.Text = CheckName2;
            xrCheckDate2.Text = CheckDate2;
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "RejectOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "RejectOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "RejectOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "RejectOrderDetail.Unit");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "RejectOrderDetail.MaterialSum");
            xrRemarkDetail.DataBindings.Add("Text", DataSource, "RejectOrderDetail.Remark");

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "RejectOrderDetail.MaterialSum", "{0:0.###}") });

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
