using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;


namespace ErpManage
{
    /// <summary>
    /// 设备管理
    /// </summary>
    public partial class frmEquipment : frmBase
    {
        EquipmentManage EquipmentManage = new EquipmentManage();
        public static frmEquipment frmequipment;

        public frmEquipment() 
        {
            InitializeComponent();
            frmequipment = this;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                frmEquipmentAdd frmEquipmentAdd = new frmEquipmentAdd();
                frmEquipmentAdd.EquipmentAdd(treeView1.SelectedNode.Tag.ToString());
            }
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "分类";
            tn.Tag = "0";
            treeView1.Nodes.Add(tn);

            TreeNode tn1 = new TreeNode();
            tn1.Text = "模具";
            tn1.Tag = "1";
            tn.Nodes.Add(tn1);

            tn1 = new TreeNode();
            tn1.Text = "计量器具";
            tn1.Tag = "2";
            tn.Nodes.Add(tn1);

             tn1 = new TreeNode();
            tn1.Text = "生产设备";
            tn1.Tag = "3";
            tn.Nodes.Add(tn1);



             tn1 = new TreeNode();
            tn1.Text = "办公设备";
            tn1.Tag = "4";
            tn.Nodes.Add(tn1);


             tn1 = new TreeNode();
            tn1.Text = "工装";
            tn1.Tag = "5";
            tn.Nodes.Add(tn1);


            this.treeView1.ExpandAll();


            //加载数据
            gridControl1.DataSource= EquipmentManage.GetEquipmentData("");

            treeView1.Focus();


           

        }

        public void LoadEquipmentTypeData()
        {
            if (treeView1.SelectedNode.Tag.ToString() != "0")
            {


                //加载数据
                gridControl1.DataSource = EquipmentManage.GetEquipmentData(" where EquipmentType='" + treeView1.SelectedNode.Tag.ToString() + "' order by EquipmentID");

            }
            else
            {
                //加载数据
                gridControl1.DataSource = EquipmentManage.GetEquipmentData(" where 1=1 order by EquipmentID");

            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
          
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmEquipmentAdd frmEquipmentAdd = new frmEquipmentAdd();
                frmEquipmentAdd.EquipmentEdit(guid);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Tag.ToString() != "0")
                {

                    //加载数据
                    gridControl1.DataSource = EquipmentManage.GetEquipmentData(" where EquipmentType='" + treeView1.SelectedNode.Tag.ToString() + "' order by EquipmentID");
                }
                else
                {

                    //加载数据
                    gridControl1.DataSource = EquipmentManage.GetEquipmentData(" where 1=1 order by EquipmentID");

                }
            }
            else
            {
                this.ShowMessage("请选择分类！");
            }
        }

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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmEquipmentAdd frmEquipmentAdd = new frmEquipmentAdd();
                frmEquipmentAdd.EquipmentEdit(guid);
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            string strsql = " where 1=1 ";

            if (txtNo.Text.Trim() != "")
            {
                strsql = strsql + " and EquipmentID like '%" + txtNo.Text.Trim().Replace("'", "''") + "%'";
            
            }


            if (txtName.Text.Trim() != "")
            {

                strsql = strsql + " and EquipmentName like '%" + txtName.Text.Trim().Replace("'", "''") + "%'";
            }


            //加载数据
            gridControl1.DataSource = EquipmentManage.GetEquipmentData(strsql+" order by EquipmentID");

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            string strsql = " where 1=1 ";

            if (txtNo.Text.Trim() != "")
            {
                strsql = strsql + " and EquipmentID like '%" + txtNo.Text.Trim().Replace("'", "''") + "%'";

            }


            if (txtName.Text.Trim() != "")
            {

                strsql = strsql + " and EquipmentName like '%" + txtName.Text.Trim().Replace("'", "''") + "%'";
            }


            //加载数据
            gridControl1.DataSource = EquipmentManage.GetEquipmentData(strsql + " order by EquipmentID");
        }
    }
}