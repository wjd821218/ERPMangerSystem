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
    /// ѡ������: ����,��Ա,��Ӧ�̣��ͻ�
    /// </summary>
    public partial class frmSelectOtherData3 : Form
    {
        BasicDataManage BasicDataManage = new BasicDataManage();
        int intFlag=0;
        public frmSelectOtherData3()
        {
            InitializeComponent();
        }

        private void frmSelectOtherData_Load(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// ����ѡ��1:Ա�� 2:����  3:��Ӧ��  4:�ͻ�
        /// </summary>
        /// <param name="flag"></param>
        public void ShowSelectData(int flag)
        {
            intFlag = flag;
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //Ա��
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl = EmployeeManage.GetEmployeeDataBySelect2();
                    gridControl1.DataSource = dtl;
                    gridView1.Columns[1].Caption = "Ա������";
                    this.Text = "Ա��ѡ��";
                    break;
             
            }
            this.ShowDialog();
        }



     

      

        //ѡ��
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectEmployee SelectEmployee = new SelectEmployee();
            List<SelectEmployee> lst = new List<SelectEmployee>();

            if (gridView1.RowCount > 0)
            {
                switch (intFlag)
                {
                   
                    case 1: //Ա��
                      
                        if (gridView1.RowCount > 0)
                        {
                            for (int i = 0; i < gridView1.RowCount; i++)
                            {


                                if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
                                {
                                    SelectEmployee = new SelectEmployee();
                                    SelectEmployee.EmpGuid = gridView1.GetRowCellValue(i, gridEmpGuid).ToString(); 
                                    SelectEmployee.EmpName = gridView1.GetRowCellValue(i, gridEmpName).ToString(); 

                                    lst.Add(SelectEmployee);
                                   // strUnitName = strUnitName + " " + gridView1.GetRowCellValue(i, gridEmpName).ToString(); 

                                }
                            }

                            this.Tag = lst;
                        }

                        break;
                   
                }


                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //SelectData();
        }

        private void SelectData()
        {
          
            //if (gridView1.RowCount > 0)
            //{
            //    switch (intFlag)
            //    {
            //        case 2: //Ա��

            //            string strUnitName = "";
            //            if (gridView1.RowCount > 0)
            //            {
            //                for (int i = 0; i < gridView1.RowCount; i++)
            //                {
            //                    if (gridView1.GetRowCellValue(i, gridCheckBox).ToString() == "True")
            //                    {
            //                        strUnitName = strUnitName+" " + gridView1.GetRowCellValue(i, gridEmpName).ToString(); 

            //                    }
            //                }

            //                this.Tag = strUnitName.Trim();
            //            }

            //            break;

            //    }


            //    this.Close();
            //}
        }

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void btnQry_Click(object sender, EventArgs e)
        {

            string strsql = "";

            switch (intFlag)
            {
                
                case 2: //Ա��
                    strsql = "where 1=1 and  IsEnable=0  ";
                    if (txtQryValue.Text.Trim() != "")
                    {
                        strsql = strsql + " and EmpName like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

                    }

                    break;
               
            }


            DataTable dtl = BasicDataManage.GetOtherSelectData2(intFlag,strsql);
            this.gridControl1.DataSource = dtl;
           
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

        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "True";//Ĭ��Ϊѡ�� 
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto case "True";
                case "No":
                    goto case "False";
                case "1":
                    goto case "True";
                case "0":
                    goto case "False";
                default:
                    e.CheckState = CheckState.Checked;
                    break;
            }
            e.Handled = true; 
        }
    }



}