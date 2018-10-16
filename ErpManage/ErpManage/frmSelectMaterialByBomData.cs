using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Collections;
using ErpManage.Business;

namespace ErpManage
{
     /// <summary>
    /// 选择物料按BOM来选择
    /// 2010-8-7
    /// </summary>
    public partial class frmSelectMaterialByBomData :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
        List<NodeData> lst = new List<NodeData>();
        public frmSelectMaterialByBomData()
        {
            InitializeComponent();

          
        }

        private void frmSelectMaterial_Load(object sender, EventArgs e)
        {
            LoadStorageClassTree();

            treeView1.ExpandAll();

            //LoadMaterial(" where IsEnable=0 ");

         
          
        }

        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadStorageClassTree()
        {
            treeView1.Nodes.Clear();

            DataTable mdt = new DataTable();
            StorageClassManage pmc = new StorageClassManage();
            mdt = pmc.GetStorageClassDatabyBom();

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



        //载入货品数据
        public void LoadMaterial(string strsql)
        {
            DataTable dtl = MaterialManage.GetSelectMaterialData_CN(strsql);
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
          
           
        }

      
        //载入数据
        private void LoadData()
        {
           
            DataTable dtl = MaterialManage.GetSelectMaterialData_CN("where IsEnable=0 ");
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }


        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 加载产品信息
        /// </summary>
        public void FillMaterial(string classid)
        {
            gridControl1.DataSource = MaterialManage.GetMaterialDataByClassID_Select(classid);

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //加载数据
            if (treeView1.SelectedNode.Text != "货品分类")
            {

                this.FillMaterial(treeView1.SelectedNode.Tag.ToString());
            }
           
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

      

      
        private void btnStorageView_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuid"].ToString();
                frmGetMaterialStorageSum frmGetMaterialStorageSum = new frmGetMaterialStorageSum();
                frmGetMaterialStorageSum.LoadData(guid);
                frmGetMaterialStorageSum.Show(this);

            }

        }

       

       

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                label3.Text = "正在加载BOM数据,请稍候...";
                label3.ForeColor = Color.Red;
                this.Refresh();

                LoadBomTree(gridView1.GetFocusedRowCellValue(gridMaterialGuid).ToString());

                label3.Text = "成品BOM列表";
                label3.ForeColor = Color.Black;
            }
        }


          /// <summary>
        /// 加载树
        /// </summary>
        public void LoadBomTree(string strMaterialGuid)
        {
            this.treeView2.Nodes.Clear();
            NodeData NodeData = new NodeData();
            NodeData NodeData_tvn = new NodeData();
            if (strMaterialGuid != "")
            {

                DataTable mdt = new DataTable();
                mdt = MaterialBOMManage.sp_GetMaterialBomData(strMaterialGuid);

                //this.treeView1.ImageList = imageList2;
                if (mdt.Rows.Count > 0)
                {
                    int MaxLayer = 10;
                    ArrayList al = new ArrayList();
                    for (int i = 1; i <= MaxLayer; i++)
                    {

                        if (i == 1)
                        {
                            DataRow[] dr;
                            dr = mdt.Select("MaterialFatherGuid=''");
                            for (int j = 0; j < dr.Length; j++)
                            {
                                TreeNode tn = new TreeNode();
                                tn.Text = dr[j]["MaterialID"].ToString() + " " + dr[j]["MaterialName"].ToString();

                                NodeData = new NodeData();
                                NodeData.MaterialGuid = dr[j]["MaterialGuID"].ToString();
                                NodeData.MaterialSum = "1";
                                tn.Tag = NodeData; //dr[j]["MaterialGuID"].ToString();

                                this.treeView2.Nodes.Add(tn);
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
                                 NodeData_tvn = new NodeData();
                                NodeData_tvn = tvn.Tag as NodeData;
                                DataRow[] dr = mdt.Select("MaterialFatherGuid='" + NodeData_tvn.MaterialGuid + "'");
                                for (int j = 0; j < dr.Length; j++)
                                {
                                    TreeNode tn = new TreeNode();
                                    decimal dec = decimal.Parse(dr[j]["MaterialSum"].ToString());
                                    tn.Text = dr[j]["MaterialID"].ToString() + " " + dr[j]["MaterialName"].ToString() + "(" + dec.ToString("g0") + ")";

                                    NodeData = new NodeData();
                                    NodeData.MaterialGuid = dr[j]["MaterialGuID"].ToString();
                                    NodeData.MaterialSum = dec.ToString("g0");
                                    tn.Tag = NodeData; //dr[j]["MaterialGuID"].ToString();


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

            if (treeView2.Nodes.Count > 0)
            {
                this.treeView2.Nodes[0].Expand();
            }
           // treeView2.ExpandAll();
         
        }

        public void GetNode(TreeNodeCollection tc)
        {
            NodeData NodeData1 = new NodeData();

            foreach (TreeNode TNode in tc)
            {
                //string PlaceNodeText = TNode.Text;

                if (TNode.Checked == true)
                {
                    NodeData1 = new NodeData();
                    NodeData1 = TNode.Tag as NodeData;

                    lst.Add(NodeData1);

                }

                GetNode(TNode.Nodes);
            }

         

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lst.Clear();

            TreeNodeCollection tc = treeView2.Nodes;

            GetNode(tc);

            this.Tag = lst;
            this.Close();
        }


      
    }

    public class NodeData
    {
        private string  _materialguid;
        /// <summary>
        /// MaterialGuid
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }


        private string _materialsum;
        /// <summary>
        /// MaterialSum
        /// </summary>
        public string MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }       
    
    }
}