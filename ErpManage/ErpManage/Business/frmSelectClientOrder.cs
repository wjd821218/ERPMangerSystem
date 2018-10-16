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
    /// 从客户订单选择产品
    /// </summary>
    public partial class frmSelectClientOrder : frmBase
    {
        ClientOrderManage ClientOrderManage = new ClientOrderManage();

        public frmSelectClientOrder()
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
            DataTable dtl = ClientOrderManage.GetClientOrderBySelect(GetWhereSQL());
            this.gridControl1.DataSource = dtl;





        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<String> alt = new List<String>();
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                    {
                        string guid = gridView1.GetRowCellValue(i, gridClientOrderDetailGuid).ToString();
                        alt.Add(guid);
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
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i,gridCheckBox, "True");
            }
        }

        private void btnNoSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridCheckBox, "False");
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