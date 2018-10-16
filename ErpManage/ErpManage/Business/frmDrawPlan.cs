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
    ///�������ϼƻ�
    /// </summary>
    public partial class frmDrawPlan :frmBase
    {
        DrawPlanManage DrawPlanManage = new DrawPlanManage();
        public static frmDrawPlan frmdrawplan;
        public frmDrawPlan()
        {
            frmdrawplan = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            frmDrawPlanAdd frmDrawPlanAdd = new frmDrawPlanAdd();
            frmDrawPlanAdd.Add();
        }

        private void frmClientOrder_Load(object sender, EventArgs e)
        {
            LoadData();


            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        public void LoadData()
        {

            DataTable dtl = DrawPlanManage.GetDrawPlanBySQL(GetWhereSQL());
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
                frmDrawPlanAdd frmDrawPlanAdd = new frmDrawPlanAdd();
                frmDrawPlanAdd.Edit(guid);

            
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmDrawPlanAdd frmDrawPlanAdd = new frmDrawPlanAdd();
                frmDrawPlanAdd.Edit(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanDelete", "Delete") == false)
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
                    DrawPlanManage.DeleteBill(dr["DrawPlanGuid"].ToString());

                 


                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "�������ϼƻ���ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ�����������ϼƻ���,Ψһ��:" + dr["DrawPlanGuid"].ToString());

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
            if (txtDrawPlanID.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanID='" + txtDrawPlanID.Text.Replace("'", "''") + "'";
            }

            if (dtpDrawPlanBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanDate>='" + dtpDrawPlanBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpDrawPlanEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawPlanDate<='" + dtpDrawPlanEndDate.Text.Trim() + " 23:59:59'";
            }

        
            return strsql;

        }

    }
}