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
    /// Ա������
    /// </summary>
    public partial class frmEmployee : frmBase
    {
        EmployeeManage EmployeeManage = new EmployeeManage();
        public static frmEmployee frmemployee;
        public frmEmployee()
        {
            InitializeComponent();
            frmemployee = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeAdd frmEmployeeAdd = new frmEmployeeAdd();
            frmEmployeeAdd.EmployeeAdd();

        }


        //�����Ʒ����
        public void LoadEmployee()
        {

            DataTable dtl = EmployeeManage.GetEmployeeData();
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        //�༭
        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmEmployeeAdd frmEmployeeAdd = new frmEmployeeAdd();
                frmEmployeeAdd.EmployeeEdit(guid);
            }

        }

        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                EmployeeManage.DeleteEmployee(dr[0].ToString());

                LoadEmployee();
                this.ShowMessage("ɾ���ɹ�!");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmEmployeeAdd frmEmployeeAdd = new frmEmployeeAdd();
                frmEmployeeAdd.EmployeeEdit(guid);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}