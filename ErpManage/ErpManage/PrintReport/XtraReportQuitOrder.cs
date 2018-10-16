using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 退料单
    /// </summary>
    public partial class XtraReportQuitOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportQuitOrder(DataSet ds1, string Supplier, string QuitOrderID, string QuitOrderDate, string StoragePerson,
            string DeliverGoodsPerson, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2,bool IsDisplayPrice,string OutStorage)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind( ds1,   Supplier,  QuitOrderID,  QuitOrderDate,  StoragePerson,
             DeliverGoodsPerson,  Remark ,  CreateName,  CreateDate,  CheckName,  CheckDate,  CheckName2,  CheckDate2, IsDisplayPrice,OutStorage);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string Supplier, string QuitOrderID, string QuitOrderDate, string StoragePerson,
            string DeliverGoodsPerson, string Remark
            , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2, bool IsDisplayPrice,string OutStorage)
        {
            this.DataSource = ds1;

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();

            xrSupplier.Text = Supplier;
            xrQuitOrderID.Text = QuitOrderID;
            xrQuitOrderDate.Text = DateTime.Parse(QuitOrderDate).ToString("yyyy-MM-dd");
            xrStoragePerson.Text = StoragePerson;
            xrDeliverGoodsPerson.Text = DeliverGoodsPerson;
            xrRemark.Text = Remark;
            xrOutStorage.Text = OutStorage;
          

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;

            xrCheckName2.Text = CheckName2;
            xrCheckDate2.Text = CheckDate2;
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "QuitOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "QuitOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "QuitOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "QuitOrderDetail.Unit");
            xrPrice.DataBindings.Add("Text", DataSource, "QuitOrderDetail.Price");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "QuitOrderDetail.MaterialSum");
            xrMaterialMoney.DataBindings.Add("Text", DataSource, "QuitOrderDetail.MaterialMoney");
            xrDetailRemark.DataBindings.Add("Text", DataSource, "QuitOrderDetail.Remark");

            //是否显示单价
            if (IsDisplayPrice == false)
            {
                // xrTableCell15.Width=0;
                // xrTableCell1.Width = 0;
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
                //xrPrice.Width = 0;
                //xrMaterialTotalMoney.Width = 0;
            }
            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "QuitOrderDetail.MaterialSum", "{0:0.###}") });

            xrPrice.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "QuitOrderDetail.Price", "{0:0.###}") });

            xrMaterialMoney.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "QuitOrderDetail.MaterialMoney", "{0:0.####}") });


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
