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

           //ѡ���ϱ��ļ�Ŀ¼
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

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "ϵͳ���ݿⱸ��", "����", SysParams.UserName + "�û�������ϵͳ���ݿ�,����·��:" + strPath + strFileName + ".bak");


                    this.ShowMessage("���ݿⱸ�ݳɹ�,�ѱ��ݵ�" + strPath + strFileName + ".bak");
                }
                else
                {
                    this.ShowMessage("��ѡ�񱸷�·��!");
                }
            }catch (Exception err)
            {
                this.ShowErrorMessage("���ݿⱸ�ݳ��ִ������鱸��·���Ƿ���ȷ!");
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}