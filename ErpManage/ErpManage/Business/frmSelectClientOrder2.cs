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
    /// 销售出库单从客户订单中选择出货物料
    /// </summary>
    public partial class frmSelectClientOrder2 : frmBase
    {
        ClientOrderManage ClientOrderManage = new ClientOrderManage();
        SellOrderManage SellOrderManage = new SellOrderManage();

        public frmSelectClientOrder2()
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
            DataTable dtl = ClientOrderManage.GetClientOrderBySellOrderSelect(GetWhereSQL());
            this.gridControl1.DataSource = dtl;


         
  
        }

        //载入数据
        private void LoadDetailData(string ClientOrderGuid)
        {
            DataTable dtl = SellOrderManage.sp_GetSelectClientOrderData(ClientOrderGuid, BeginDate.Text, EndDate.Text);
            this.gridControl2.DataSource = dtl;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, gridCheckBox, "True");
            }

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView2.Columns["Price"].Visible = false;
               
            }


        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {

            List<SelectClientOrderDetail> alt = new List<SelectClientOrderDetail>();
            if (gridView1.RowCount > 0)
            {
                //客户订单guid
                int intRow = gridView1.GetSelectedRows()[0];
                string strClientOrderGuid = gridView1.GetRowCellValue(intRow, gridClientOrderGuid).ToString();

                //客户订单id
                string strClientOrderID = gridView1.GetRowCellValue(intRow, gridClientOrderID).ToString();

                SelectClientOrderDetail SelectClientOrderDetail = new SelectClientOrderDetail();
                //采购订单明细
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        SelectClientOrderDetail = new SelectClientOrderDetail();
                        SelectClientOrderDetail.ClientOrderGuid = strClientOrderGuid;
                        SelectClientOrderDetail.ClientOrderID = strClientOrderID;
                        SelectClientOrderDetail.ClientOrderDetailGuid = gridView2.GetRowCellValue(i, gridClientOrderDetailGuid).ToString();
                        //SelectClientOrderDetail.ClientOrderDate = DateTime.Parse(gridView2.GetRowCellValue(i, gridClientOrderDate).ToString());
                        SelectClientOrderDetail.MaterialGuID = gridView2.GetRowCellValue(i, gridMaterialGuid).ToString();
                        SelectClientOrderDetail.MaterialID = gridView2.GetRowCellValue(i, gridMaterialID).ToString();
                        SelectClientOrderDetail.MaterialName = gridView2.GetRowCellValue(i, gridMaterialName).ToString();
                        SelectClientOrderDetail.Unit = gridView2.GetRowCellValue(i, gridUnit).ToString();
                        SelectClientOrderDetail.Spec = gridView2.GetRowCellValue(i, gridSpec).ToString();
                        SelectClientOrderDetail.Price = decimal.Parse( gridView2.GetRowCellValue(i, gridPrice).ToString());
                        SelectClientOrderDetail.MaterialSum = decimal.Parse(gridView2.GetRowCellValue(i, gridMaterialSum).ToString());
                        SelectClientOrderDetail.OutStorageSum = decimal.Parse(gridView2.GetRowCellValue(i, gridOutStorageSum).ToString());
                        SelectClientOrderDetail.CanOutSum = decimal.Parse(gridView2.GetRowCellValue(i, gridCanOutSum).ToString());

                        alt.Add(SelectClientOrderDetail);
                    }

                }

                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择客户订单数据！");
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
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["ClientOrderGuID"].ToString();
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
            if (txtClientOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderID='" + txtClientOrderID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }


            if (cboOrderType.Text.Trim() != "")
            {
                strsql = strsql + " and OrderType='" + cboOrderType.Text.Trim() + "' ";
            }


            return strsql;

        }

       


       


       
    }
}