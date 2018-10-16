using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ErpManageLibrary;


namespace ErpManage
{
    /// <summary>
    /// 系统日志
    /// </summary>
    public partial class frmSystemLog : frmBase
    {
 
        public frmSystemLog()
        {
            InitializeComponent();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
           
          
        }

     
        private void LoadData()
        {
            SystemLogManage SystemLogManage = new SystemLogManage();
            DataTable dtl = SystemLogManage.GetSystemLogInfo(GetSQL());

            gridControl1.DataSource = dtl;
            
               

        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //删除
        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            txtOperateModule.Focus();
            gridView1.UpdateCurrentRow();

            DialogResult dr = MessageBox.Show("确定要删除所选择的记录吗", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                List<string> lst = new List<string>();

                if (gridView1.RowCount > 0)
                {
                    //int intRow = gridView1.GetSelectedRows()[0];
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                        {
                            lst.Add(gridView1.GetRowCellValue(i, gridGuid).ToString());
                        }
                    }
                }

                SystemLogManage SystemLogManage = new SystemLogManage();
                SystemLogManage.DeleteSyslog(lst);

                LoadData();
            }



        }



        private string GetSQL()
        {
            string strsql = " where 1=1";

            if (txtUserID.Text.Trim() != "")
            {
                strsql = strsql + " and OperateUser='" + txtUserID.Text.Replace("'", "''").Trim() + "'";
            }


            if (txtOperateModule.Text.Trim() != "")
            {
                strsql = strsql + " and OperateModule like '%" + txtOperateModule.Text.Replace("'", "''").Trim() + "%'";
            }


            if (BeginDate.Text != "")
            {
                strsql = strsql + " and OperateDate >='" + BeginDate.Text + " 00:00:00'";
            }
            if (endDate.Text != "")
            {
                strsql = strsql + " and OperateDate <='" + endDate.Text + " 23:59:59'";
            }

            return strsql;

        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnSelectALL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridCheckBox, "True");
            }
        }

        private void btnNoSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridCheckBox, "False");
            }
        }

        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "True";//默认为选中 
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto case "True";
                case "No":
                    goto case "False";
                case "1":
                    goto case "True";
                case "0":
                    goto case "False";
                default:
                    e.CheckState = CheckState.Checked;
                    break;
            }
            e.Handled = true;

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
    }
}