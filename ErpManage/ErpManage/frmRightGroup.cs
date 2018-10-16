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
    /// �����
    /// </summary>
    public partial class frmRightGroup :frmBase
    {
        public frmRightGroup()
        {
            InitializeComponent();
        }

        private void LoadGroup()
        {
            RightGroupManage RightGroupManage = new RightGroupManage();
            DataTable dtl = RightGroupManage.GetRightGroupInfo();

            gridGroup.DataSource = dtl;
        
        }

        private void frmRightGroup_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Trim() == "")
            {
                this.ShowMessage("����������!");
                return;
            }

            RightGroupManage RightGroupManage = new RightGroupManage();
            RightGroupManage.AddGroup(txtGroupName.Text.Trim());

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "Ȩ��������", "����", SysParams.UserName + "�û�����Ȩ���飬����:" + txtGroupName.Text.Trim());



            LoadGroup();
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}