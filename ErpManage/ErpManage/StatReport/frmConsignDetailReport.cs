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
    ///委外加工入库明细报表
    /// </summary>
    public partial class frmConsignDetailReport : frmBase
    {
        public frmConsignDetailReport()
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

            if (txtIncomeDepot.Tag != null)
            {
                if (txtIncomeDepot.Tag.ToString() != "")
                {
                    strsql = strsql + " and IncomeDepot='" + txtIncomeDepot.Tag.ToString() + "'";
                }

            }

            if (txtConsignID.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignID='" + txtConsignID.Text.Trim().Replace("'","''") + "'";
            }

            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_ConsignDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["ConsignID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["ConsignID"].ToString()
           ||
           this.gridView1.GetDataRow(e.RowHandle1)["ConsignDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["ConsignDate"].ToString()
           )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "委外加工入库单明细报表", "");
            rc.Preview();
        }
    }
}