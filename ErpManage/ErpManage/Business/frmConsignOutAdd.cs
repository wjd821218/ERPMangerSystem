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
    /// 半成品入库新增
    /// </summary>
    public partial class frmConsignOutAdd :frmBase
    {
      
        MaterialManage MaterialManage = new MaterialManage();
        ConsignOutManage ConsignOutManage = new ConsignOutManage();
        DataSet ds = new DataSet();
        public frmConsignOutAdd()
        {
            InitializeComponent();
        }


        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ConsignOutPrint", "Print") == false)
            {
                tsbPrint.Enabled= false;
            }

        }


        //新增
        public void AddBill()
        {
            txtConsignOutID.Text = GetAutoId("ConsignOut");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtConsignOutGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
          

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string ConsignOutGuid)
        {
            txtConsignOutGuid.Text = ConsignOutGuid;
            DataTable dtl = ConsignOutManage.GetConsignOutByConsignOutGuid(ConsignOutGuid);

            txtConsignOutID.Text = dtl.Rows[0]["ConsignOutID"].ToString();
            dtpConsignOutDate.Text= DateTime.Parse(dtl.Rows[0]["ConsignOutDate"].ToString()).ToString("yyyy-MM-dd");

            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();

            txtPlant.Text = dtl.Rows[0]["PlantName"].ToString();
            txtPlant.Tag = dtl.Rows[0]["Plant"].ToString();

            txtOutcomeDepot.Text = dtl.Rows[0]["OutComeDepotName"].ToString();
            txtOutcomeDepot.Tag = dtl.Rows[0]["OutComeDepot"].ToString();

            txtSatrapPerson.Text = dtl.Rows[0]["SatrapPersonName"].ToString();
            txtSatrapPerson.Tag = dtl.Rows[0]["SatrapPerson"].ToString();

            txtTransactorPerson.Text = dtl.Rows[0]["TransactorPersonName"].ToString();
            txtTransactorPerson.Tag = dtl.Rows[0]["TransactorPerson"].ToString();

            txtDepotPerson.Text = dtl.Rows[0]["DepotPersonName"].ToString();
            txtDepotPerson.Tag = dtl.Rows[0]["DepotPerson"].ToString();

            txtArriveDate.Text = dtl.Rows[0]["ArriveDate"].ToString();


            txtSupplier.Text = dtl.Rows[0]["SupplierName"].ToString(); 
            txtSupplier.Tag = dtl.Rows[0]["SupplierGuid"].ToString(); 

            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
            txtInUnit.Text = dtl.Rows[0]["InUnit"].ToString();
            
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
            dtl2 = ConsignOutManage.GetConsignOutDetail(ConsignOutGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "ConsignOutDetail";

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

        //------------------------------------------------------------
        //判断当前需要出库的数量是否已经超过库存数量，如果超过则返回False
        public List<YJMaterialStorage> IsOverStorageNum()
        {
            List<YJMaterialStorage> lst = new List<YJMaterialStorage>();
            YJMaterialStorage YJMaterialStorage = new YJMaterialStorage();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                string strMaterialGuid = dr["MaterialGuID"].ToString();
                string strMaterialID = dr["MaterialID"].ToString();
                string strMaterialName = dr["MaterialName"].ToString();
                //得到当前料件在指定仓库中的数量
                DataTable dtl = MaterialManage.sp_GetOneStorageSumData(txtOutcomeDepot.Tag.ToString(), strMaterialGuid);

                if (dtl.Rows.Count > 0)
                {
                    decimal decMaterialSum = 0;
                    //库存中有数量，当前数量与库存中的比较，如果当前数量大于库存中的数量，则给出提示
                    if (dr["MaterialSum"].ToString().Trim() != "")
                    {
                        decMaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                    }

                    decimal decStorageSum = decimal.Parse(dtl.Rows[0]["StorageSum"].ToString());

                    if (decMaterialSum > decStorageSum)
                    {
                        YJMaterialStorage = new YJMaterialStorage();
                        YJMaterialStorage.MaterialID = strMaterialID;
                        YJMaterialStorage.MaterialName = strMaterialName;
                        YJMaterialStorage.MaterialSum = decMaterialSum;
                        YJMaterialStorage.StorageSum = decStorageSum;
                        YJMaterialStorage.StorageName = txtOutcomeDepot.Text;
                        lst.Add(YJMaterialStorage);

                    }

                }
            }
            return lst;

        }
        //---------------------------------------------------------


        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(1);
        }

        /// <summary>
        /// 保存类型
        /// </summary>
        /// <param name="SaveType">1-保存 2-保存并审核</param>
        /// <returns></returns>
        private bool SaveData(int SaveType)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtOutcomeDepot.Text == "")
            {
                this.ShowAlertMessage("必须输入发货仓库!");
                return false;
            }

            if (dtpConsignOutDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return false;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return false;
            }



            //-------------------------------------
            //是否开启数量超出库存预警
            if (MaterialManage.OverNumStorage(txtOutcomeDepot.Tag.ToString()) == true)
            {
                List<YJMaterialStorage> lst = IsOverStorageNum();
                if (lst.Count > 0)
                {
                    frmShowYJMaterial frmShowYJMaterial = new frmShowYJMaterial();
                    frmShowYJMaterial.ShowFillData(lst);
                    return false;
                }
            }
            //---------------------------------------

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            ConsignOut ConsignOut = new ConsignOut();
            ConsignOut.ConsignOutGuid = txtConsignOutGuid.Text;
            ConsignOut.ConsignOutID = txtConsignOutID.Text;
            ConsignOut.ConsignOutDate = DateTime.Parse(dtpConsignOutDate.Text);
            if (txtOutcomeDepot.Tag != null)
            {
                ConsignOut.OutcomeDepot = txtOutcomeDepot.Tag.ToString();
            }
            if (txtPlant.Tag != null)
            {
                ConsignOut.Plant = txtPlant.Tag.ToString();
            }
            if (txtQualityPerson.Tag != null)
            {
                ConsignOut.QualityPerson = txtQualityPerson.Tag.ToString();
            }
            if (txtSatrapPerson.Tag != null)
            {
                ConsignOut.SatrapPerson = txtSatrapPerson.Tag.ToString();
            }
            if (txtTransactorPerson.Tag != null)
            {
                ConsignOut.TransactorPerson = txtTransactorPerson.Tag.ToString();
            }
            if (txtOutcomeDepot.Tag != null)
            {
                ConsignOut.OutcomeDepot = txtOutcomeDepot.Tag.ToString();
            }

            if (txtDepotPerson.Tag != null)
            {
                ConsignOut.DepotPerson = txtDepotPerson.Tag.ToString();
            }

            if (txtSupplier.Tag != null)
            {
                ConsignOut.SupplierGuid = txtSupplier.Tag.ToString();
            }

            ConsignOut.ArriveDate = txtArriveDate.Text;
            ConsignOut.InUnit = txtInUnit.Text;
            ConsignOut.Remark = txtRemark.Text;

            ConsignOut.CreateGuid = txtCreateGuid.Tag.ToString();
            ConsignOut.CreateDate = DateTime.Now;
            ConsignOut.CheckGuid = "";
            ConsignOut.CheckDate = DateTime.Parse("1900-01-01");




            List<ConsignOutDetail> list = new List<ConsignOutDetail>();
            ConsignOutDetail ConsignOutDetail = new ConsignOutDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                ConsignOutDetail = new ConsignOutDetail();
                ConsignOutDetail.ConsignOutGuid = txtConsignOutGuid.Text;
                ConsignOutDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    ConsignOutDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    ConsignOutDetail.MaterialSum = 0;
                }
                ConsignOutDetail.Determinant = dr["Determinant"].ToString();

                ConsignOutDetail.SortID = i;
                list.Add(ConsignOutDetail);
            }



            //保存
            ConsignOutManage.SaveBill(ConsignOut, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "委外出库单保存", "保存", SysParams.UserName + "用户保存委外出库单,唯一号:" + txtConsignOutGuid.Text + ",委外出库单号:" + txtConsignOutID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "ConsignOutDetail";

            this.Tag = "edit";

            if (SaveType == 1)
            {
                this.ShowMessage("保存成功");
            }

            frmConsignOut.frmconsignout.LoadData();

            return true;
        
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该委外加工出库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (SaveData(2) == false)
                {
                    return;
                }

                //更新审核状态
                ConsignOutManage.CheckBill(txtConsignOutGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "委外出库单审核", "审核", SysParams.UserName + "用户审核委外出库单,唯一号:" + txtConsignOutGuid.Text + ",委外出库单号:" + txtConsignOutID.Text);

                //刷新列表界面
                frmConsignOut.frmconsignout.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该委外加工出库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ConsignOutManage.CheckBill(txtConsignOutGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "委外出库单反审", "反审", SysParams.UserName + "用户反审委外出库单,唯一号:" + txtConsignOutGuid.Text + ",委外出库单号:" + txtConsignOutID.Text);

                //刷新列表界面
                frmConsignOut.frmconsignout.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtConsignOutID.Text = GetAutoId("ConsignOut");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtConsignOutGuid.Text = Guid.NewGuid().ToString();


            txtQualityPerson.Text = "";
            txtQualityPerson.Tag = "";

            txtPlant.Text = "";
            txtPlant.Tag = "";

            txtOutcomeDepot.Text = "";
            txtOutcomeDepot.Tag = "";

            txtSatrapPerson.Text = "";
            txtSatrapPerson.Tag = "";

            txtTransactorPerson.Text = "";
            txtTransactorPerson.Tag = "";


            txtSupplier.Text = "";
            txtSupplier.Tag = "";

           txtArriveDate.Text = "";
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
                    txtOutcomeDepot.Text = ""; //名称
                    txtOutcomeDepot.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutcomeDepot.Text = arrValue[1]; //名称
                        txtOutcomeDepot.Tag = arrValue[0];  //Guid
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
            XtraReportConsignOut XtraReportConsignOut = new XtraReportConsignOut(ds, txtConsignOutID.Text, dtpConsignOutDate.Text, txtPlant.Text, txtOutcomeDepot.Text, txtTransactorPerson.Text,
                                    txtSatrapPerson.Text, txtQualityPerson.Text, txtDepotPerson.Text,txtInUnit.Text,txtSupplier.Text,txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text,txtArriveDate.Text);
            XtraReportConsignOut.ShowPreview();
        }

        //供应商
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

        /// <summary>
        /// 显示某个物料的入库批次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchNo_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["MaterialGuID"].ToString();
                frmGetMaterialBatchNo frmGetMaterialBatchNo = new frmGetMaterialBatchNo();
                frmGetMaterialBatchNo.LoadData(guid);
                frmGetMaterialBatchNo.Show(this);

            }
        }


    }
}