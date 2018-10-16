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
    /// 选择数据: 部门,人员,供应商，客户
    /// </summary>
    public partial class frmSelectOtherData : Form
    {
        BasicDataManage BasicDataManage = new BasicDataManage();
        int intFlag=0;
        public frmSelectOtherData()
        {
            InitializeComponent();
        }

        private void frmSelectOtherData_Load(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// 数据选择：1:员工 2:部门  3:供应商  4:客户
        /// </summary>
        /// <param name="flag"></param>
        public void ShowSelectData(int flag)
        {
            intFlag = flag;
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //员工
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl = EmployeeManage.GetEmployeeDataBySelect();
                    gridControl1.DataSource = dtl;
                    gridView1.Columns[1].Caption = "员工编号";
                    gridView1.Columns[2].Caption = "员工姓名";
                    gridView1.Columns[3].Caption = "部门";
                    this.Text = "员工选择";
                    break;
                case 2: //部门
                    DeptManage DeptManage = new DeptManage();
                    dtl = DeptManage.GetDeptDataBySelect();
                    gridControl1.DataSource = dtl;
                    gridView1.Columns[1].Caption = "部门名称";
                    this.Text = "部门选择";
                    break;
                case 3: //供应商
                    SupplierManage SupplierManage = new SupplierManage();
                    dtl = SupplierManage.GetSupplierDataBySelect();
                    gridControl1.DataSource = dtl;
                    gridView1.Columns[1].Caption = "供应商名称";
                    this.Text = "供应商选择";
                    break;
                case 4: //客户
                    ClientManage ClientManage = new ClientManage();
                    dtl=ClientManage.GetClientDataBySelect();
                    gridControl1.DataSource = dtl;
                    gridView1.Columns[1].Caption = "客户名称";
                    this.Text = "客户选择";
                    break;
            }

            gridView1.Columns[0].Visible = false;
            this.ShowDialog();
        }



     

      

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strguid = "";
            string strname = "";
            if (gridView1.RowCount > 0)
            {
                switch (intFlag)
                {
                    case 1: //员工
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["EmpGuid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["EmpName"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 2: //部门
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["DeptGuid"].ToString();
                       strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["DeptName"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 3: //供应商
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["Guid"].ToString();
                       strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["Name"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 4: //客户
                       strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["Guid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["Name"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                }


                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            SelectData();
        }

        private void SelectData()
        {
            string strguid = "";
            string strname = "";
            if (gridView1.RowCount > 0)
            {
                switch (intFlag)
                {
                    case 1: //员工
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["EmpGuid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["EmpName"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 2: //部门
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["DeptGuid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["DeptName"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 3: //供应商
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["Guid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["Name"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                    case 4: //客户
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["Guid"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["Name"].ToString();
                        this.Tag = strguid + "|" + strname;

                        break;
                }


                this.Close();
            }
        }

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void btnQry_Click(object sender, EventArgs e)
        {

            string strsql = "";

            switch (intFlag)
            {
                case 1: //员工
                    strsql = "where 1=1 and  IsEnable=0  ";
                    if (txtQryValue.Text.Trim() != "")
                    {
                        strsql = strsql + " and EmpName like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    }


                    break;
                case 2: //部门
                    strsql = "where 1=1 and  IsEnable=0  ";
                    if (txtQryValue.Text.Trim() != "")
                    {
                        strsql = strsql + " and DeptName like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    }

                    break;
                case 3: //供应商
                    strsql = "where 1=1 and  IsEnable=0  ";
                    if (txtQryValue.Text.Trim() != "")
                    {
                        strsql = strsql + " and Name like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    }

                    break;
                case 4: //客户
                    strsql = "where 1=1 and  IsEnable=0  ";
                    if (txtQryValue.Text.Trim() != "")
                    {
                        strsql = strsql + " and Name like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    }

                    break;
            }


            DataTable dtl = BasicDataManage.GetOtherSelectData(intFlag,strsql);
            this.gridControl1.DataSource = dtl;
            gridView1.Columns[0].Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            SelectData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Tag = "ClearTextBox";
            this.Close();
        }
    }
}