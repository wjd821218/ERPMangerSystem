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
    /// 库存报表
    /// </summary>
    public partial class frmQuitOrderDetailReport : frmBase
    {
        public frmQuitOrderDetailReport()
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
                strsql = strsql + " and QuitOrderDate>='" + dtpBeginDate.Text + " 00:00:00'";

            }

            if (dtpEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderDate<='" + dtpEndDate.Text + " 23:59:59'";

            }

            if (txtQuitOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitOrderID<='" + txtQuitOrderID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtSupplierGuid.Tag != null)
            {
                if (txtSupplierGuid.Tag.ToString() != "")
                {
                    strsql = strsql + " and QuitOrder.SupplierGuid='" + txtSupplierGuid.Tag.ToString() + "'";
                }

            }

            if (txtOutStorage.Tag != null)
            {
                if (txtOutStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and QuitOrder.OutStorage='" + txtOutStorage.Tag.ToString() + "'";
                }
            }


            return strsql;

        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_QuitOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

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

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["QuitOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["QuitOrderID"].ToString()
            ||
            this.gridView1.GetDataRow(e.RowHandle1)["QuitOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["QuitOrderDate"].ToString()
            )
                e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "退料单明细报表", "");
            rc.Preview();
        }

        private void txtOutStorage_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSelectOutStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtOutStorage.Text = ""; //名称
                    txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //名称
                        txtOutStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}