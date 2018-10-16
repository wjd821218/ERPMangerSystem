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
    /// 委外加工入库
    /// </summary>
    public partial class frmConsign : frmBase
    {
        ConsignManage ConsignManage=new ConsignManage();
        public static frmConsign frmconsign;
        public frmConsign()
        {
            InitializeComponent();
            frmconsign = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            frmConsignAdd frmConsignAdd = new frmConsignAdd();
            frmConsignAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = ConsignManage.GetConsignBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmConsignAdd frmConsignAdd = new frmConsignAdd();
                frmConsignAdd.EditBill(guid);
            }
        }

    
        private void frmConsign_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmConsignAdd frmConsignAdd = new frmConsignAdd();
                frmConsignAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ConsignManage ConsignManage = new ConsignManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (ConsignManage.GetIsCheck(dr["ConsignGuid"].ToString()) == false)
                    {
                        ConsignManage.DeleteBill(dr["ConsignGuid"].ToString());

                    


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "委外入库单删除", "删除", SysParams.UserName + "用户删除了委外入库单,委外入库单唯一号:" + dr["ConsignGuid"].ToString());

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
            if (txtConsignID.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignID='" + txtConsignID.Text.Replace("'", "''") + "'";
            }

            if (dtpConsignBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignDate>='" + dtpConsignBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpConsignEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignDate<='" + dtpConsignEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtDepotPerson.Tag != null)
            {
                if (txtDepotPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and DepotPerson='" + txtDepotPerson.Tag.ToString() + "'";
                }
            }

            if (txtTransactorPerson.Tag != null)
            {
                if (txtTransactorPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and TransactorPerson='" + txtTransactorPerson.Tag.ToString() + "'";

                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
            }

            if (txtBatchNO.Text.Trim() != "")
            {
                strsql = strsql + " and BatchNo='" + txtBatchNO.Text.Trim() + "'";

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
                    txtTransactorPerson.Text = ""; //名称
                    txtTransactorPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtTransactorPerson.Text = arrValue[1]; //名称
                        txtTransactorPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectDepotPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDepotPerson.Text = "";
                    txtDepotPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDepotPerson.Text = arrValue[1]; //名称
                        txtDepotPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplier.Text = ""; //名称
                    txtSupplier.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //名称
                        txtSupplier.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}
