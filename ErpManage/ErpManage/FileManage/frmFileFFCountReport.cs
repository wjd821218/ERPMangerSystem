using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage
{
    /// <summary>
    /// 文件资料发放统计报表
    /// </summary>
    public partial class frmFileFFCountReport : frmBase
    {
        public frmFileFFCountReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        #region 控件汉化
        /// <summary>
        /// 将控件汉化
        /// </summary>
        public void IniControl_CN()
        {
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();


        }
        #endregion

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView2.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

      

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    

        /// <summary>
        /// 选择文件类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectFileClass frmSelectFileClass = new frmSelectFileClass();
            frmSelectFileClass.InValue = 0;
            frmSelectFileClass.ShowDialog();

            if (frmSelectFileClass.Tag != null)
            {
                SelectFileClass SelectFileClass = frmSelectFileClass.Tag as SelectFileClass;

                txtFileClass.Text = SelectFileClass.FileClassName;
                txtFileClass.Tag = SelectFileClass.FileClassID;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileID.Text = "";
            txtFileName.Text = "";
            txtProductName.Text = "";
            txtFileClass.Text = "";
            txtControlType.Text = "";
            txtControlType.Tag = "";
            txtFileClass.Tag = "";

            txtFileApplyPerson.Text = "";
            txtFileApplyPerson.Tag = "";
           
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            string strsql = " where 1=1 ";

            if (txtFileClass.Text.Trim() != "")
            {
                strsql = strsql + " and FileType='" + txtFileClass.Tag.ToString() + "'";

            }

            if (txtFileID.Text.Trim().Replace("'", "''") != "")
            {
                strsql = strsql + " and FileID like '" + txtFileID.Text.Trim().Replace("'", "''") + "%'";

            }


            if (txtFileName.Text.Trim().Replace("'", "''") != "")
            {
                strsql = strsql + " and FileName like '" + txtFileName.Text.Trim().Replace("'", "''") + "%'";

            }


            if (txtControlType.Text.Trim().Replace("'", "''") != "")
            {
                strsql = strsql + " and ControlType = '" + txtControlType.Tag.ToString() + "'";

            }


            if (txtProductName.Text.Trim().Replace("'", "''") != "")
            {
                strsql = strsql + " and ProductName like '" + txtProductName.Text.Trim().Replace("'", "''") + "%'";

            }


            if (txtFileApplyPerson.Text.Trim() != "")
            {
                strsql = strsql + " and PersonGuID='" + txtFileApplyPerson.Tag.ToString()+ "'";
            
            }


            if (txtDownDept.Text.Trim() != "")
            {
                strsql = strsql + " and FileApplyDept='" + txtDownDept.Tag.ToString() + "'";

            }




            FileDataManage FileDataManage = new FileDataManage();
            this.gridControl2.DataSource = FileDataManage.GetFileFFCountBySQL(strsql);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFileApplyPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtFileApplyPerson.Text = ""; //名称
                    txtFileApplyPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtFileApplyPerson.Text = arrValue[1]; //名称
                        txtFileApplyPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }

            
        }

        private void gridView2_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (this.gridView2.GetDataRow(e.RowHandle1)["FileID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["FileID"].ToString()
           ||
           this.gridView2.GetDataRow(e.RowHandle1)["FileName"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["FileName"].ToString()
              ||
           this.gridView2.GetDataRow(e.RowHandle1)["FileTypeName"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["FileTypeName"].ToString()
                  ||
           this.gridView2.GetDataRow(e.RowHandle1)["VersionID"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["VersionID"].ToString()
                 ||
           this.gridView2.GetDataRow(e.RowHandle1)["ProductName"].ToString() != this.gridView2.GetDataRow(e.RowHandle2)["ProductName"].ToString()

               )
                e.Handled = true;
        }

        private void btnSelectDownDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDownDept.Text = ""; //名称
                    txtDownDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDownDept.Text = arrValue[1]; //名称
                        txtDownDept.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        
    }
}