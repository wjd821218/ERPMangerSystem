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
    ///得到各仓库料件的数量
    /// </summary>
    public partial class frmGetMaterialStorageSum :frmBase
    {

        public frmGetMaterialStorageSum()
        {
            InitializeComponent();
        }

       
        private void frmClientOrder_Load(object sender, EventArgs e)
        {
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


           
            DataTable dtl = MaterialManage.sp_GetStorageSumData(strMaterialGuid);
            gridControl1.DataSource = dtl;

           

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}