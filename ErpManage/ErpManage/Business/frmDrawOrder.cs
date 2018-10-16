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
    /// 邻料单
    /// </summary>
    public partial class frmDrawOrder : frmBase
    {
        DrawOrderManage DrawOrderManage = new DrawOrderManage();
        public static frmDrawOrder frmdraworder;
        public frmDrawOrder()
        {
           
            InitializeComponent();

            frmdraworder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            frmDrawOrderAdd frmDrawOrderAdd = new frmDrawOrderAdd();
            frmDrawOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = DrawOrderManage.GetDrawOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;

           


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmDrawOrderAdd frmDrawOrderAdd = new frmDrawOrderAdd();
                frmDrawOrderAdd.EditBill(guid);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrawOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmDrawOrderAdd frmDrawOrderAdd = new frmDrawOrderAdd();
                frmDrawOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DrawOrderManage DrawOrderManage = new DrawOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (DrawOrderManage.GetIsCheck(dr["DrawOrderGuid"].ToString()) == false)
                    {
                        DrawOrderManage.DeleteBill(dr["DrawOrderGuid"].ToString());

                       

                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "领料单删除", "删除", SysParams.UserName + "用户删除了领料单,领料单唯一号:" + dr["DrawOrderGuid"].ToString() + ",领料单号:" + dr["DrawOrderID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("删除成功!");
                    }
                    else
                    {
                        this.ShowAlertMessage("此单据已审核，不可以删除!");
                    }
                }

            }
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtDrawOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and DrawOrderID='" + txtDrawOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpDrawOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawOrderDate>='" + dtpDrawOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpDrawOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and DrawOrderDate<='" + dtpDrawOrderEndDate.Text.Trim() + " 23:59:59'";
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

            if (txtOutStorage.Tag!= null)
            {
                if (txtOutStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and OutStorage='" + txtOutStorage.Tag.ToString() + "'";

                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
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

        //领料仓库
        private void btnSelectOutStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtOutStorage.Text = ""; //名称
                    txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //名称
                        txtOutStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}