using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage
{
    public partial class frmMaterialAdd : frmBase
    {

        public static frmMaterialAdd frmmaterialadd;
        private bool IsEdit = false;
        public int Invalue = 0;//如果为1则是从调拨单那边新增的
        /// <summary>
        /// 货品新增
        /// </summary>
        public frmMaterialAdd()
        {
            InitializeComponent();
            frmmaterialadd = this;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ///// <summary>
        ///// 绑定下拉列表框，通用方法
        ///// </summary>
        //public void cboDataBind(ComboBox obj, int flag)
        //{
        //    BasicDataManage BasicDataManage = new BasicDataManage();
        //    obj.Items.Clear();

        //    DataTable dtl = BasicDataManage.GetBasicData(flag);
        //    for (int i = 0; i < dtl.Rows.Count; i++)
        //    {
        //        obj.Items.Add(dtl.Rows[i]["UnitName"].ToString());
        //    }
        //}

        private void frmMaterialAdd_Load(object sender, EventArgs e)
        {

        }


        //新增
        public void MaterialAdd(string classid, string classname)
        {
            txtClass.Text = classname;
            txtClass.Tag = classid;

            IsEdit = false;


            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            this.ShowDialog();

        }

        //编辑
        public void MaterialEdit(string MaterialGuid)
        {


            FillData(MaterialGuid);

            IsEdit = true;

            this.ShowDialog();

        }


        //新增时，选择货品分类窗口反过来调用给填充值
        public void GetMaterialClass(string classid, string classname)
        {
            txtClass.Text = classname;
            txtClass.Tag = classid;
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string MaterialGuid)
        {
            MaterialManage MaterialManage = new MaterialManage();

            DataTable dtl = MaterialManage.GetMaterial(MaterialGuid);

            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["MaterialGuId"].ToString();
                txtMaterialId.Text = dtl.Rows[0]["MaterialId"].ToString();
                txtMaterialName.Text = dtl.Rows[0]["MaterialName"].ToString();
                txtSpec.Text = dtl.Rows[0]["SpecInterName"].ToString();
                txtSpec.Tag = dtl.Rows[0]["Spec"].ToString();
                txtUnit.Text = dtl.Rows[0]["UnitInterName"].ToString();
                txtUnit.Tag = dtl.Rows[0]["Unit"].ToString();
                txtClass.Text = dtl.Rows[0]["ClassInterName"].ToString();
                txtClass.Tag = dtl.Rows[0]["Classid"].ToString();
                txtPlace.Text = dtl.Rows[0]["Place"].ToString();
                txtCalculateMethod.Text = dtl.Rows[0]["CalculateMethodInterName"].ToString();
                txtCalculateMethod.Tag = dtl.Rows[0]["CalculateMethod"].ToString();
                txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
                txtPicID.Text = dtl.Rows[0]["PicID"].ToString();
                txtClientID.Text= dtl.Rows[0]["ClientID"].ToString();
                txtSupplierGuid.Text = dtl.Rows[0]["SupplierName"].ToString();
                txtSupplierGuid.Tag= dtl.Rows[0]["SupplierGuid"].ToString();
                txtSafeStockSum.Text = dtl.Rows[0]["SafeStockSum"].ToString();

                if (dtl.Rows[0]["IsEnable"].ToString().Trim() == "1")
                {
                    chkStop.Checked = true;
                }

                txtPrice.Text = dtl.Rows[0]["Price"].ToString().Trim();


            }

           

          
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClass.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择物料分类!");
                return;
            }
            if (txtMaterialId.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入物料编号!");
                txtMaterialName.Focus();
                return;
            }
            if (txtMaterialName.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入物料名称!");
                txtMaterialName.Focus();
                return;
            }
            if (txtUnit.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入单位!");
                txtUnit.Focus();
                return;
            }
            //if (txtSpec.Text.Trim()== "")
            //{
            //    this.ShowAlertMessage("请输入规格!");
            //    cboSpec.Focus();
            //    return;
            //}


            MaterialManage MaterialManage = new MaterialManage();

     
            //判断当前料件是否已经存在相同的,如果已经存在则给出提示
            if (MaterialManage.IsExistMaterial(txtGuid.Text, txtMaterialId.Text, txtMaterialName.Text.Trim(), IsEdit))
            {
                this.ShowAlertMessage("你输入的货品信息已经存在,请修改后再确定!");
                return;
            }
          


            Material material = new Material();
            material.MaterialGuID = txtGuid.Text;
            material.MaterialID = txtMaterialId.Text;
            material.MaterialName = txtMaterialName.Text;
            if (txtSpec.Tag != null)
            {
                material.Spec = txtSpec.Tag.ToString();
            }
            else
            {
                material.Spec = "";
            }
            if (txtUnit.Tag != null)
            {
                material.Unit = txtUnit.Tag.ToString();
            }
            else
            {
                material.Unit = "";
            }
            material.ClassId = txtClass.Tag.ToString();
            material.Place = txtPlace.Text.Trim();
            if (txtCalculateMethod.Tag != null)
            {
                material.CalculateMethod = txtCalculateMethod.Tag.ToString();
            }
            else
            {
                material.CalculateMethod = "";
            }
            material.Remark = txtRemark.Text.Trim();

            if (txtSafeStockSum.Text == "")
            {
                material.SafeStockSum = 0;
            }
            else
            {
                material.SafeStockSum = int.Parse(txtSafeStockSum.Text);
            }


            if (txtPrice.Text == "")
            {
                material.Price = 0;
            }
            else
            {
                material.Price = decimal.Parse(txtPrice.Text);
            }

            if (chkStop.Checked == true)
            {
                material.IsEnable = 1; //停用
            }
            else
            {
                material.IsEnable = 0;//可用
            }
            material.PicID = txtPicID.Text.Trim();
            material.ClientID = txtClientID.Text.Trim();
            if (txtSupplierGuid.Tag!=null)
            {
                material.SupplierGuid = txtSupplierGuid.Tag.ToString();
            }
            else
            {
                material.SupplierGuid = "";
            }

            //保存
            MaterialManage.Save(material);

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "物料数据", "新增或编辑", SysParams.UserName + "用户新增或编辑了物料，物料:" + material.MaterialGuID + "," + material.MaterialID + "," + material.MaterialName);

            IsEdit = true;

            //刷新
            string strsql = " where ClassId='" + txtClass.Tag.ToString() + "'";

            //如果是从调拨单新增进入的则刷新父窗口
            if (Invalue == 0)
            {
                frmMaterial.frmmaterial.LoadMaterial(strsql);
            }

        }


        /// <summary>
        /// 选择货品分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectType frmSelectType = new frmSelectType();
            frmSelectType.InValue = 0;
            frmSelectType.ShowDialog();

            if (frmSelectType.Tag != null)
            {
                SelectMaterialType SelectMaterialType = frmSelectType.Tag as SelectMaterialType;

                txtClass.Text  = SelectMaterialType.MaterialTypeName;
                txtClass.Tag = SelectMaterialType.MaterialTypeID;

            }
        }

        //规格型号选择
        private void btnSelectSpec_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(6);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSpec.Text = ""; //名称
                    txtSpec.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSpec.Text = arrValue[1]; //名称
                        txtSpec.Tag = arrValue[0];  //Guid
                    }
                }
            }

        }

        //单位选择
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(1);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtUnit.Text = ""; //名称
                    txtUnit.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtUnit.Text = arrValue[1]; //名称
                        txtUnit.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //计价方法选择
        private void btnSelectCalculateMethod_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(7);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtCalculateMethod.Text = ""; //名称
                    txtCalculateMethod.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtCalculateMethod.Text = arrValue[1]; //名称
                        txtCalculateMethod.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsEdit = false;

            txtGuid.Text = Guid.NewGuid().ToString();

            txtMaterialId.Text = "";
            txtMaterialName.Text = "";
            txtSpec.Text = "";
            txtSpec.Tag = "";
            txtUnit.Text = "";
            txtUnit.Tag = "";
            txtPlace.Text = "";
            txtCalculateMethod.Text = "";
            txtCalculateMethod.Tag = "";
            txtRemark.Text = "";
            txtSafeStockSum.Text = "";
            txtPrice.Text = "";
            txtClientID.Text = "";
            txtPicID.Text = "";
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(3);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSupplierGuid.Text = ""; //名称
                    txtSupplierGuid.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplierGuid.Text = arrValue[1]; //名称
                        txtSupplierGuid.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }




    }
}