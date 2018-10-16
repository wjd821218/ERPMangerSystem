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
    /// �ɹ���ⵥ�鿴
    /// </summary>
    public partial class frmStockInOrder : frmBase
    {
        StockInOrderManage StockInOrderManage = new StockInOrderManage();
        public static frmStockInOrder frmstockinorder;
        public frmStockInOrder()
        {
            frmstockinorder = this;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
            frmStockInOrderAdd.AddBill();
        }

        private void frmStockInOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "StockInDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }

        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = StockInOrderManage.GetStockInOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
                frmStockInOrderAdd.EditBill(guid);
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
                frmStockInOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  
                    if (StockInOrderManage.GetIsCheck(dr["StockInOrderGuid"].ToString()) == false)
                    {
                        StockInOrderManage.DeleteBill(dr["StockInOrderGuid"].ToString());

                       

                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "�ɹ���ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ���˲ɹ���ⵥ,�ɹ���ⵥΨһ��:" + dr["StockInOrderGuid"].ToString() + ",�ɹ���ⵥ��:" + dr["StockInOrderID"].ToString());

                        gridView1.DeleteSelectedRows();

                        this.ShowMessage("ɾ���ɹ�!");
                    }
                    else
                    {
                        this.ShowMessage("�˵����Ѿ����,����ɾ��!");
                    }
                }

            }
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplier.Text = ""; //����
                    txtSupplier.Tag = "";  //Guid
                }
                else
                {

                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //����
                        txtSupplier.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStoragePerson.Text = ""; //����
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //����
                        txtStoragePerson.Tag = arrValue[0];  //Guid
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
            if (txtStockInOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderID='" + txtStockInOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpStockInOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate>='" + dtpStockInOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpStockInOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and StockInOrderDate<='" + dtpStockInOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
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
                strsql = strsql + " and BatchNO='" + txtBatchNO.Text.Replace("'", "''") + "'";
            }

            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }


            return strsql;

        }

        //�ջ��ֿ�
        private void btnSelectInStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtInStorage.Text = ""; //����
                    txtInStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtInStorage.Text = arrValue[1]; //����
                        txtInStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}