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
    /// 期初录入
    /// </summary>
    public partial class frmInitialGoods : frmBase
    {
        InitialGoodsManage InitialGoodsManage=new InitialGoodsManage();
        public static frmInitialGoods frminitialgoods;
        public frmInitialGoods()
        {
            InitializeComponent();
            frminitialgoods = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmInitialGoodsAdd frmInitialGoodsAdd = new frmInitialGoodsAdd();
            frmInitialGoodsAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = InitialGoodsManage.GetInitialGoodsBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmInitialGoodsAdd frmInitialGoodsAdd = new frmInitialGoodsAdd();
                frmInitialGoodsAdd.EditBill(guid);
            }
        }

    
        private void frmInitialGoods_Load(object sender, EventArgs e)
        {
            LoadData();

            //权限判断
            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsDelete", "Delete") == false)
            //{
            //    btnDelete.Enabled = false;
            //}
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmInitialGoodsAdd frmInitialGoodsAdd = new frmInitialGoodsAdd();
                frmInitialGoodsAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                if (MessageBox.Show("确定删除该数据！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    InitialGoodsManage InitialGoodsManage = new InitialGoodsManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (InitialGoodsManage.GetIsCheck(dr["InitialGoodsGuid"].ToString()) == false)
                    {
                        InitialGoodsManage.DeleteBill(dr["InitialGoodsGuid"].ToString());

                    


                        //写日志
                        SysLog.AddOperateLog(SysParams.UserName, "期初入库单删除", "删除", SysParams.UserName + "用户删除了期初入库单,期初入库单唯一号:" + dr["InitialGoodsGuid"].ToString() + ",期初入库单号:" + dr["InitialGoodsID"].ToString());

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

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtInitialGoodsID.Text.Trim() != "")
            {
                strsql = strsql + " and InitialGoodsID='" + txtInitialGoodsID.Text.Replace("'", "''") + "'";
            }

            if (dtpInitialGoodsBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and InitialGoodsDate>='" + dtpInitialGoodsBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpInitialGoodsEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and InitialGoodsDate<='" + dtpInitialGoodsEndDate.Text.Trim() + " 23:59:59'";
            }
 
            if (txtIncomeDepot.Tag != null)
            {
                if (txtIncomeDepot.Tag.ToString() != "")
                {
                    strsql = strsql + " and IncomeDepot='" + txtIncomeDepot.Tag.ToString() + "'";

                }
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }


            return strsql;

        }
      




        //收货仓库
        private void btnSelectIncomeDepot_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtIncomeDepot.Text = ""; //名称
                    txtIncomeDepot.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtIncomeDepot.Text = arrValue[1]; //名称
                        txtIncomeDepot.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}
