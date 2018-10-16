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
    public partial class frmMaterialClassAdd : Form
    {
        public frmMaterialClassAdd()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StorageClassManage ptm = new StorageClassManage();

            long maxnode = long.Parse(ptm.GetMaxNodeData(txtFatherID.Text)) + 1;

            ptm.InsertTypeNode(maxnode.ToString(), txtTypeName.Text, txtFatherID.Text);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "�����������", "����", SysParams.UserName + "�û�����������������:" + maxnode.ToString() + ",�������:" + txtTypeName.Text + ",�����:" + txtFatherID.Text);


            frmMaterialClass.frmmaterialclass.Refresh();

            this.Close();
        }
    }
}