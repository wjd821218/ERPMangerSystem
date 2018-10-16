using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using ErpManageLibrary;

namespace ErpManage.PrintReport
{
    /// <summary>
    /// 付款单
    /// </summary>
    public partial class XtraReportPaymentOrderTwoPrint: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraReportPaymentOrderTwoPrint(string PaymentOrderID,string PaymentOrderID2)
        {
            InitializeComponent();

            IniControl_CN();

            DataBind(PaymentOrderID,PaymentOrderID2);
           
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(string PaymentOrderGuid,string PaymentOrderGuid2)
        {
            //得到付款单1的数据源
            DataTable dtlPayment1 = new DataTable();
            PaymentOrderManage PaymentOrderManage = new PaymentOrderManage();
            dtlPayment1 = PaymentOrderManage.GetPaymentOrderByPaymentGuid(PaymentOrderGuid);
            string PaymentOrderID, PaymentOrderDate, SupplierName, PaymentPerson, Remark, BankID, PayID, CreateName, CreateDate, CheckName, CheckDate,CheckName21, CheckDate21;
            PaymentOrderID = dtlPayment1.Rows[0]["PaymentOrderID"].ToString();
            PaymentOrderDate = dtlPayment1.Rows[0]["PaymentOrderDate"].ToString();
            SupplierName = dtlPayment1.Rows[0]["SupplierName"].ToString();
            PaymentPerson = dtlPayment1.Rows[0]["PayPersonName"].ToString();
            Remark = dtlPayment1.Rows[0]["Remark"].ToString();
            BankID = dtlPayment1.Rows[0]["BankID"].ToString();
            PayID = dtlPayment1.Rows[0]["PayID"].ToString();
            CreateName = dtlPayment1.Rows[0]["CreateName"].ToString();
            CreateDate = dtlPayment1.Rows[0]["CreateDate"].ToString();
            CheckName = dtlPayment1.Rows[0]["CheckName"].ToString();
            CheckDate = dtlPayment1.Rows[0]["CheckDate"].ToString();
            CheckName21 = dtlPayment1.Rows[0]["CheckName2"].ToString();
            CheckDate21 = dtlPayment1.Rows[0]["CheckDate2"].ToString();





            DataSet dsetdetail = new DataSet();
            DataTable dtl1 = new DataTable();
            DataTable dtl2 = new DataTable();
            dtl1 = PaymentOrderManage.GetPaymentOrderDetail1ByGuid(PaymentOrderGuid);
            dtl2 = PaymentOrderManage.GetPaymentOrderDetail2ByGuid(PaymentOrderGuid);

            //用于打印
            dsetdetail.Tables.Clear();
            dsetdetail.Tables.Add(dtl1.Copy());
            dsetdetail.Tables[0].TableName = "PaymentOrderDetail1";
            dsetdetail.Tables.Add(dtl2.Copy());
            dsetdetail.Tables[1].TableName = "PaymentOrderDetail2";



            //得到付款单2的数据源
            DataTable dtlPayment2 = new DataTable();
            dtlPayment2 = PaymentOrderManage.GetPaymentOrderByPaymentGuid(PaymentOrderGuid2);
            string PaymentOrderID2, PaymentOrderDate2, SupplierName2, PaymentPerson2, Remark2, BankID2, PayID2, CreateName2, CreateDate2, CheckName2, CheckDate2,CheckName22, CheckDate22;
            PaymentOrderID2 = dtlPayment2.Rows[0]["PaymentOrderID"].ToString();
            PaymentOrderDate2 = dtlPayment2.Rows[0]["PaymentOrderDate"].ToString();
            SupplierName2 = dtlPayment2.Rows[0]["SupplierName"].ToString();
            PaymentPerson2 = dtlPayment2.Rows[0]["PayPersonName"].ToString();
            Remark2 = dtlPayment2.Rows[0]["Remark"].ToString();
            BankID2 = dtlPayment2.Rows[0]["BankID"].ToString();
            PayID2 = dtlPayment2.Rows[0]["PayID"].ToString();
            CreateName2 = dtlPayment2.Rows[0]["CreateName"].ToString();
            CreateDate2 = dtlPayment2.Rows[0]["CreateDate"].ToString();
            CheckName2 = dtlPayment1.Rows[0]["CheckName"].ToString();
            CheckDate2 = dtlPayment1.Rows[0]["CheckDate"].ToString();
            CheckName22 = dtlPayment1.Rows[0]["CheckName2"].ToString();
            CheckDate22 = dtlPayment1.Rows[0]["CheckDate2"].ToString();


            DataSet dsetdetail2 = new DataSet();
            DataTable dtl11 = new DataTable();
            DataTable dtl21 = new DataTable();
            dtl11 = PaymentOrderManage.GetPaymentOrderDetail1ByGuid(PaymentOrderGuid2);
            dtl21 = PaymentOrderManage.GetPaymentOrderDetail2ByGuid(PaymentOrderGuid2);

            //用于打印
            dsetdetail2.Tables.Clear();
            dsetdetail2.Tables.Add(dtl11.Copy());
            dsetdetail2.Tables[0].TableName = "PaymentOrderDetail1";
            dsetdetail2.Tables.Add(dtl21.Copy());
            dsetdetail2.Tables[1].TableName = "PaymentOrderDetail2";




            XtraReportPaymentOrder XtraReportPaymentOrder = new XtraReportPaymentOrder(dsetdetail, PaymentOrderID, PaymentOrderDate, SupplierName, PaymentPerson, Remark, BankID, PayID, CreateName, CreateDate, CheckName, CheckDate, CheckName21, CheckDate21);
            xrSubreport1.ReportSource = XtraReportPaymentOrder;

            XtraReportPaymentOrder2 XtraReportPaymentOrder2 = new XtraReportPaymentOrder2(dsetdetail2, PaymentOrderID2, PaymentOrderDate2, SupplierName2, PaymentPerson2, Remark2, BankID2, PayID2, CreateName, CreateDate, CheckName2, CheckDate2, CheckName22, CheckDate22);
            xrSubreport2.ReportSource = XtraReportPaymentOrder2;

       
       

        

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
