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
    /// 部门新增
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

        //新增
        public void EmployeeAdd()
        {
            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            //绑定部门
            cboDataBind(cboDept);

            this.ShowDialog();
        
        }

        /// <summary>
        /// 绑定下拉列表框，通用方法
        /// </summary>
        public void cboDataBind(ComboBox obj)
        {
            DeptManage dm = new DeptManage();
            DataTable dtl = dm.GetDeptData();
            ListItem item;
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                item = new ListItem();
                item.Text = dtl.Rows[i]["部门名称"].ToString();
                item.Value = dtl.Rows[i]["DeptGuid"].ToString();
                obj.Items.Add(item);
            }

        }

        //新增
        public void EmployeeEdit(string EmployeeGuid)
        {
            FillData(EmployeeGuid);
        }


        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string EmployeeGuid)
        {
            //绑定部门
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
                ShowMessage("请输入员工编号!");
                return;
            }

            if (txtEmpName.Text.Trim() == "")
            {
                ShowMessage("请输入员工姓名!");
                return;

            }

            if (cboDept.Text == "")
            {
                ShowMessage("请选择员工所在部门!");
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

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "员工管理新增或编辑", "新增或编辑", SysParams.UserName + "新增或编辑了用户[" + txtEmpId.Text + "," + txtEmpName.Text + "]");


            frmEmployee.frmemployee.LoadEmployee();

            this.Close();

        }


    }
}