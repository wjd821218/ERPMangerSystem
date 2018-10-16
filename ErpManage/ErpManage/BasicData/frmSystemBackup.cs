using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.BasicData
{
    public partial class frmSystemBackup : frmBase
    {
        public frmSystemBackup()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1=new FolderBrowserDialog();

           //选择上报文件目录
			if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
                txtPath.Text = FolderBrowserDialog1.SelectedPath;
            }
        }

       

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Trim() != "")
                {
                    string strPath = txtPath.Text + @"\ERPManage";
                    string strFileName = DateTime.Now.ToString("yyyy-MM-dd");

                    SystemManage SystemManage = new SystemManage();
                    SystemManage.sp_BackupDatabase(strPath, strFileName);

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "系统数据库备份", "备份", SysParams.UserName + "用户备份了系统数据库,备份路径:" + strPath + strFileName + ".bak");


                    this.ShowMessage("数据库备份成功,已备份到" + strPath + strFileName + ".bak");
                }
                else
                {
                    this.ShowMessage("请选择备份路径!");
                }
            }catch (Exception err)
            {
                this.ShowErrorMessage("数据库备份出现错误，请检查备份路径是否正确!");
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}