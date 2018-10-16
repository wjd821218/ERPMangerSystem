using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// 从采购订单选择产品
    /// </summary>
    public partial class frmSelectStockOrder : frmBase
    {
        StockOrderManage StockOrderManage = new StockOrderManage();
        StockInOrderManage StockInOrderManage = new StockInOrderManage();

        public frmSelectStockOrder()
        {
            InitializeComponent();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //载入数据
        private void LoadData()
        {
            DataTable dtl = StockOrderManage.GetStockOrderBySQL_Select(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

  
        }

        //载入数据
        private void LoadDetailData(string StockOrderGuid)
        {
            DataTable dtl = StockInOrderManage.sp_GetSelectStockOrderData(StockOrderGuid,BeginDate.Text,EndDate.Text);
            this.gridControl2.DataSource = dtl;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, gridCheckBox, "True");
            }


        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<SelectStockOrderDetail> alt = new List<SelectStockOrderDetail>();
            if (gridView1.RowCount > 0)
            {
                //采购订单guid
                int intRow = gridView1.GetSelectedRows()[0];
                string strStockOrderGuid = gridView1.GetRowCellValue(intRow, gridStockOrderGuid).ToString();
              
                //采购订单id
                string strStockOrderID = gridView1.GetRowCellValue(intRow, gridStockOrderID).ToString();

                SelectStockOrderDetail SelectStockOrderDetail = new SelectStockOrderDetail();
                //采购订单明细
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        SelectStockOrderDetail = new SelectStockOrderDetail();
                        SelectStockOrderDetail.StockOrderGuid = strStockOrderGuid;
                        SelectStockOrderDetail.StockOrderID = strStockOrderID;
                        SelectStockOrderDetail.StockOrderDetailGuid = gridView2.GetRowCellValue(i, gridStockOrderDetailGuid).ToString();
                        //SelectStockOrderDetail.StockOrderDate = DateTime.Parse(gridView2.GetRowCellValue(i, gridStockOrderDate).ToString());
                        SelectStockOrderDetail.MaterialGuID = gridView2.GetRowCellValue(i, gridMaterialGuid).ToString();
                        SelectStockOrderDetail.MaterialID = gridView2.GetRowCellValue(i, gridMaterialID).ToString();
                        SelectStockOrderDetail.MaterialName = gridView2.GetRowCellValue(i, gridMaterialName).ToString();
                        SelectStockOrderDetail.Unit = gridView2.GetRowCellValue(i, gridUnit).ToString();
                        SelectStockOrderDetail.Spec = gridView2.GetRowCellValue(i, gridSpec).ToString();
                        SelectStockOrderDetail.MaterialSum = decimal.Parse(gridView2.GetRowCellValue(i, gridMaterialSum).ToString());
                        SelectStockOrderDetail.StorageSum = decimal.Parse(gridView2.GetRowCellValue(i, gridStorageSum).ToString());
                        SelectStockOrderDetail.CanInSum = decimal.Parse(gridView2.GetRowCellValue(i, gridCanInSum).ToString());

                        alt.Add(SelectStockOrderDetail);
                    }

                }

                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择采购订单数据！");
                    return;
                }

                this.Tag = alt;
                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //if (gridView1.RowCount > 0)
            //{
            //    //int intRow = gridView1.GetSelectedRows()[0];
            //    string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
            //    this.Tag = guid;

            //    this.Close();
            //}
        }

     

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
            //string strsql = "";

            //if (txtQryValue.Text.Trim() !="")
            //{
            //    strsql = " where ProductName like '" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";
            //}
            //DataTable dtl = ProductManage.GetSelectProductData_CN(strsql);
            //this.gridControl1.DataSource = dtl;

            //gridView1.Columns[0].Visible = false;

        }

        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
              string val = ""; 
            if (e.Value != null) 
            { 
                val = e.Value.ToString(); 
            } 
            else 
            { 
                val = "True";//默认为选中 
            } 
            switch (val) 
            { 
                case "True": 
                    e.CheckState = CheckState.Checked; 
                    break; 
                case "False": 
                    e.CheckState = CheckState.Unchecked; 
                    break; 
                case "Yes": 
                    goto case "True"; 
                case "No": 
                    goto case "False"; 
                case "1": 
                    goto case "True"; 
                case "0": 
                    goto case "False"; 
                default: 
                    e.CheckState = CheckState.Checked; 
                    break; 
            } 
            e.Handled = true; 

        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
           // if ((this.gridView1.GetDataRow(e.RowHandle1)["BillID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["BillID"].ToString())
           //  || (this.gridView1.GetDataRow(e.RowHandle1)["BillDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["BillDate"].ToString()))
           //     e.Handled = true;
        }

      

        private void btnSelectALL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i,gridCheckBox, "True");
            }
        }

        private void btnNoSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, gridCheckBox, "False");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["StockOrderGuID"].ToString();
                LoadDetailData(guid);
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where CheckGuid<>'' and EndGuid='' ";
            if (txtStockOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderID='" + txtStockOrderID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtSupplierGuid.Text.Trim() != "")
            {
                strsql = strsql + " and SupplierGuid='" + txtSupplierGuid.Tag.ToString() + "'";
            }

            return strsql;

        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplierGuid.Text = ""; //名称
                    txtSupplierGuid.Tag = "";  //Guid
                }
                else
                {

                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplierGuid.Text = arrValue[1]; //名称
                        txtSupplierGuid.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }


       


       
    }
}