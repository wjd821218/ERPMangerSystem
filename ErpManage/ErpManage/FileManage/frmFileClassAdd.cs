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
    /// �ļ��������
    /// </summary>
    public partial class frmFileClassAdd : Form
    {
        public frmFileClassAdd()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileClassManage ptm = new FileClassManage();

            //long maxnode = long.Parse(ptm.GetMaxNodeData(txtFatherID.Text)) + 1;
          
         
            string strGuid=Guid.NewGuid().ToString();

            ptm.InsertTypeNode(strGuid, txtTypeName.Text, txtFatherID.Text);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "�ļ��������", "����", SysParams.UserName + "�û������ļ���������:" + strGuid + ",�������:" + txtTypeName.Text + ",�����:" + txtFatherID.Text);


            frmFileClass.frmfileclass.Refresh();
           // frmMaterialClass.frmmaterialclass.Refresh();

            this.Close();
        }
    }
}