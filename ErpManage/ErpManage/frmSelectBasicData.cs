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
    /// 选择基础数据: 仓库,部门,人员,单位,规格型号
    /// </summary>
    public partial class frmSelectBasicData : Form
    {
        BasicDataManage BasicDataManage = new BasicDataManage();
        int intFlag = 0;
        public frmSelectBasicData()
        {
            InitializeComponent();

            //  iniTemp();
        }

        private void frmSelectBasicData_Load(object sender, EventArgs e)
        {
            // LoadData();

        }


        //临时Demo用
        //private void iniTemp()
        //{
        //    DataTable _dt = new DataTable();
        //    DataColumn _datacol1 = new DataColumn("物料号");
        //    DataColumn _datacol2 = new DataColumn("物料名称");
        //    DataColumn _datacol3 = new DataColumn("单位");
        //    DataColumn _datacol4 = new DataColumn("规格型号");

        //    _dt.Columns.Add(_datacol1);
        //    _dt.Columns.Add(_datacol2);
        //    _dt.Columns.Add(_datacol3);
        //    _dt.Columns.Add(_datacol4);

        //    DataRow _datarow1 = _dt.NewRow();
        //    _dt.Rows.Add(_datarow1);

        //    _dt.Rows[0]["物料号"] = "P0001";
        //    _dt.Rows[0]["物料名称"] = "电脑";
        //    _dt.Rows[0]["单位"] = "台";
        //    _dt.Rows[0]["规格型号"] = "300型";

        //    _datarow1 = _dt.NewRow();
        //    _dt.Rows.Add(_datarow1);

        //    _dt.Rows[1]["物料号"] = "C0001";
        //    _dt.Rows[1]["物料名称"] = "主机";
        //    _dt.Rows[1]["单位"] = "台";
        //    _dt.Rows[1]["规格型号"] = "300型";

        //    gridControl1.DataSource = _dt;
        //}

        /// <summary>
        /// 选择基础数据窗口 1:单位  2:币种 3:结算方式  4:车间 5:仓库  6:规格 7:计价方法 8:财务科目  9:受控类别 12 模具类别 13 产品类别
        /// </summary>
        /// <param name="flag"> 1:单位  2:币种 3:结算方式  4:车间 5:仓库  6:规格 7:计价方法 8:财务科目 9:受控类别  12 模具类别 13 产品类别</param>
        public void ShowSelectBasicDataFrm(int flag)
        {
            intFlag = flag;

            LoadData(flag);

            SetFrmColCaption(flag);

            this.ShowDialog();
        }

        //载入数据
        private void LoadData(int flag)
        {
            DataTable dtl = BasicDataManage.GetBasicData(flag);
            this.gridControl1.DataSource = dtl;
            gridView1.Columns[0].Visible = false;




        }

        private void SetFrmColCaption(int flag)
        {
            switch (flag)
            {
                case 1:
                    gridView1.Columns["UnitName"].Caption = "单位";
                    break;
                case 2:
                    gridView1.Columns["UnitName"].Caption = "币种";
                    break;
                case 3:
                    gridView1.Columns["UnitName"].Caption = "结算方式";
                    break;
                case 4:
                    gridView1.Columns["UnitName"].Caption = "车间";
                    break;
                case 5:
                    gridView1.Columns["UnitName"].Caption = "仓库";
                    break;
                case 6:
                    gridView1.Columns["UnitName"].Caption = "规格";
                    break;
                case 7:
                    gridView1.Columns["UnitName"].Caption = "计价方法";
                    break;
                case 8:
                    gridView1.Columns["UnitName"].Caption = "财务科目";
                    break;
                case 9:
                    gridView1.Columns["UnitName"].Caption = "受控类别";
                    break;
                case 12:
                    gridView1.Columns["UnitName"].Caption = "模具类别";
                    break;
                case 13:
                    gridView1.Columns["UnitName"].Caption = "产品类别";
                    break;
            }


        }


        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["UnitID"].ToString();
                string strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["UnitName"].ToString();
                this.Tag = strguid + "|" + strname;

                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                string strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["UnitID"].ToString();
                string strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["UnitName"].ToString();
                this.Tag = strguid + "|" + strname;

                this.Close();
            }
        }

        private void txtQryValue_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            string strsql = "where  1=1 and  IsDelete=0  and  flag= " + intFlag.ToString().Trim();
            if (txtQryValue.Text.Trim() != "")
            {
                strsql = strsql + " and UnitName like '%" + txtQryValue.Text.Trim().Replace("'", "''") + "%'";

            }

            DataTable dtl = BasicDataManage.GetBasicDataByLikeUnitName(strsql);
            this.gridControl1.DataSource = dtl;
            gridView1.Columns[0].Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Tag = "ClearTextBox";
            this.Close();
        }
    }
}