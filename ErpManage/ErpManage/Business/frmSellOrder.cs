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
    /// ���۳��ⵥ
    /// </summary>
    public partial class frmSellOrder :frmBase
    {
        SellOrderManage SellOrderManage = new SellOrderManage();
        public static frmSellOrder frmsellorder;
        public frmSellOrder()
        {
            InitializeComponent();
            frmsellorder = this;
        }

    
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            frmSellOrderAdd frmSellOrderAdd = new frmSellOrderAdd();
            frmSellOrderAdd.AddBill();
        }

        public void LoadData()
        {
            DataTable dtl = new DataTable();
            dtl = SellOrderManage.GetSellOrderBySQL(GetWhereSQL());

            gridControl1.DataSource = dtl;


        }

     
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmSellOrderAdd frmSellOrderAdd = new frmSellOrderAdd();
                frmSellOrderAdd.EditBill(guid);
            }
        }

     

        private void frmSellOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "SellOrderDelete", "Delete") == false)
            {
                btnDelete.Enabled = false;
            }
        }

        private void tsbedit_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();


                frmSellOrderAdd frmSellOrderAdd = new frmSellOrderAdd();
                frmSellOrderAdd.EditBill(guid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SellOrderManage SellOrderManage = new SellOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (SellOrderManage.GetIsCheck(dr["SellOrderGuid"].ToString()) == false)
                    {
                        SellOrderManage.DeleteBill(dr["SellOrderGuid"].ToString());

                       
                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "���۳��ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ�������۳��ⵥ,���۳��ⵥΨһ��:" + dr["SellOrderGuid"].ToString() + ",���۳��ⵥ����:" + dr["SellOrderID"].ToString());

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

      

        private void exit_Click(object sender, EventArgs e)
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
            if (txtSellOrderID.Text.Trim() != "")
            {
                strsql = strsql + " and SellOrderID='" + txtSellOrderID.Text.Replace("'", "''") + "'";
            }

            if (dtpSellOrderBeginDate.Text.Trim() != "")
            {
                strsql = strsql + " and SellOrderDate>='" + dtpSellOrderBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dtpSellOrderEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and SellOrderDate<='" + dtpSellOrderEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtClient.Tag != null)
            {
                if (txtClient.Tag.ToString() != "")
                {
                    strsql = strsql + " and ClientGuid='" + txtClient.Tag.ToString() + "'";
                }
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

            if (txtOutStorage.Tag != null)
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

            if (chkCheck2.Checked == true)
            {
                strsql = strsql + " and CheckGuid2<>'' ";
            }

            return strsql;

        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(4);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtClient.Text = ""; //����
                    txtClient.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtClient.Text = arrValue[1]; //����
                        txtClient.Tag = arrValue[0];  //Guid
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

        private void btnSelectQualityPerson_Click(object sender, EventArgs e)
        {

            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtQualityPerson.Text = ""; //����
                    txtQualityPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtQualityPerson.Text = arrValue[1]; //����
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
                    txtOutStorage.Text = ""; //����
                    txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //����
                        txtOutStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}
