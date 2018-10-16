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
    /// ������ⵥ
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


            //Ȩ���ж�
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


                if (MessageBox.Show("ȷ��ɾ�������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    QuitStorageOrderManage QuitStorageOrderManage = new QuitStorageOrderManage();
                    dr = (DataRowView)(gridView1.GetFocusedRow());
                    if (QuitStorageOrderManage.GetIsCheck(dr["QuitStorageOrderGuid"].ToString()) == false)
                    {
                        QuitStorageOrderManage.DeleteBill(dr["QuitStorageOrderGuid"].ToString());

                       
                        //д��־
                        SysLog.AddOperateLog(SysParams.UserName, "������ⵥɾ��", "ɾ��", SysParams.UserName + "�û�ɾ����������ⵥ,������ⵥΨһ��:" + dr["QuitStorageOrderGuid"].ToString() + ",������ⵥ����:" + dr["QuitStorageOrderID"].ToString());

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

        //�ֿ��Ա
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

        

    

        //���ϲֿ�
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



