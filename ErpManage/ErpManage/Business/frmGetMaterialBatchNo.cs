using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;

namespace ErpManage.Business
{
    /// <summary>
    ///得到物料入库的所有批次情况
    /// </summary>
    public partial class frmGetMaterialBatchNo :frmBase
    {

        public frmGetMaterialBatchNo()
        {
            InitializeComponent();
        }


        public void LoadData(string strMaterialGuid)
        {
            MaterialManage MaterialManage = new MaterialManage();
            Material material = new Material();
            material = MaterialManage.GetMaterialByGuid(strMaterialGuid);

            txtMaterialID.Text = material.MaterialID;
            txtMaterialName.Text = material.MaterialName;
            txtSpec.Text = base.GetBasicDataNameByID(material.Spec);
            txtUnit.Text = base.GetBasicDataNameByID(material.Unit);


            StatReportManage StatReportManage = new StatReportManage();
            DataTable dtl = StatReportManage.sp_GetStorageSumBatchNo(strMaterialGuid);
            gridControl1.DataSource = dtl;

           

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}