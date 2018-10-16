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
    /// 在制品报表
    /// 日期：2010-6-18
    /// </summary>
    public partial class frmProcessReport : frmBase
    {
       
       
        public frmProcessReport()
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

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("请查询数据后再打印!");
                return;
            }

            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "在制品报表","",true);
            rc.Preview();
         
          
        }

        private void tsbQry_Click(object sender, EventArgs e)
        {

            StatReportManage StatReportManage = new StatReportManage();
            gridControl1.DataSource = StatReportManage.sp_ProcessProduct("");


            ////权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialMoney"].Visible = false;

                gridView1.Columns["Price2"].Visible = false;
                gridView1.Columns["MaterialMoney2"].Visible = false;
            }

        }

     
    }
}