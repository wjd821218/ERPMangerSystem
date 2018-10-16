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
    /// ��Ӧ�̹���
    /// </summary>
    public partial class frmDept : frmBase
    {
        DeptManage DeptManage = new DeptManage();
        public static frmDept frmdept;
        public frmDept()
        {
            InitializeComponent();
            frmdept = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDeptAdd frmDeptAdd = new frmDeptAdd();
            frmDeptAdd.DeptAdd();

        }


        //�����Ʒ����
        public void LoadDept()
        {

            DataTable dtl = DeptManage.GetDeptData();
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        private void frmDept_Load(object sender, EventArgs e)
        {
            LoadDept();
        }

        //�༭
        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmDeptAdd frmDeptAdd = new frmDeptAdd();
                frmDeptAdd.DeptEdit(guid);
            }

        }

        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                DeptManage.DeleteDept(dr[0].ToString());

                SysLog.AddOperateLog(SysParams.UserName, "����", "ɾ������", SysParams.UserName + "�û�ɾ������[" + dr["��������"].ToString() + "]");


                LoadDept();
                this.ShowMessage("ɾ���ɹ�!");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmDeptAdd frmDeptAdd = new frmDeptAdd();
                frmDeptAdd.DeptEdit(guid);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}