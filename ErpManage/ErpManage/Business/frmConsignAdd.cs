using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.PrintReport;

namespace ErpManage.Business
{
    /// <summary>
    /// 委外加工入库新增
    /// </summary>
    public partial class frmConsignAdd :frmBase
    {
      
        MaterialManage MaterialManage = new MaterialManage();
        ConsignManage ConsignManage = new ConsignManage();
        DataSet ds = new DataSet();
        public frmConsignAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignPrint", "Print") == false)
            {
                tsbPrint.Enabled= false;
            }

        }


        //新增
        public void AddBill()
        {
            txtConsignID.Text = GetAutoId("Consign");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtConsignGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();
            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
      

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string ConsignGuid)
        {
            txtConsignGuid.Text = ConsignGuid;
            DataTable dtl = ConsignManage.GetConsignByConsignGuid(ConsignGuid);

            txtConsignID.Text = dtl.Rows[0]["ConsignID"].ToString();
            dtpConsignDate.Text = DateTime.Parse(dtl.Rows[0]["ConsignDate"].ToString()).ToString("yyyy-MM-dd");

            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();

            txtPlant.Text = dtl.Rows[0]["PlantName"].ToString();
            txtPlant.Tag = dtl.Rows[0]["Plant"].ToString();

            txtIncomeDepot.Text = dtl.Rows[0]["IncomeDepotName"].ToString();
            txtIncomeDepot.Tag = dtl.Rows[0]["IncomeDepot"].ToString();

            txtSatrapPerson.Text = dtl.Rows[0]["SatrapPersonName"].ToString();
            txtSatrapPerson.Tag = dtl.Rows[0]["SatrapPerson"].ToString();

            txtTransactorPerson.Text = dtl.Rows[0]["TransactorPersonName"].ToString();
            txtTransactorPerson.Tag = dtl.Rows[0]["TransactorPerson"].ToString();

            txtDepotPerson.Text = dtl.Rows[0]["DepotPersonName"].ToString();
            txtDepotPerson.Tag = dtl.Rows[0]["DepotPerson"].ToString();

            txtSupplier.Text = dtl.Rows[0]["SupplierName"].ToString();
            txtSupplier.Tag = dtl.Rows[0]["SupplierGuid"].ToString();

            txtBatchNO.Text = dtl.Rows[0]["BatchNo"].ToString();
 
            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
            
            txtCreateGuid.Tag = dtl.Rows[0]["CreateGuid"].ToString();
            txtCreateGuid.Text = dtl.Rows[0]["CreateName"].ToString();
            if (dtl.Rows[0]["CreateDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCreateDate.Text = dtl.Rows[0]["CreateDate"].ToString();
            }
            else
            {
                txtCreateDate.Text = "";
            }


            txtCheckGuid.Tag = dtl.Rows[0]["CheckGuid"].ToString();
            txtCheckGuid.Text = dtl.Rows[0]["CheckName"].ToString();

            if (dtl.Rows[0]["CheckDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }

            //判断是否已经审核
            if (txtCheckGuid.Text.Trim() != "")
            {
                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;
                tsbSave.Enabled = false;
            }
            else
            {
                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;
                tsbSave.Enabled = true;
            }


            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = ConsignManage.GetConsignDetail(ConsignGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "ConsignDetail";

            SetRight();
            this.ShowDialog();
        }
    

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("MaterialGuID");
            DataColumn _datacol2 = new DataColumn("MaterialID");
            DataColumn _datacol3 = new DataColumn("MaterialName");
            DataColumn _datacol4 = new DataColumn("Spec");
            DataColumn _datacol5 = new DataColumn("Unit");
            DataColumn _datacol6 = new DataColumn("MaterialSum");
            DataColumn _datacol7 = new DataColumn("Determinant");
        
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
     
            return _dt;
        }


      


        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtIncomeDepot.Text == "")
            {
                this.ShowAlertMessage("必须输入收货仓库!");
                return;
            }

            if (dtpConsignDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }


            if (txtBatchNO.Text.Trim().Length != 8)
            {
                this.ShowAlertMessage("批号请输入8位日期型,例 yyyyMMdd[20110101]!");
                return;

            }
            else
            {
                string strDate = txtBatchNO.Text.Substring(0, 4) + "-" + txtBatchNO.Text.Substring(4, 2) + "-" + txtBatchNO.Text.Substring(6, 2);
                if (IsDate(strDate) != true)
                {
                    this.ShowAlertMessage("批号输入格式不对，应该为8位日期型,例 yyyyMMdd[20110101]!");
                    return;
                }
            }



            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            Consign Consign = new Consign();
            Consign.ConsignGuid = txtConsignGuid.Text;
            Consign.ConsignID = txtConsignID.Text;
            Consign.ConsignDate = DateTime.Parse(dtpConsignDate.Text);
            if (txtIncomeDepot.Tag != null)
            {
                Consign.IncomeDepot = txtIncomeDepot.Tag.ToString();
            }
            if (txtPlant.Tag!= null)
            {
                Consign.Plant = txtPlant.Tag.ToString();
            }
            if (txtQualityPerson.Tag!= null)
            {
                Consign.QualityPerson = txtQualityPerson.Tag.ToString();
            }
            if (txtSatrapPerson.Tag != null)
            {
                Consign.SatrapPerson = txtSatrapPerson.Tag.ToString();
            }
            if (txtTransactorPerson.Tag != null)
            {
                Consign.TransactorPerson = txtTransactorPerson.Tag.ToString();
            }
            if (txtIncomeDepot.Tag!= null)
            {
                Consign.IncomeDepot = txtIncomeDepot.Tag.ToString();
            }

            if (txtDepotPerson.Tag != null)
            {
                Consign.DepotPerson = txtDepotPerson.Tag.ToString();
            }

            if (txtSupplier.Tag != null)
            {
                Consign.SupplierGuid = txtSupplier.Tag.ToString();
            }

            Consign.BatchNo = txtBatchNO.Text.Trim();
            Consign.Remark = txtRemark.Text;

            Consign.CreateGuid = txtCreateGuid.Tag.ToString();
            Consign.CreateDate = DateTime.Now;
            Consign.CheckGuid = "";
            Consign.CheckDate = DateTime.Parse("1900-01-01");
           



            List<ConsignDetail> list = new List<ConsignDetail>();
            ConsignDetail ConsignDetail = new ConsignDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                ConsignDetail = new ConsignDetail();
                ConsignDetail.ConsignGuid = txtConsignGuid.Text;
                ConsignDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    ConsignDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    ConsignDetail.MaterialSum = 0;
                }
                ConsignDetail.Determinant = dr["Determinant"].ToString();

                ConsignDetail.SortID = i;
                list.Add(ConsignDetail);
            }



            //保存
            ConsignManage.SaveBill(Consign, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "委外入库单保存", "保存", SysParams.UserName + "用户保存委外入库单,唯一号:" + txtConsignGuid.Text + ",委外入库单号:" + txtConsignID.Text);

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "ConsignDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmConsign.frmconsign.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该委外加工入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ConsignManage.CheckBill(txtConsignGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "委外入库单审核", "审核", SysParams.UserName + "用户审核委外入库单,唯一号:" + txtConsignGuid.Text + ",委外入库单号:" + txtConsignID.Text);

                //刷新列表界面
                frmConsign.frmconsign.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该委外加工入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ConsignManage.CheckBill(txtConsignGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbSave.Enabled = true;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "委外入库单反审", "反审", SysParams.UserName + "用户反审委外入库单,唯一号:" + txtConsignGuid.Text + ",委外入库单号:" + txtConsignID.Text);

                //刷新列表界面
                frmConsign.frmconsign.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtConsignID.Text = GetAutoId("Consign");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtConsignGuid.Text = Guid.NewGuid().ToString();


            txtQualityPerson.Text = "";
            txtQualityPerson.Tag = "";

            txtPlant.Text = "";
            txtPlant.Tag = "";

            txtIncomeDepot.Text = "";
            txtIncomeDepot.Tag = "";

            txtSatrapPerson.Text = "";
            txtSatrapPerson.Tag = "";

            txtTransactorPerson.Text = "";
            txtTransactorPerson.Tag = "";

            txtSupplier.Text = "";
            txtSupplier.Tag = "";

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

      

            ds.Tables.Clear();
        }

       

        private void btnDelDetail_Click_1(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null)
            {
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //得到料件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        Material material = new Material();
                        material = MaterialManage.GetMaterialByGuid(lstGuid[i]);

                        //填充数据
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID, material.MaterialGuID);
                        gridView1.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));

                    }




                }

            }
        }

     
     
        //经办人
        private void btnSelectTransactorPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtTransactorPerson.Text = ""; //名称
                    txtTransactorPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtTransactorPerson.Text = arrValue[1]; //名称
                        txtTransactorPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //主管
        private void btnSelectSatrapPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtSatrapPerson.Text = ""; //名称
                   txtSatrapPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSatrapPerson.Text = arrValue[1]; //名称
                        txtSatrapPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //品质员
        private void btnSelectQualityPerson_Click(object sender, EventArgs e)
        {

            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtQualityPerson.Text= ""; //名称
                   txtQualityPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtQualityPerson.Text = arrValue[1]; //名称
                        txtQualityPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //仓管员
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
                        txtDepotPerson.Text = arrValue[1]; //名称
                        txtDepotPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //车间
        private void btnSelectPlant_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(4);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                  txtPlant.Text = ""; //名称
                  txtPlant.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtPlant.Text = arrValue[1]; //名称
                        txtPlant.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //收货仓库
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

        private void btnStorageView_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuID"].ToString();
                frmGetMaterialStorageSum frmGetMaterialStorageSum = new frmGetMaterialStorageSum();
                frmGetMaterialStorageSum.LoadData(guid);
                frmGetMaterialStorageSum.Show(this);

            }

        }

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            //打印入库单
            XtraReportConsign XtraReportConsign = new XtraReportConsign(ds,txtConsignID.Text,dtpConsignDate.Text,txtPlant.Text,txtIncomeDepot.Text,txtTransactorPerson.Text,
                                    txtSatrapPerson.Text,txtQualityPerson.Text,txtDepotPerson.Text,txtSupplier.Text,txtBatchNO.Text,txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            XtraReportConsign.ShowPreview();
        }

        //选择供应商
        private void btnSelectSupplier_Click(object sender, EventArgs e)
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

    }
}