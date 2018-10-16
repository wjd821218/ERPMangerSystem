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
    /// 文件资料一览表
    /// </summary>
    public partial class frmFileDetailReport : frmBase
    {
        public frmFileDetailReport()
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {

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

        private void exit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        //查询
        private void btnQry_Click(object sender, EventArgs e)
        {
             FileDataManage FileDataManage = new FileDataManage();
            string strsql = " where 1=1 ";

            if (txtFileClass.Text.Trim() != "")
            {
                DataTable dtl = FileDataManage.GetSubFileType(txtFileClass.Tag.ToString());
                for (int i = 0; i < dtl.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        strsql = strsql + "and  (FileType='" + dtl.Rows[i]["InterID"].ToString() + "'";
                    }
                    else
                    {
                        strsql = strsql + " or  FileType='" + dtl.Rows[i]["InterID"].ToString() + "'";
                    }
                
                }

                if (dtl.Rows.Count > 0)
                {
                    strsql = strsql + " )";
                }
            
            }

            if (txtFileID.Text.Trim().Replace("'","''")!= "")
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

            if (dtBeginDate.Text.Trim() != "")
            {

                strsql = strsql + "  and PublishDate>='" + dtBeginDate.Text.Trim() + " 00:00:00'";
            }


            if (dtEndDate.Text.Trim() != "")
            {

                strsql = strsql + " and  PublishDate<='" + dtEndDate.Text.Trim() + " 23:59:59'";
            }

            //格式化文件类别子类为一级类别名称
            FileDataManage.GetSubFileType2("");

          
            this.gridControl1.DataSource = FileDataManage.GetFileDataBySQL_en(strsql);
        }

        private void button2_Click(object sender, EventArgs e)
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


        //受控类别选择
        private void btnSelectSpec_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(9);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtControlType.Text = ""; //名称
                    txtControlType.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtControlType.Text = arrValue[1]; //名称
                        txtControlType.Tag = arrValue[0];  //Guid
                    }
                }
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
            dtBeginDate.Text = "";
            dtEndDate.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}