using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// ���
    /// </summary>
    public partial class XtraReportPaymentOrder2: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportPaymentOrder2(DataSet ds1, string PaymentOrderID, string PaymentOrderDate, string ClientGuid, string PaymentPerson, string Remark, string BankID, string PayID
             , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2, string CheckDate2)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, PaymentOrderID, PaymentOrderDate, ClientGuid, PaymentPerson, Remark, BankID, PayID, CreateName, CreateDate, CheckName, CheckDate, CheckName2, CheckDate2);
        }

        /// <summary>
        /// ������
        /// </summary>
        private void DataBind(DataSet ds1, string PaymentOrderID, string PaymentOrderDate, string ClientGuid, string PaymentPerson, string Remark,string BankID,string PayID
             , string CreateName, string CreateDate, string CheckName, string CheckDate, string CheckName2,string  CheckDate2)
        {
            this.DataSource = ds1;

            XtraReportPaymentOrderChild2 XtraReportPaymentOrderChild2 = new XtraReportPaymentOrderChild2(ds1);
            xrSubreport1.ReportSource = XtraReportPaymentOrderChild2;

            xrPaymentOrderID.Text = PaymentOrderID;
            xrPaymentOrderDate.Text = DateTime.Parse(PaymentOrderDate).ToString("yyyy-MM-dd");
            xrClientGuid.Text = ClientGuid;
            xrPayPerson.Text = PaymentPerson;
            xrBankID.Text = BankID;
            xrPayID.Text = PayID;
            xrRemark.Text = Remark;

            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;
            xrCheckName2.Text = CheckName2;
            xrCheckDate2.Text = CheckDate2;

            xrCompanyNameCn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyName"].ToString();
            xrCompanyNameEn.Text = System.Configuration.ConfigurationSettings.AppSettings["CompanyNameEn"].ToString();


            
            //��ϸ��
            this.DataSource = ds.Tables[1];
            xrStockOrderID.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.StockInOrderID");
            xrStockOrderDate.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.StockInOrderDate");
            xrStockOrderMoney.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.StockInOrderMoney");
            xrMaterialSum.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.MaterialSum");
            xrRemark2.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.Remark");

            //���ڸ�ʽ�İ�
            xrStockOrderDate.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "PaymentOrderDetail2.StockInOrderDate", "{0:yyyy-MM-dd}") });

            xrStockOrderMoney.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "PaymentOrderDetail2.StockInOrderMoney", "{0:0.###}") });

            xrMaterialSum.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "PaymentOrderDetail2.MaterialSum", "{0:0.###}") });


            //�����кϼ�
            XRSummary xrye = new XRSummary();
            xrTotalCount.DataBindings.Add("Text", DataSource, "PaymentOrderDetail2.StockInOrderMoney");
            xrye.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
            xrye.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            xrye.FormatString = "{0:0.###}";
            xrTotalCount.Summary = xrye;

          

           // xrPrintTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
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


        #region �ؼ�����
        /// <summary>
        /// ���ؼ�����
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
