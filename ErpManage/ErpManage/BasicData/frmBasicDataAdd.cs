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
    /// ����ѡ��
    /// </summary>
    public partial class frmBasicDataAdd :frmBase
    {
        BasicDataManage BasicDataManage = new BasicDataManage();
        public frmBasicDataAdd()
        {
            InitializeComponent();
        }

       

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void loaddata()
        {
            
            int flag = 0;
            switch (listSelect.SelectedItem.ToString().Trim())
            {
                case "��λ":
                    flag = 1; 
                    break;
                case "����":
                    flag = 2;
                    break;
                case "���㷽ʽ":
                    flag = 3;
                    break;
                case "����":
                    flag = 4;
                    break;
                case "�ֿ�":
                    flag = 5;
                    break;
                case "���":
                    flag = 6;
                    break;
                case "�Ƽ۷���":
                    flag = 7;
                    break;
                case "�����Ŀ":
                    flag = 8;
                    break;
                case "ģ�����":
                    flag = 12;
                    break;
                case "��Ʒ���":
                    flag = 13;
                    break;
            }

            //�󶨲ֿ�
            DataTable dtl = BasicDataManage.GetBasicData(flag);
            this.gridSelect.DataSource = dtl;
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string str = "";
            switch (listSelect.SelectedItem.ToString().Trim())
            {
                case "��λ":
                    flag = 1;
                    str = "��λ";
                    break;
                case "����":
                    flag = 2;
                    str = "����";
                    break;
                case "���㷽ʽ":
                    flag = 3;
                    str = "���㷽ʽ";
                    break;
                case "����":
                    flag = 4;
                    str = "����";
                    break;
                case "�ֿ�":
                    flag = 5;
                    str = "�ֿ�";
                    break;
                case "���":
                    flag = 6;
                    str = "���";
                    break;
                case "�Ƽ۷���":
                    flag = 7;
                    str = "�Ƽ۷���";
                    break;
                case "�����Ŀ":
                    flag =8;
                    str = "�����Ŀ";
                    break;
                case "ģ�����":
                    flag = 12;
                    str = "ģ�����";
                    break;
                case "��Ʒ���":
                    flag =13;
                    str = "��Ʒ���";
                    break;

            }

            if (BasicDataManage.IsExistUnit(flag.ToString(), txtValue.Text.Trim()) == true)
            {
                this.ShowMessage(str+"ѡ��ֵ�Ѵ��ڣ������䣡");
                return;
            
            }



            ErpManageLibrary.BasicData basicData = new ErpManageLibrary.BasicData();
            basicData.UnitName = txtValue.Text;
            basicData.flag = flag;

            BasicDataManage.Save(basicData);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "������������", "����", SysParams.UserName + "������flag=" + flag.ToString() + ", UnitNameΪ" + txtValue.Text + "�ĸ�������");


            loaddata();

           
        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (gridVProGroup.RowCount > 0)
            {
               
                switch (listSelect.SelectedItem.ToString().Trim())
                {
                    case "��λ":
                        flag = 1;
                        break;
                    case "����":
                        flag = 2;
                        break;
                    case "���㷽ʽ":
                        flag = 3;
                        break;
                    case "����":
                        flag = 4;
                        break;
                    case "�ֿ�":
                        flag = 5;
                        break;
                    case "���":
                        flag = 6;
                        break;
                    case "�Ƽ۷���":
                        flag = 7;
                        break;
                    case "�����Ŀ":
                        flag = 8;
                        break;
                    case "ģ�����":
                        flag = 12;
                        break;
                    case "��Ʒ���":
                        flag = 13;
                        break;
                }
                DialogResult dr = MessageBox.Show("ȷ��Ҫɾ����ѡ��ļ�¼��", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string unitid = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row[0].ToString();


                    BasicDataManage.DeleteBasicData(unitid);

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "��������ɾ��", "ɾ��", SysParams.UserName + "ɾ����flag="+flag.ToString()+",GuidΪ" + unitid + "�ĸ�������");


                    loaddata();
                }

            }
        }

        private void listSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}