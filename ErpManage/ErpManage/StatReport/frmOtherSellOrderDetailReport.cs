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
    ///其它出库单明细报表
    /// </summary>
    public partial class frmOtherSellOrderDetailReport : frmBase
    {
        public frmOtherSellOrderDetailReport()
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

            if (txtClient.Tag != null)
            {
                if (txtClient.Tag.ToString() != "")
                {
                    strsql = strsql + " and Client='" + txtClient.Tag.ToString() + "'";
                }
            }

            if (BeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherSellOrderDate>='" + BeginDate.Text+ " 00:00:00'";
            
            }

            if (EndDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherSellOrderDate<='" + EndDate.Text + " 23:59:59'";

            }

            if (txtOtherSellOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and OtherSellOrderID='" + txtOtherSellOrderID.Text.Replace("'", "''").Trim() + "'";
            }

            if (txtOutStorage.Tag != null)
            { 
               if (txtOutStorage.Tag.ToString()!="")
               {
                   strsql = strsql + " and OutStorage='" + txtOutStorage.Tag.ToString() + "'";
               }
             
            }

            return strsql;
        
        }

        private void LoadData(string strsql)
        {
            DataTable dtl = new DataTable();
            StatReportManage StatReportManage = new StatReportManage();
            dtl = StatReportManage.sp_OtherSellOrderDetail_Report(strsql);

            this.gridControl1.DataSource = dtl;
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView1.GetDataRow(e.RowHandle1)["OtherSellOrderID"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["OtherSellOrderID"].ToString()
             ||
             this.gridView1.GetDataRow(e.RowHandle1)["OtherSellOrderDate"].ToString() != this.gridView1.GetDataRow(e.RowHandle2)["OtherSellOrderDate"].ToString()
             )
                e.Handled = true;
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(4);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtClient.Text = ""; //名称
                    txtClient.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtClient.Text = arrValue[1]; //名称
                        txtClient.Tag = arrValue[0];  //Guid
                    }
                }
            }
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