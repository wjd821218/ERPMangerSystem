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
    /// <summary>
    /// 供应商新增
    /// </summary>
    public partial class frmSupplierAdd : frmBase
    {
        SupplierManage SupplierManage = new SupplierManage();
        public frmSupplierAdd()
        {
            InitializeComponent();

            txtGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增
        public void SupplierAdd()
        {
            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            this.ShowDialog();
        
        }

        //新增
        public void SupplierEdit(string SupplierGuid)
        {
            FillData(SupplierGuid);
        }


        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string SupplierGuid)
        {
            SupplierManage suppliermanage = new SupplierManage();
            DataTable dtl = suppliermanage.GetSupplierData_CN(SupplierGuid);

            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["Guid"].ToString();
                txtName.Text = dtl.Rows[0]["Name"].ToString();
                txtSimpName.Text = dtl.Rows[0]["SimpName"].ToString();
                txtLinkMan.Text = dtl.Rows[0]["LinkMan"].ToString();
                txtTelephone.Text = dtl.Rows[0]["Telephone"].ToString();
                txtFax.Text = dtl.Rows[0]["Fax"].ToString();
                txtAddress.Text = dtl.Rows[0]["Address"].ToString();
                txtZip.Text = dtl.Rows[0]["Zip"].ToString();
                txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
                txtProduceType.Text = dtl.Rows[0]["ProduceType"].ToString();

                if (dtl.Rows[0]["IsEnable"].ToString() == "1")
                {
                    chkIsEnable.Checked = true;
                }
                else
                {
                    chkIsEnable.Checked = false;
                }
            }

            this.ShowDialog();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier Supplier = new Supplier();
            Supplier.Guid = txtGuid.Text;

            Supplier.Name = txtName.Text;
            Supplier.SimpName = txtSimpName.Text;
            Supplier.LinkMan = txtLinkMan.Text;
            Supplier.Telephone = txtTelephone.Text;
            Supplier.Fax = txtFax.Text;
            Supplier.Address = txtAddress.Text;
            Supplier.Zip = txtZip.Text;
            Supplier.Remark = txtRemark.Text;
            Supplier.ProduceType = txtProduceType.Text;

            if (chkIsEnable.Checked == true)
            {
                Supplier.IsEnable = 1;
            }
            else
            {
                Supplier.IsEnable = 0;
            }
            SupplierManage.Save(Supplier);

            frmSupplier.frmsupplier.LoadSupplier();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "供应商新增或编辑", "新增或编辑", SysParams.UserName + "新增或编辑了供应商[" + Supplier.Name + "]");


            this.Close();

        }


    }
}