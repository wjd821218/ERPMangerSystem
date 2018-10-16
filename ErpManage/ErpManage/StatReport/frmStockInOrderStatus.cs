using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.StatReport
{
    /// <summary>
    /// 采购入库单是否已开票报表(已勾结，未勾结)
    /// </summary>
    public partial class frmStockInOrderStatus : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmStockInOrderStatus()
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
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();

           string  strValue = "";
           if (chkEnd.Checked == true)
           {
               strValue = "1"; //已勾结
           }

           if (txtSupplierGuid.Tag == null)
           {
               txtSupplierGuid.Tag = "";
           }

            dtl = StatReportManage.sp_GetStockInOrderStatus_Report(txtStockInOrderID.Text.Replace("'","''"),dtpBeginDate.Text,dtpEndDate.Text,txtSupplierGuid.Tag.ToString(),strValue);

            this.gridControl1.DataSource = dtl;
        }

      


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void btnSelect_Click(object sender, EventArgs e)
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

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "采购入库单已开票报表", "");
            rc.Preview();
        }
    }
}