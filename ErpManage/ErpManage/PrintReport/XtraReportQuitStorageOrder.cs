using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 退料入库单
    /// </summary>
    public partial class XtraReportQuitStorageOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportQuitStorageOrder(DataSet ds1, string QuitStorageOrderID, string QuitStorageOrderDate, string Dept,
               string InStorage, string MaterialPerson, string StoragePerson, string QualityPerson, string BatchNo,string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, QuitStorageOrderID, QuitStorageOrderDate, Dept,
                InStorage, MaterialPerson, StoragePerson, QualityPerson, BatchNo ,Remark
            , CreateName, CreateDate, CheckName, CheckDate);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string QuitStorageOrderID, string QuitStorageOrderDate, string Dept,
               string InStorage, string MaterialPerson, string StoragePerson, string QualityPerson,string BatchNo, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            this.DataSource = ds1;


            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();

            xrQuitStorageOrderID.Text = QuitStorageOrderID;
            xrQuitStorageOrderDate.Text = DateTime.Parse(QuitStorageOrderDate).ToString("yyyy-MM-dd"); ;
            xrDept.Text = Dept;
            xrInStorage.Text = InStorage;
            xrMaterialPerson.Text = MaterialPerson;
            xrStoragePerson.Text = StoragePerson;
            xrQualityPerson.Text = QualityPerson;
            xrBatchNo.Text = BatchNo;
            xrRemark.Text = Remark;
        
          

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;

         
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.Unit");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.MaterialSum");
            xrDetailRemark.DataBindings.Add("Text", DataSource, "QuitStorageOrderDetail.Remark");

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "QuitStorageOrderDetail.MaterialSum", "{0:0.###}") });


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
