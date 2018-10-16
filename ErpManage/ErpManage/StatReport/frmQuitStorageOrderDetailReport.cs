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
    /// 退料入库单统计报表
    /// </summary>
    public partial class frmQuitStorageOrderDetailReport : frmBase
    {
        public frmQuitStorageOrderDetailReport()
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
                strsql = strsql + " and QuitStorageOrderDate>='" + dtpBeginDate.Text + " 00:00:00'";

            }

            if (dtpEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrderDate<='" + dtpEndDate.Text + " 23:59:59'";

            }

            if (txtQuitStorageOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrderID<='" + txtQuitStorageOrderID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtInStorage.Tag != null)
            {
                if (txtInStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and QuitStorageOrder.InStorage='" + txtInStorage.Tag.ToString() + "'";
                }

            }

            if (txtQuitStorageOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrder.QuitStorageOrderID='" + txtQuitStorageOrderID.Text.Trim().Replace("'","''") + "'";
            }



            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_QuitStorageOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

     
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

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["QuitStorageOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["QuitStorageOrderID"].ToString()
         ||
         this.gridView1.GetDataRow(e.RowHandle1)["QuitStorageOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["QuitStorageOrderDate"].ToString()
         )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "退料入库单明细报表", "");
            rc.Preview();
        }
    }
}