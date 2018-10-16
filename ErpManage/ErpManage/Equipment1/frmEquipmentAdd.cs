using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ErpManageLibrary;

namespace ErpManage
{
    /// <summary>
    /// 设备基础资料维护
    /// </summary>
    public partial class frmEquipmentAdd :frmBase
    {


        public frmEquipmentAdd()
        {
            InitializeComponent();
        }


        public void IniEquipmentType()
        {
            cboEquipmentType.Items.Clear();


            //载入模具信息
            ListItem item = new ListItem();
            item.Text = "模具";
            item.Value = "1";
            cboEquipmentType.Items.Add(item);


            item = new ListItem();
            item.Text = "计量器具";
            item.Value = "2";
            cboEquipmentType.Items.Add(item);


            item = new ListItem();
            item.Text = "生产设备";
            item.Value = "3";
            cboEquipmentType.Items.Add(item);

            item = new ListItem();
            item.Text = "办公设备";
            item.Value = "4";
            cboEquipmentType.Items.Add(item);


            item = new ListItem();
            item.Text = "工装";
            item.Value = "5";
            cboEquipmentType.Items.Add(item);
        
        }

        public void EquipmentAdd(string strType)
        {
           

            txtEquipmentGuID.Text = Guid.NewGuid().ToString();


            IniEquipmentType();


            switch(strType)
            {
                case "1":
                      cboEquipmentType.SelectedIndex = 0;
                      tabEquipment.SelectTab(tabEquipmentDie);
                    break;
                case "2":
                    cboEquipmentType.SelectedIndex = 1;
                    tabEquipment.SelectTab(tabEquipmentGage);
                    break;
                case "3":
                    cboEquipmentType.SelectedIndex = 2;
                   
                    tabEquipment.SelectTab(tabEquipmentInformation);
                    break;
                case "4":
                    cboEquipmentType.SelectedIndex =3;
                    tabEquipment.SelectTab(tabEquipmentOffice);
                    break;
                case "5":
                    cboEquipmentType.SelectedIndex =4;
                    tabEquipment.SelectTab(tabEquipmentFrock);
                 
                    break;
            }

            this.ShowDialog();
        }




        /// <summary>
        /// 加载设备数据
        /// </summary>
        /// <param name="strEquipmentGuID"></param>
        public void EquipmentEdit(string strEquipmentGuID)
        {
            EquipmentManage EquipmentManage = new EquipmentManage();
            DataTable dtl = new DataTable();
            dtl = EquipmentManage.GetEquipmentDataByEquipmentGuID(strEquipmentGuID);

            txtEquipmentGuID.Text = strEquipmentGuID; //dtl.Rows[i]["EquipmentGuID"].ToString().Trim(); //无名称
            txtEquipmentID.Text = dtl.Rows[0]["EquipmentID"].ToString().Trim(); //工装设备编号
            txtEquipmentName.Text = dtl.Rows[0]["EquipmentName"].ToString().Trim(); //工装设备名称


            IniEquipmentType();

            switch (dtl.Rows[0]["EquipmentType"].ToString().Trim()) //工装设备分类
            {
                case "1":
                    cboEquipmentType.SelectedIndex = 0;
                    tabEquipment.SelectTab(tabEquipmentDie);
                    break;
                case "2":
                    cboEquipmentType.SelectedIndex = 1;
                    tabEquipment.SelectTab(tabEquipmentGage);
                    break;
                case "3":
                    cboEquipmentType.SelectedIndex = 2;

                    tabEquipment.SelectTab(tabEquipmentInformation);
                    break;
                case "4":
                    cboEquipmentType.SelectedIndex = 3;
                    tabEquipment.SelectTab(tabEquipmentOffice);
                    break;
                case "5":
                    cboEquipmentType.SelectedIndex = 4;
                    tabEquipment.SelectTab(tabEquipmentFrock);

                    break;
            }

        
            
            txtUsePerson.Text = dtl.Rows[0]["UsePerson"].ToString().Trim(); //使用者

            if (dtl.Rows[0]["EquipmentState"].ToString().Trim() == "0") //状态：1-可用 0-停用
            {
                chkEquipmentState.Checked = true;
            }
            else
            {
                chkEquipmentState.Checked = false;
            }
         
            txtSavePlace.Text = dtl.Rows[0]["SavePlace"].ToString().Trim(); //存放地点
            txtRemark.Text = dtl.Rows[0]["Remark"].ToString().Trim(); //备注







            DataTable dtlDetail = new DataTable();
            dtlDetail = EquipmentManage.GetEquipmentDetailData(strEquipmentGuID, dtl.Rows[0]["EquipmentType"].ToString());

            if (dtlDetail.Rows.Count > 0)
            {
                switch (dtl.Rows[0]["EquipmentType"].ToString().Trim()) //工装设备分类
                {
                    case "1":


                        txtEquipmentGuID.Text = dtlDetail.Rows[0]["EquipmentGuID"].ToString().Trim(); //工装设备主表号
                        txtDieType.Text = dtlDetail.Rows[0]["DieType"].ToString().Trim(); //模具类别
                        txtProductType.Text = dtlDetail.Rows[0]["ProductType"].ToString().Trim(); //产品类别
                        txtLife.Text = dtlDetail.Rows[0]["Life"].ToString().Trim(); //寿命
                        txtEnergy.Text = dtlDetail.Rows[0]["Energy"].ToString().Trim(); //产能
                        txtPartName.Text = dtlDetail.Rows[0]["PartName"].ToString().Trim(); //零件名称
                        txtPartID.Text = dtlDetail.Rows[0]["PartID"].ToString().Trim(); //零件物料编号
                        txtExteriorSize.Text = dtlDetail.Rows[0]["ExteriorSize"].ToString().Trim(); //外型尺寸（mm)
                        txtDatum.Text = dtlDetail.Rows[0]["Datum"].ToString().Trim(); //无名称
                        txtDieSource.Text = dtlDetail.Rows[0]["DieSource"].ToString().Trim(); //模具来源
                        txtAperture.Text = dtlDetail.Rows[0]["Aperture"].ToString().Trim(); //模穴


                        break;
                    case "2":

                        txtEquipmentGuID.Text = dtlDetail.Rows[0]["EquipmentGuID"].ToString().Trim(); //无名称
                        txtGageSpec.Text = dtlDetail.Rows[0]["GageSpec"].ToString().Trim(); //规格型号
                        txtLeaveFactoryID.Text = dtlDetail.Rows[0]["LeaveFactoryID"].ToString().Trim(); //出厂编号
                        txtScaleArea.Text = dtlDetail.Rows[0]["ScaleArea"].ToString().Trim(); //测量范围
                        txtScalePrecision.Text = dtlDetail.Rows[0]["ScalePrecision"].ToString().Trim(); //精度
                        txtManageLevel.Text = dtlDetail.Rows[0]["ManageLevel"].ToString().Trim(); //管理级别
                        txtCheckType.Text = dtlDetail.Rows[0]["CheckType"].ToString().Trim(); //检定方式
                        txtCheckCycle.Text = dtlDetail.Rows[0]["CheckCycle"].ToString().Trim(); //校准周期
                        txtCheckUnit.Text = dtlDetail.Rows[0]["CheckUnit"].ToString().Trim(); //校准单位
                        txtAppraisalRecord.Text = dtlDetail.Rows[0]["AppraisalRecord"].ToString().Trim(); //鉴定记录


                        break;
                    case "3":

                        txtEquipmentGuID.Text = dtlDetail.Rows[0]["EquipmentGuID"].ToString().Trim(); //无名称
                        txtEquipmentInformationSpec.Text = dtlDetail.Rows[0]["EquipmentInformationSpec"].ToString().Trim(); //设备型号规格
                        txtMadeManufacturer.Text = dtlDetail.Rows[0]["MadeManufacturer"].ToString().Trim(); //设备制造厂商
                        txtHistoryRecord.Text = dtlDetail.Rows[0]["HistoryRecord"].ToString().Trim(); //历史记录
                        if (DateTime.Parse(dtlDetail.Rows[0]["MadeDate"].ToString().Trim()).ToString("yyyy-MM-dd") != "1900-01-01")
                        {
                            deMadeDate.Text = DateTime.Parse(dtlDetail.Rows[0]["MadeDate"].ToString().Trim()).ToString("yyyy-MM-dd");
                        }
                        if (DateTime.Parse(dtlDetail.Rows[0]["UseDate"].ToString().Trim()).ToString("yyyy-MM-dd") != "1900-01-01")
                        {
                            deUseDate.Text = DateTime.Parse(dtlDetail.Rows[0]["UseDate"].ToString().Trim()).ToString("yyyy-MM-dd");
                        }

                        break;
                    case "4":

                        txtEquipmentGuID.Text = dtlDetail.Rows[0]["EquipmentGuID"].ToString().Trim(); //无名称
                        txtBrand.Text = dtlDetail.Rows[0]["Brand"].ToString().Trim(); //品牌
                        txtEquipmentOfficeSpec.Text = dtlDetail.Rows[0]["EquipmentOfficeSpec"].ToString().Trim(); //规格
                        txtDiskSize.Text = dtlDetail.Rows[0]["DiskSize"].ToString().Trim(); //硬盘大小
                        txtCPU.Text = dtlDetail.Rows[0]["CPU"].ToString().Trim(); //CPU
                        txtMemory.Text = dtlDetail.Rows[0]["Memory"].ToString().Trim(); //内存
                        txtDisplayCar.Text = dtlDetail.Rows[0]["DisplayCar"].ToString().Trim(); //显卡


                        break;
                    case "5":


                        txtEquipmentGuID.Text = dtlDetail.Rows[0]["EquipmentGuID"].ToString().Trim(); //主表guid
                        txtProductClass.Text = dtlDetail.Rows[0]["ProductClass"].ToString().Trim(); //产品类别
                        txtWorkEfficiency.Text = dtlDetail.Rows[0]["WorkEfficiency"].ToString().Trim(); //工位
                        txtEquipmentStuff.Text = dtlDetail.Rows[0]["EquipmentStuff"].ToString().Trim(); //材料
                        txtEquipmentFormal.Text = dtlDetail.Rows[0]["EquipmentFormal"].ToString().Trim(); //外形尺寸
                        txtFrockSource.Text = dtlDetail.Rows[0]["FrockSource"].ToString().Trim(); //工装来源


                        break;
                }
            }

            this.ShowDialog();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

             EquipmentManage EquipmentManage = new EquipmentManage();
            if (txtEquipmentID.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入编号!");
                txtEquipmentID.Focus();
                return;
            }

            if (EquipmentManage.IsExistEquipementID(txtEquipmentGuID.Text.Trim().Replace("'","''").Trim(),txtEquipmentID.Text.Trim().Replace("'","''").Trim())==true)
            {
              this.ShowAlertMessage("编号已经存在，请重新输入!");
                txtEquipmentID.Focus();
                return;
               
            }


            if (txtEquipmentName.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入名称!");
                txtEquipmentName.Focus();
                return;
            }
            if (cboEquipmentType.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择分类!");
                cboEquipmentType.Focus();
                return;
            }

            if (txtSavePlace.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入存放地点!");
                txtSavePlace.Focus();
                return;
            }
            
          

           
            Equipment Equipment = new Equipment();
            EquipmentDie EquipmentDie = new EquipmentDie();
            EquipmentGage EquipmentGage = new EquipmentGage();
            EquipmentFrock EquipmentFrock = new EquipmentFrock();
            EquipmentInformation EquipmentInformation = new EquipmentInformation();
            EquipmentOffice EquipmentOffice = new EquipmentOffice();

            //保存主表
            Equipment.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");
            Equipment.EquipmentID = txtEquipmentID.Text.Trim().Replace("'","''");
            Equipment.EquipmentName = txtEquipmentName.Text.Trim().Replace("'","''");
            Equipment.EquipmentType = ((ListItem)cboEquipmentType.SelectedItem).Value; 
            Equipment.UsePerson = txtUsePerson.Text.Trim().Replace("'","''");
            if (chkEquipmentState.Checked == true)
            {
                Equipment.EquipmentState = "0";  //状态：1-可用 0-停用

            }
            else
            {
                Equipment.EquipmentState = "1";
            }
            Equipment.SavePlace = txtSavePlace.Text.Trim().Replace("'","''");
            Equipment.Remark = txtRemark.Text.Trim().Replace("'","''");
            

            //保存明细
            switch (cboEquipmentType.SelectedIndex)
            {
                case 0: //tabEquipmentDie
                    EquipmentDie.DieGuID = Guid.NewGuid().ToString();
                    EquipmentDie.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");
                    EquipmentDie.DieType = txtDieType.Text.Trim().Replace("'","''");
                    EquipmentDie.ProductType = txtProductType.Text.Trim().Replace("'","''");
                    EquipmentDie.Life = txtLife.Text.Trim().Replace("'","''");
                    EquipmentDie.Energy = txtEnergy.Text.Trim().Replace("'","''");
                    EquipmentDie.PartName = txtPartName.Text.Trim().Replace("'","''");
                    EquipmentDie.PartID = txtPartID.Text.Trim().Replace("'","''");
                    EquipmentDie.ExteriorSize = txtExteriorSize.Text.Trim().Replace("'","''");
                    EquipmentDie.Datum = txtDatum.Text.Trim().Replace("'","''");
                    EquipmentDie.DieSource = txtDieSource.Text.Trim().Replace("'","''");
                    EquipmentDie.Aperture = txtAperture.Text.Trim().Replace("'","''");

                 
                    break;
                case 1://tabEquipmentGage
                    EquipmentGage.GageGuID = Guid.NewGuid().ToString();
                    EquipmentGage.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");//无名称
                    EquipmentGage.GageSpec = txtGageSpec.Text.Trim().Replace("'","''");//规格型号
                    EquipmentGage.LeaveFactoryID = txtLeaveFactoryID.Text.Trim().Replace("'","''");//出厂编号
                    EquipmentGage.ScaleArea = txtScaleArea.Text.Trim().Replace("'","''");//测量范围
                    EquipmentGage.ScalePrecision = txtScalePrecision.Text.Trim().Replace("'","''");//精度
                    EquipmentGage.ManageLevel = txtManageLevel.Text.Trim().Replace("'","''");//管理级别
                    EquipmentGage.CheckType = txtCheckType.Text.Trim().Replace("'","''");//检定方式
                    EquipmentGage.CheckCycle = txtCheckCycle.Text.Trim().Replace("'","''");//校准周期
                    EquipmentGage.CheckUnit = txtCheckUnit.Text.Trim().Replace("'","''");//校准单位
                    EquipmentGage.AppraisalRecord = txtAppraisalRecord.Text.Trim().Replace("'","''");//鉴定记录
               
                    break;
                case 2://tabEquipmentInformation
                    EquipmentInformation.EquipmentInformationGuID = Guid.NewGuid().ToString();
                    EquipmentInformation.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");//无名称
                    EquipmentInformation.EquipmentInformationSpec = txtEquipmentInformationSpec.Text.Trim().Replace("'","''");//设备型号规格
                    EquipmentInformation.MadeManufacturer = txtMadeManufacturer.Text.Trim().Replace("'","''");//设备制造厂商
                    if (deMadeDate.Text.Trim() == "")
                    {
                        EquipmentInformation.MadeDate = DateTime.Parse("1900-01-01");
                    }
                    else
                    {
                        EquipmentInformation.MadeDate = DateTime.Parse(deMadeDate.Text);
                    }

                    if (deUseDate.Text.Trim() == "")
                    {
                        EquipmentInformation.UseDate = DateTime.Parse("1900-01-01");
                    }
                    else
                    {
                        EquipmentInformation.UseDate = DateTime.Parse(deUseDate.Text);
                    }
                   
                
                    EquipmentInformation.HistoryRecord = txtHistoryRecord.Text.Trim().Replace("'","''");//历史记录


                 

                    break;
                case 3://tabEquipmentOffice
                    EquipmentOffice.EquipmentOfficeGuID = Guid.NewGuid().ToString();
                    EquipmentOffice.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");//无名称
                    EquipmentOffice.Brand = txtBrand.Text.Trim().Replace("'","''");//品牌
                    EquipmentOffice.EquipmentOfficeSpec = txtEquipmentOfficeSpec.Text.Trim().Replace("'","''");//规格
                    EquipmentOffice.DiskSize = txtDiskSize.Text.Trim().Replace("'","''");//硬盘大小
                    EquipmentOffice.CPU = txtCPU.Text.Trim().Replace("'","''");//CPU
                    EquipmentOffice.Memory = txtMemory.Text.Trim().Replace("'","''");//内存
                    EquipmentOffice.DisplayCar = txtDisplayCar.Text.Trim().Replace("'","''");//显卡

                  
                    break;
                case 4://tabEquipmentFrock
                    EquipmentFrock.EquipmentFrockGuID = Guid.NewGuid().ToString();
                    EquipmentFrock.EquipmentGuID = txtEquipmentGuID.Text.Trim().Replace("'","''");//主表guid
                    EquipmentFrock.ProductClass = txtProductClass.Text.Trim().Replace("'","''");//产品类别
                    EquipmentFrock.WorkEfficiency = txtWorkEfficiency.Text.Trim().Replace("'","''");//工位
                    EquipmentFrock.EquipmentStuff = txtEquipmentStuff.Text.Trim().Replace("'","''");//材料
                    EquipmentFrock.EquipmentFormal = txtEquipmentFormal.Text.Trim().Replace("'","''");//外形尺寸
                    EquipmentFrock.FrockSource = txtFrockSource.Text.Trim().Replace("'","''");//工装来源
                    break;
            
            }

            EquipmentManage.SaveBill(Equipment, EquipmentDie, EquipmentFrock, EquipmentGage, EquipmentOffice, EquipmentInformation);

            //刷新父窗口
            frmEquipment.frmequipment.LoadEquipmentTypeData();

            this.ShowMessage("保存成功！");
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEquipmentType.SelectedIndex)
            {
                case 0:
                    tabEquipment.SelectTab(tabEquipmentDie);
                    SetTabEnable(cboEquipmentType.SelectedIndex);
                    break;
                case 1:
                    tabEquipment.SelectTab(tabEquipmentGage);
                    SetTabEnable(cboEquipmentType.SelectedIndex);
                    break;
                case 2:
                    tabEquipment.SelectTab(tabEquipmentInformation);
                    SetTabEnable(cboEquipmentType.SelectedIndex);
                    break;
                case 3:
                    tabEquipment.SelectTab(tabEquipmentOffice);
                    SetTabEnable(cboEquipmentType.SelectedIndex);
                    break;
                case 4:
                    tabEquipment.SelectTab(tabEquipmentFrock);
                    SetTabEnable(cboEquipmentType.SelectedIndex);
                    break;

            }


        }


        private void SetTabEnable(int tab)
        {
            tabEquipment.TabPages[0].Enabled = false;
            tabEquipment.TabPages[1].Enabled = false;
            tabEquipment.TabPages[2].Enabled = false;
            tabEquipment.TabPages[3].Enabled = false;
            tabEquipment.TabPages[4].Enabled = false;


            tabEquipment.TabPages[tab].Enabled = true; 



        }

        private void frmEquipmentAdd_Load(object sender, EventArgs e)
        {
            //权限判断
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "EquipmentSave", "Save") == false)
            {
                btnSave.Enabled = false;

            }
        }

        private void btnSelectUsePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtUsePerson.Text = ""; //名称
                    txtUsePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtUsePerson.Text = arrValue[1]; //名称
                        txtUsePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectDieType_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(12);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtDieType.Text = ""; //名称
                    txtDieType.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtDieType.Text = arrValue[1]; //名称
                        txtDieType.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectProductType_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(13);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtProductType.Text = ""; //名称
                    txtProductType.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');


                    if (arrValue.Length > 0)
                    {
                        txtProductType.Text = arrValue[1]; //名称
                        txtProductType.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }
    }
}