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
    ///客户订单明细报表
    /// </summary>
    public partial class frmClientOrderDetailReport : frmBase
    {
        public frmClientOrderDetailReport()
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

          
            if (dtpClientOrderBeginDate.Text!= "")
            {
                strsql = strsql + " and ClientOrderDate>='" + dtpClientOrderBeginDate.Text + " 00:00:00'";

            }

            if (dtpClientOrderEndDate.Text != "")
            {
                strsql = strsql + " and ClientOrderDate<='" + dtpClientOrderEndDate.Text + " 23:59:59'";

            }


            if (dtpEncasementBeginDate.Text != "")
            {
                strsql = strsql + " and EncasementDate>='" + dtpEncasementBeginDate.Text + " 00:00:00'";

            }

            if (dtpEncasementEndDate.Text != "")
            {
                strsql = strsql + " and EncasementDate<='" + dtpEncasementEndDate.Text + " 23:59:59'";

            }



            if (txtClientOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and ClientOrderID='" + txtClientOrderID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtContractID.Text.Trim() != "")
            {
                strsql = strsql + " and ContractID='" + txtContractID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtCheckBatchID.Text.Trim() != "")
            {
                strsql = strsql + " and CheckBatchID='" + txtCheckBatchID.Text.Replace("'", "''").Trim() + "'";
            }

            if (cboOrderType.Text.Trim() != "")
            {
                strsql = strsql + " and OrderType='" + cboOrderType.Text.Trim() + "' ";
            }


            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_ClientOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["ClientOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["ClientOrderID"].ToString()
            ||
            this.gridView1.GetDataRow(e.RowHandle1)["ClientOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["ClientOrderDate"].ToString()
               ||
            this.gridView1.GetDataRow(e.RowHandle1)["EncasementDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["EncasementDate"].ToString()

                )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "客户订单明细报表", "");
            rc.Preview();
        }

    }
}