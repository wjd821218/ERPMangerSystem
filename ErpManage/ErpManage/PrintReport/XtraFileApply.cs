using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ErpManage
{
    /// <summary>
    /// 文件申请单
    /// </summary>
    public partial class XtraFileApply: DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds;
        public XtraFileApply(DataSet ds1, string FileApplyID, string FileApplyDate, string FileApplyType, string ApplyDept,
            string FileApplyPerson,string Remark, string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            InitializeComponent();

            IniControl_CN();

            ds = ds1;

            DataBind(ds1, FileApplyID, FileApplyDate, FileApplyType, ApplyDept, FileApplyPerson,  Remark, CreateName, CreateDate, CheckName, CheckDate);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void DataBind(DataSet ds1, string FileApplyID, string FileApplyDate, string FileApplyType, string ApplyDept,
            string FileApplyPerson, string Remark, string CreateName, string CreateDate, string CheckName, string CheckDate)
        {
            this.DataSource = ds1;


            xrFileApplyID.Text = FileApplyID;
            xrFileApplyDate.Text = DateTime.Parse(FileApplyDate).ToString("yyyy-MM-dd");
            xrFileApplyType.Text = FileApplyType;
            xrFileApplyDept.Text = ApplyDept;
            xrFileApplyPerson.Text = FileApplyPerson;
            xrRemark.Text = Remark;
          


            xrCreateName.Text = CreateName;
            xrCreateDate.Text = CreateDate;
            xrCheckName.Text = CheckName;
            xrCheckDate.Text = CheckDate;
            
            
            //明细表
            this.DataSource = ds.Tables[0];
            xrFileID.DataBindings.Add("Text", DataSource, "FileApplyDetail.FileID");
            xrFileName.DataBindings.Add("Text", DataSource, "FileApplyDetail.FileName");
            xrControlType.DataBindings.Add("Text", DataSource, "FileApplyDetail.ControlTypeName");
            xrFileType.DataBindings.Add("Text", DataSource, "FileApplyDetail.FileTypeName");
            xrVersionID.DataBindings.Add("Text", DataSource, "FileApplyDetail.VersionID");
            xrPublishDate.DataBindings.Add("Text", DataSource, "FileApplyDetail.PublishDate");
            xrIsDownload.DataBindings.Add("Text", DataSource, "FileApplyDetail.IsDownloadName");

            xrPublishDate.DataBindings.AddRange(new XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "FileApplyDetail.PublishDate", "{0:yyyy-MM-dd}") });

            xrPrintTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

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
