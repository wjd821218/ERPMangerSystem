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
    /// 工程更改单
    /// </summary>
    public partial class frmChangeBill : frmBase
    {
        public static frmChangeBill frmchangeBill;
        public frmChangeBill()
        {
            InitializeComponent();
            frmchangeBill = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChangeBillAdd frmChangeBillAdd = new frmChangeBillAdd();
            frmChangeBillAdd.Add();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangeBill_Load(object sender, EventArgs e)
        {

            LoadData();


            ////权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeBillDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }



        }

        public void LoadData()
        {
            ChangeBillManage ChangeBillManage = new ChangeBillManage();
            DataTable dtl = ChangeBillManage.GetChangeBill(GetWhereSQL());
            gridControl1.DataSource = dtl;



        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {


            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmChangeBillAdd frmChangeBillAdd = new frmChangeBillAdd();
                frmChangeBillAdd.Edit(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {



            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmChangeBillAdd frmChangeBillAdd = new frmChangeBillAdd();
                frmChangeBillAdd.Edit(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ChangeBillManage ChangeBillManage = new ChangeBillManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (ChangeBillManage.GetIsCheck(dr["ChangeBillGuID"].ToString()) == false)
                    {
                        ChangeBillManage.DeleteChangeBill(dr["ChangeBillGuID"].ToString());


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "工程更改单删除", "删除", SysParams.UserName + "用户删除了工程更改单,工程更改单唯一号:" + dr["ChangeBillGuID"].ToString());

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

            if (txtChangeBillID.Text.Trim() != "")
            {
                strsql = strsql + " and ChangeBillID='" + txtChangeBillID.Text.Trim().Replace("'", "''") + "'";
            }
            

            if (txtFileID.Text.Trim() != "")
            {
                strsql = strsql + " and FileID='" + txtFileID.Text.Trim().Replace("'", "''") + "'";
            }

            if (dtpChangeBillDateBegin.Text != "")
            {
                strsql = strsql + " and ChangeBillDate>='" + dtpChangeBillDateBegin.Text + " 00:00:00'";
            }

            if (dtpChangeBillDateEnd.Text.Trim() != "")
            {
                strsql = strsql + " and ChangeBillDate<='" + dtpChangeBillDateEnd.Text + " 23:59:59'";
            }

          

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }





            return strsql;

        }

        private void btnSelectFileID_Click(object sender, EventArgs e)
        {
            frmSelectFile frmSelectFile = new frmSelectFile();
            frmSelectFile.ShowDialog();



            if (frmSelectFile.Tag != null)
            {
                //取出选择的文件Guid
                List<string> lstGuid = frmSelectFile.Tag as List<string>;


                //选择的文件填充
                if (lstGuid.Count > 0)
                {
                    FileDataManage FileDataManage = new FileDataManage();
                    FileData filedata = new FileData();
                    filedata = FileDataManage.GetFileData(lstGuid[0]);

                    txtFileID.Text = filedata.FileID;
                    txtFileID.Tag = filedata.FileGuID;
                    txtFileName.Text = filedata.FileName;
                   // txtOldVersionID.Text = filedata.VersionID;

                }

            }
        }

       
    
    }
}