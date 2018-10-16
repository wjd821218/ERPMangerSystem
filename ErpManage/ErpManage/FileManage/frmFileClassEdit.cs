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
    /// �ļ����༭
    /// </summary>
    public partial class frmFileClassEdit : Form
    {
        public frmFileClassEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowEdit(string MaterialGuid,string MaterialName)
        {
            txtTypeName.Tag=MaterialGuid;
            txtTypeName.Text = MaterialName;

            this.ShowDialog();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            FileClassManage ptm = new FileClassManage();
            ptm.UpdateTypeNode(txtTypeName.Tag.ToString(), txtTypeName.Text.Replace("'","''").Trim());

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "�ļ����༭", "�༭", SysParams.UserName + "�û��༭�ļ���������:" + txtTypeName.Tag.ToString() + ",�������:" + txtTypeName.Text.Replace("'", "''").Trim());

            
            frmMaterialClass.frmmaterialclass.Refresh();
            this.Close();
        }
    }
}