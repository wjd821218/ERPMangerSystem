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
    /// 从退料单选择产品:2010-8-27
    /// </summary>
    public partial class frmSelectQuitOrder : frmBase
    {
        QuitOrderManage QuitOrderManage = new QuitOrderManage();

        public frmSelectQuitOrder()
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
            DataTable dtl = QuitOrderManage.GetQuitOrderBySQL(GetWhereSQL());
            this.gridControl1.DataSource = dtl;

  
        }

        //载入数据
        private void LoadDetailData(string QuitOrderGuid)
        {
            DataTable dtl = QuitOrderManage.GetQuitOrderDetailBySelect(QuitOrderGuid);
            this.gridControl2.DataSource = dtl;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, gridCheckBox, "True");
            }


        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<SelectQuitOrderDetail> alt = new List<SelectQuitOrderDetail>();
            if (gridView1.RowCount > 0)
            {
                //退料单guid
                int intRow = gridView1.GetSelectedRows()[0];
                string strQuitOrderGuid = gridView1.GetRowCellValue(intRow, gridQuitOrderGuid).ToString();

                //退料单id
                string strQuitOrderID = gridView1.GetRowCellValue(intRow, gridQuitOrderID).ToString();

                SelectQuitOrderDetail SelectQuitOrderDetail = new SelectQuitOrderDetail();
                //退料单明细
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        SelectQuitOrderDetail = new SelectQuitOrderDetail();
                        SelectQuitOrderDetail.QuitOrderGuid = strQuitOrderGuid;
                        SelectQuitOrderDetail.QuitOrderID = strQuitOrderID;
                        SelectQuitOrderDetail.QuitOrderDetailGuid = gridView2.GetRowCellValue(i, gridQuitOrderDetailGuid).ToString();
                        SelectQuitOrderDetail.QuitOrderDate = DateTime.Parse(gridView1.GetRowCellValue(intRow, gridQuitOrderDate).ToString());
                        SelectQuitOrderDetail.MaterialGuID = gridView2.GetRowCellValue(i, gridMaterialGuid).ToString();
                        SelectQuitOrderDetail.MaterialID = gridView2.GetRowCellValue(i, gridMaterialID).ToString();
                        SelectQuitOrderDetail.MaterialName = gridView2.GetRowCellValue(i, gridMaterialName).ToString();

                        decimal price = decimal.Parse(gridView2.GetRowCellValue(i, gridMaterialPrice).ToString());
                        decimal MaterialSum = decimal.Parse(gridView2.GetRowCellValue(i, gridMaterialSum).ToString());
                        SelectQuitOrderDetail.MaterialPrice =price;
                        SelectQuitOrderDetail.MaterialMoney = -price * MaterialSum;
                        SelectQuitOrderDetail.MaterialSum = MaterialSum;

                        SelectQuitOrderDetail.SupplierName = gridView1.GetRowCellValue(intRow, gridSupplierName).ToString();
                        
                        alt.Add(SelectQuitOrderDetail);
                    }

                }

                if (alt.Count <= 0)
                {
                    //请选择记录
                    ShowMessage("请选择退料单数据！");
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
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["QuitOrderGuID"].ToString();
                LoadDetailData(guid);
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where CheckGuid2<>''  ";
            if (txtQuitOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderID='" + txtQuitOrderID.Text.Replace("'", "''") + "'";
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderDate>='" + BeginDate.Text.Trim() + " 00:00:00'";
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderDate<='" + EndDate.Text.Trim() + " 23:59:59'";
            }

            return strsql;

        }


       


       
    }
}