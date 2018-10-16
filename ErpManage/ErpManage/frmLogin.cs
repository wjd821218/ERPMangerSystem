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
    /// ϵͳ��½
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
                MessageBox.Show("��ѡ���û���!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("�������û�����!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lum.IsEnable(txtUserID.Text.Trim()) == false)
            {

                if (lum.CheckUserPassword(txtUserID.Text.Trim(), txtPassword.Text))
                {
                    SysParams.UserID = txtUserID.Text.Trim();
                    SysParams.UserName = lum.GetLoginUserName(txtUserID.Text.Trim());

                    //�����ε�½���û�������Ŀ���ƴ�����
                    WriteLoginUnitXML();
                    //this.DialogResult = DialogResult.OK;
                    this.Visible = false;

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "ϵͳ��½", "", SysParams.UserName + "�û�����ϵͳ");


                    frmErpMain frmErpMain = new frmErpMain();
                    frmErpMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("��������û��˺Ż��û������д���,������!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            else
            {
                MessageBox.Show("���û��ѽ��ã��޷���½ϵͳ!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
        /// �������б��ͨ�÷���
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
            //��ʼ�����ݿ������ַ���
            CommonDataConfig.ConnectionDefaultStr = System.Configuration.ConfigurationSettings.AppSettings["ConnStr"].ToString();
         

            //���ϴε�½���û�����Ŀ���Ƽ��س���
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
        /// ȡ����½�û�������Ŀ����
        /// </summary>
        private void GetLoginUnitXML()
        {
            string fileName = Application.StartupPath + @"\HistoryLogin.xml";
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(fileName);
            XmlNode rootNode = myXmlDocument.DocumentElement;
            //�û��ϴε�½�˺�
            string userid = rootNode.ChildNodes[0].ChildNodes[0].Attributes["value"].Value;

            txtUserID.Text = userid;
        }

        /// <summary>
        /// ����½�û�����Ŀ���ƴ���xml��
        /// </summary>
        private void WriteLoginUnitXML()
        {

            string fileName = Application.StartupPath + @"\HistoryLogin.xml";

            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(fileName);
            XmlNode rootNode = myXmlDocument.DocumentElement;
            //�û��ϴε�½�û���
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