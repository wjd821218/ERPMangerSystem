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

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "物料类别编辑", "编辑", SysParams.UserName + "用户编辑物料类别，类别编号:" + txtTypeName.Tag.ToString() + ",类别名称:" + txtTypeName.Text.Replace("'", "''").Trim());

            
            frmMaterialClass.frmmaterialclass.Refresh();
            this.Close();
        }
    }
}