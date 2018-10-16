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
    /// ��Ʒ���
    /// </summary>
    public partial class frmGoodsOrder : frmBase
    {
        GoodsOrderManage GoodsOrderManage=new GoodsOrderManage();
        public static frmGoodsOrder frmgoodsorder;
        public frmGoodsOrder()
        {
            InitializeComponent();
            frmgoodsorder = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            frmGoodsOrderAdd frmGoodsOrderAdd = new frmGoodsOrderAdd();
            frmGoodsOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = GoodsOrderManage.GetGoodsOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmGoodsOrderAdd frmGoodsOrderAdd = new frmGoodsOrderAdd();
                frmGoodsOrderAdd.EditBill(guid);
            }
        }


        private void frmGoodsOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "GoodsOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmGoodsOrderAdd frmGoodsOrderAdd = new frmGoodsOrderAdd();
                frmGoodsOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GoodsOrderManage GoodsOrderManage = new GoodsOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (GoodsOrderManage.GetIsCheck(dr["GoodsOrderGuid"].ToString()) == false)
                    {
                        GoodsOrderManage.DeleteBill(dr["GoodsOrderGuid"].ToString());

                       
                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "��Ʒ��ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˳�Ʒ��ⵥ,��Ʒ��ⵥΨһ��:" + dr["GoodsOrderGuid"].ToString() + ",��Ʒ��ⵥ��:" + dr["GoodsOrderID"].ToString());

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
            if (txtGoodsOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and GoodsOrderID='" + txtGoodsOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpGoodsOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and GoodsOrderDate>='" + dtpGoodsOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpGoodsOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and GoodsOrderDate<='" + dtpGoodsOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtTransactorPerson.Tag != null)
            {
                if (txtTransactorPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and TransactorPerson='" + txtTransactorPerson.Tag.ToString() + "'";
                }
            }

            if (txtDepotPerson.Tag != null)
            {
                if (txtDepotPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and DepotPerson='" + txtDepotPerson.Tag.ToString() + "'";

                }
            }

            if (txtIncomeDepot.Tag != null)
            {
                if (txtIncomeDepot.Tag.ToString() != "")
                {
                    strsql = strsql + " and IncomeDepot='" + txtIncomeDepot.Tag.ToString() + "'";
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

        //������
        private void btnSelectTransactorPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtTransactorPerson.Text = ""; //����
                    txtTransactorPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtTransactorPerson.Text = arrValue[1]; //����
                        txtTransactorPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

      


        //�ֹ�Ա
        private void btnSelectDepotPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDepotPerson.Text = "";
                    txtDepotPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDepotPerson.Text = arrValue[1]; //����
                        txtDepotPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
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
