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
    /// 货物类别新增
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

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "物料类别新增", "新增", SysParams.UserName + "用户新增物料类别，类别编号:" + maxnode.ToString() + ",类别名称:" + txtTypeName.Text + ",父结点:" + txtFatherID.Text);


            frmMaterialClass.frmmaterialclass.Refresh();

            this.Close();
        }
    }
}