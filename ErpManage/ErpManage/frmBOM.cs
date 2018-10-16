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
    /// BOM����
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
        ///����ĸ��
        /// </summary>
        private void LoadMaterialBom()
        {
            DataTable dtl = MaterialBOMManage.GetMaterialBOM();
            this.gridControl1.DataSource = dtl;
        
        }

        /// <summary>
        /// ����ĸ���µ��Ӽ�(һ��)
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        private void LoadMaterialBomDetail(string MaterialFatherGuid)
        {
            DataTable dtl = MaterialBOMManage.GetMaterialBOMDetail(MaterialFatherGuid);
            this.gridControl2.DataSource = dtl;

        }


        /// <summary>
        /// ������
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
                        int upLenth = al.Count; //��¼��һ��ڵ���
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
                                al.Add(tn); //���ӱ���ڵ㣬�Ա���һ�����
                            }
                            dr = null;
                        }
                        for (int k = upLenth - 1; k >= 0; k--)
                        {
                            al.RemoveAt(k); //ɾ����һ��ڵ������
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
                DialogResult dr = MessageBox.Show("ȷ��Ҫɾ��ѡ�������(ĸ��)����?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                    MaterialBOMManage.DetailMaterialBom(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "BOM����", "ɾ��BOM", SysParams.UserName + "�û�ɾ����BOM������:" + gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString()+","+gridView1.GetFocusedRowCellValue(gridMaterialName).ToString());


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