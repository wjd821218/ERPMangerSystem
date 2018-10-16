using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.IO;
using Daniel.Liu.DAO;
using System.Collections;

namespace ErpManage
{
    /// <summary>
    /// 文件管理-文件信息录入
    /// </summary>
    public partial class frmFileManage : frmBase
    {
        FileDataManage FileDataManage = new FileDataManage();
        public static frmFileManage frmfileManage;
        public frmFileManage()
        {
            
            InitializeComponent();
            frmfileManage = this;

            IniControl_CN();
        }

      
        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadFileClassTree()
        {
            treeView1.Nodes.Clear();

            DataTable mdt = new DataTable();
            FileClassManage pmc = new FileClassManage();
            mdt = pmc.GetFileClassData();

            this.treeView1.ImageList = imageList1;
            if (mdt.Rows.Count > 0)
            {
                int MaxLayer = 10;
                ArrayList al = new ArrayList();
                for (int i = 1; i <= MaxLayer; i++)
                {

                    if (i == 1)
                    {
                        DataRow[] dr;
                        dr = mdt.Select("FatherID='0'", "OrderNo");
                        for (int j = 0; j < dr.Length; j++)
                        {
                            TreeNode tn = new TreeNode();
                            tn.Text = dr[j]["InterName"].ToString();

                            tn.Tag = dr[j]["InterID"].ToString();

                            this.treeView1.Nodes.Add(tn);
                            al.Add(tn);

                        }
                        dr = null;
                    }
                    else
                    {
                        int upLenth = al.Count; //记录上一层节点数
                        for (int k = 0; k < upLenth; k++)
                        {
                            TreeNode tvn = (TreeNode)al[k];
                            DataRow[] dr = mdt.Select("FatherID='" + tvn.Tag.ToString() + "'", "OrderNo");
                            for (int j = 0; j < dr.Length; j++)
                            {
                                TreeNode tn = new TreeNode();
                                tn.Text = dr[j]["InterName"].ToString();
                                tn.Tag = dr[j]["InterID"].ToString();
                                tvn.Nodes.Add(tn);
                                al.Add(tn); //增加本层节点，以便下一层加载
                            }
                            dr = null;
                        }
                        for (int k = upLenth - 1; k >= 0; k--)
                        {
                            al.RemoveAt(k); //删除上一层节点的引用
                        }
                        if (al.Count == 0)
                        {
                            break;
                        }
                    }
                }
                al = null;
            }

            mdt.Dispose();
        }
       

        private void frmFileAdd_Load(object sender, EventArgs e)
        {
            LoadFileClassTree();

            treeView1.ExpandAll();

            LoadFileData("");

            cboQry.SelectedIndex = 0;

            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        //载入货品数据
        public void LoadFileData(string strsql)
        {
           
            DataTable dtl = FileDataManage.GetFileDataBySQL(strsql);
            gridControl1.DataSource = dtl;


            gridView1.Columns["selectvalue"].Visible = false;
            gridView1.Columns["FileGuID"].Visible = false;
            gridView1.Columns["CreateDate"].Visible = false;
            gridView1.Columns["CreateGuid"].Visible = false;
            //gridView1.Columns["CreateName"].Visible = false;


        }

        //文件类别维护
        private void tsbFileClass_Click(object sender, EventArgs e)
        {
            frmFileClass frmFileClass = new frmFileClass();
            frmFileClass.ShowDialog();
        }

        //新增
        private void tsbAdd_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode != null)
            {
                frmFileAdd frmFileAdd = new frmFileAdd();
                frmFileAdd.FileAdd(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            }
            else
            {
                this.ShowAlertMessage("请先选择文件类别后再添加!");
            }

           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void tsbFileClass_Click_1(object sender, EventArgs e)
        {
            frmFileClass frmFileClass = new frmFileClass();
            frmFileClass.ShowDialog();

            LoadFileClassTree();

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //加载数据
            if (treeView1.SelectedNode.Text != "文件类别")
            {

                this.FillFileData(treeView1.SelectedNode.Tag.ToString());
            }
            else
            {
                this.FillFileData("");
            }
        }

        /// <summary>
        /// 加载产品信息
        /// </summary>
        public void FillFileData(string classid)
        {

            if (classid.Trim() != "")
            {
                gridControl1.DataSource = FileDataManage.GetFileDataBySQL("where FileType='" + classid + "'");
            }
            else
            {
                gridControl1.DataSource = FileDataManage.GetFileDataBySQL("");
            }

            if (gridView1.Columns.Count > 3)
            {
                gridView1.Columns["文件编号"].MinWidth = 100;
                gridView1.Columns["文件名称"].MinWidth = 100;
                
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuID"].ToString();

                frmFileAdd frmFileAdd = new frmFileAdd();
                frmFileAdd.FileEdit(guid);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuID"].ToString();

                frmFileAdd frmFileAdd = new frmFileAdd();
                frmFileAdd.FileEdit(guid);
            }

        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            

              string strsql = "";
            switch (cboQry.Text.Trim())
            {
                case "文件编号":

                     strsql = " where IsEnable=0 and  FileID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "文件名称":

                     strsql = " where IsEnable=0 and  FileName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "产品名称":
                     strsql = " where IsEnable=0 and  ProductName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    break;
                case "版本号":
                     strsql = " where IsEnable=0 and  VersionID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    break;

            }




            DataTable dtl = FileDataManage.GetFileDataBySQL(strsql);
            gridControl1.DataSource = dtl;
            gridView1.Columns[0].Visible = false;
        }

        private void txtQryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnQry_Click(null, null);
            }
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
            //DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();
            //DevExpress.XtraReports.Localization.ReportLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraReportsLocalizationCHS();
            //DevExpress.XtraRichTextEdit.Localization.XtraRichTextEditLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichTextEditLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerExtensionsLocalizationCHS();
            //DevExpress.XtraSpellChecker.Localization.SpellCheckerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSpellCheckerLocalizationCHS();
            //DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraTreeListLocalizationCHS();
            //DevExpress.XtraVerticalGrid.Localization.VGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraVerticalGridLocalizationCHS();
            //DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraWizardLocalizationCHS();
        }
        #endregion

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                //权限判断
                if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DeleteFile", "Qry") == false)
                {
                    this.ShowMessage("对不起，你没有操作此项功能的权限！");
                    return;
                }


                if (gridView1.RowCount > 0)
                {
                    string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuID"].ToString();

                    //删除文件
                    if (FileDataManage.IsFileUse(guid) == true)
                    {
                        this.ShowAlertMessage("此文件已被使用，不能删除!");

                    }
                    else
                    {
                        FileDataManage.DeleteFile(guid);
                        btnQry_Click(null, null);

                    }



                }
            }

        }

        /// <summary>
        /// 显示附件修改历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileChange_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuID"].ToString();


                frmFileChangeRecord frmFileChangeRecord = new frmFileChangeRecord(guid);
                frmFileChangeRecord.ShowDialog();
            }
        }

    }
}