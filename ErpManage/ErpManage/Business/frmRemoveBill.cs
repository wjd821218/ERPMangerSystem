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
    /// 调拨单
    /// </summary>
    public partial class frmRemoveBill : frmBase
    {
        RemoveBillManage RemoveBillManage=new RemoveBillManage();
        public static frmRemoveBill frmremovebill;
        public frmRemoveBill()
        {
            InitializeComponent();
            frmremovebill = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            frmRemoveBillAdd frmRemoveBillAdd = new frmRemoveBillAdd();
            frmRemoveBillAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = RemoveBillManage.GetRemoveBillBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmRemoveBillAdd frmRemoveBillAdd = new frmRemoveBillAdd();
                frmRemoveBillAdd.EditBill(guid);
            }
        }

    
        private void frmRemoveBill_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmRemoveBillAdd frmRemoveBillAdd = new frmRemoveBillAdd();
                frmRemoveBillAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RemoveBillManage RemoveBillManage = new RemoveBillManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (RemoveBillManage.GetIsCheck(dr["RemoveBillGuid"].ToString()) == false)
                    {
                        RemoveBillManage.DeleteBill(dr["RemoveBillGuid"].ToString());

                    


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "调拨单删除", "删除", SysParams.UserName + "用户删除了调拨单,调拨单唯一号:" + dr["RemoveBillGuid"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowAlertMessage("此单据已审核，不可以删除!");
                    }
                }


            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtRemoveBillID.Text.Trim() != "")
            {
                strsql = strsql + " and RemoveBillID='" + txtRemoveBillID.Text.Replace("'", "''") + "'";
            }

            if (dtpRemoveBillBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and RemoveBillDate>='" + dtpRemoveBillBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpRemoveBillEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and RemoveBillDate<='" + dtpRemoveBillEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtHandlePerson.Tag != null)
            {
                if (txtHandlePerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and HandlePerson='" + txtHandlePerson.Tag.ToString() + "'";

                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            return strsql;

        }

        private void btnSelectTransactorPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtHandlePerson.Text = ""; //名称
                    txtHandlePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtHandlePerson.Text = arrValue[1]; //名称
                        txtHandlePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

      
    }
}
