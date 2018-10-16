using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;

namespace ErpManage
{
    /// <summary>
    /// BOM管理
    /// </summary>
    public partial class frmBOM : frmBase
    {
        public static frmBOM frmbom;
        MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
        public frmBOM()
        {
            InitializeComponent();
            frmbom = this;

         
        }

        /// <summary>
        ///载入母件
        /// </summary>
        private void LoadMaterialBom()
        {
            DataTable dtl = MaterialBOMManage.GetMaterialBOM();
            this.gridControl1.DataSource = dtl;
        
        }

        /// <summary>
        /// 载入母件下的子件(一级)
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        private void LoadMaterialBomDetail(string MaterialFatherGuid)
        {
            DataTable dtl = MaterialBOMManage.GetMaterialBOMDetail(MaterialFatherGuid);
            this.gridControl2.DataSource = dtl;

        }


        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadStorageClassTree()
        {

            DataTable mdt = new DataTable();
            StorageClassManage pmc = new StorageClassManage();
            mdt = pmc.GetStorageClassData();

            this.treeView1.ImageList = imageList2;
            if (mdt.Rows.Count > 0)
            {
                int MaxLayer = 10;
                ArrayList al = new ArrayList();
                for (int i = 1; i <= MaxLayer; i++)
                {

                    if (i == 1)
                    {
                        DataRow[] dr;
                        dr = mdt.Select("FatherID='0'");
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
                            DataRow[] dr = mdt.Select("FatherID='" + tvn.Tag.ToString() + "'");
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



        public void FillData()
        {
            treeView1.Nodes.Clear();
            LoadStorageClassTree();
            treeView1.ExpandAll();

            this.ShowDialog();
        }


        public void Refresh()
        {
            treeView1.Nodes.Clear();
            LoadStorageClassTree();
            treeView1.ExpandAll();

        
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmMaterialClassAdd fpt = new frmMaterialClassAdd();
            //fpt.txtFatherID.Text  = treeView1.SelectedNode.Tag.ToString();
            // fpt.txtFatherName.Text = treeView1.SelectedNode.Text;
            // fpt.ShowDialog();

            frmBOMAdd frmBOMAdd = new frmBOMAdd();
            frmBOMAdd.ShowDialog();


            LoadMaterialBom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount >= 0)
            {
                DialogResult dr = MessageBox.Show("确定要删除选择的物料(母件)数据?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                    MaterialBOMManage.DetailMaterialBom(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "BOM数据", "删除BOM", SysParams.UserName + "用户删除了BOM，物料:" + gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString()+","+gridView1.GetFocusedRowCellValue(gridMaterialName).ToString());


                    LoadMaterialBom();

                    if (gridView1.RowCount >= 0)
                    {
                        LoadMaterialBomDetail(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());
                    }
                }
            }
        }

        private void frmStorageClass_Load(object sender, EventArgs e)
        {
            //LoadStorageClassTree();

            //treeView1.ExpandAll();

            LoadMaterialBom();

            if (gridView1.RowCount > 0)
            {
                LoadMaterialBomDetail(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                frmBOMAdd frmBOMAdd = new frmBOMAdd();
                frmBOMAdd.EditBom(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                LoadMaterialBomDetail(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                frmBOMAdd frmBOMAdd = new frmBOMAdd();
                frmBOMAdd.EditBom(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());

            }
        }

        private void txtFatherMaterialID_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, gridMaterialID).ToString().ToUpper().IndexOf(txtFatherMaterialID.Text.ToUpper()) == 0)
                {
                    gridView1.FocusedRowHandle = i;
                    break;
                }
            }
        }

        private void txtChildMaterialID_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (gridView2.GetRowCellValue(i, gridMaterialIDDetail).ToString().ToUpper().IndexOf(txtChildMaterialID.Text.ToUpper()) == 0)
                {
                    gridView2.FocusedRowHandle = i;
                    break;
                }
            }
        }
    }
}