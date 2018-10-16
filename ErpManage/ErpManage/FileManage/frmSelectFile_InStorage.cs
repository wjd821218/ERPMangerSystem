using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Collections;

namespace ErpManage
{
    /// <summary>
    /// 文件选择----供文件入库专用
    /// </summary>
    public partial class frmSelectFile_InStorage : Form
    {
        FileDataManage FileDataManage = new FileDataManage();
        public frmSelectFile_InStorage()
        {
            InitializeComponent();
        }

        private void frmSelectFile_Load(object sender, EventArgs e)
        {
            LoadFileClassTree();

            treeView1.ExpandAll();

            LoadFileData("  ");

            //cboQry.SelectedIndex = 0;
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


        //载入货品数据
        public void LoadFileData(string strsql)
        {

            DataTable dtl = FileDataManage.GetFileDataBySQL2(strsql);
            gridControl1.DataSource = dtl;


            gridView1.Columns["FileGuID"].Visible = false;

        }

        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "True";//默认为选中 
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto case "True";
                case "No":
                    goto case "False";
                case "1":
                    goto case "True";
                case "0":
                    goto case "False";
                default:
                    e.CheckState = CheckState.Checked;
                    break;
            }
            e.Handled = true;
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
                gridControl1.DataSource = FileDataManage.GetFileDataBySQL2("where   FileType='" + classid + "'");
            }
            else
            {
                gridControl1.DataSource = FileDataManage.GetFileDataBySQL2("");
            }

            if (gridView1.Columns.Count > 3)
            {
                gridView1.Columns["文件编号"].MinWidth = 100;
                gridView1.Columns["文件名称"].MinWidth = 100;

            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                List<string> lst = new List<string>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        //int intRow = gridView1.GetSelectedRows()[0];
                        string guid = gridView1.GetRowCellValue(i, gridFileGuID).ToString();

                        lst.Add(guid);

                    }
                }

                this.Tag = lst;
                this.Close();
            }
        }

        //全选与取消全选
        private void chkAll_Click(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(i, gridCheckBox, "True");
                }

            }
            else
            {


                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(i, gridCheckBox, "False");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQry_Click(object sender, EventArgs e)
        {

            string strsql = "";
            switch (cboQry.Text.Trim())
            {
                case "文件编号":

                    strsql = " where   IsEnable=0 and  FileID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "文件名称":

                    strsql = " where IsEnable=0 and  FileName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "产品名称":
                    strsql = " where  IsEnable=0 and  ProductName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    break;
                case "版本号":
                    strsql = " where  IsEnable=0 and  VersionID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    break;
            }


            gridControl1.DataSource = FileDataManage.GetFileDataBySQL2(strsql);

        }


        private void txtQryValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                btnQry_Click(null, null);
            }
        }
    }
}