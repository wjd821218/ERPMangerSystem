using System;
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
    /// 库存预警物料上下限数量维护
    /// </summary>
    public partial class frmStockYJAdd : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmStockYJAdd()
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
            string strWheresql = " where IsEnable=0 ";
          
            string strMaterialGuid="";

            if (txtMaterialGuid.Tag !=null)
            {
                if (txtMaterialGuid.Tag.ToString() != "")
                {
                    strMaterialGuid = txtMaterialGuid.Tag.ToString();
                    strWheresql = strWheresql + " and  MaterialGuid='" + strMaterialGuid + "'";
                }
            }
          
               string strMaterialType="";

            if (txtMaterialType.Tag !=null)
            {
                if (txtMaterialType.Tag.ToString() != "")
                {
                    strMaterialType = txtMaterialType.Tag.ToString();
                    strWheresql = strWheresql + " and  ClassID='" + strMaterialType + "'";
                }
            }


            StockYJManage StockYJManage = new StockYJManage();
            gridControl1.DataSource = StockYJManage.GetStockYJData(strWheresql);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaterialGuid.Text = "";
            txtMaterialGuid.Tag = "";
          
            txtMaterialName.Text = "";
            txtMaterialType.Text = "";
            txtMaterialType.Tag = "";
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void frmStockReport_Load(object sender, EventArgs e)
        {
           
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtMaterialName.Focus();
            gridView1.UpdateCurrentRow();

            List<StockYJ> lstStockYJ = new List<StockYJ>();
            StockYJ StockYJ = new StockYJ();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                StockYJ = new StockYJ();
                if (dr["StockYJGuid"].ToString().Trim() == "")
                {
                    StockYJ.StockYJGuid = Guid.NewGuid().ToString();
                }
                else
                {
                   StockYJ.StockYJGuid = dr["StockYJGuid"].ToString();
                }
                StockYJ.MaterialGuid = dr["MaterialGuid"].ToString();
               
                StockYJ.StockYJDown = decimal.Parse(dr["StockYJDown"].ToString());
                StockYJ.StockYJUp = decimal.Parse(dr["StockYJUp"].ToString());
                StockYJ.BomSum = decimal.Parse(dr["BomSum"].ToString());

                lstStockYJ.Add(StockYJ);
            }

            StockYJManage StockYJManage = new StockYJManage();
            StockYJManage.InsertData(lstStockYJ);

            ShowAlertMessage("数据保存成功");

        }

        private void btnBomQry_Click(object sender, EventArgs e)
        {
            if (txtMaterialGuid.Text.Trim() == "")
            {
                ShowAlertMessage("请选择物料！");
                return;
            }

            StockYJManage StockYJManage = new StockYJManage();
            gridControl1.DataSource = StockYJManage.sp_GetMaterialBomData_BomQry2(txtMaterialGuid.Text.Trim());

        }
    }
}