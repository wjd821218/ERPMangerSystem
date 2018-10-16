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
    /// 收款单查看
    /// </summary>
    public partial class frmIncomeOrder :frmBase
    {
        IncomeOrderManage IncomeOrderManage = new IncomeOrderManage();
        public  static frmIncomeOrder frmincomeorder;
        public frmIncomeOrder()
        {
            InitializeComponent();
            frmincomeorder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            frmIncomeOrderAdd frmIncomeOrderAdd = new frmIncomeOrderAdd();
            frmIncomeOrderAdd.AddBill();
        }


        private void frmIncomeOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IncomeOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = IncomeOrderManage.GetIncomeOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmIncomeOrderAdd frmIncomeOrderAdd = new frmIncomeOrderAdd();
                frmIncomeOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmIncomeOrderAdd frmIncomeOrderAdd = new frmIncomeOrderAdd();
                frmIncomeOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (IncomeOrderManage.GetIsCheck(dr["IncomeOrderGuid"].ToString()) == false)
                    {
                        IncomeOrderManage.DeleteBill(dr["IncomeOrderGuid"].ToString());

                      


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "收款单删除", "删除", SysParams.UserName + "用户删除了收款单,收款单唯一号:" + dr["IncomeOrderGuid"].ToString() + ",收款单号:" + dr["IncomeOrderID"].ToString());

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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtIncomeOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and IncomeOrderID='" + txtIncomeOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpIncomeOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and IncomeOrderDate>='" + dtpIncomeOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpIncomeOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and IncomeOrderDate<='" + dtpIncomeOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtClient.Tag != null)
            {
                if (txtClient.Tag.ToString() != "")
                {

                    strsql = strsql + " and ClientGuid<='" + txtClient.Tag.ToString() + "'";
                }
            }



            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            return strsql;

        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(4);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtClient.Text = ""; //名称
                    txtClient.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtClient.Text = arrValue[1]; //名称
                        txtClient.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }


    }

}