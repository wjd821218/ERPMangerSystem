using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 其它出库单
    /// </summary>
    public partial class XtraReportOtherSellOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportOtherSellOrder(DataSet ds1, string Client, string SellOrderID, string SellOrderDate, string OutStorage,
            string StoragePerson, string QualityPerson, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate,bool IsDisplayPrice)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind( ds1,   Client,  SellOrderID,  SellOrderDate,  OutStorage,
             StoragePerson, QualityPerson, Remark, CreateName, CreateDate, CheckName, CheckDate, IsDisplayPrice);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string Client, string SellOrderID, string SellOrderDate, string OutStorage,
            string StoragePerson, string QualityPerson, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate, bool IsDisplayPrice)
        {
            this.DataSource = ds1;

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();



            xrClient.Text = Client;
            xrOtherSellOrderID.Text = SellOrderID;
            xrOtherSellOrderDate.Text = DateTime.Parse(SellOrderDate).ToString("yyyy-MM-dd");
            xrOutStorage.Text = OutStorage;
            xrStoragePerson.Text = StoragePerson;
            xrQualityPerson.Text = QualityPerson;
            xrRemark.Text = Remark;
        
          

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;
          
           
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "SellOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "SellOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "SellOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "SellOrderDetail.Unit");
            xrPrice.DataBindings.Add("Text", DataSource, "SellOrderDetail.Price");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "SellOrderDetail.MaterialSum");
            xrMaterialMoney.DataBindings.Add("Text", DataSource, "SellOrderDetail.MaterialMoney");
            xrDetailRemark.DataBindings.Add("Text", DataSource, "SellOrderDetail.Remark");



            //是否显示单价
            if (IsDisplayPrice == false)
            {
               
                xrTable11.DeleteColumn(xrTableCell5);
                xrTable11.DeleteColumn(xrTableCell7);

                xrTable8.DeleteColumn(xrPrice);
                xrTable8.DeleteColumn(xrMaterialMoney);

                xrTableCell1.Width = 160;
                xrDetailRemark.Width = 160;

                xrMaterialSum.Width = 100;
                xrTableCell15.Width = 100;

                xrTableCell13.Width = 80;
                xrUnit.Width = 80;
            
            }
            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "SellOrderDetail.MaterialSum", "{0:0.###}") });

            xrPrice.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "SellOrderDetail.Price", "{0:0.###}") });

            xrMaterialMoney.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "SellOrderDetail.MaterialMoney", "{0:0.####}") });



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
