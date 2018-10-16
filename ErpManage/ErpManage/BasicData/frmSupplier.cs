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
    public partial class frmSupplier : frmBase
    {
        SupplierManage SupplierManage = new SupplierManage();
        public static frmSupplier frmsupplier;
        public frmSupplier()
        {
            InitializeComponent();
            frmsupplier = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
            frmSupplierAdd.SupplierAdd();

        }


        //�����Ʒ����
        public void LoadSupplier()
        {

            DataTable dtl = SupplierManage.GetSupplierData();
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        //�༭
        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
                frmSupplierAdd.SupplierEdit(guid);
            }

        }

        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                SupplierManage.DeleteSupplier(dr[0].ToString());


                //д��־
                //SysLog.AddOperateLog(SysParams.UserName, "��Ӧ��ɾ��", "ɾ��", SysParams.UserName + "ɾ���˹�Ӧ��[" + Supplier.Name + "]");


                LoadSupplier();
                this.ShowMessage("ɾ���ɹ�!");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
                frmSupplierAdd.SupplierEdit(guid);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}