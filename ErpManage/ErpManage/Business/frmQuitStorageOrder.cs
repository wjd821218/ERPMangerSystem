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
    /// 退料入库单
    /// 
    /// </summary>
    public partial class frmQuitStorageOrder : frmBase
    {
         QuitStorageOrderManage QuitStorageOrderManage = new QuitStorageOrderManage();
         public static frmQuitStorageOrder frmQuitStorageOrde;

        public frmQuitStorageOrder()
        {
            InitializeComponent();
            frmQuitStorageOrde = this;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            frmQuitStorageOrderAdd frmQuitStorageOrderAdd = new frmQuitStorageOrderAdd();
            frmQuitStorageOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = QuitStorageOrderManage.GetQuitStorageOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmQuitStorageOrderAdd frmQuitStorageOrderAdd = new frmQuitStorageOrderAdd();
                frmQuitStorageOrderAdd.EditBill(guid);
            }
        }

     

        private void frmQuitStorageOrder_Load(object sender, EventArgs e)
        {
            LoadData();


            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmQuitStorageOrderAdd frmQuitStorageOrderAdd = new frmQuitStorageOrderAdd();
                frmQuitStorageOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    QuitStorageOrderManage QuitStorageOrderManage = new QuitStorageOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (QuitStorageOrderManage.GetIsCheck(dr["QuitStorageOrderGuid"].ToString()) == false)
                    {
                        QuitStorageOrderManage.DeleteBill(dr["QuitStorageOrderGuid"].ToString());

                       
                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "退料入库单删除", "删除", SysParams.UserName + "用户删除了退料入库单,退料入库单唯一号:" + dr["QuitStorageOrderGuid"].ToString() + ",退料入库单单号:" + dr["QuitStorageOrderID"].ToString());

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

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //仓库管员
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

        

    

        //退料仓库
        private void btnSelectInStorage_Click(object sender, EventArgs e)
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
            if (txtQuitStorageOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrderID='" + txtQuitStorageOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpQuitStorageOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrderDate>='" + dtpQuitStorageOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpQuitStorageOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and QuitStorageOrderDate<='" + dtpQuitStorageOrderEndDate.Text.Trim() + " 23:59:59'";
            }


            if (txtStoragePerson.Tag != null)
            {
                if (txtStoragePerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and StoragePerson='" + txtStoragePerson.Tag.ToString() + "'";
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



