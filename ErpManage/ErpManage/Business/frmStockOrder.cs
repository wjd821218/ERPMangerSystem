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
    /// 采购订单查看
    /// </summary>
    public partial class frmStockOrder : frmBase
    {
        public static frmStockOrder frmstockorder;
        StockOrderManage StockOrderManage = new StockOrderManage();
        public frmStockOrder()
        {
            frmstockorder = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
            frmStockOrderAdd.AddBill();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = StockOrderManage.GetStockOrderBySQL_CN(GetWhereSQL());

            gridControl1.DataSource = dtl;

        
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
                frmStockOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockOrderAdd frmStockOrderAdd = new frmStockOrderAdd();
                frmStockOrderAdd.EditBill(guid);
            }
        }

        //--------------------------------------

        //判断将删除的单据是否已有别的单据引用
        public List<YJOrderDelete> IsYJOrderDelete(string StockOrderGuID)
        {
            List<YJOrderDelete> lst = new List<YJOrderDelete>();
            YJOrderDelete YJOrderDelete = new YJOrderDelete();


            StockOrderManage StockOrderManage = new StockOrderManage();
            DataTable dtl = StockOrderManage.GetStockOrderIDAndPaymentOrderID(StockOrderGuID);

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                string strOrderID = dtl.Rows[i]["StockInOrderID"].ToString();
                YJOrderDelete = new YJOrderDelete();
                YJOrderDelete.OrderID = strOrderID;
                YJOrderDelete.OrderName = "采购入库单";
                lst.Add(YJOrderDelete);
            }
            return lst;
        }

        //--------------------------------------------------



        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  
                    if (StockOrderManage.GetIsCheck(dr["StockOrderGuid"].ToString()) == false)
                    {
                        //-----------------------------------------------------
                        MaterialManage MaterialManage = new MaterialManage();
                        if (MaterialManage.OrderDeleteAlert() == true)
                        {
                            //加载出被引用的单据
                            List<YJOrderDelete> lst = IsYJOrderDelete(dr["StockOrderGuid"].ToString());
                            if (lst.Count > 0)
                            {
                                frmShowYJOrderDelete frmShowYJOrderDelete = new frmShowYJOrderDelete();
                                frmShowYJOrderDelete.ShowFillData(lst);
                                return;
                            }
                        }
                        //---------------------------------------------------------


                        StockOrderManage.DeleteBill(dr["StockOrderGuid"].ToString());


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "采购订单删除", "删除", SysParams.UserName + "用户删除了采购订单,订单唯一号:" + dr["StockOrderGuid"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowMessage("此单据已经审核或结单,不能删除!");
                    }


                }
            }
           
            
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtStockOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderID='" + txtStockOrderID.Text.Replace("'", "''") + "'";
            }

            if (StockOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate>='" + StockOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (StockOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate<='" + StockOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkEnd.Checked == true)
            {
                strsql = strsql + " and EndGuid<>'' ";
            }


            return strsql;

        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
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