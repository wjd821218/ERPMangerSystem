using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    /// 超领单
    /// </summary>
    public partial class frmExcessOrder : frmBase
    {
        ExcessOrderManage ExcessOrderManage = new ExcessOrderManage();
        public static frmExcessOrder frmexcessorder;
        public frmExcessOrder()
        {
           
            InitializeComponent();

            frmexcessorder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmExcessOrderAdd frmExcessOrderAdd = new frmExcessOrderAdd();
            frmExcessOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = ExcessOrderManage.GetExcessOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ExcessOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmExcessOrderAdd frmExcessOrderAdd = new frmExcessOrderAdd();
                frmExcessOrderAdd.EditBill(guid);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmExcessOrderAdd frmExcessOrderAdd = new frmExcessOrderAdd();
                frmExcessOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ExcessOrderManage ExcessOrderManage = new ExcessOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (ExcessOrderManage.GetIsCheck(dr["ExcessOrderGuid"].ToString()) == false)
                    {
                        ExcessOrderManage.DeleteBill(dr["ExcessOrderGuid"].ToString());

                      

                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "超领单删除", "删除", SysParams.UserName + "用户删除了超领单,超领单唯一号:" + dr["ExcessOrderGuid"].ToString() + ",超领料单号:" + dr["ExcessOrderID"].ToString());

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

        private void frmExcessOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ExcessOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }


        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtExcessOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and ExcessOrderID='" + txtExcessOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpExcessOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and ExcessOrderDate>='" + dtpExcessOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpExcessOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and ExcessOrderDate<='" + dtpExcessOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtDrawPerson.Tag != null)
            {
                if (txtDrawPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and DrawPerson='" + txtDrawPerson.Tag.ToString() + "'";
                }
            }

            if (txtEmitPerson.Tag != null)
            {
                if (txtEmitPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and EmitPerson='" + txtEmitPerson.Tag.ToString() + "'";

                }
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


        //领料人
        private void btnSelectDrawPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDrawPerson.Text = ""; //名称
                    txtDrawPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDrawPerson.Text = arrValue[1]; //名称
                        txtDrawPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //发料人
        private void btnSelectEmitPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtEmitPerson.Text = ""; //名称
                    txtEmitPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtEmitPerson.Text = arrValue[1]; //名称
                        txtEmitPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}