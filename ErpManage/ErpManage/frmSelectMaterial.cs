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
    /// ѡ���Ʒ
    /// 
    /// �޸�1:
    /// �޸Ĺ��ܣ����ӿͻ������ͼ�ŵĲ�ѯ
    /// ���ڣ�2010-6-4
    /// </summary>
    public partial class frmSelectMaterial :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        private  int IsViewStop=0;  //�Ƿ���ʾͣ�õ����ϣ�1:��ʾ 0:����ʾ
        public frmSelectMaterial()
        {
            
            InitializeComponent();

            IsViewStop = 0;
        }

        /// <summary>
        /// �Ƿ���ʾͣ�õ����ϣ�1:��ʾ 0:����ʾ
        /// </summary>
        /// <param name="intIsViewStop"></param>
        public frmSelectMaterial(int intIsViewStop)
        {
            InitializeComponent();

            IsViewStop = intIsViewStop;
        }

        private void frmSelectMaterial_Load(object sender, EventArgs e)
        {
            LoadStorageClassTree();

            treeView1.ExpandAll();

            if (IsViewStop == 0)
            {
                LoadMaterial(" where IsEnable=0 ");
            }
            else
            {
                LoadMaterial(" where  1=1 ");
            }

            cboSelect.SelectedIndex = 0;
          
        }

        /// <summary>
        /// ������
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



        //�����Ʒ����
        public void LoadMaterial(string strsql)
        {
            DataTable dtl = MaterialManage.GetSelectMaterialData_CN(strsql);
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[2].MinWidth = 100;
            gridView1.Columns[3].MinWidth = 100;


            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["����"].Visible = false; 
            }
           




        }

      
        //��������
        //private void LoadData()
        //{
           
        //    DataTable dtl = MaterialManage.GetSelectMaterialData_CN("where IsEnable=0 ");
        //    this.gridControl1.DataSource = dtl;

        //    gridView1.Columns[0].Visible = false;

        //}


        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
            Qry();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// ���ز�Ʒ��Ϣ
        /// </summary>
        public void FillMaterial(string classid)
        {
            if (IsViewStop == 0)
            {
                gridControl1.DataSource = MaterialManage.GetMaterialDataByClassID_Select(classid);
            }
            else
            {
                //��ʾ�������ϣ�����ͣ�õ�
                gridControl1.DataSource = MaterialManage.GetMaterialDataByClassID_Select2(classid);
            }

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //��������
            if (treeView1.SelectedNode.Text != "��Ʒ����")
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
                val = "True";//Ĭ��Ϊѡ�� 
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
            string strsql2 = " where IsEnable=0 ";

            if (IsViewStop == 0)
            {
                strsql2 = " where IsEnable=0 ";
            }
            else
            {
                strsql2 = " where 1=1  ";
            }

            #region �޸�1:
            switch (cboSelect.Text.Trim())
            { 
                case "���ϱ��":
                    strsql =strsql2+"  and  MaterialID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "��������":
                    strsql =strsql2+"  and  MaterialName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "�ͻ����":
                    strsql = strsql2 + " and  ClientID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;
                case "ͼ��":
                    strsql = strsql2 + " and  PicID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
                    break;

            }
            #endregion

            //if (cboSelect.Text.Trim() == "���ϱ��")
            //{
            //    strsql = " where IsEnable=0 and  MaterialID like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            //}
            //else if (cboSelect.Text.Trim() == "��������")
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

        //��BOM��ѯ����ʾ�������ϲ�Ʒ�������е�BOM�Ӽ�
        private void btnBomQry_Click(object sender, EventArgs e)
        {
            if (txtQryValue.Text.Trim() == "")
            {
                this.ShowMessage("������Ҫ��ѯ��ֵ!");
                txtQryValue.Focus();
                return;
            }

            DataTable dtl = MaterialManage.sp_GetBomDataByMaterialGuid(txtQryValue.Text.Trim());
            this.gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
            
        }

        //˫���������ϱ�ż��ص�����ֵ�ı�����
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string mid = ((DataRowView)(gridView1.GetFocusedRow())).Row["���ϱ��"].ToString();
                txtQryValue.Text = mid;
            }

        }

      
    }
}