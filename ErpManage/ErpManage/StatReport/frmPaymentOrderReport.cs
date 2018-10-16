using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;
using DevExpress.Utils;

namespace ErpManage.StatReport
{
    /// <summary>
    /// 采购付款单报表
    /// </summary>
    public partial class frmPaymentOrderReport : frmBase
    {
       
        DataSet ds = new DataSet();
        public frmPaymentOrderReport()
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

            gridView1.Columns.Clear();

            if (dtpBeginDate.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择开始日期!");
                return;
            }


              if (dtpEndDate.Text.Trim()=="")
            {
                this.ShowAlertMessage("请选择截止日期!");
                return ;
            }

             
          


            StatReportManage  StatReportManage=new StatReportManage();
            DataTable dtl = StatReportManage.sp_Payment_Report(dtpBeginDate.Text , dtpEndDate.Text );
            this.gridControl1.DataSource = dtl;

            for (int i = 1; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].DisplayFormat.FormatType = FormatType.Numeric;
                gridView1.Columns[i].DisplayFormat.FormatString = "0.####";
       
            }


            gridView1.Columns["合计"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["合计"].SummaryItem.FieldName = "合计";
         
            gridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "合计",gridView1.Columns["合计"], "小计：{0:N2}");  //可以显示小计
            gridView1.OptionsView.ShowFooter = true;


        
            //用于打印
            //DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            //ds.Tables.Clear();
            //ds.Tables.Add(dtl3.Copy());
            //ds.Tables[0].TableName = "PaymentOrderReport";


        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void frmStockReport_Load(object sender, EventArgs e)
        {
            dtpEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "采购付款单统计报表", "");
            rc.Preview();
        }
    }
}