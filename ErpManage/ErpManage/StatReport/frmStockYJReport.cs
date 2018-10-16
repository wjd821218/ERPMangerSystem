using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;
using DevExpress.XtraGrid.Views.Grid;

namespace ErpManage.StatReport
{
    /// <summary>
    /// 库存预警报表
    /// </summary>
    public partial class frmStockYJReport : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmStockYJReport()
        {
            InitializeComponent();

            IniControl_CN();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                this.ShowMessage("导出成功");
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

        private void btnQry_Click(object sender, EventArgs e)
        {
            if (txtIncomeDepot.Text.Trim() == "")
            {
                ShowAlertMessage("请选择仓库！");
                return;
            }



            StockYJManage StockYJManage = new StockYJManage();
            gridControl1.DataSource = StockYJManage.sp_GetOneStorageSumDataByYJ2( txtIncomeDepot.Tag.ToString());

            //string strMaterialGuid="";

            //if (txtMaterialGuid.Tag !=null)
            //{
            //    strMaterialGuid=txtMaterialGuid.Tag.ToString();
            //}
          
            //   string strMaterialType="";

            //if (txtMaterialType.Tag !=null)
            //{
            //    strMaterialType=txtMaterialType.Tag.ToString();
            //}



            //StatReportManage StatReportManage = new StatReportManage();
            //gridControl1.DataSource=StatReportManage.StockReport(strMaterialGuid, txtStorage.Tag.ToString(), strMaterialType, dtpEndDate.Text.Trim()+" 23:59:59");




            ////权限判断
            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            //{
            //    gridView1.Columns["Price"].Visible = false;
            //    gridView1.Columns["MaterialMoney"].Visible = false;

            //    gridView1.Columns["Price2"].Visible = false;
            //    gridView1.Columns["MaterialMoney2"].Visible = false;
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaterialGuid.Text = "";
            txtMaterialGuid.Tag = "";
          
            txtMaterialName.Text = "";
            txtMaterialType.Text = "";
            txtMaterialType.Tag = "";

            txtIncomeDepot.Text = ""; //名称
            txtIncomeDepot.Tag = "";  //Guid
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmStockReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStockYJAdd frmStockYJAdd = new frmStockYJAdd();
            frmStockYJAdd.Show(this);
        }

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

        private void btnBomQry_Click(object sender, EventArgs e)
        {
            if (txtMaterialGuid.Text.Trim() == "")
            {
                ShowAlertMessage("请选择物料！");
                return;
            }

            if (txtIncomeDepot.Text.Trim() == "")
            {
                ShowAlertMessage("请选择仓库！");
                return;
            }

            StockYJManage StockYJManage = new StockYJManage();
            gridControl1.DataSource = StockYJManage.sp_GetOneStorageSumDataByYJ(txtMaterialGuid.Text.Trim(),txtIncomeDepot.Tag.ToString());
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (view.GetRowCellDisplayText(e.RowHandle, view.Columns["StockYJDown"]).Trim() != "" && view.GetRowCellDisplayText(e.RowHandle, view.Columns["StorageSum"]).Trim() != "")
                {
                    decimal decStockYJDown = decimal.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["StockYJDown"]));
                    decimal decStorageSum = decimal.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["StorageSum"]));
                    if (decStockYJDown > decStorageSum)
                    {
                        e.Appearance.BackColor = Color.Red;
                        // e.Appearance.BackColor2 = Color.SeaShell;
                    }
                }
            }
        }
    }
}