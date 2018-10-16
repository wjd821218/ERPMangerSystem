using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;
using ErpManage.Business;

namespace ErpManage.StatReport
{
    /// <summary>
    /// 库存明细报表
    /// </summary>
    public partial class frmStockDetailReport : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DataSet ds = new DataSet();
        public frmStockDetailReport()
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

      

        private void btnQry_Click(object sender, EventArgs e)
        {
            if (txtStorage.Text.Trim()=="")
            {
                this.ShowAlertMessage("请选择仓库!");
                return ;
            }

            if (txtMaterialGuid.Text == "")
            {
                this.ShowAlertMessage("请选择物料!");
                return;
            }

          
            string strMaterialGuid="";

            if (txtMaterialGuid.Tag !=null)
            {
                strMaterialGuid=txtMaterialGuid.Tag.ToString();
            }
          
             

            StatReportManage StatReportManage = new StatReportManage();
            gridControl1.DataSource=StatReportManage.StockDetailReport(strMaterialGuid, txtStorage.Tag.ToString());

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "StockDetailReport";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaterialGuid.Text = "";
            txtMaterialGuid.Tag = "";
         
            txtMaterialName.Text = "";
        
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
            XtraReportStockDetailReport XtraReportStockDetailReport = new XtraReportStockDetailReport(ds, txtStorage.Text, txtMaterialGuid.Text, txtMaterialName.Text);
            XtraReportStockDetailReport.ShowPreview();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DataRowView dr = (DataRowView)(gridView1.GetFocusedRow());
                string strFlag = dr["Flag"].ToString();
                string strGuid = dr["BillGuid"].ToString();

                switch (strFlag)
                {
                    case "StockInOrder":
                        frmStockInOrderAdd frmStockInOrderAdd = new frmStockInOrderAdd();
                        frmStockInOrderAdd.EditBill(strGuid);
                        break;
                    case "GoodsOrder":
                        frmGoodsOrderAdd frmGoodsOrderAdd = new frmGoodsOrderAdd();
                        frmGoodsOrderAdd.EditBill(strGuid);
                        break;
                    case "HalfGoods":
                        frmHalfGoodsAdd frmHalfGoodsAdd = new frmHalfGoodsAdd();
                        frmHalfGoodsAdd.EditBill(strGuid);
                        break;
                    case "Consign":
                        frmConsignAdd frmConsignAdd = new frmConsignAdd();
                        frmConsignAdd.EditBill(strGuid);
                        break;
                    case "QuitStorageOrder":
                        frmQuitStorageOrderAdd frmQuitStorageOrderAdd = new frmQuitStorageOrderAdd();
                        frmQuitStorageOrderAdd.EditBill(strGuid);
                        break;
                    case "DrawOrder":

                        frmDrawOrderAdd frmDrawOrderAdd = new frmDrawOrderAdd();
                        frmDrawOrderAdd.EditBill(strGuid);
                        break;
                    case "ExcessOrder":
                        frmExcessOrderAdd frmExcessOrderAdd = new frmExcessOrderAdd();
                        frmExcessOrderAdd.EditBill(strGuid);
                        break;
                    case "SellOrder":
                        frmSellOrderAdd frmSellOrderAdd = new frmSellOrderAdd();
                        frmSellOrderAdd.EditBill(strGuid);
                        break;
                    case "ConsignOut":
                        frmConsignOutAdd frmConsignOutAdd = new frmConsignOutAdd();
                        frmConsignOutAdd.EditBill(strGuid);
                        break;
                    case "OtherSellOrder":
                        frmOtherSellOrderAdd frmOtherSellOrderAdd = new frmOtherSellOrderAdd();
                        frmOtherSellOrderAdd.EditBill(strGuid);
                        break;
                    case "RemoveBillIn":
                    case "RemoveBillOut":
                        frmRemoveBillAdd frmRemoveBillAdd = new frmRemoveBillAdd();
                        frmRemoveBillAdd.EditBill(strGuid);
                        break;
                    case "RejectOrder":
                        frmRejectOrderAdd frmRejectOrderAdd = new frmRejectOrderAdd();
                        frmRejectOrderAdd.EditBill(strGuid);
                        break;
                }
            }


            /*
                case  when Flag='StockInOrder'  then  '采购入库单' 
                when Flag='GoodsOrder'   then  '成品入库单' 
                when Flag='HalfGoods'      then  '半成品入库单' 
                when Flag='Consign'            then  '委外加工入库单'
                when Flag='QuitStorageOrder'     then  '退料入库单'
                when Flag='DrawOrder'  then  '领料单' 
                when Flag='ExcessOrder'   then  '超领单' 
                when Flag='SellOrder'      then  '销售出库单' 
                when Flag='ConsignOut'            then  '委外加工出库单'
                when Flag='OtherSellOrder'            then  '其它出库单'
             * */
        }
    }
}