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
        public int Invalue = 0;//���Ϊ1���Ǵӵ������Ǳ�������
        /// <summary>
        /// ��Ʒ����
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
        ///// �������б��ͨ�÷���
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


        //����
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

        //�༭
        public void MaterialEdit(string MaterialGuid)
        {


            FillData(MaterialGuid);

            IsEdit = true;

            this.ShowDialog();

        }


        //����ʱ��ѡ���Ʒ���ര�ڷ��������ø����ֵ
        public void GetMaterialClass(string classid, string classname)
        {
            txtClass.Text = classname;
            txtClass.Tag = classid;
        }

        /// <summary>
        /// ��������
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

        //����
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClass.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ�����Ϸ���!");
                return;
            }
            if (txtMaterialId.Text.Trim() == "")
            {
                this.ShowAlertMessage("���������ϱ��!");
                txtMaterialName.Focus();
                return;
            }
            if (txtMaterialName.Text.Trim() == "")
            {
                this.ShowAlertMessage("��������������!");
                txtMaterialName.Focus();
                return;
            }
            if (txtUnit.Text.Trim() == "")
            {
                this.ShowAlertMessage("�����뵥λ!");
                txtUnit.Focus();
                return;
            }
            //if (txtSpec.Text.Trim()== "")
            //{
            //    this.ShowAlertMessage("��������!");
            //    cboSpec.Focus();
            //    return;
            //}


            MaterialManage MaterialManage = new MaterialManage();

     
            //�жϵ�ǰ�ϼ��Ƿ��Ѿ�������ͬ��,����Ѿ������������ʾ
            if (MaterialManage.IsExistMaterial(txtGuid.Text, txtMaterialId.Text, txtMaterialName.Text.Trim(), IsEdit))
            {
                this.ShowAlertMessage("������Ļ�Ʒ��Ϣ�Ѿ�����,���޸ĺ���ȷ��!");
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
                material.IsEnable = 1; //ͣ��
            }
            else
            {
                material.IsEnable = 0;//����
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

            //����
            MaterialManage.Save(material);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "��������", "������༭", SysParams.UserName + "�û�������༭�����ϣ�����:" + material.MaterialGuID + "," + material.MaterialID + "," + material.MaterialName);

            IsEdit = true;

            //ˢ��
            string strsql = " where ClassId='" + txtClass.Tag.ToString() + "'";

            //����Ǵӵ����������������ˢ�¸�����
            if (Invalue == 0)
            {
                frmMaterial.frmmaterial.LoadMaterial(strsql);
            }

        }


        /// <summary>
        /// ѡ���Ʒ����
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

        //����ͺ�ѡ��
        private void btnSelectSpec_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(6);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtSpec.Text = ""; //����
                    txtSpec.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSpec.Text = arrValue[1]; //����
                        txtSpec.Tag = arrValue[0];  //Guid
                    }
                }
            }

        }

        //��λѡ��
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(1);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtUnit.Text = ""; //����
                    txtUnit.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtUnit.Text = arrValue[1]; //����
                        txtUnit.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //�Ƽ۷���ѡ��
        private void btnSelectCalculateMethod_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(7);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtCalculateMethod.Text = ""; //����
                    txtCalculateMethod.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtCalculateMethod.Text = arrValue[1]; //����
                        txtCalculateMethod.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        //����
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
                    txtSupplierGuid.Text = ""; //����
                    txtSupplierGuid.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtSupplierGuid.Text = arrValue[1]; //����
                        txtSupplierGuid.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }




    }
}