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
    /// 期初录入新增
    /// </summary>
    public partial class frmInitialGoodsAdd :frmBase
    {
      
        MaterialManage MaterialManage = new MaterialManage();
        InitialGoodsManage InitialGoodsManage = new InitialGoodsManage();
        DataSet ds = new DataSet();
        public frmInitialGoodsAdd()
        {
            InitializeComponent();
        }
        //权限判断
        public void SetRight()
        {

            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsSave", "Save") == false)
            //{
            //    btnAdd.Enabled = false;
            //    tsbSave.Enabled = false;
            //}

            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsCheck", "Check") == false)
            //{
            //    tsbCheck.Enabled = false;
            //}

            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsUnCheck", "UnCheck") == false)
            //{
            //    tsbUnCheck.Enabled = false;
            //}

            //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "InitialGoodsPrint", "Print") == false)
            //{
            //   tsbPrint.Enabled = false;
            //}

        }
       

        //新增
        public void AddBill()
        {
            txtInitialGoodsID.Text = GetAutoId("InitialGoods");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtInitialGoodsGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
          

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string InitialGoodsGuid)
        {
            txtInitialGoodsGuid.Text = InitialGoodsGuid;
            DataTable dtl = InitialGoodsManage.GetInitialGoodsByInitialGoodsGuid(InitialGoodsGuid);

            txtInitialGoodsID.Text = dtl.Rows[0]["InitialGoodsID"].ToString();
            dtpInitialGoodsDate.Text = DateTime.Parse(dtl.Rows[0]["InitialGoodsDate"].ToString()).ToString("yyyy-MM-dd");


            txtIncomeDepot.Text = dtl.Rows[0]["IncomeDepotName"].ToString();
            txtIncomeDepot.Tag = dtl.Rows[0]["IncomeDepot"].ToString();

       
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
            dtl2 = InitialGoodsManage.GetInitialGoodsDetail(InitialGoodsGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
           // DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
          //  ds.Tables.Clear();
           // ds.Tables.Add(dtl3.Copy());
           // ds.Tables[0].TableName = "InitialGoodsDetail";


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
           
        
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
       
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

            if (dtpInitialGoodsDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            InitialGoods InitialGoods = new InitialGoods();
            InitialGoods.InitialGoodsGuid = txtInitialGoodsGuid.Text;
            InitialGoods.InitialGoodsID = txtInitialGoodsID.Text;
            InitialGoods.InitialGoodsDate = DateTime.Parse(dtpInitialGoodsDate.Text);
            if (txtIncomeDepot.Tag != null)
            {
                InitialGoods.IncomeDepot = txtIncomeDepot.Tag.ToString();
            }
          
          
            InitialGoods.Remark = txtRemark.Text;

            InitialGoods.CreateGuid = txtCreateGuid.Tag.ToString();
            InitialGoods.CreateDate = DateTime.Now;
            InitialGoods.CheckGuid = "";
            InitialGoods.CheckDate = DateTime.Parse("1900-01-01");
           



            List<InitialGoodsDetail> list = new List<InitialGoodsDetail>();
            InitialGoodsDetail InitialGoodsDetail = new InitialGoodsDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                InitialGoodsDetail = new InitialGoodsDetail();
                InitialGoodsDetail.InitialGoodsGuid = txtInitialGoodsGuid.Text;
                InitialGoodsDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    InitialGoodsDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    InitialGoodsDetail.MaterialSum = 0;
                }
           

               
                list.Add(InitialGoodsDetail);
            }



            //保存
            InitialGoodsManage.SaveBill(InitialGoods, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "期初入库单保存", "保存", SysParams.UserName + "用户保存期初入库单,唯一号:" + txtInitialGoodsGuid.Text + ",期初入库单号:" + txtInitialGoodsID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "InitialGoodsDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmInitialGoods.frminitialgoods.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该期初入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                InitialGoodsManage.CheckBill(txtInitialGoodsGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "期初入库单审核", "审核", SysParams.UserName + "用户审核期初入库单,唯一号:" + txtInitialGoodsGuid.Text + ",期初入库单号:" + txtInitialGoodsID.Text);

                frmInitialGoods.frminitialgoods.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该期初入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                InitialGoodsManage.CheckBill(txtInitialGoodsGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "期初入库单反审", "反审", SysParams.UserName + "用户反审期初入库单,唯一号:" + txtInitialGoodsGuid.Text + ",期初入库单号:" + txtInitialGoodsID.Text);

                frmInitialGoods.frminitialgoods.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtInitialGoodsID.Text = GetAutoId("InitialGoods");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtInitialGoodsGuid.Text = Guid.NewGuid().ToString();


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
            //if (ds.Tables.Count <= 0)
            //{
            //    this.ShowAlertMessage("请保存数据后再打印!");
            //    return;
            //}

            ////打印入库单
            //XtraReportInitialGoods XtraReportInitialGoods = new XtraReportInitialGoods(ds,txtInitialGoodsID.Text , dtpInitialGoodsDate.Text,
            //                                                 txtPlant.Text, txtIncomeDepot.Text, txtTransactorPerson.Text,txtSatrapPerson.Text,txtQualityPerson.Text,txtDepotPerson.Text ,
            //                                                 txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            //XtraReportInitialGoods.ShowPreview();
        }

    }
}