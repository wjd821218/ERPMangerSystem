using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 客户订单打印
    /// </summary>
    public partial class XtraReportClientOrder: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportClientOrder(DataSet ds1, string ClientOrderID, string ClientOrderDate, string EncasementDate,
            string ContractID, string CheckBatchID, string DownDept, string ReceiveDept,string Remark,
            string CreateName,string CreateDate,string CheckName,string CheckDate,string CheckName2,string CheckDate2)
            
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds, ClientOrderID, ClientOrderDate, EncasementDate, ContractID, CheckBatchID, DownDept, ReceiveDept, Remark,
                     CreateName, CreateDate, CheckName, CheckDate, CheckName2, CheckDate2    
                );
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string ClientOrderID,string ClientOrderDate,string EncasementDate,string ContractID, 
            string CheckBatchID,string  DownDept, string ReceiveDept,string  Remark,
             string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2
            )
        {
            this.DataSource = ds1;

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


           // xrClientOrderID.Text = ClientOrderID;
            xrClientOrderDate.Text = DateTime.Parse(ClientOrderDate).ToString("yyyy-MM-dd");
            if (EncasementDate.Trim() != "")
            {
                xrEncasementDate.Text = DateTime.Parse(EncasementDate).ToString("yyyy-MM-dd");
            }
            else
            {
                xrEncasementDate.Text = "";
            }
            xrContractID.Text = ContractID;
            xrCheckBatchID.Text = CheckBatchID;
            xrDownDept.Text = DownDept;
            xrReceiveDept.Text = ReceiveDept;
            xrRemark.Text = Remark;

            xrCreateName.Text = CreateName;
        //    xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;
         //   xrCheckName2.Text = CheckName2;
          //  xrCheckDate2.Text = CheckDate2;



            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrMaterialID.DataBindings.Add("Text", DataSource, "ClientOrderDetail.MaterialID");
            xrMaterialName.DataBindings.Add("Text", DataSource, "ClientOrderDetail.MaterialName");
            xrSpec.DataBindings.Add("Text", DataSource, "ClientOrderDetail.Spec");
            xrUnit.DataBindings.Add("Text", DataSource, "ClientOrderDetail.Unit");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "ClientOrderDetail.MaterialSum");
            xrRemarkDetail.DataBindings.Add("Text", DataSource, "ClientOrderDetail.Remark");
            xrClientNo.DataBindings.Add("Text", DataSource, "ClientOrderDetail.ClientID");

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "ClientOrderDetail.MaterialSum", "{0:0.###}") });

            //xrPrintTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
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
