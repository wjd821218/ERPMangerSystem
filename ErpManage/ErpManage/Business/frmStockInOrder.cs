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
    /// 采购入库单查看
    /// </summary>
    public partial class frmStockInOrder : frmBase
    {
        StockInOrderManage StockInOrderManage = new StockInOrderManage();
        public static frmStockInOrder frmstockinorder;
        public frmStockInOrder()
        {
            frmstockinorder = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
            frmStockInOrderAdd.AddBill();
        }

        private void frmStockInOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = StockInOrderManage.GetStockInOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


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


                frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
                frmStockInOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
                frmStockInOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  
                    if (StockInOrderManage.GetIsCheck(dr["StockInOrderGuid"].ToString()) == false)
                    {
                        StockInOrderManage.DeleteBill(dr["StockInOrderGuid"].ToString());

                       

                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "采购入库单删除", "删除", SysParams.UserName + "用户删除了采购入库单,采购入库单唯一号:" + dr["StockInOrderGuid"].ToString() + ",采购入库单号:" + dr["StockInOrderID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowMessage("此单据已经审核,不能删除!");
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

        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStoragePerson.Text = ""; //名称
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //名称
                        txtStoragePerson.Tag = arrValue[0];  //Guid
                    }
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
            if (txtStockInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderID='" + txtStockInOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpStockInOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate>='" + dtpStockInOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpStockInOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate<='" + dtpStockInOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
            }

            if (txtStoragePerson.Tag != null)
            {
                if (txtStoragePerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and StoragePerson='" + txtStoragePerson.Tag.ToString() + "'";
                }
            }

            if (txtInStorage.Tag != null)
            {
                if (txtInStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and InStorage='" + txtInStorage.Tag.ToString() + "'";
                }
            }

            if (txtBatchNO.Text.Trim() != "")
            {
                strsql = strsql + " and BatchNO='" + txtBatchNO.Text.Replace("'", "''") + "'";
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }


            return strsql;

        }

        //收货仓库
        private void btnSelectInStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtInStorage.Text = ""; //名称
                    txtInStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtInStorage.Text = arrValue[1]; //名称
                        txtInStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}