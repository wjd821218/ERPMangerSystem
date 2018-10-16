using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.StatReport
{
    /// <summary>
    ///采购订单明细报表
    /// </summary>
    public partial class frmStockOrderDetailReport : frmBase
    {
        public frmStockOrderDetailReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQry_Click(object sender, EventArgs e)
        {

            LoadData(GetWhereSQL());
        }

        private string GetWhereSQL()
        {
            string strsql = " where 1=1 ";



            if (dtpBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate>='" + dtpBeginDate.Text + " 00:00:00'";

            }

            if (dtpEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderDate<='" + dtpEndDate.Text + " 23:59:59'";

            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and dbo.StockOrder.SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }

            }

            if (txtStockOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderID='" + txtStockOrderID.Text.Replace("'","''").Trim() + "'";
            }

            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
             dtl = StatReportManage.sp_StockOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void btnSelect_Click(object sender, EventArgs e)
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

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["StockOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["StockOrderID"].ToString()
     ||
     this.gridView1.GetDataRow(e.RowHandle1)["StockOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["StockOrderDate"].ToString()
     ||
     this.gridView1.GetDataRow(e.RowHandle1)["SupplierName"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["SupplierName"].ToString()

                )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "采购订单明细报表", "");
            rc.Preview();
        }
    }
}