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
    /// 采购订单执行情况报表
    /// </summary>
    public partial class frmSelectStockOrderReport : frmBase
    {
        StockInOrderManage StockInOrderManage = new StockInOrderManage();
     

        public frmSelectStockOrderReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
           
        }


        //载入数据
        private void LoadDetailData()
        {
            string flag ;
            if (chkEnd.Checked == true)
            {
                flag = "1";  //已结单
            }
            else
            {
                flag = "0"; //未结单
            }

            DataTable dtl = StockInOrderManage.sp_GetSelectStockOrderDataReport(txtStockOrderID.Text.Replace("'", "''").Trim(), BeginDate.Text, EndDate.Text, flag);
            this.gridControl2.DataSource = dtl;

        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadDetailData();
        }



     

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if ((this.gridView2.GetDataRow(e.RowHandle1)["StockOrderID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["StockOrderID"].ToString())
             || (this.gridView2.GetDataRow(e.RowHandle1)["StockOrderDate"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["StockOrderDate"].ToString())
                || (this.gridView2.GetDataRow(e.RowHandle1)["SupplierName"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["SupplierName"].ToString()))
                e.Handled = true;
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView2.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
              //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl2, "采购订单执行情况报表", "", true);
            rc.Preview();
        }
       
    }
}