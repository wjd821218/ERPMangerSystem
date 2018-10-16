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
    /// �޸����ϱ�ţ��˹��������������ʹ�ã���������ϱ���Ѿ����ڣ����ܸ��³ɹ�
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
                ShowMessage("�����ϱ�Ų����ڣ������²�ѯ!");
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
                ShowMessage("������ԭ���ϱ��!");
                return;
            }
            if (txtNewMaterialID.Text.Trim() == "")
            {
                ShowMessage("�����������ϱ��!");
                return;
            }


            MaterialManage MaterialManage = new MaterialManage();
            Material Material = new Material();
            Material = MaterialManage.GetMaterialByID(txtOldMaterialID.Text.Trim());

            if (Material.MaterialID == null)
            {
                ShowMessage("ԭ���ϱ�Ų����ڣ��޷�����!");
                return;
            }
            else
            {
                //�ֲ����Ƿ�Ŀ�����ϱ���Ѿ�����.�����������ʾ���ܸ��£�ֻ�ܸĳ�Ŀ�����ϲ����ڵ����ϱ��
                Material = new Material();
                Material = MaterialManage.GetMaterialByID(txtNewMaterialID.Text.Trim());
                if (Material.MaterialID != null)
                {
                    ShowMessage("�����ϱ���Ѿ����ڣ��޷�����!");
                    return;
                }
                else
                { 
                     //ִ�����ϱ�ŵı��
                    MaterialManage.ChangeMaterialID(txtOldMaterialID.Text.Trim(), txtNewMaterialID.Text.Trim());


                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "�޸����ϱ��", "�޸����ϱ��", SysParams.UserName + "�û��޸������ϱ��,ԭ���ϱ��:" +txtOldMaterialID.Text.Trim() + ",�����ϱ��:" + txtNewMaterialID.Text.Trim());



                    ShowMessage("�����ϱ���Ѿ����³ɹ�!");
                
                }


            }

        }
    }
}