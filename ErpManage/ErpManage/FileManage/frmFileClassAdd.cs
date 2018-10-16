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
    /// 文件类别新增
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

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "文件类别新增", "新增", SysParams.UserName + "用户新增文件类别，类别编号:" + strGuid + ",类别名称:" + txtTypeName.Text + ",父结点:" + txtFatherID.Text);


            frmFileClass.frmfileclass.Refresh();
           // frmMaterialClass.frmmaterialclass.Refresh();

            this.Close();
        }
    }
}