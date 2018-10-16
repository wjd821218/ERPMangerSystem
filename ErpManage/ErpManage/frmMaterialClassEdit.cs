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
    /// �����������
    /// </summary>
    public partial class frmMaterialClassEdit : Form
    {
        public frmMaterialClassEdit()
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
            StorageClassManage ptm = new StorageClassManage();
            ptm.UpdateTypeNode(txtTypeName.Tag.ToString(), txtTypeName.Text.Replace("'","''").Trim());

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "�������༭", "�༭", SysParams.UserName + "�û��༭������������:" + txtTypeName.Tag.ToString() + ",�������:" + txtTypeName.Text.Replace("'", "''").Trim());

            
            frmMaterialClass.frmmaterialclass.Refresh();
            this.Close();
        }
    }
}