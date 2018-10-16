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
    /// 物料需求计划
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

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockPlanDelete", "Delete") == false)
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
                    MaterialMRPPlanManage.DeleteBill(dr["MaterialMRPPlanGuid"].ToString());

                 

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "物料需求计划删除", "删除", SysParams.UserName + "用户删除了物料需求计划,物料需求计划唯一号:" + dr["MaterialMRPPlanGuid"].ToString());

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