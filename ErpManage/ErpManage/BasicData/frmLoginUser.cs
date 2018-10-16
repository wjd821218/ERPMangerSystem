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
    /// 用户管理
    /// </summary>
    public partial class frmLoginUser : Form
    {
        DataTable dtl = new DataTable();
        LoginUserManage LoginUserManage = new LoginUserManage();
        public frmLoginUser()
        {
            InitializeComponent();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
           
            LoginUser LoginUser = new LoginUser();
            LoginUser.USERID = txtUserID.Text;
            LoginUser.USERNAME = txtUserName.Text;
            LoginUser.EMAIL = txtEmail.Text;
            LoginUser.IsEnable = chkIsEnable.Checked == true ? 1 : 0;
            LoginUser.PASSWORD = LoginUserManage.EncryptDES(txtPassword.Text, "ABCD1234");

            LoginUserManage.Save(LoginUser);

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "操作新增或编辑", "新增或编辑", SysParams.UserName + "新增或编辑了操作员[" + LoginUser.USERID + "," + LoginUser.USERNAME + "]");


            LoadData();

            MessageBox.Show("保存成功!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            dtl = LoginUserManage.GetLoginUserInfo_CN();
            gridLoginPerson.DataSource = dtl;

        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //删除
        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            int rowIndex = RowIndex(dtl);
            if (rowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("确定要删除所选择的记录吗", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string userid = gridVProGroup.GetDataRow(rowIndex)[0].ToString();

                    LoginUserManage.DeleteLoginUser(userid);

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "登陆用户删除", "删除", SysParams.UserName + "用户删除了登陆用户,用户ID:" + txtUserID.Text + ",用户名:" + txtUserName.Text);


                    LoadData();
                }

            }

        }


        //得到网格当前选择行
        public int RowIndex(object dataSource)
        {
            int result = -1;
            if (dataSource != null)
            {
                result = this.BindingContext[dataSource].Position;
            }
            return result;
        }

        private void gridLoginPerson_Click(object sender, EventArgs e)
        {
            string strUserID = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["用户账号"].ToString();
            string strUserName = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["用户中文名称"].ToString();
            string strEmail = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["Email"].ToString();
            string strIsEnable = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["是否禁用"].ToString();
          

            txtUserID.Text = strUserID;
            txtUserName.Text = strUserName;
            txtEmail.Text = strEmail;

            if (strIsEnable.Trim() == "禁用")
            {
                chkIsEnable.Checked = true;
            }
            else
            {
                chkIsEnable.Checked = false;
            }


        }
    }
}