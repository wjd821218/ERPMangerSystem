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
    /// 调拨单新增
    /// 
    /// 修改1
    /// 修改时间：2010-6-17  增加二级审核与二级反审
    /// </summary>
    public partial class frmRemoveBillAdd :frmBase
    {
      
        MaterialManage MaterialManage = new MaterialManage();
        RemoveBillManage RemoveBillManage = new RemoveBillManage();
        DataSet ds = new DataSet();
        public frmRemoveBillAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillCheck2", "Check2") == false)
            {
                tsbCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillUnCheck2", "UnCheck2") == false)
            {
                tsbUnCheck2.Enabled = false;
            }


            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "RemoveBillPrint", "Print") == false)
            {
                tsbPrint.Enabled= false;
            }

        }


        //新增
        public void AddBill()
        {
            txtRemoveBillID.Text = GetAutoId("RemoveBill");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtRemoveBillGuid.Text = Guid.NewGuid().ToString();


            gridControl1.DataSource=IniBindTable();
            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;
      

            SetRight();
            this.ShowDialog();
        
        }

        //编辑
        public void EditBill(string RemoveBillGuid)
        {
            txtRemoveBillGuid.Text = RemoveBillGuid;
            DataTable dtl = RemoveBillManage.GetRemoveBillByRemoveBillGuid(RemoveBillGuid);

            txtRemoveBillID.Text = dtl.Rows[0]["RemoveBillID"].ToString();
            dtpRemoveBillDate.Text = DateTime.Parse(dtl.Rows[0]["RemoveBillDate"].ToString()).ToString("yyyy-MM-dd");


            txtDepotOut.Text = dtl.Rows[0]["DepotOutName"].ToString();
            txtDepotOut.Tag = dtl.Rows[0]["DepotOut"].ToString();

            txtDepotIn.Text = dtl.Rows[0]["DepotInName"].ToString();
            txtDepotIn.Tag = dtl.Rows[0]["DepotIn"].ToString();

            txtHandlePerson.Text = dtl.Rows[0]["HandlePersonName"].ToString();
            txtHandlePerson.Tag = dtl.Rows[0]["HandlePerson"].ToString();
 
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


            txtCheckGuid2.Tag = dtl.Rows[0]["CheckGuid2"].ToString();
            txtCheckGuid2.Text = dtl.Rows[0]["CheckName2"].ToString();

            if (dtl.Rows[0]["CheckDate2"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate2.Text = dtl.Rows[0]["CheckDate2"].ToString();
            }
            else
            {
                txtCheckDate2.Text = "";
            }


            //判断是否已经二级审核
            if (txtCheckGuid2.Text.Trim() != "")
            {
                tsbSave.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;


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

                }
                else
                {
                    tsbSave.Enabled = true;

                    tsbCheck.Enabled = true;
                    tsbUnCheck.Enabled = false;

                    tsbCheck2.Enabled = false;
                    tsbUnCheck2.Enabled = false;


                }
            }
            

            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = RemoveBillManage.GetRemoveBillDetail(RemoveBillGuid);
            gridControl1.DataSource = dtl2;


            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "RemoveBillDetail";

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
                DataTable dtl = MaterialManage.sp_GetOneStorageSumData(txtDepotOut.Tag.ToString(), strMaterialGuid);

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
                        YJMaterialStorage.StorageName = txtDepotOut.Text;
                        lst.Add(YJMaterialStorage);

                    }

                }
            }
            return lst;

        }
        //---------------------------------------------------------



        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(1);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="SaveType">1-保存  2-保存并审核</param>
        /// <returns></returns>
        private bool SaveData(int SaveType)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            if (txtDepotOut.Text == "")
            {
                this.ShowAlertMessage("必须输入调出仓库!");
                return false;
            }

            if (txtDepotIn.Text == "")
            {
                this.ShowAlertMessage("必须输入调入仓库!");
                return false;
            }

            if (dtpRemoveBillDate.Text == "")
            {
                this.ShowAlertMessage("必须输入开单日期!");
                return false;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return false;
            }

            //if (bm.IsExistBillID(txtBillID.Text) == true && this.Tag.ToString() == "add")
            //{
            //    this.ShowAlertMessage("订单号已经存在，请重新输入!");
            //    return;
            //}


            //-------------------------------------
            //是否开启数量超出库存预警
            if (MaterialManage.OverNumStorage(txtDepotOut.Tag.ToString()) == true)
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



            RemoveBill RemoveBill = new RemoveBill();
            RemoveBill.RemoveBillGuid = txtRemoveBillGuid.Text;
            RemoveBill.RemoveBillID = txtRemoveBillID.Text;
            RemoveBill.RemoveBillDate = DateTime.Parse(dtpRemoveBillDate.Text);
            if (txtDepotOut.Tag != null)
            {
                RemoveBill.DepotOut = txtDepotOut.Tag.ToString();
            }

            if (txtDepotIn.Tag != null)
            {
                RemoveBill.DepotIn = txtDepotIn.Tag.ToString();
            }

            if (txtHandlePerson.Tag != null)
            {
                RemoveBill.HandlePerson = txtHandlePerson.Tag.ToString();
            }


            RemoveBill.Remark = txtRemark.Text;

            RemoveBill.CreateGuid = txtCreateGuid.Tag.ToString();
            RemoveBill.CreateDate = DateTime.Now;
            RemoveBill.CheckGuid = "";
            RemoveBill.CheckDate = DateTime.Parse("1900-01-01");
            RemoveBill.CheckGuid2 = "";
            RemoveBill.CheckDate2 = DateTime.Parse("1900-01-01");





            List<RemoveBillDetail> list = new List<RemoveBillDetail>();
            RemoveBillDetail RemoveBillDetail = new RemoveBillDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                RemoveBillDetail = new RemoveBillDetail();
                RemoveBillDetail.RemoveBillGuid = txtRemoveBillGuid.Text;
                RemoveBillDetail.MaterialGuID = dr["MaterialGuID"].ToString();
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    RemoveBillDetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    RemoveBillDetail.MaterialSum = 0;
                }


                list.Add(RemoveBillDetail);
            }



            //保存
            RemoveBillManage.SaveBill(RemoveBill, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "调拨单保存", "保存", SysParams.UserName + "用户保存调拨单,唯一号:" + txtRemoveBillGuid.Text + ",调拨单号:" + txtRemoveBillID.Text);

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "RemoveBillDetail";


            this.Tag = "edit";

            if (SaveType == 1)
            {
                this.ShowMessage("保存成功");
            }

            frmRemoveBill.frmremovebill.LoadData();

            return true;
        }


        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该调拨单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (SaveData(2) == false)
                {
                    return;
                }


                //更新审核状态
                RemoveBillManage.CheckBill(txtRemoveBillGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);
                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;



                tsbSave.Enabled = false;

             


                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "调拨单审核", "审核", SysParams.UserName + "用户审核调拨单,唯一号:" + txtRemoveBillGuid.Text + ",调拨单号:" + txtRemoveBillID.Text);

                frmRemoveBill.frmremovebill.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该调拨单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RemoveBillManage.CheckBill(txtRemoveBillGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";


                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;



                tsbSave.Enabled = true;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "调拨单反审", "反审", SysParams.UserName + "用户反审调拨单,唯一号:" + txtRemoveBillGuid.Text + ",调拨单号:" + txtRemoveBillID.Text);

                frmRemoveBill.frmremovebill.LoadData();
            }
        }


        //二级审核
        private void tsbCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级审该调拨单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RemoveBillManage.CheckBill2(txtRemoveBillGuid.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = DateTime.Now.ToString();
                txtCheckGuid2.Tag = SysParams.UserID;
                txtCheckGuid2.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "调拨单二级审该", "二级审该", SysParams.UserName + "用户二级审该调拨单,唯一号:" + txtRemoveBillGuid.Text + ",调拨单单号:" + txtRemoveBillID.Text);

                frmRemoveBill.frmremovebill.LoadData();
            }
        }

        //二级反审
        private void tsbUnCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级反审调拨单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                RemoveBillManage.CheckBill2(txtRemoveBillGuid.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = "";
                txtCheckGuid2.Tag = "";
                txtCheckGuid2.Text = "";

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;

                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "调拨单二级反审", "二级反审", SysParams.UserName + "用户二级反审该调拨单,唯一号:" + txtRemoveBillGuid.Text + ",调拨单单号:" + txtRemoveBillID.Text);

                frmRemoveBill.frmremovebill.LoadData();
            }
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRemoveBillID.Text = GetAutoId("RemoveBill");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtRemoveBillGuid.Text = Guid.NewGuid().ToString();

            txtDepotOut.Text = "";
            txtDepotOut.Tag = "";


            txtDepotIn.Text = "";
            txtDepotIn.Tag = "";

            txtHandlePerson.Text = "";
            txtHandlePerson.Tag = "";

         
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

     
     

        //调拨人
        private void btnSelectSatrapPerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                   txtHandlePerson.Text = ""; //名称
                   txtHandlePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtHandlePerson.Text = arrValue[1]; //名称
                        txtHandlePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }


     
        //调出仓库
        private void btnSelectIncomeDepot_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDepotOut.Text = ""; //名称
                    txtDepotOut.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtDepotOut.Text = arrValue[1]; //名称
                        txtDepotOut.Tag = arrValue[0];  //Guid
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
            XtraReportRemoveBill XtraReportRemoveBill = new XtraReportRemoveBill(ds, txtRemoveBillID.Text, dtpRemoveBillDate.Text, txtDepotOut.Text, txtDepotIn.Text,txtHandlePerson.Text,
                                    txtRemark.Text, txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text,txtCheckGuid2.Text,txtCheckDate2.Text);
            XtraReportRemoveBill.ShowPreview();
        }

        //调入仓库
        private void btnSelectDepotIn_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(5);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDepotIn.Text = ""; //名称
                    txtDepotIn.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtDepotIn.Text = arrValue[1]; //名称
                        txtDepotIn.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

     

    }
}