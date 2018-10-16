using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// ��������ƻ�
    /// </summary>
    public partial class frmBomMRP :frmBase
    {
        MaterialMRPPlanManage MaterialMRPPlanManage = new MaterialMRPPlanManage();
        public static frmBomMRP frmbommrp;
        public frmBomMRP()
        {
            frmbommrp = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

          

            frmBomMRPAdd frmBomMRPAdd = new frmBomMRPAdd();
            frmBomMRPAdd.Add();
        }

        private void frmClientOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockPlanDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        public void LoadData()
        {

            DataTable dtl = MaterialMRPPlanManage.GetMRPPlanBySQL(GetWhereSQL());
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
          
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmBomMRPAdd frmBomMRPAdd = new frmBomMRPAdd();
                frmBomMRPAdd.Edit(guid);

            
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmBomMRPAdd frmBomMRPAdd = new frmBomMRPAdd();
                frmBomMRPAdd.Edit(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockPlanDelete", "Delete") == false)
            {
                this.ShowMessage("�Բ�����û�в�������ܵ�Ȩ�ޣ�");
                return;
            }
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {                   
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    MaterialMRPPlanManage.DeleteBill(dr["MaterialMRPPlanGuid"].ToString());

                 

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "��������ƻ�ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ������������ƻ�,��������ƻ�Ψһ��:" + dr["MaterialMRPPlanGuid"].ToString());

                    gridView1.DeleteSelectedRows();
                    this.ShowMessage("ɾ���ɹ�!");
                }

            }
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtMaterialMRPPlanID.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanID='" + txtMaterialMRPPlanID.Text.Replace("'", "''") + "'";
            }

            if (MaterialMRPPlanBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanDate>='" + MaterialMRPPlanBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (MaterialMRPPlanEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and MaterialMRPPlanDate<='" + MaterialMRPPlanEndDate.Text.Trim() + " 23:59:59'";
            }

            return strsql;

        }

       
    }
}