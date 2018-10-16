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
    /// 选择文件类别
    /// </summary>
    public partial class frmSelectFileClass :frmBase
    {
        public int InValue = 0;//0:从库存报表进入
        public frmSelectFileClass()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadFileClassTree()
        {

            DataTable mdt = new DataTable();
            FileClassManage pmc = new FileClassManage();
            mdt = pmc.GetFileClassData();

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


        private void frmSelectType_Load(object sender, EventArgs e)
        {
            LoadFileClassTree();

            treeView1.ExpandAll();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (InValue == 0)
            {
                SelectFileClass SelectFileClass = new SelectFileClass();
                SelectFileClass.FileClassID = treeView1.SelectedNode.Tag.ToString();
                SelectFileClass.FileClassName = treeView1.SelectedNode.Text;

                this.Tag = SelectFileClass;
                
            }

            //if (InValue == 1)
            //{
            //    frmDepotMaterialInOutSum.frmdepotmaterialInOutSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            //if (InValue == 2)
            //{
            //    frmDepotMaterialTypeInOutSum.frmdepotmaterialTypeInOutSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            //if (InValue == 3)
            //{
            //    frmDepotMaterialSum.frmdepotMaterialSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            this.Close();
        
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (InValue == 0)
            {
                SelectFileClass SelectFileClass = new SelectFileClass();
                SelectFileClass.FileClassID = treeView1.SelectedNode.Tag.ToString();
                SelectFileClass.FileClassName = treeView1.SelectedNode.Text;

                this.Tag = SelectFileClass;
            }

            //if (InValue == 1)
            //{
            //    frmDepotMaterialInOutSum.frmdepotmaterialInOutSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            //if (InValue == 2)
            //{
            //    frmDepotMaterialTypeInOutSum.frmdepotmaterialTypeInOutSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            //if (InValue == 3)
            //{
            //    frmDepotMaterialSum.frmdepotMaterialSum.GetClass(treeView1.SelectedNode.Tag.ToString(), treeView1.SelectedNode.Text);
            //}

            this.Close();
        }

    }
}