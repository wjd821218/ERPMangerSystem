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
    public partial class frmChangePassword : Form
    {
        public string USERID;
        public string USERName;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Trim()=="")
            {
                MessageBox.Show("������ԭ����!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text.Trim() != txtNewPassword2.Text.Trim())
            {
                MessageBox.Show("������������ͬ��������!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginUserManage lum = new LoginUserManage();
            if (!lum.CheckUserPassword(USERID, txtOldPassword.Text))
            {
                MessageBox.Show("�����޸�ʧ��,�����û���������������ȷ��!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (lum.ChangePassword(USERID, txtOldPassword.Text, txtNewPassword.Text))
            {
                MessageBox.Show("�����޸ĳɹ�!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("�����޸�ʧ��,����ԭ�����Ƿ�������ȷ!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = USERName;
           
        }
    }
}