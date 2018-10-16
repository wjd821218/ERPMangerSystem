using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManage;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.StatReport
{
    /// <summary>
    /// �շ�����ܱ�
    /// 
    /// �޸�1
    /// �޸Ĺ��ܣ�����Ϊ��Ϊ0�Ĳ���ʾ������һ��chk
    /// �޸�ʱ�䣺2010-7-20
    /// 
    /// �޸�2
    /// �޸Ĺ��ܣ����� chk �ڳ�������涼Ϊ0����ʾ
    /// �޸�ʱ�䣺2011-3-4
    /// </summary>
    public partial class frmDepotMaterialInOutSum : frmBase
    {
    
        MaterialManage MaterialManage = new MaterialManage();
        
        public frmDepotMaterialInOutSum()
        {
            InitializeComponent();
            IniControl_CN();
        }

      
     
        private void frmBill_Load(object sender, EventArgs e)
        {
            dtpBeginDate.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-01";
            dtpEndDate.Text = DateTime.Now.ToShortDateString();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


    
        //����ѯ
        private void btnQty_Click(object sender, EventArgs e)
        {
            if (txtStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ��ֿ�!");
                return;
            }

            if (dtpBeginDate.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ���ֹ����!");
                return;
            }


            string strMaterialGuid = "";

            if (txtMaterialGuid.Tag != null)
            {
                strMaterialGuid = txtMaterialGuid.Tag.ToString();
            }

            string strMaterialType = "";

            if (txtMaterialType.Tag != null)
            {
                strMaterialType = txtMaterialType.Tag.ToString();
            }

            string strSupplierGuid = "";
            if (txtSupplier.Tag != null)
            {
                strSupplierGuid = txtSupplier.Tag.ToString();
            }



            StatReportManage StatReportManage = new StatReportManage();
            if (chkView.Checked == true)
            {
                DataTable dtl = new DataTable();
                dtl = StatReportManage.sp_GetInOutStorageSum(dtpBeginDate.Text + " 00:00:00", dtpEndDate.Text + " 23:59:59", strMaterialGuid, txtStorage.Tag.ToString(), strMaterialType, strSupplierGuid);
                gridControl1.DataSource = dtl;

            }
            else
            {
                //����Ϊ0��ʾû���ϣ��ڳ�������涼Ϊ0����ʾҲû����
                if (chkView2.Checked == false)
                {
                    DataTable dtl = new DataTable();
                    DataTable dtl2 = new DataTable();
                    dtl = StatReportManage.sp_GetInOutStorageSum(dtpBeginDate.Text + " 00:00:00", dtpEndDate.Text + " 23:59:59", strMaterialGuid, txtStorage.Tag.ToString(), strMaterialType, strSupplierGuid);
                    dtl2 = GetNewDataTable(dtl, " BQInOnlySum>0 or BQInOnlySum<0 or BQOutOnlySum>0 or BQOutOnlySum<0 ");
                    gridControl1.DataSource = dtl2;
                }
                else
                {
                    //����Ϊ0��ʾû���ϣ��ڳ�������涼Ϊ0����ʾ������
                    if (chkView2.Checked == true)
                    {
                        DataTable dtl = new DataTable();
                        DataTable dtl2 = new DataTable();
                        dtl = StatReportManage.sp_GetInOutStorageSum(dtpBeginDate.Text + " 00:00:00", dtpEndDate.Text + " 23:59:59", strMaterialGuid, txtStorage.Tag.ToString(), strMaterialType, strSupplierGuid);
                        dtl2 = GetNewDataTable(dtl, " QCOnlySum>0 or QCOnlySum<0 or BQInOnlySum>0 or BQInOnlySum<0 or BQOutOnlySum>0 or BQOutOnlySum<0  ");
                        gridControl1.DataSource = dtl2;
                    
                    }

                
                }


            }
 
            //Ȩ���ж�
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                bandedGridView1.Columns["JCOnlyMoney"].Visible = false;
                bandedGridView1.Columns["QCOnlyMoney"].Visible = false;
                bandedGridView1.Columns["BQOutOnlyMoney"].Visible = false;
                bandedGridView1.Columns["BQInOnlyMoney"].Visible = false;
            }
           
        
           
        }

        /// <summary>
        /// ִ��DataTable�еĲ�ѯ�����µ�DataTable
        /// </summary>
        /// <param name="dt">Դ����DataTable</param>
        /// <param name="condition">��ѯ����</param>
        /// <returns></returns>
        private DataTable GetNewDataTable(DataTable dt, string condition)
        {
            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            DataRow[] dr = dt.Select(condition);
            for (int i = 0; i < dr.Length; i++)
            {
                newdt.ImportRow((DataRow)dr[i]);
            }
            return newdt;//���صĲ�ѯ���
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel�ļ�|*.XLS|�����ļ�|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                bandedGridView1.ExportToXls(filename);

                this.ShowMessage("�����ɹ�");
            }
        }

        //����
        private void button1_Click(object sender, EventArgs e)
        {

            txtStorage.Tag = "";
            txtStorage.Text = "";

            dtpBeginDate.Text = "";
            dtpEndDate.Text = "";
            txtMaterialGuid.Text = "";
            txtMaterialGuid.Tag = "";
            txtMaterialName.Text = "";
            txtMaterialType.Text = "";
            txtMaterialType.Tag = "";

       
        }


      

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //����ֱ�Ӵ�ӡ
            ReportCenter rc = new ReportCenter(gridControl1, "�շ�����ܱ�","",true);
            
            rc.Preview();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel�ļ�|*.XLS|�����ļ�|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                bandedGridView1.ExportToXls(filename);

                this.ShowMessage("�����ɹ�");
            }
        }

      

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnSelectMaterialType_Click(object sender, EventArgs e)
        {
            frmSelectType frmSelectType = new frmSelectType();
            frmSelectType.InValue = 0;
            frmSelectType.ShowDialog();

            if (frmSelectType.Tag != null)
            {
                SelectMaterialType SelectMaterialType = frmSelectType.Tag as SelectMaterialType;

                txtMaterialType.Text = SelectMaterialType.MaterialTypeName;
                txtMaterialType.Tag = SelectMaterialType.MaterialTypeID;

            }
        }

        private void btnSelectStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStorage.Text = ""; //����
                    txtStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtStorage.Text = arrValue[1]; //����
                        txtStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectMaterialGuid_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial(1);
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null)
            {
                //ȡ��ѡ����ϼ�Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //ѡ���Ʒ�����
                if (lstGuid.Count > 0)
                {
                    //�õ��ϼ�����Ϣ

                    Material material = new Material();
                    material = MaterialManage.GetMaterialByGuid(lstGuid[0]);

                    //�������
                    txtMaterialGuid.Text = material.MaterialID;
                    txtMaterialGuid.Tag = material.MaterialGuID;

                    txtMaterialName.Text = material.MaterialName;

                }

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
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

        private void chkView2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkView2.Checked == true)
            {
                chkView.Checked = false;
            }
           
        }

        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
            if (chkView.Checked == true)
            {
                chkView2.Checked = false;
            }
        }
    }
}