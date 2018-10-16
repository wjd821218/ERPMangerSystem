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
    /// ���۳��ⵥ�ӿͻ�������ѡ���������
    /// </summary>
    public partial class frmSelectClientOrderReport : frmBase
    {
       
        SellOrderManage SellOrderManage = new SellOrderManage();

        public frmSelectClientOrderReport()
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
            string flag;
            if (chkEnd.Checked == true)
            {
                flag = "1";  //�ѽᵥ
            }
            else
            {
                flag = "0"; //δ�ᵥ
            }



            DataTable dtl = SellOrderManage.sp_GetSelectClientOrderDataReport(txtClientOrderID.Text.Trim().Replace("'", "''"), BeginDate.Text, EndDate.Text, flag);
            this.gridControl2.DataSource = dtl;

         

            //Ȩ���ж�
            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            //{
            //    gridView2.Columns["Price"].Visible = false;
               
            //}


        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadDetailData();
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if ((this.gridView2.GetDataRow(e.RowHandle1)["ClientOrderID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["ClientOrderID"].ToString())
           || (this.gridView2.GetDataRow(e.RowHandle1)["ClientOrderDate"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["ClientOrderDate"].ToString())
                || (this.gridView2.GetDataRow(e.RowHandle1)["ContractID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["ContractID"].ToString()))
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
            ReportCenter rc = new ReportCenter(gridControl2, "�ͻ�����ִ���������", "",true);
            rc.Preview();
        }

 
       
    }
}