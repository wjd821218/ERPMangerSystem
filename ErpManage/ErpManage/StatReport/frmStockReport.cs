﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.StatReport
{
    /// <summary>
    /// 库存报表
    /// </summary>
    public partial class frmStockReport : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmStockReport()
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
            if (txtStorage.Text.Trim()=="")
            {
                this.ShowAlertMessage("请选择仓库!");
                return ;
            }

              if (dtpEndDate.Text.Trim()=="")
            {
                this.ShowAlertMessage("请选择截止日期!");
                return ;
            }

          
            string strMaterialGuid="";

            if (txtMaterialGuid.Tag !=null)
            {
                strMaterialGuid=txtMaterialGuid.Tag.ToString();
            }
          
               string strMaterialType="";

            if (txtMaterialType.Tag !=null)
            {
                strMaterialType=txtMaterialType.Tag.ToString();
            }



            StatReportManage StatReportManage = new StatReportManage();
            gridControl1.DataSource=StatReportManage.StockReport(strMaterialGuid, txtStorage.Tag.ToString(), strMaterialType, dtpEndDate.Text.Trim()+" 23:59:59");

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "StockReport";



            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "IsDisplayPrice", "IsDisplayPrice") == false)
            {
                gridView1.Columns["Price"].Visible = false;
                gridView1.Columns["MaterialMoney"].Visible = false;

                gridView1.Columns["Price2"].Visible = false;
                gridView1.Columns["MaterialMoney2"].Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaterialGuid.Text = "";
            txtMaterialGuid.Tag = "";
            dtpEndDate.Text = "";
            txtMaterialName.Text = "";
            txtMaterialType.Text = "";
            txtMaterialType.Tag = "";
            txtStorage.Text = "";
            txtStorage.Tag = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("请查询数据后再打印!");
                return;
            }
         
            //打印库存报表
            XtraReportStockReport XtraReportStockReport = new XtraReportStockReport(ds,txtStorage.Text,dtpEndDate.Text,txtMaterialType.Text,txtMaterialGuid.Text,txtMaterialName.Text);
            XtraReportStockReport.ShowPreview();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            dtpEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}