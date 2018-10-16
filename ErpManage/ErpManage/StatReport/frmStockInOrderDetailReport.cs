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
    ///销售出库单明细报表
    /// </summary>
    public partial class frmStockInOrderDetailReport : frmBase
    {
        public frmStockInOrderDetailReport()
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

        //选择供应商
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



        //选择收货仓库
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

        private void btnQry_Click(object sender, EventArgs e)
        {


            LoadData(GetWhereSQL());
        }

        private string GetWhereSQL()
        {
            string strsql = " where 1=1 ";



            if (dtpBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate>='" + dtpBeginDate.Text + " 00:00:00'";

            }

            if (dtpEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate<='" + dtpEndDate.Text + " 23:59:59'";

            }

            if (txtSupplierGuid.Tag != null)
            {
                if (txtSupplierGuid.Tag.ToString() != "")
                {
                    strsql = strsql + " and StockInOrder.SupplierGuid='" + txtSupplierGuid.Tag.ToString() + "'";
                }

            }


            if (txtInStorage.Tag != null)
            {
                if (txtInStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and InStorage='" + txtInStorage.Tag.ToString() + "'";
                }

            }

            if (txtStockInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderID='" + txtStockInOrderID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtStockOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockOrderID='" + txtStockOrderID.Text.Replace("'", "''").Trim() + "'";
            }


            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_StockInOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["StockInOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["StockInOrderID"].ToString()
       ||
       this.gridView1.GetDataRow(e.RowHandle1)["StockInOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["StockInOrderDate"].ToString()
       )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "采购入库单明细报表", "");
            rc.Preview();
        }
    }
}