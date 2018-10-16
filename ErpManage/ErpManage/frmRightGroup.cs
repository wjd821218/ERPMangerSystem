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
    /// 组管理
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
                this.ShowMessage("请输入组名!");
                return;
            }

            RightGroupManage RightGroupManage = new RightGroupManage();
            RightGroupManage.AddGroup(txtGroupName.Text.Trim());

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "权限组新增", "新增", SysParams.UserName + "用户新增权限组，组名:" + txtGroupName.Text.Trim());



            LoadGroup();
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}