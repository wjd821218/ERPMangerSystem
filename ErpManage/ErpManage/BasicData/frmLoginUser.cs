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
    /// �û�����
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

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "����������༭", "������༭", SysParams.UserName + "������༭�˲���Ա[" + LoginUser.USERID + "," + LoginUser.USERNAME + "]");


            LoadData();

            MessageBox.Show("����ɹ�!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //ɾ��
        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            int rowIndex = RowIndex(dtl);
            if (rowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("ȷ��Ҫɾ����ѡ��ļ�¼��", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string userid = gridVProGroup.GetDataRow(rowIndex)[0].ToString();

                    LoginUserManage.DeleteLoginUser(userid);

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "��½�û�ɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˵�½�û�,�û�ID:" + txtUserID.Text + ",�û���:" + txtUserName.Text);


                    LoadData();
                }

            }

        }


        //�õ�����ǰѡ����
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
            string strUserID = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["�û��˺�"].ToString();
            string strUserName = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["�û���������"].ToString();
            string strEmail = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["Email"].ToString();
            string strIsEnable = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row["�Ƿ����"].ToString();
          

            txtUserID.Text = strUserID;
            txtUserName.Text = strUserName;
            txtEmail.Text = strEmail;

            if (strIsEnable.Trim() == "����")
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