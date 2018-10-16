using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using ErpManage.Business;
using ErpManage.PrintReport;

namespace ErpManage
{
    /// <summary>
    /// 客户订单
    /// </summary>
    public partial class frmClientOrderAdd : frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        ClientOrderManage ClientOrderManage = new ClientOrderManage();
        DataSet ds = new DataSet();
        public frmClientOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {
            
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false; 
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderCheck2", "Check2") == false)
            {
                tsbCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderUnCheck2", "UnCheck2") == false)
            {
                tsbUnCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderEnd", "End") == false)
            {
                tsbEnd.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ClientOrderPrint", "Print") == false)
            {
               tsbPrint.Enabled= false;
            }
        
        }

        //新增
        public void AddBill()
        {
            txtClientOrderID.Text = GetAutoId("ClientOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtClientOrderGuid.Text = Guid.NewGuid().ToString();

            this.gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;
            tsbEnd.Enabled = false;

            SetRight();

            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string ClientOrderGuid)
        {
            txtClientOrderGuid.Text = ClientOrderGuid;

            DataTable dtl = ClientOrderManage.GetClientOrderByClientOrderGuid(ClientOrderGuid);

            txtClientOrderGuid.Text = ClientOrderGuid;
            txtClientOrderID.Text = dtl.Rows[0]["ClientOrderID"].ToString();
            dtpClientOrderDate.Text = DateTime.Parse(dtl.Rows[0]["ClientOrderDate"].ToString()).ToString("yyyy-MM-dd");

            if (dtl.Rows[0]["EncasementDate"].ToString().Trim() == "")
            {
                dtpEncasementDate.Text = "";
            }
            else
            {
                dtpEncasementDate.Text =DateTime.Parse (dtl.Rows[0]["EncasementDate"].ToString()).ToString("yyyy-MM-dd");
            }

           
            txtContractID.Text = dtl.Rows[0]["ContractID"].ToString();
            txtCheckBatchID.Text = dtl.Rows[0]["CheckBatchID"].ToString();

            cboOrderType.Text = dtl.Rows[0]["OrderType"].ToString();


            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();

            //txtDownDept.Tag = dtl.Rows[0]["DownDept"].ToString();
            txtDownDept.Text = dtl.Rows[0]["DownDeptName"].ToString();

            //txtReceiveDept.Tag = dtl.Rows[0]["ReceiveDept"].ToString();
            txtReceiveDept.Text = dtl.Rows[0]["ReceiveDeptName"].ToString();
        
            txtCreateGuid.Tag = dtl.Rows[0]["CreateGuid"].ToString();
            txtCreateGuid.Text = dtl.Rows[0]["CreateName"].ToString();
            if (dtl.Rows[0]["CreateDate"].ToString().Trim() != "")
            {
               txtCreateDate.Text= dtl.Rows[0]["CreateDate"].ToString();
            }
            else
            {
                txtCreateDate.Text = "";
            }


            txtCheckGuid.Tag = dtl.Rows[0]["CheckGuid"].ToString();
            txtCheckGuid.Text = dtl.Rows[0]["CheckName"].ToString();

            if (dtl.Rows[0]["CheckDate"].ToString().Trim() != "")
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }


            txtCheckGuid2.Tag = dtl.Rows[0]["CheckGuid2"].ToString();
            txtCheckGuid2.Text = dtl.Rows[0]["CheckName2"].ToString();

            if (dtl.Rows[0]["CheckDate2"].ToString().Trim() != "")
            {
                txtCheckDate2.Text = dtl.Rows[0]["CheckDate2"].ToString();
            }
            else
            {
                txtCheckDate2.Text = "";
            }


            txtEndGuid.Tag = dtl.Rows[0]["EndGuid"].ToString();
            txtEndGuid.Text = dtl.Rows[0]["EndName"].ToString();

            if (dtl.Rows[0]["EndDate"].ToString().Trim() != "")
            {
                txtEndDate.Text = dtl.Rows[0]["EndDate"].ToString();
            }
            else
            {
                txtEndDate.Text = "";
            }
           
            //判断是否已经结单,结单后不能进行任何修改
            if (txtEndGuid.Text.Trim() != "")
            {
                tsbSave.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;

                if (txtCheckGuid2.Text.Trim() != "")
                {
                    tsbEnd.Enabled = false;
                }
                else
                {
                    tsbEnd.Enabled = true;
                }
            }
            else
            {
                //判断是否已经二级审核
                if (txtCheckGuid2.Text.Trim() != "")
                {
                    tsbSave.Enabled = false;

                    tsbCheck.Enabled = false;
                    tsbUnCheck.Enabled = false;

                    tsbCheck2.Enabled = false;
                    tsbUnCheck2.Enabled = true;

                    tsbEnd.Enabled = true;

                }
                else
                {   //是否一级审核
                    if (txtCheckGuid.Text.Trim() != "")
                    {
                        tsbSave.Enabled = false;

                        tsbCheck.Enabled = false;
                        tsbUnCheck.Enabled = true;

                        tsbCheck2.Enabled = true;
                        tsbUnCheck2.Enabled = false;

                        tsbEnd.Enabled = false;
                    }
                    else
                    {
                        tsbSave.Enabled = true;

                        tsbCheck.Enabled = true;
                        tsbUnCheck.Enabled = false;

                        tsbCheck2.Enabled = false;
                        tsbUnCheck2.Enabled = false;

                        tsbEnd.Enabled = false;
                    }
                }

            }

            //加载明细
            loadDetail(ClientOrderGuid);

            SetRight();


            DataTable dtl2 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl2.Copy());
            ds.Tables[0].TableName = "ClientOrderDetail";

          

            this.ShowDialog();
            
        }

        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("MaterialGuID");
            DataColumn _datacol2 = new DataColumn("MaterialID");
            DataColumn _datacol3 = new DataColumn("MaterialName");
            DataColumn _datacol4 = new DataColumn("Unit");
            DataColumn _datacol5 = new DataColumn("Spec");
            DataColumn _datacol6 = new DataColumn("MaterialSum");
            DataColumn _datacol7 = new DataColumn("ClientID");
            DataColumn _datacol8 = new DataColumn("PicID");
            DataColumn _datacol9 = new DataColumn("Remark");
         

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);
      

            return _dt;
        }


        //收单部门
        private void btnSelectDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData2 frmSelectOtherData2 = new frmSelectOtherData2();
            frmSelectOtherData2.ShowSelectData(2);
            if (frmSelectOtherData2.Tag != null)
            {
                if (frmSelectOtherData2.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtReceiveDept.Text = ""; //名称
                   
                }
                else
                {
                   
                    txtReceiveDept.Text = frmSelectOtherData2.Tag.ToString(); //名称
                   
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //下单部门
        private void btnSelectDownDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDownDept.Text = ""; //名称
                    txtDownDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDownDept.Text = arrValue[1]; //名称
                        txtDownDept.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //增加明细
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
                        gridView1.SetFocusedRowCellValue(gridClientID, material.ClientID);
                        gridView1.SetFocusedRowCellValue(gridPicID, material.PicID);
                        gridView1.SetFocusedRowCellValue(gridRemark,"" );
                    }

                  


                }

            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        //载入明细物料数据
        private void loadDetail(string clientorderguid)
        {
            DataTable dtl = new DataTable();
            dtl=ClientOrderManage.GetClientOrderDetail(clientorderguid);
            gridControl1.DataSource = dtl;

            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "ClientOrderDetail";
        }

        //保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
           


            txtRemark.Focus();
            gridView1.UpdateCurrentRow();
            if (dtpClientOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入下单日期!");
                return;
            }

            if (cboOrderType.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择订单类别!");
                cboOrderType.Focus();
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


            ClientOrder ClientOrder = new ClientOrder();
            ClientOrder.ClientOrderGuid = txtClientOrderGuid.Text;
            ClientOrder.ClientOrderID = txtClientOrderID.Text;
            ClientOrder.ClientOrderDate = DateTime.Parse(dtpClientOrderDate.Text);
            if (dtpEncasementDate.Text.Trim() == "")
            {
                ClientOrder.EncasementDate = DateTime.Parse("1900-01-01");
            }
            else
            {
                ClientOrder.EncasementDate = DateTime.Parse(dtpEncasementDate.Text);
            }
            ClientOrder.ContractID = txtContractID.Text;
            ClientOrder.CheckBatchID = txtCheckBatchID.Text;
            if (txtDownDept.Tag != null)
            {
                ClientOrder.DownDept = txtDownDept.Tag.ToString();
            }

            ClientOrder.ReceiveDept = txtReceiveDept.Text;

            ClientOrder.OrderType = cboOrderType.Text;

            ClientOrder.Remark = txtRemark.Text;
            ClientOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            ClientOrder.CreateDate = DateTime.Now;
            ClientOrder.CheckGuid = "";
            ClientOrder.CheckDate = DateTime.Parse("1900-01-01");
            ClientOrder.CheckGuid2 = "";
            ClientOrder.CheckDate2 = DateTime.Parse("1900-01-01");
            ClientOrder.EndGuid = "";
            ClientOrder.EndDate = DateTime.Parse("1900-01-01");



            List<ClientOrderDetail> list = new List<ClientOrderDetail>();
            ClientOrderDetail ClientOrderDetail = new ClientOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                ClientOrderDetail = new ClientOrderDetail();
                ClientOrderDetail.ClientOrderGuid = ClientOrder.ClientOrderGuid;
                ClientOrderDetail.MaterialGuid = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    ClientOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    ClientOrderDetail.MaterialSum = 0;
                }


                ClientOrderDetail.Remark = dr["Remark"].ToString(); //gridView1.GetRowCellValue(i, gridProductGuid).ToString();


                list.Add(ClientOrderDetail);

            }



            //保存
            ClientOrderManage.SaveBill(ClientOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;


            DataTable dtl = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl.Copy());
            ds.Tables[0].TableName = "ClientOrderDetail";

         

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "客户订单保存", "保存", SysParams.UserName + "用户保存了客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);



            this.Tag = "edit";
            this.ShowMessage("保存成功");
            

            frmClientOrder.frmclientorder.LoadData();
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定审核该客户订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ClientOrderManage.CheckBill(txtClientOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;

                tsbEnd.Enabled = false;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "客户订单审核", "审核", SysParams.UserName + "用户审核了客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);

                //刷新列表界面
                frmClientOrder.frmclientorder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("确定反审该客户订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ClientOrderManage.CheckBill(txtClientOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;

                tsbEnd.Enabled = false;

                tsbSave.Enabled = true;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "客户订单审核", "反审", SysParams.UserName + "用户反审了客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);


                //刷新列表界面
                frmClientOrder.frmclientorder.LoadData();
            }
        }

        private void tsbEnd_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("确定对此客户订单结单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                //更新审核状态
                ClientOrderManage.EndBill(txtClientOrderGuid.Text);

                //设置为：已审核
                //SetControlEnable(1)

                txtEndDate.Text = DateTime.Now.ToString();
                txtEndGuid.Tag = SysParams.UserID;
                txtEndGuid.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;


                tsbSave.Enabled = false;
                tsbEnd.Enabled = false;

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "客户订单结单", "结单", SysParams.UserName + "用户结单客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);

                //刷新列表界面
                frmClientOrder.frmclientorder.LoadData();
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
          

            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            //打印入库单
            XtraReportClientOrder XtraReportClientOrder = new XtraReportClientOrder(ds, txtClientOrderID.Text, dtpClientOrderDate.Text, dtpEncasementDate.Text,
                                                             txtContractID.Text, txtCheckBatchID.Text, txtDownDept.Text, txtReceiveDept.Text, txtRemark.Text,
                                                             txtCreateGuid.Text,txtCreateDate.Text,txtCheckGuid.Text,txtCheckDate.Text,txtCheckGuid2.Text,txtCheckDate2.Text
                                                             );
            XtraReportClientOrder.ShowPreview();
        }

        private void tsbCheck2_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("确定二级审该客户订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ClientOrderManage.CheckBill2(txtClientOrderGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = DateTime.Now.ToString();
                txtCheckGuid2.Tag = SysParams.UserID;
                txtCheckGuid2.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;

                tsbEnd.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "客户订单二级审该", "二级审该", SysParams.UserName + "用户二级审该客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);

                //刷新列表界面
                frmClientOrder.frmclientorder.LoadData();
            }
        }

        private void tsbUnCheck2_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("确定二级审该客户订单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ClientOrderManage.CheckBill2(txtClientOrderGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = "";
                txtCheckGuid2.Tag = "";
                txtCheckGuid2.Text = "";

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;

                tsbEnd.Enabled = false;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "客户订单二级反审", "二级反审", SysParams.UserName + "用户二级反审客户订单,订单唯一号:" + txtClientOrderGuid.Text + "订单号:" + txtClientOrderID.Text);

                //刷新列表界面
                frmClientOrder.frmclientorder.LoadData();
            }
        }

        private void repositoryItemSpinEdit2_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtClientOrderID.Text = GetAutoId("ClientOrder");
            txtClientOrderGuid.Text = Guid.NewGuid().ToString();
   
            txtContractID.Text ="";
            txtCheckBatchID.Text = "";
            cboOrderType.Text = "";
            txtRemark.Text = "";

            txtDownDept.Tag = "";
            txtDownDept.Text = "";

            txtReceiveDept.Tag = "";
            txtReceiveDept.Text = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtCheckDate.Text = "";
            txtCheckGuid.Text = "";
            txtCheckGuid.Tag = "";

            txtCheckDate2.Text = "";
            txtCheckGuid2.Text = "";
            txtCheckGuid2.Tag = "";

            txtEndDate.Text = "";
            txtEndGuid.Text = "";
            txtEndGuid.Tag = "";

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;
            tsbEnd.Enabled = false;

            this.gridControl1.DataSource = IniBindTable();

            ds.Tables.Clear();
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


       
       
    }
}