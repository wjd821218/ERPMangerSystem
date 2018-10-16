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
    ///  退料入库单新增
    /// </summary>
    public partial class frmQuitStorageOrderAdd :frmBase
    {
         MaterialManage MaterialManage = new MaterialManage();
        QuitStorageOrderManage QuitStorageOrderManage = new QuitStorageOrderManage();
        DataSet ds = new DataSet();

        public frmQuitStorageOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "QuitStorageOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled= false;
            }

        }

        //新增
        public void AddBill()
        {
            txtQuitStorageOrderID.Text = GetAutoId("QuitStorageOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtQuitStorageOrderGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
          

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string QuitStorageOrderGuid)
        {
            txtQuitStorageOrderGuid.Text = QuitStorageOrderGuid;
            DataTable dtl = QuitStorageOrderManage.GetQuitStorageOrderByQuitStorageOrderGuid(QuitStorageOrderGuid);

            txtQuitStorageOrderID.Text = dtl.Rows[0]["QuitStorageOrderID"].ToString();
            dtpQuitStorageOrderDate.Text = DateTime.Parse(dtl.Rows[0]["QuitStorageOrderDate"].ToString()).ToString("yyyy-MM-dd");

            txtInStorage.Text = dtl.Rows[0]["InStorageName"].ToString();
            txtInStorage.Tag = dtl.Rows[0]["InStorage"].ToString();

            txtQualityPerson.Text = dtl.Rows[0]["QualityPersonName"].ToString();
            txtQualityPerson.Tag = dtl.Rows[0]["QualityPerson"].ToString();


            txtMaterialPerson.Text = dtl.Rows[0]["MaterialPersonName"].ToString();
            txtMaterialPerson.Tag = dtl.Rows[0]["MaterialPerson"].ToString();

            txtStoragePerson.Text = dtl.Rows[0]["StoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["StoragePerson"].ToString();



            txtDept.Text = dtl.Rows[0]["DeptName"].ToString();
            txtDept.Tag = dtl.Rows[0]["Dept"].ToString();


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
            dtl2 = QuitStorageOrderManage.GetQuitStorageOrderDetail(QuitStorageOrderGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "QuitStorageOrderDetail";

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
            DataColumn _datacol7 = new DataColumn("Remark");
        
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

            if (txtInStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入收货仓库!");
                return;
            }

            if (dtpQuitStorageOrderDate.Text == "")
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


            QuitStorageOrder QuitStorageOrder = new QuitStorageOrder();
            QuitStorageOrder.QuitStorageOrderGuid = txtQuitStorageOrderGuid.Text;
            QuitStorageOrder.QuitStorageOrderID = txtQuitStorageOrderID.Text;
            QuitStorageOrder.QuitStorageOrderDate = DateTime.Parse(dtpQuitStorageOrderDate.Text);
            if (txtInStorage.Tag  != null)
            {
                QuitStorageOrder.InStorage = txtInStorage.Tag.ToString();
            }
            if (txtQualityPerson.Tag != null)
            {
                QuitStorageOrder.QualityPerson = txtQualityPerson.Tag.ToString();
            }
            if (txtMaterialPerson.Tag!= null)
            {
                QuitStorageOrder.MaterialPerson = txtMaterialPerson.Tag.ToString();
            }
            if (txtDept.Tag != null)
            {
                QuitStorageOrder.Dept = txtDept.Tag.ToString();
            }
            if (txtStoragePerson.Tag!= null)
            {
                QuitStorageOrder.StoragePerson = txtStoragePerson.Tag.ToString();
            }
            QuitStorageOrder.BatchNo = txtBatchNO.Text;
            QuitStorageOrder.Remark = txtRemark.Text;

            QuitStorageOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            QuitStorageOrder.CreateDate = DateTime.Now;
            QuitStorageOrder.CheckGuid = "";
            QuitStorageOrder.CheckDate = DateTime.Parse("1900-01-01");
           



            List<QuitStorageOrderDetail> list = new List<QuitStorageOrderDetail>();
            QuitStorageOrderDetail QuitStorageOrderDetail = new QuitStorageOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                QuitStorageOrderDetail = new QuitStorageOrderDetail();
                QuitStorageOrderDetail.QuitStorageOrderGuid = txtQuitStorageOrderGuid.Text;
                QuitStorageOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    QuitStorageOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    QuitStorageOrderDetail.MaterialSum = 0;
                }

                QuitStorageOrderDetail.Remark = dr["Remark"].ToString();
                QuitStorageOrderDetail.SortID = i;
                list.Add(QuitStorageOrderDetail);
            }



            //保存
            QuitStorageOrderManage.SaveBill(QuitStorageOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "退料入库单保存", "保存", SysParams.UserName + "用户保存退料入库单,唯一号:" + txtQuitStorageOrderGuid.Text + ",退料入库单号:" + txtQuitStorageOrderID.Text);

            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "QuitStorageOrderDetail";

            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmQuitStorageOrder.frmQuitStorageOrde.LoadData();
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该退料入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                QuitStorageOrderManage.CheckBill(txtQuitStorageOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "退料入库单审核", "审核", SysParams.UserName + "用户审核退料入库单,唯一号:" + txtQuitStorageOrderGuid.Text + ",退料入库单号:" + txtQuitStorageOrderID.Text);

                frmQuitStorageOrder.frmQuitStorageOrde.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该退料入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                QuitStorageOrderManage.CheckBill(txtQuitStorageOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "退料入库单反审", "反审", SysParams.UserName + "用户反审退料入库单,唯一号:" + txtQuitStorageOrderGuid.Text + ",退料入库单号:" + txtQuitStorageOrderID.Text);


                frmQuitStorageOrder.frmQuitStorageOrde.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtQuitStorageOrderID.Text = GetAutoId("QuitStorageOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtQuitStorageOrderGuid.Text = Guid.NewGuid().ToString();


            txtInStorage.Tag = "";
            txtInStorage.Text = "";
            txtMaterialPerson.Tag = "";
            txtMaterialPerson.Text = "";
            txtStoragePerson.Tag = "";
            txtStoragePerson.Text = "";
            txtDept.Tag= "";
            txtDept.Text = "";
            txtQualityPerson.Tag = "";
            txtQualityPerson.Text = "";
           
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

        //仓库管员
        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtStoragePerson.Text = ""; //名称
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //名称
                        txtStoragePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //物料员
        private void btnSelectMaterialPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtMaterialPerson.Text = ""; //名称
                    txtMaterialPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtMaterialPerson.Text = arrValue[1]; //名称
                        txtMaterialPerson.Tag = arrValue[0];  //Guid
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
                    txtQualityPerson.Text = ""; //名称
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

        //退料仓库
        private void btnSelectInStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtInStorage.Text = ""; //名称
                    txtInStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtInStorage.Text = arrValue[1]; //名称
                        txtInStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //部门
        private void btnSelectDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtDept.Text= ""; //名称
                   txtDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDept.Text = arrValue[1]; //名称
                        txtDept.Tag = arrValue[0];  //Guid
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

        private void repositoryItemSpinEdit1_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
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
            XtraReportQuitStorageOrder XtraReportQuitStorageOrder = new XtraReportQuitStorageOrder(ds,txtQuitStorageOrderID.Text,dtpQuitStorageOrderDate.Text,txtDept.Text  ,
                                                                txtInStorage.Text,txtMaterialPerson.Text,txtStoragePerson.Text,txtQualityPerson.Text, 
                                                            txtBatchNO.Text, txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            XtraReportQuitStorageOrder.ShowPreview();
        }

       
    }
}