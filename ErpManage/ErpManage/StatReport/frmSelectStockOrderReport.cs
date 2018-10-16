using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// �ɹ�����ִ���������
    /// </summary>
    public partial class frmSelectStockOrderReport : frmBase
    {
        StockInOrderManage StockInOrderManage = new StockInOrderManage();
     

        public frmSelectStockOrderReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
           
        }


        //��������
        private void LoadDetailData()
        {
            string flag ;
            if (chkEnd.Checked == true)
            {
                flag = "1";  //�ѽᵥ
            }
            else
            {
                flag = "0"; //δ�ᵥ
            }

            DataTable dtl = StockInOrderManage.sp_GetSelectStockOrderDataReport(txtStockOrderID.Text.Replace("'", "''").Trim(), BeginDate.Text, EndDate.Text, flag);
            this.gridControl2.DataSource = dtl;

        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadDetailData();
        }



     

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if ((this.gridView2.GetDataRow(e.RowHandle1)["StockOrderID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["StockOrderID"].ToString())
             || (this.gridView2.GetDataRow(e.RowHandle1)["StockOrderDate"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["StockOrderDate"].ToString())
                || (this.gridView2.GetDataRow(e.RowHandle1)["SupplierName"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["SupplierName"].ToString()))
                e.Handled = true;
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel�ļ�|*.XLS|�����ļ�|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView2.ExportToXls(filename);

                this.ShowMessage("�����ɹ�");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
              //����ֱ�Ӵ�ӡ
            ReportCenter rc = new ReportCenter(gridControl2, "�ɹ�����ִ���������", "", true);
            rc.Preview();
        }
       
    }
}