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
    ///�ͻ�����
    /// </summary>
    public partial class frmClient : frmBase
    {
        ClientManage ClientManage = new ClientManage();
        public static frmClient frmclient;
        public frmClient()
        {
            InitializeComponent();
            frmclient = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmClientAdd frmClientAdd = new frmClientAdd();
            frmClientAdd.ClientAdd();

        }


        //�����Ʒ����
        public void LoadClient()
        {

            DataTable dtl = ClientManage.GetClientData();
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            LoadClient();
        }

        //�༭
        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

                frmClientAdd frmClientAdd = new frmClientAdd();
                frmClientAdd.ClientEdit(guid);
            }

        }

        //ɾ��
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                ClientManage.DeleteClient(dr[0].ToString());

                LoadClient();
                this.ShowMessage("ɾ���ɹ�!");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //int intRow = gridView1.GetSelectedRows()[0];
            string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();

            frmClientAdd frmClientAdd = new frmClientAdd();
            frmClientAdd.ClientEdit(guid);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}