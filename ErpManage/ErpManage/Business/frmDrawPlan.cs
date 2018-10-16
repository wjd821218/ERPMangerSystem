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
    ///生产领料计划
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


            //权限判断
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
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawPlanDelete", "Delete") == false)
            {
                this.ShowMessage("对不起，你没有操作此项功能的权限！");
                return;
            }

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {                   
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    DrawPlanManage.DeleteBill(dr["DrawPlanGuid"].ToString());

                 


                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "生产领料计划单删除", "删除", SysParams.UserName + "用户删除了生产领料计划单,唯一号:" + dr["DrawPlanGuid"].ToString());

                    gridView1.DeleteSelectedRows();

                    this.ShowMessage("删除成功!");
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