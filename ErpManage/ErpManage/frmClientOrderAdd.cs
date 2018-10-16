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
    public partial class frmClientOrderAdd : Form
    {
        public frmClientOrderAdd()
        {
            InitializeComponent();
        }

        private void btnSelectEmp_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                if (arrValue.Length > 0)
                {
                   txtEmp.Text = arrValue[1]; //名称
                   txtEmp.Tag = arrValue[0];  //Guid
                }
            }
        }

        private void btnSelectDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                if (arrValue.Length > 0)
                {
                    txtDept.Text = arrValue[1]; //名称
                    txtDept.Tag = arrValue[0];  //Guid
                }
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
             frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
             frmSelectOtherData.ShowSelectData(4);
             if (frmSelectOtherData.Tag != null)
             {
                 string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                 if (arrValue.Length > 0)
                 {
                     txtClient.Text = arrValue[1]; //名称
                     txtClient.Tag = arrValue[0];  //Guid
                 }
             }
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                if (arrValue.Length > 0)
                {
                    txtSupplier.Text = arrValue[1]; //名称
                    txtSupplier.Tag = arrValue[0];  //Guid
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RightGroupManage RightGroupManage=new RightGroupManage();
            //保存
            bool i = false;
            i = RightGroupManage.IsOperateRightByUserID("admin", "ClientOrder", "Save");

            //删除
            i = RightGroupManage.IsOperateRightByUserID("admin", "ClientOrder", "Delete");

            //查询
            i = RightGroupManage.IsOperateRightByUserID("admin", "ClientOrder", "Qry");
        }
    }
}