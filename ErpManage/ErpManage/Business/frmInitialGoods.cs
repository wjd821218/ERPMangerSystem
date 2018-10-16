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
    /// �ڳ�¼��
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

            //Ȩ���ж�
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
                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    InitialGoodsManage InitialGoodsManage = new InitialGoodsManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());

                    if (InitialGoodsManage.GetIsCheck(dr["InitialGoodsGuid"].ToString()) == false)
                    {
                        InitialGoodsManage.DeleteBill(dr["InitialGoodsGuid"].ToString());

                    


                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "�ڳ���ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ�����ڳ���ⵥ,�ڳ���ⵥΨһ��:" + dr["InitialGoodsGuid"].ToString() + ",�ڳ���ⵥ��:" + dr["InitialGoodsID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("ɾ���ɹ�!");
                    }
                    else
                    {
                        this.ShowAlertMessage("�˵�������ˣ�������ɾ��!");
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
      




        //�ջ��ֿ�
        private void btnSelectIncomeDepot_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtIncomeDepot.Text = ""; //����
                    txtIncomeDepot.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtIncomeDepot.Text = arrValue[1]; //����
                        txtIncomeDepot.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}
