using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Web.UI.WebControls;
using Daniel.Liu.DAO;
using System.Xml;

namespace ErpManage
{
    /// <summary>
    /// 系统登陆
    /// </summary>
    public partial class frmLogin : Form
    {
        LoginUserManage lum = new LoginUserManage();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void login()
        {
            if (txtUserID.Text.Trim() == "")
            {
                MessageBox.Show("请选择用户名!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户密码!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lum.IsEnable(txtUserID.Text.Trim()) == false)
            {

                if (lum.CheckUserPassword(txtUserID.Text.Trim(), txtPassword.Text))
                {
                    SysParams.UserID = txtUserID.Text.Trim();
                    SysParams.UserName = lum.GetLoginUserName(txtUserID.Text.Trim());

                    //将本次登陆的用户名与项目名称存起来
                    WriteLoginUnitXML();
                    //this.DialogResult = DialogResult.OK;
                    this.Visible = false;

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "系统登陆", "", SysParams.UserName + "用户进入系统");


                    frmErpMain frmErpMain = new frmErpMain();
                    frmErpMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("你输入的用户账号或用户密码有错误,请重输!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            else
            {
                MessageBox.Show("此用户已禁用，无法登陆系统!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                login();
            }
        }


        /// <summary>
        /// 绑定下拉列表框，通用方法
        /// </summary>
        //public void cboDataBind(ComboBox obj)
        //{
        //    LoginUserManage lum = new LoginUserManage();
        //    DataTable dtl = lum.GetLoginUserInfo();
        //    ListItem item;
        //    for (int i = 0; i < dtl.Rows.Count; i++)
        //    {
        //        item = new ListItem();
        //        item.Text = dtl.Rows[i]["USERNAME"].ToString();
        //        item.Value = dtl.Rows[i]["USERID"].ToString();
        //        obj.Items.Add(item);
        //    }

        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //初始化数据库连接字符串
            CommonDataConfig.ConnectionDefaultStr = System.Configuration.ConfigurationSettings.AppSettings["ConnStr"].ToString();
         

            //将上次登陆的用户与项目名称加载出来
            GetLoginUnitXML();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            login();
        }

        /// <summary>
        /// 取出登陆用户名与项目名称
        /// </summary>
        private void GetLoginUnitXML()
        {
            string fileName = Application.StartupPath + @"\HistoryLogin.xml";
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(fileName);
            XmlNode rootNode = myXmlDocument.DocumentElement;
            //用户上次登陆账号
            string userid = rootNode.ChildNodes[0].ChildNodes[0].Attributes["value"].Value;

            txtUserID.Text = userid;
        }

        /// <summary>
        /// 将登陆用户与项目名称存入xml中
        /// </summary>
        private void WriteLoginUnitXML()
        {

            string fileName = Application.StartupPath + @"\HistoryLogin.xml";

            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(fileName);
            XmlNode rootNode = myXmlDocument.DocumentElement;
            //用户上次登陆用户名
            rootNode.ChildNodes[0].ChildNodes[0].Attributes["value"].Value = txtUserID.Text;
        
            myXmlDocument.Save(Application.StartupPath + @"\HistoryLogin.xml");
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frmcp = new frmChangePassword();
            frmcp.USERID = txtUserID.Text;
            frmcp.USERName = lum.GetLoginUserName(txtUserID.Text.Trim());
            frmcp.ShowDialog();
        }


    }
}