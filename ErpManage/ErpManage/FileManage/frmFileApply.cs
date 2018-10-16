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
    /// 文件申请新增
    /// </summary>
    public partial class frmFileApply :frmBase
    {
        public static frmFileApply frmfileapply;
        public frmFileApply()
        {
            InitializeComponent();
            frmfileapply = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFileApplyAdd frmFileApplyAdd = new frmFileApplyAdd();
            frmFileApplyAdd.AddBill();
        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFileApply_Load(object sender, EventArgs e)
        {

            LoadData();


            ////权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileApplyDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }



        }

        public void LoadData()
        {
            FileApplyManage FileApplyManage = new FileApplyManage();
            DataTable dtl = FileApplyManage.GetFileApplyBySQL(GetWhereSQL());
            gridControl1.DataSource = dtl;

        

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {


            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmFileApplyAdd frmFileApplyAdd = new frmFileApplyAdd();
                frmFileApplyAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {



            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmFileApplyAdd frmFileApplyAdd = new frmFileApplyAdd();
                frmFileApplyAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    FileApplyManage FileApplyManage = new FileApplyManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (FileApplyManage.GetIsCheck(dr["FileApplyGuID"].ToString()) == false)
                    {
                        FileApplyManage.DeleteBill(dr["FileApplyGuID"].ToString());


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "文件申请单删除", "删除", SysParams.UserName + "用户删除了文件申请单,文件申请单唯一号:" + dr["FileApplyGuID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowMessage("此单据已经审核,不能删除!");
                    }
                }

            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = " where 1=1 ";



            if (txtFileApplyID.Text.Trim() != "")
            {
                strsql = strsql + " and FileApplyID='" + txtFileApplyID.Text.Trim().Replace("'", "''") + "'";
            }

            if (deFileApplyBeginDate.Text != "")
            {
                strsql = strsql + " and FileApplyDate>='" + deFileApplyBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (deFileApplyEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and FileApplyDate<='" + deFileApplyEndDate.Text.Trim() + " 23:59:59'";
            }

            if (cboFileApplyType.Text.Trim() != "")
            {
                if (cboFileApplyType.Text.Trim() == "员工")
                {
                    strsql = strsql + " and FileApplyType='1'";
                }
                else  if (cboFileApplyType.Text.Trim() == "部门")
                {
                    strsql = strsql + " and FileApplyType='2'";
                }
            
            }

            if (txtFileApplyDept.Text.Trim() != "")
            {
                strsql = strsql + " and FileApplyDept='" + txtFileApplyDept.Tag.ToString() + "'";
            }

            if (txtFileApplyPerson.Text.Trim() != "")
            {
                strsql = strsql + " and FileApplyPerson='" + txtFileApplyPerson.Tag.ToString() + "'";
            }


            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

         



            return strsql;

        }

        private void btnSelectFileApplyPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtFileApplyPerson.Text = ""; //名称
                    txtFileApplyPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtFileApplyPerson.Text = arrValue[1]; //名称
                        txtFileApplyPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectFileApplyDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtFileApplyDept.Text = ""; //名称
                    txtFileApplyDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtFileApplyDept.Text = arrValue[1]; //名称
                        txtFileApplyDept.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}