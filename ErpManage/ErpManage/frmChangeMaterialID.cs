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
    /// 修改物料编号：此功能在特殊情况下使用，如果新物料编号已经存在，则不能更新成功
    /// </summary>
    public partial class frmChangeMaterialID : frmBase
    {
        public frmChangeMaterialID()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            MaterialManage MaterialManage = new MaterialManage();
            Material Material = new Material();
            Material = MaterialManage.GetMaterialByID(txtMaterialID.Text.Trim());

            if (Material == null)
            {
                ShowMessage("此物料编号不存在，请重新查询!");
                return;
            }
            else
            {
                txtMaterialName.Text = Material.MaterialName;
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldMaterialID.Text.Trim() == "")
            {
                ShowMessage("请输入原物料编号!");
                return;
            }
            if (txtNewMaterialID.Text.Trim() == "")
            {
                ShowMessage("请输入新物料编号!");
                return;
            }


            MaterialManage MaterialManage = new MaterialManage();
            Material Material = new Material();
            Material = MaterialManage.GetMaterialByID(txtOldMaterialID.Text.Trim());

            if (Material.MaterialID == null)
            {
                ShowMessage("原物料编号不存在，无法更新!");
                return;
            }
            else
            {
                //现查找是否目标物料编号已经存在.如果存在则提示不能更新，只能改成目标物料不存在的物料编号
                Material = new Material();
                Material = MaterialManage.GetMaterialByID(txtNewMaterialID.Text.Trim());
                if (Material.MaterialID != null)
                {
                    ShowMessage("新物料编号已经存在，无法更新!");
                    return;
                }
                else
                { 
                     //执行物料编号的变更
                    MaterialManage.ChangeMaterialID(txtOldMaterialID.Text.Trim(), txtNewMaterialID.Text.Trim());


                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "修改物料编号", "修改物料编号", SysParams.UserName + "用户修改了物料编号,原物料编号:" +txtOldMaterialID.Text.Trim() + ",新物料编号:" + txtNewMaterialID.Text.Trim());



                    ShowMessage("新物料编号已经更新成功!");
                
                }


            }

        }
    }
}