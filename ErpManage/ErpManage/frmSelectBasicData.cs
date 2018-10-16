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
    /// ѡ���������: �ֿ�,����,��Ա,��λ,����ͺ�
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


        //��ʱDemo��
        //private void iniTemp()
        //{
        //    DataTable _dt = new DataTable();
        //    DataColumn _datacol1 = new DataColumn("���Ϻ�");
        //    DataColumn _datacol2 = new DataColumn("��������");
        //    DataColumn _datacol3 = new DataColumn("��λ");
        //    DataColumn _datacol4 = new DataColumn("����ͺ�");

        //    _dt.Columns.Add(_datacol1);
        //    _dt.Columns.Add(_datacol2);
        //    _dt.Columns.Add(_datacol3);
        //    _dt.Columns.Add(_datacol4);

        //    DataRow _datarow1 = _dt.NewRow();
        //    _dt.Rows.Add(_datarow1);

        //    _dt.Rows[0]["���Ϻ�"] = "P0001";
        //    _dt.Rows[0]["��������"] = "����";
        //    _dt.Rows[0]["��λ"] = "̨";
        //    _dt.Rows[0]["����ͺ�"] = "300��";

        //    _datarow1 = _dt.NewRow();
        //    _dt.Rows.Add(_datarow1);

        //    _dt.Rows[1]["���Ϻ�"] = "C0001";
        //    _dt.Rows[1]["��������"] = "����";
        //    _dt.Rows[1]["��λ"] = "̨";
        //    _dt.Rows[1]["����ͺ�"] = "300��";

        //    gridControl1.DataSource = _dt;
        //}

        /// <summary>
        /// ѡ��������ݴ��� 1:��λ  2:���� 3:���㷽ʽ  4:���� 5:�ֿ�  6:��� 7:�Ƽ۷��� 8:�����Ŀ  9:�ܿ���� 12 ģ����� 13 ��Ʒ���
        /// </summary>
        /// <param name="flag"> 1:��λ  2:���� 3:���㷽ʽ  4:���� 5:�ֿ�  6:��� 7:�Ƽ۷��� 8:�����Ŀ 9:�ܿ����  12 ģ����� 13 ��Ʒ���</param>
        public void ShowSelectBasicDataFrm(int flag)
        {
            intFlag = flag;

            LoadData(flag);

            SetFrmColCaption(flag);

            this.ShowDialog();
        }

        //��������
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
                    gridView1.Columns["UnitName"].Caption = "��λ";
                    break;
                case 2:
                    gridView1.Columns["UnitName"].Caption = "����";
                    break;
                case 3:
                    gridView1.Columns["UnitName"].Caption = "���㷽ʽ";
                    break;
                case 4:
                    gridView1.Columns["UnitName"].Caption = "����";
                    break;
                case 5:
                    gridView1.Columns["UnitName"].Caption = "�ֿ�";
                    break;
                case 6:
                    gridView1.Columns["UnitName"].Caption = "���";
                    break;
                case 7:
                    gridView1.Columns["UnitName"].Caption = "�Ƽ۷���";
                    break;
                case 8:
                    gridView1.Columns["UnitName"].Caption = "�����Ŀ";
                    break;
                case 9:
                    gridView1.Columns["UnitName"].Caption = "�ܿ����";
                    break;
                case 12:
                    gridView1.Columns["UnitName"].Caption = "ģ�����";
                    break;
                case 13:
                    gridView1.Columns["UnitName"].Caption = "��Ʒ���";
                    break;
            }


        }


        //ѡ��
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