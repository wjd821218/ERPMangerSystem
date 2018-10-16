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
    /// 出库数量超出库存物料列表
    /// </summary>
    public partial class frmShowYJMaterial : frmBase
    {
        public frmShowYJMaterial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载超过库存的物料列表
        /// </summary>
        /// <param name="lst"></param>
        public void ShowFillData(List<YJMaterialStorage> lst )
        {
            gridControl1.DataSource= IniBindTable();
            YJMaterialStorage YJMaterialStorage = new YJMaterialStorage();

            //得到料件的信息
            for (int i = 0; i < lst.Count; i++)
            {
                YJMaterialStorage = lst[i] as YJMaterialStorage;

                //填充数据
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue(gridMaterialID, YJMaterialStorage.MaterialID);
                gridView1.SetFocusedRowCellValue(gridMaterialName, YJMaterialStorage.MaterialName);
                gridView1.SetFocusedRowCellValue(gridMaterialSum, YJMaterialStorage.MaterialSum.ToString("g0"));
                gridView1.SetFocusedRowCellValue(gridStorageSum, YJMaterialStorage.StorageSum.ToString("g0"));
                gridView1.SetFocusedRowCellValue(gridStorageName, YJMaterialStorage.StorageName);

            }

            this.ShowDialog();
        }


        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("MaterialID");
            DataColumn _datacol2 = new DataColumn("MaterialName");
            DataColumn _datacol3 = new DataColumn("MaterialSum");
            DataColumn _datacol4 = new DataColumn("StorageSum");
            DataColumn _datacol5 = new DataColumn("StorageName");


            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
          

            return _dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}