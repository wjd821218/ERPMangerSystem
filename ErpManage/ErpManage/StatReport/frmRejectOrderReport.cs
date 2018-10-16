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
    /// 报废单统计报表
    /// </summary>
    public partial class frmRejectOrderReport : frmBase
    {
        public frmRejectOrderReport()
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
            string strsql = " where CheckGuid2<>'''' ";



            if (dtpBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and RejectOrderDate>='" + dtpBeginDate.Text + " 00:00:00'";

            }

            if (dtpEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and RejectOrderDate<='" + dtpEndDate.Text + " 23:59:59'";

            }


            if (txtProductType.Text.Trim() != "")
            {

                strsql = strsql + " and RejectOrder.ProductType='" + txtProductType.Text.Trim().Replace("'", "''") + "'";


            }

            if (txtClientOrderID.Text.Trim() != "")
            {

                strsql = strsql + " and RejectOrder.ClientOrderID='" + txtClientOrderID.Text.Trim().Replace("'", "''") + "'";


            }


            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
           dtl = StatReportManage.sp_RejectOrder_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "报废单统计报表", "");
            rc.Preview();
        }

      
    }
}