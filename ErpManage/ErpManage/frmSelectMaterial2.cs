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
    /// 选择货品
    /// 
    /// 修改1:
    /// 修改功能：此功能只提供给领料单单使用，因为点击了BOM查询后再点选择的物料会
    ///           加载出物料的单耗
    /// 日期：2010-9-24
    /// 
    /// 
    /// </summary>
    public partial class frmSelectMaterial2 :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        public frmSelectMaterial2()
        {
            InitializeComponent();

          
        }

        private void frmSelectMaterial_Load(object sender, EventArgs e)
        {
            LoadStorageClassTree();

            treeView1.ExpandAll();

            LoadMaterial(" where IsEnable=0 ");

            cboSelect.SelectedIndex = 0;
          
        }

        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadStorageClassTree()
        {
            treeView1.Nodes.Clear();

            DataTable mdt = new DataTable();
            StorageClassManage pmc = new StorageClassManage();
            mdt = pmc.GetStorageClassData();

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
            gridView1.Columns[2].MinWidth = 100;
            gridView1.Columns[3].MinWidth = 100;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["单价"].Visible = false; 
            }
           




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
            Qry();

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
            else
            {
                this.FillMaterial("");
            }
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                List<string> lst = new List<string>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        //int intRow = gridView1.GetSelectedRows()[0];
                        string guid = gridView1.GetRowCellValue(i, gridMaterialGuid).ToString();

                        lst.Add(guid);
                        //this.Tag = guid;
                    }
                }

                this.Tag = lst;
                this.Close();
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

        private void btnQry_Click(object sender, EventArgs e)
        {

            Qry();
          
             
        }

        private void Qry()
        {

            string strsql = "";
          


            #region 修改1:
            switch (cboSelect.Text.Trim())
            { 
                case "物料编号":
                    strsql = " where IsEnable=0 and  MaterialID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "物料名称":
                    strsql = " where IsEnable=0 and  MaterialName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "客户编号":
                    strsql = " where IsEnable=0 and  ClientID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "图号":
                    strsql = " where IsEnable=0 and  PicID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;

            }
            #endregion

            //if (cboSelect.Text.Trim() == "物料编号")
            //{
            //    strsql = " where IsEnable=0 and  MaterialID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            //}
            //else if (cboSelect.Text.Trim() == "物料名称")
            //{
            //    strsql = " where IsEnable=0 and  MaterialName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            //}

            DataTable dtl = MaterialManage.GetSelectMaterialData_CN(strsql);
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
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

        //按BOM查询，显示出此物料产品下面所有的BOM子件
        private void btnBomQry_Click(object sender, EventArgs e)
        {
            if (txtQryValue.Text.Trim() == "")
            {
                this.ShowMessage("请输入要查询的值!");
                txtQryValue.Focus();
                return;
            }

            DataTable dtl = MaterialManage.sp_GetBomDataByMaterialGuid(txtQryValue.Text.Trim());
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
            
        }


        //------------------------------------------------------------
        //双击将此物料编号加载到输入值文本框中
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string mid = ((DataRowView)(gridView1.GetFocusedRow())).Row["物料编号"].ToString();
                 string MaterialGuid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuid"].ToString();
                txtQryValue.Text = mid;
                txtQryValue.Tag = MaterialGuid;
            }

        }

      
    }
}