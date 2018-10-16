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
    /// 删除单据时有关系单据编号显示
    /// </summary>
    public partial class frmShowYJOrderDelete : frmBase
    {
        public frmShowYJOrderDelete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 删除单据时有关系单据编号显示
        /// </summary>
        /// <param name="lst"></param>
        public void ShowFillData(List<YJOrderDelete> lst )
        {
            gridControl1.DataSource= IniBindTable();
            YJOrderDelete YJOrderDelete = new YJOrderDelete();

            //得到订单的信息
            for (int i = 0; i < lst.Count; i++)
            {
                YJOrderDelete = lst[i] as YJOrderDelete;

                //填充数据
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue(gridOrderID, YJOrderDelete.OrderID);
                gridView1.SetFocusedRowCellValue(gridOrderName, YJOrderDelete.OrderName);
             
            }

            this.ShowDialog();
        }


        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("OrderID");
            DataColumn _datacol2 = new DataColumn("OrderName");
       

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
          
         
            return _dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}