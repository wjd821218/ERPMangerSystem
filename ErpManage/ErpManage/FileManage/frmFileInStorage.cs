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
    /// 文件入库 
    /// </summary>
    public partial class frmFileInStorage : frmBase
    {
        public static frmFileInStorage frmfileinstorage;
        public frmFileInStorage()
        {
            InitializeComponent();
            frmfileinstorage = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFileInStorageAdd frmFileInStorageAdd = new frmFileInStorageAdd();
            frmFileInStorageAdd.AddBill();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFileInStorage_Load(object sender, EventArgs e)
        {

            LoadData();


            ////权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }



        }

        public void LoadData()
        {
            FileInStorageManage FileInStorageManage = new FileInStorageManage();
            DataTable dtl = FileInStorageManage.GetFileInStorageBySQL(GetWhereSQL());
            gridControl1.DataSource = dtl;

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].MinWidth = 100;

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {


            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmFileInStorageAdd frmFileInStorageAdd = new frmFileInStorageAdd();
                frmFileInStorageAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {



            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmFileInStorageAdd frmFileInStorageAdd = new frmFileInStorageAdd();
                frmFileInStorageAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    FileInStorageManage FileInStorageManage = new FileInStorageManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (FileInStorageManage.GetIsCheck(dr["FileInStorageGuID"].ToString()) == false)
                    {
                        FileInStorageManage.DeleteBill(dr["FileInStorageGuID"].ToString());


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "文件入库单删除", "删除", SysParams.UserName + "用户删除了文件入库单,文件入库单唯一号:" + dr["FileInStorageGuID"].ToString());

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



            if (txtFileInStorageID.Text.Trim() != "")
            {
                strsql = strsql + " and FileInStorageID='" + txtFileInStorageID.Text.Trim().Replace("'", "''") + "'";
            }

            if (deFileInStorageBeginDate.Text != "")
            {
                strsql = strsql + " and FileInStorageDate>='" + deFileInStorageBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (deFileInStorageEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and FileInStorageDate<='" + deFileInStorageEndDate.Text.Trim() + " 23:59:59'";
            }


            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }

            if (chkCheck2.Checked == true)
            {
                strsql = strsql + " and CheckGuid2<>'' ";
            }

         

            return strsql;

        }

    }
}