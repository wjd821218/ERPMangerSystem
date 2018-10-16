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
    /// 从采购入库单选择产品:2010-8-27
    /// </summary>
    public partial class frmSelectStockInOrder3 : frmBase
    {
        StockInOrderManage StockInOrderManage = new StockInOrderManage();

        public frmSelectStockInOrder3()
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
            DataTable dtl = StockInOrderManage.GetStockInOrderBySQL(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

  
        }

        //载入数据
        private void LoadDetailData(string StockInOrderGuid)
        {
            DataTable dtl = StockInOrderManage.GetStockInOrderDetailBySelect(StockInOrderGuid);
            this.gridControl2.DataSource = dtl;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, gridCheckBox, "True");
            }


        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<SelectStockInOrderDetail> alt = new List<SelectStockInOrderDetail>();
            if (gridView1.RowCount > 0)
            {
                //采购订单guid
                int intRow = gridView1.GetSelectedRows()[0];
                string strStockInOrderGuid = gridView1.GetRowCellValue(intRow, gridStockInOrderGuid).ToString();
              
                //采购入库单id
                string strStockInOrderID = gridView1.GetRowCellValue(intRow, gridStockInOrderID).ToString();

                SelectStockInOrderDetail SelectStockInOrderDetail = new SelectStockInOrderDetail();
                //采购订单明细
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        SelectStockInOrderDetail = new SelectStockInOrderDetail();
                        SelectStockInOrderDetail.StockInOrderGuid = strStockInOrderGuid;
                        SelectStockInOrderDetail.StockInOrderID = strStockInOrderID;
                        SelectStockInOrderDetail.StockInOrderDetailGuid = gridView2.GetRowCellValue(i, gridStockInOrderDetailGuid).ToString();
                        SelectStockInOrderDetail.StockInOrderDate = DateTime.Parse(gridView1.GetRowCellValue(intRow, gridStockInOrderDate).ToString());
                        SelectStockInOrderDetail.MaterialGuID = gridView2.GetRowCellValue(i, gridMaterialGuid).ToString();
                        SelectStockInOrderDetail.MaterialID = gridView2.GetRowCellValue(i, gridMaterialID).ToString();
                        SelectStockInOrderDetail.MaterialName = gridView2.GetRowCellValue(i, gridMaterialName).ToString();

                        decimal price = StockInOrderManage.GetStockOrderPriceByMaterial(gridView2.GetRowCellValue(i, gridStockOrderGuid).ToString(), SelectStockInOrderDetail.MaterialGuID);
                        decimal StorageSum=decimal.Parse(gridView2.GetRowCellValue(i, gridStorageSum).ToString());
                        SelectStockInOrderDetail.MaterialPrice =price;
                        SelectStockInOrderDetail.MaterialMoney = price*StorageSum;
                        SelectStockInOrderDetail.StorageSum = StorageSum;

                        SelectStockInOrderDetail.SupplierName = gridView1.GetRowCellValue(intRow, gridSupplierName).ToString();
                        
                        alt.Add(SelectStockInOrderDetail);
                    }

                }

                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择采购入库单数据！");
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
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["StockInOrderGuID"].ToString();
                LoadDetailData(guid);
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where CheckGuid<>''  ";
            if (txtStockInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderID='" + txtStockInOrderID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }

            return strsql;

        }


       


       
    }
}