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
    /// 其它入库单
    /// </summary>
    public partial class frmOtherInOrder :frmBase
    {
        OtherInOrderManage OtherInOrderManage = new OtherInOrderManage();
        public static frmOtherInOrder frmotherinorder;
        public frmOtherInOrder()
        {
            InitializeComponent();
            frmotherinorder = this;
        }

    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            frmOtherInOrderAdd frmOtherInOrderAdd = new frmOtherInOrderAdd();
            frmOtherInOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = OtherInOrderManage.GetOtherInOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmOtherInOrderAdd frmOtherInOrderAdd = new frmOtherInOrderAdd();
                frmOtherInOrderAdd.EditBill(guid);
            }
        }

     

        private void frmOtherInOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "OtherInOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmOtherInOrderAdd frmOtherInOrderAdd = new frmOtherInOrderAdd();
                frmOtherInOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    OtherInOrderManage OtherInOrderManage = new OtherInOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (OtherInOrderManage.GetIsCheck(dr["OtherInOrderGuid"].ToString()) == false)
                    {
                        OtherInOrderManage.DeleteBill(dr["OtherInOrderGuid"].ToString());

                       

                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "其它出库单删除", "删除", SysParams.UserName + "用户删除了其它出库单,其它出库单唯一号:" + dr["OtherInOrderGuid"].ToString() + ",其它出库单号:" + dr["OtherInOrderID"].ToString());
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

      

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStoragePerson.Text = ""; //名称
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //名称
                        txtStoragePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectQualityPerson_Click(object sender, EventArgs e)
        {

            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtQualityPerson.Text = ""; //名称
                    txtQualityPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtQualityPerson.Text = arrValue[1]; //名称
                        txtQualityPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectOutStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtInStorage.Text = ""; //名称
                    txtInStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtInStorage.Text = arrValue[1]; //名称
                        txtInStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtOtherInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderID='" + txtOtherInOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpOtherInOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderDate>='" + dtpOtherInOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpOtherInOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and OtherInOrderDate<='" + dtpOtherInOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtStoragePerson.Tag != null)
            {
                if (txtStoragePerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and StoragePerson='" + txtStoragePerson.Tag.ToString() + "'";

                }
            }


            if (txtQualityPerson.Tag != null)
            {
                if (txtQualityPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and QualityPerson='" + txtQualityPerson.Tag.ToString() + "'";

                }
            }

            if (txtInStorage.Tag != null)
            {
                if (txtInStorage.Tag.ToString() != "")
                {
                    strsql = strsql + " and InStorage='" + txtInStorage.Tag.ToString() + "'";

                }
            }

            if (txtBatchNO.Text.Trim() != "")
            {
                strsql = strsql + " and BatchNo='" + txtBatchNO.Text.Trim() + "'";
               
            }


            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }


            return strsql;

        }

    }
}
