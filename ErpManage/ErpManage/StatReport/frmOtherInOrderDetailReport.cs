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
    ///其它入库单明细报表
    /// </summary>
    public partial class frmOtherInOrderDetailReport : frmBase
    {
        public frmOtherInOrderDetailReport()
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

         
            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderDate>='" + BeginDate.Text+ " 00:00:00'";
            
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderDate<='" + EndDate.Text + " 23:59:59'";

            }

            if (txtOtherInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderID='" + txtOtherInOrderID.Text.Replace("'", "''").Trim() + "'";
            }

            if (txtInStorage.Tag != null)
            { 
               if (txtInStorage.Tag.ToString()!="")
               {
                   strsql = strsql + " and InStorage='" + txtInStorage.Tag.ToString() + "'";
               }
             
            }

            return strsql;
        
        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_OtherInOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["OtherInOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["OtherInOrderID"].ToString()
             ||
             this.gridView1.GetDataRow(e.RowHandle1)["OtherInOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["OtherInOrderDate"].ToString()
             )
                e.Handled = true;
        }

       

        private void btnSelectOutStorage_Click(object sender, EventArgs e)
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "其它出库单明细报表", "");
            rc.Preview();
        }
    }
}