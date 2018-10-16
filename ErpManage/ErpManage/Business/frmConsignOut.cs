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
    /// ί��ӹ����
    /// </summary>
    public partial class frmConsignOut : frmBase
    {
        ConsignOutManage ConsignOutManage=new ConsignOutManage();
        public static frmConsignOut frmconsignout;
        public frmConsignOut()
        {
            InitializeComponent();
            frmconsignout = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          

            frmConsignOutAdd frmConsignOutAdd = new frmConsignOutAdd();
            frmConsignOutAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = ConsignOutManage.GetConsignOutBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmConsignOutAdd frmConsignOutAdd = new frmConsignOutAdd();
                frmConsignOutAdd.EditBill(guid);
            }
        }

    
        private void frmConsignOut_Load(object sender, EventArgs e)
        {
            LoadData();

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
                frmConsignOutAdd frmConsignOutAdd = new frmConsignOutAdd();
                frmConsignOutAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ConsignOutManage ConsignOutManage = new ConsignOutManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (ConsignOutManage.GetIsCheck(dr["ConsignOutGuid"].ToString()) == false)
                    {

                        ConsignOutManage.DeleteBill(dr["ConsignOutGuid"].ToString());

                    

                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "ί����ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ����ί����ⵥ,ί����ⵥΨһ��:" + dr["ConsignOutGuid"].ToString());

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

        public string GetWhereSQL()
        {
            string strsql = "  where  1=1 ";
            if (txtConsignOutID.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignOutID='" + txtConsignOutID.Text.Replace("'", "''") + "'";
            }

            if (dtpConsignOutBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignOutDate>='" + dtpConsignOutBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpConsignOutEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and ConsignOutDate<='" + dtpConsignOutEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtDepotPerson.Tag != null)
            {
                if (txtDepotPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and DepotPerson='" + txtDepotPerson.Tag.ToString() + "'";
                }
            }

            if (txtTransactorPerson.Tag != null)
            {
                if (txtTransactorPerson.Tag.ToString() != "")
                {
                    strsql = strsql + " and TransactorPerson='" + txtTransactorPerson.Tag.ToString() + "'";

                }
            }



            if (chkCheck.Checked == true)
            {
                strsql = strsql + " and CheckGuid<>'' ";
            }


            if (txtSupplier.Tag != null)
            {
                if (txtSupplier.Tag.ToString() != "")
                {
                    strsql = strsql + " and SupplierGuid='" + txtSupplier.Tag.ToString() + "'";
                }
            }

            return strsql;

        }

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

        private void btnQty_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
