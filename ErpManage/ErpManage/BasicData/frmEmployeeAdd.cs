using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Web.UI.WebControls;

namespace ErpManage
{
    /// <summary>
    /// ��������
    /// </summary>
    public partial class frmEmployeeAdd : frmBase
    {
        EmployeeManage EmployeeManage = new EmployeeManage();
        public frmEmployeeAdd()
        {
            InitializeComponent();

            txtGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //����
        public void EmployeeAdd()
        {
            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            //�󶨲���
            cboDataBind(cboDept);

            this.ShowDialog();
        
        }

        /// <summary>
        /// �������б��ͨ�÷���
        /// </summary>
        public void cboDataBind(ComboBox obj)
        {
            DeptManage dm = new DeptManage();
            DataTable dtl = dm.GetDeptData();
            ListItem item;
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                item = new ListItem();
                item.Text = dtl.Rows[i]["��������"].ToString();
                item.Value = dtl.Rows[i]["DeptGuid"].ToString();
                obj.Items.Add(item);
            }

        }

        //����
        public void EmployeeEdit(string EmployeeGuid)
        {
            FillData(EmployeeGuid);
        }


        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string EmployeeGuid)
        {
            //�󶨲���
            cboDataBind(cboDept);

            EmployeeManage Employeemanage = new EmployeeManage();
            DataTable dtl = Employeemanage.GetEmployeeData(EmployeeGuid);

            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["EmpGuid"].ToString();
                txtEmpId.Text = dtl.Rows[0]["EmpID"].ToString();
                txtEmpName.Text = dtl.Rows[0]["EmpName"].ToString();
                txtTelephone.Text = dtl.Rows[0]["Telephone"].ToString();
                txtCardID.Text = dtl.Rows[0]["CardID"].ToString();
                txtAddress.Text = dtl.Rows[0]["Address"].ToString();
                txtSex.Text = dtl.Rows[0]["Sex"].ToString();
                if (dtl.Rows[0]["IsEnable"].ToString() == "1")
                {
                    chkIsEnable.Checked = true;
                }
                else
                {
                    chkIsEnable.Checked = false;
                }


                for (int i = 0; i < cboDept.Items.Count; i++)
                {
                    ListItem item = cboDept.Items[i] as ListItem;
                    if (item.Value.Trim() ==dtl.Rows[0]["Dept"].ToString().Trim())
                    {
                        cboDept.SelectedIndex = i;
                        break;
                    }
                }

                
            }

            this.ShowDialog();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text.Trim() == "")
            {
                ShowMessage("������Ա�����!");
                return;
            }

            if (txtEmpName.Text.Trim() == "")
            {
                ShowMessage("������Ա������!");
                return;

            }

            if (cboDept.Text == "")
            {
                ShowMessage("��ѡ��Ա�����ڲ���!");
                return;
            }

            Employee Employee = new Employee();
            Employee.EmpGuid = txtGuid.Text;

            Employee.EmpID = txtEmpId.Text;
            Employee.EmpName = txtEmpName.Text;
            Employee.Telephone = txtTelephone.Text;
            Employee.CardID = txtCardID.Text;
            Employee.Address = txtAddress.Text;
            Employee.Dept = ((ListItem)cboDept.SelectedItem).Value;
            Employee.Sex = txtSex.Text;
            if (chkIsEnable.Checked == true)
            {
                Employee.IsEnable = 1;
            }
            else
            {
                Employee.IsEnable = 0;
            }
            
                EmployeeManage.Save(Employee);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "Ա������������༭", "������༭", SysParams.UserName + "������༭���û�[" + txtEmpId.Text + "," + txtEmpName.Text + "]");


            frmEmployee.frmemployee.LoadEmployee();

            this.Close();

        }


    }
}