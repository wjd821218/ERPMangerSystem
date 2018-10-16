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
    /// 收发存汇总表
    /// 
    /// 修改1
    /// 修改功能：进出为都为0的不显示，增加一个chk
    /// 修改时间：2010-7-20
    /// 
    /// 修改2
    /// 修改功能：增加 chk 期初进出结存都为0不显示
    /// 修改时间：2011-3-4
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

      


    
        //库存查询
        private void btnQty_Click(object sender, EventArgs e)
        {
            if (txtStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择仓库!");
                return;
            }

            if (dtpBeginDate.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择截止日期!");
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
                //进出为0显示没勾上，期初进出结存都为0不显示也没勾上
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
                    //进出为0显示没勾上，期初进出结存都为0不显示勾上了
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
 
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                bandedGridView1.Columns["JCOnlyMoney"].Visible = false;
                bandedGridView1.Columns["QCOnlyMoney"].Visible = false;
                bandedGridView1.Columns["BQOutOnlyMoney"].Visible = false;
                bandedGridView1.Columns["BQInOnlyMoney"].Visible = false;
            }
           
        
           
        }

        /// <summary>
        /// 执行DataTable中的查询返回新的DataTable
        /// </summary>
        /// <param name="dt">源数据DataTable</param>
        /// <param name="condition">查询条件</param>
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
            return newdt;//返回的查询结果
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                bandedGridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
            }
        }

        //重置
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
            //网格直接打印
            ReportCenter rc = new ReportCenter(gridControl1, "收发存汇总表","",true);
            
            rc.Preview();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                bandedGridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
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
                    txtStorage.Text = ""; //名称
                    txtStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtStorage.Text = arrValue[1]; //名称
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
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //得到料件的信息

                    Material material = new Material();
                    material = MaterialManage.GetMaterialByGuid(lstGuid[0]);

                    //填充数据
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
                    txtSupplier.Text = ""; //名称
                    txtSupplier.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplier.Text = arrValue[1]; //名称
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