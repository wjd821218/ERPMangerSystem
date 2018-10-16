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
using DevExpress.XtraReports.UI;

namespace ErpManage
{
    /// <summary>
    /// 领料单新增
    /// 
    /// 
    /// 修改1：增加请领数一列 2010-8-4
    /// </summary>
    public partial class frmDrawOrderAdd :frmBase
    {
        MaterialManage MaterialManage = new MaterialManage();
        DrawOrderManage DrawOrderManage = new DrawOrderManage();
        DrawPlanManage DrawPlanManage = new DrawPlanManage();
        DataSet ds = new DataSet();
        DataSet dsConsume = new DataSet();
  
        public frmDrawOrderAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "DrawOrderPrint", "Print") == false)
            {
                tsbPrint.Enabled = false;
            }


        }

        //新增
        public void AddBill()
        {
            txtDrawOrderID.Text = GetAutoId("DrawOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtDrawOrderGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();
            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
           

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string DrawOrderGuid)
        {
            txtDrawOrderGuid.Text = DrawOrderGuid;
            DataTable dtl = DrawOrderManage.GetDrawOrderByDrawOrderGuid(DrawOrderGuid);

            txtDrawOrderID.Text = dtl.Rows[0]["DrawOrderID"].ToString();
            dtpDrawOrderDate.Text = DateTime.Parse(dtl.Rows[0]["DrawOrderDate"].ToString()).ToString("yyyy-MM-dd");

            txtDrawPerson.Text = dtl.Rows[0]["DrawPersonName"].ToString();
            txtDrawPerson.Tag = dtl.Rows[0]["DrawPerson"].ToString();

            txtEmitPerson.Text = dtl.Rows[0]["EmitPersonName"].ToString();
            txtEmitPerson.Tag = dtl.Rows[0]["EmitPerson"].ToString();

            txtOutStorage.Text = dtl.Rows[0]["OutStorageName"].ToString();
            txtOutStorage.Tag = dtl.Rows[0]["OutStorage"].ToString();
 
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
            dtl2 = DrawOrderManage.GetDrawOrderDetail(DrawOrderGuid);
            gridControl1.DataSource = dtl2;

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "DrawOrderDetail";


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
            DataColumn _datacol6 = new DataColumn("ConsumeSum");
            DataColumn _datacol7 = new DataColumn("MaterialSum");
            DataColumn _datacol8 = new DataColumn("ApplyMaterialSum");
        
            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
     
            return _dt;
        }


        private void btnSelectDrawPlan_Click(object sender, EventArgs e)
        {
            //frmSelectStockOrder frmSelectStockOrder = new frmSelectStockOrder();
            //frmSelectStockOrder.ShowDialog();

            //if (frmSelectStockOrder.Tag != null)
            //{
            //    //取出选择的料件Guid
            //    List<SelectStockOrderDetail> lstGuid = frmSelectStockOrder.Tag as List<SelectStockOrderDetail>;
            //    SelectStockOrderDetail SelectStockOrderDetail = new SelectStockOrderDetail();

            //    //选择的品名填充
            //    if (lstGuid.Count > 0)
            //    {
                 
            //        //得到料件的信息
            //        for (int i = 0; i < lstGuid.Count; i++)
            //        {
            //            SelectStockOrderDetail = lstGuid[i] as SelectStockOrderDetail;

            //            //填充数据
            //            gridView1.AddNewRow();
            //            gridView1.SetFocusedRowCellValue(gridStockOrderGuid, SelectStockOrderDetail.StockOrderGuid);
            //            gridView1.SetFocusedRowCellValue(gridStockOrderID, SelectStockOrderDetail.StockOrderID);
            //            gridView1.SetFocusedRowCellValue(gridStockOrderDetailGuid, SelectStockOrderDetail.StockOrderDetailGuid);
            //            gridView1.SetFocusedRowCellValue(gridMaterialGuID, SelectStockOrderDetail.MaterialGuID);
            //            gridView1.SetFocusedRowCellValue(gridMaterialID, SelectStockOrderDetail.MaterialID);
            //            gridView1.SetFocusedRowCellValue(gridMaterialName, SelectStockOrderDetail.MaterialName);
            //            gridView1.SetFocusedRowCellValue(gridUnit, SelectStockOrderDetail.Unit);
            //            gridView1.SetFocusedRowCellValue(gridSpec, SelectStockOrderDetail.Spec);
            //            gridView1.SetFocusedRowCellValue(gridMaterialSum, SelectStockOrderDetail.MaterialSum);
            //            gridView1.SetFocusedRowCellValue(gridStorageSum, SelectStockOrderDetail.CanInSum);

            //        }




            //    }

            //}
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
                DataTable dtl = MaterialManage.sp_GetOneStorageSumData(txtOutStorage.Tag.ToString(), strMaterialGuid);

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
                        YJMaterialStorage.StorageName = txtOutStorage.Text;
                        lst.Add(YJMaterialStorage);

                    }

                }
            }
            return lst;

        }
        //---------------------------------------------------------


        
          





        //保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(1);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="SaveType">保存类型：1-保存 2-审核并保存</param>
        /// <returns></returns>
        private bool SaveData(int SaveType)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtDrawPerson.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入领料人!");
                return false;
            }

            if (dtpDrawOrderDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return false;
            }

            // if (txtEmitPerson.Text.Trim() == "")
            //{
            //    this.ShowAlertMessage("必须输入发料人!");
            //    return;
            // }

            if (txtOutStorage.Text.Trim() == "")
            {
                this.ShowAlertMessage("必须输入领料仓库!");
                return false;
            }


            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return false;
            }


            //-------------------------------------
            //是否开启数量超出库存预警
            if (MaterialManage.OverNumStorage(txtOutStorage.Tag.ToString()) == true)
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


            DrawOrder DrawOrder = new DrawOrder();
            DrawOrder.DrawOrderGuid = txtDrawOrderGuid.Text;
            DrawOrder.DrawOrderID = txtDrawOrderID.Text;
            DrawOrder.DrawOrderDate = DateTime.Parse(dtpDrawOrderDate.Text);
            if (txtDrawPerson.Tag != null)
            {
                DrawOrder.DrawPerson = txtDrawPerson.Tag.ToString();
            }
            if (txtEmitPerson.Tag != null)
            {
                DrawOrder.EmitPerson = txtEmitPerson.Tag.ToString();
            }
            if (txtOutStorage.Tag != null)
            {
                DrawOrder.OutStorage = txtOutStorage.Tag.ToString();
            }

            DrawOrder.Remark = txtRemark.Text;

            DrawOrder.CreateGuid = txtCreateGuid.Tag.ToString();
            DrawOrder.CreateDate = DateTime.Now;
            DrawOrder.CheckGuid = "";
            DrawOrder.CheckDate = DateTime.Parse("1900-01-01");




            List<DrawOrderDetail> list = new List<DrawOrderDetail>();
            DrawOrderDetail DrawOrderDetail = new DrawOrderDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                DrawOrderDetail = new DrawOrderDetail();
                DrawOrderDetail.DrawOrderGuid = txtDrawOrderGuid.Text;
                DrawOrderDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["ConsumeSum"].ToString().Trim() != "")
                {
                    DrawOrderDetail.ConsumeSum = decimal.Parse(dr["ConsumeSum"].ToString());
                }
                else
                {
                    DrawOrderDetail.ConsumeSum = 0;
                }

                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    DrawOrderDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    DrawOrderDetail.MaterialSum = 0;
                }

                if (dr["ApplyMaterialSum"].ToString().Trim() != "")
                {
                    DrawOrderDetail.ApplyMaterialSum = decimal.Parse(dr["ApplyMaterialSum"].ToString());
                }
                else
                {
                    DrawOrderDetail.ApplyMaterialSum = 0;
                }
                DrawOrderDetail.SortID = i;
                list.Add(DrawOrderDetail);
            }



            //保存
            DrawOrderManage.SaveBill(DrawOrder, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "领料单保存", "保存", SysParams.UserName + "用户保存领料单,唯一号:" + txtDrawOrderGuid.Text + ",领料单单号:" + txtDrawOrderID.Text);


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "DrawOrderDetail";


            this.Tag = "edit";

            //保存时才出现保存成功提示，审核时，先保存数据后再审核
            if (SaveType == 1)
            {
                this.ShowMessage("保存成功");
            }

            frmDrawOrder.frmdraworder.LoadData();

            //正确则返回
            return true;
        
        }



        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该领料单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //审核前要先保存
                if (SaveData(2) == false)
                {
                    return;
                }

                //更新审核状态
                DrawOrderManage.CheckBill(txtDrawOrderGuid.Text, 1);

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
                SysLog.AddOperateLog(SysParams.UserName, "领料单审核", "审核", SysParams.UserName + "用户审核领料单,唯一号:" + txtDrawOrderGuid.Text + ",领料单单号:" + txtDrawOrderID.Text);

                //刷新列表界面
                frmDrawOrder.frmdraworder.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该领料单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                DrawOrderManage.CheckBill(txtDrawOrderGuid.Text, 0);

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
                SysLog.AddOperateLog(SysParams.UserName, "领料单反审", "反审", SysParams.UserName + "用户反审领料单,唯一号:" + txtDrawOrderGuid.Text + ",领料单单号:" + txtDrawOrderID.Text);

                //刷新列表界面
                frmDrawOrder.frmdraworder.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDrawOrderID.Text = GetAutoId("DrawOrder");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtDrawOrderGuid.Text = Guid.NewGuid().ToString();

            txtDrawPerson.Text = "";
            txtDrawPerson.Tag = "";

            txtEmitPerson.Text = "";
            txtEmitPerson.Tag = "";

            txtOutStorage.Text = "";
            txtOutStorage.Tag = "";
 

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;


            ds.Tables.Clear();
        }

        //领料人
        private void btnSelectDrawPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtDrawPerson.Text  = ""; //名称
                   txtDrawPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtDrawPerson.Text = arrValue[1]; //名称
                        txtDrawPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //发料人
        private void btnSelectEmitPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtEmitPerson.Text = ""; //名称
                    txtEmitPerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtEmitPerson.Text = arrValue[1]; //名称
                        txtEmitPerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //领料仓库
        private void btnSelectOutStorage_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtOutStorage.Text = ""; //名称
                   txtOutStorage.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtOutStorage.Text = arrValue[1]; //名称
                        txtOutStorage.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnDelDetail_Click_1(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();

            frmSelectMaterial2 frmSelectMaterial2 = new frmSelectMaterial2();
            frmSelectMaterial2.ShowDialog();

            if (frmSelectMaterial2.Tag != null)
            {
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial2.Tag as List<string>;

                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //组建物料sql
                    string strsql = " where 1<>1 ";
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        strsql = strsql + " or MaterialGuid='" + lstGuid[i] + "'";
                    }

                    //加载单耗
                    DataSet dsetConsume = new DataSet();
                    if (frmSelectMaterial2.txtQryValue.Text.Trim() != "")
                    {
                        if (frmSelectMaterial2.txtQryValue.Tag != null)
                        {
                            //确认是点击了BOM查询
                            dsetConsume = MaterialBOMManage.sp_GetMaterialBomConsumeByDrawOrder(strsql, frmSelectMaterial2.txtQryValue.Tag.ToString());

                        }
                    }

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

                        //加载单耗
                        if (frmSelectMaterial2.txtQryValue.Text.Trim() != "")
                        {
                            if (frmSelectMaterial2.txtQryValue.Tag != null)
                            {
                                decimal decConsumeSum = GetConsumeSum(material.MaterialGuID, dsetConsume);

                                gridView1.SetFocusedRowCellValue(gridConsumeSum, decConsumeSum.ToString("g0"));



                            }


                        }


                    }




                }

            }
        }

        /// <summary>
        ///得到物料在某个成品下的单耗
        /// </summary>
        public decimal GetConsumeSum(string materialguid, DataSet dset)
        {
            DataRow[] dr;

            dr = dset.Tables[0].Select("MaterialGuid='" + materialguid + "'");

            if (dr.Length > 0)
            {
                return decimal.Parse(dr[0]["MaterialSum"].ToString());
            }
            else
            {
                return 0;
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

        private void btnSelectDrawPlan_Click_1(object sender, EventArgs e)
        {
            frmSelectDrawPlan frmSelectDrawPlan = new frmSelectDrawPlan();
            frmSelectDrawPlan.ShowDialog();

            if (frmSelectDrawPlan.Tag != null)
            {
                //得到选中的物料需求计划物料数据信息
                List<String> list = new List<string>();
                list = (List<String>)frmSelectDrawPlan.Tag;


                //得到客户订单的明细数据,组件sql
                if (list.Count > 0)
                {
                    DataTable dtl = new DataTable();
                    if (list[1].Trim() == "")
                    {
                        dtl = DrawPlanManage.GetDrawPlanCalcSumByDrawPlanGuid(list[0]);
                    }
                    else
                    {
                        dtl = DrawPlanManage.GetDrawPlanCalcSumByDrawPlanGuid(list[0],list[1]);
                    }


                    //得到当前成品的Guid
                    MaterialBOMManage MaterialBOMManage=new MaterialBOMManage();
                    string strProductMaterialGuid = DrawPlanManage.GetDrawPlanFatherMaterialGuid(list[0].Trim());

                    //执行得到产品下面的子件数据记录
                    dsConsume = MaterialBOMManage.sp_GetMaterialBomConsume(strProductMaterialGuid);


                    //填充数据     
                    for (int j = 0; j < dtl.Rows.Count; j++)
                    {
                        //将选择的客户订单的数据加载过来
                        //填充数据
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID  , dtl.Rows[j]["MaterialGuID"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialID, dtl.Rows[j]["MaterialID"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialName, dtl.Rows[j]["MaterialName"].ToString());
                        gridView1.SetFocusedRowCellValue(gridUnit, dtl.Rows[j]["Unit"].ToString());
                        gridView1.SetFocusedRowCellValue(gridSpec, dtl.Rows[j]["Spec"].ToString());
                        gridView1.SetFocusedRowCellValue(gridMaterialSum, "0");


                        gridView1.SetFocusedRowCellValue(gridApplyMaterialSum, decimal.Parse(dtl.Rows[j]["RequirementSum"].ToString()).ToString("g0"));

                        if (GetFieldDataValue(dtl.Rows[j]["MaterialGuID"].ToString()).Trim() != "")
                        {
                            gridView1.SetFocusedRowCellValue(gridConsumeSum, decimal.Parse(GetFieldDataValue(dtl.Rows[j]["MaterialGuID"].ToString())).ToString("g0"));
                        }
                        else
                        {
                            gridView1.SetFocusedRowCellValue(gridConsumeSum, "0");
                        }

                    }
                }
            }
        }


        /// <summary>
        ///得到料件的单耗(子件的用量)
        /// </summary>
        public string   GetFieldDataValue(string MaterialGuid)
        {
           


            DataRow[] dr;

            dr = dsConsume.Tables[0].Select("MaterialGuid='" + MaterialGuid.Trim() + "'");


            if (dr.Length > 0)
            {

                return dr[0]["MaterialSum"].ToString();
            }
            else
            {
                return "";
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }
            

            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("DrawOrderID");
            DataColumn _datacol2 = new DataColumn("DrawOrderDate");
            DataColumn _datacol3 = new DataColumn("DrawPerson");
            DataColumn _datacol4 = new DataColumn("EmitPerson");
            DataColumn _datacol5 = new DataColumn("OutStorage");
            DataColumn _datacol6 = new DataColumn("Remark");
            DataColumn _datacol7 = new DataColumn("CreateGuid");
            DataColumn _datacol8 = new DataColumn("CreateDate");
            DataColumn _datacol9 = new DataColumn("CheckGuid");
            DataColumn _datacol10 = new DataColumn("CheckDate");
            DataColumn _datacol11 = new DataColumn("PrintTime");


            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);
            _dt.Columns.Add(_datacol10);
            _dt.Columns.Add(_datacol11);

             DataRow _datarow1 = _dt.NewRow();
            _dt.Rows.Add(_datarow1);
            _dt.Rows[0]["DrawOrderID"] = txtDrawOrderID.Text;
            _dt.Rows[0]["DrawOrderDate"] =dtpDrawOrderDate.Text;
            _dt.Rows[0]["DrawPerson"] = txtDrawPerson.Text;
            _dt.Rows[0]["EmitPerson"] = txtEmitPerson.Text;
            _dt.Rows[0]["OutStorage"] = txtOutStorage.Text;
            _dt.Rows[0]["Remark"] = txtRemark.Text;
            _dt.Rows[0]["CreateGuid"] = txtCreateGuid.Text;
            _dt.Rows[0]["CreateDate"] = txtCreateDate.Text;
            _dt.Rows[0]["CheckGuid"] = txtCheckGuid.Text;
            _dt.Rows[0]["CheckDate"] = txtCheckDate.Text;
            _dt.Rows[0]["PrintTime"] =DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


            _dt.TableName = "DrawOrder";

             DataSet ds1 = new DataSet();
             ds1.Tables.Add(_dt);
             ds1.Tables.Add(ds.Tables["DrawOrderDetail"].Copy());


             //XtraReport report = new XtraReport();
             //report.LoadLayout("XtraReportDrawOrder2.repx");
             //report.DataMember = "DrawOrderDetail";
             //report.DataSource = ds1;
             //report.CreateDocument();
             //report.ShowPreview();


             XtraReportDrawOrder XtraReportDrawOrder = new XtraReportDrawOrder();
             XtraReportDrawOrder.DataSource = ds1;
             XtraReportDrawOrder.DataMember = "DrawOrderDetail";
             XtraReportDrawOrder.ShowPreview();
           

            //打印领料单
          //  XtraReportDrawOrder XtraReportDrawOrder = new XtraReportDrawOrder(ds, txtDrawOrderID.Text, dtpDrawOrderDate.Text,
              //                                              txtDrawPerson.Text, txtEmitPerson.Text,txtOutStorage.Text, txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
           // XtraReportDrawOrder.ShowDesigner();
        }


        //按产品BOM来增加物料明细
        private void btnAddDetailByBom_Click(object sender, EventArgs e)
        {
            frmSelectMaterialByBomData frmSelectMaterialByBomData = new frmSelectMaterialByBomData();
            frmSelectMaterialByBomData.ShowDialog();


            if (frmSelectMaterialByBomData.Tag != null)
            {
                //取出选择的料件Guid
                NodeData NodeData = new NodeData();
                List<NodeData> lstNodeData = frmSelectMaterialByBomData.Tag as List<NodeData>;


                //选择的品名填充
                if (lstNodeData.Count > 0)
                {
                    //得到料件的信息
                    for (int i = 0; i < lstNodeData.Count; i++)
                    {
                        NodeData = new NodeData();
                        NodeData = lstNodeData[i];

                        Material material = new Material();
                        material = MaterialManage.GetMaterialByGuid(NodeData.MaterialGuid);

                        //填充数据
                        gridView1.AddNewRow();
                        gridView1.SetFocusedRowCellValue(gridMaterialGuID, material.MaterialGuID);
                        gridView1.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView1.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
                        gridView1.SetFocusedRowCellValue(gridConsumeSum, decimal.Parse(NodeData.MaterialSum).ToString("g0"));
                        gridView1.SetFocusedRowCellValue(gridMaterialSum, "0");
                        gridView1.SetFocusedRowCellValue(gridApplyMaterialSum, "0");
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