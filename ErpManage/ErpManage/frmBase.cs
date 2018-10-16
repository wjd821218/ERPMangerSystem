using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Collections;
using System.Text.RegularExpressions;

namespace ErpManage
{
    /// <summary>
    /// 父类窗口，提供公共的方法
    /// </summary>
    public partial class frmBase : Form
    {
        BillAutoIDManage BillAutoIDManage = new BillAutoIDManage();
        public RightGroupManage rightgroupManage = new RightGroupManage();
        public frmBase()
        {
            InitializeComponent();
        }

        public string GetAutoId(string flag)
        {
            //得到前缀
            string strOrderName = BillAutoIDManage.GetBillName(flag);


            //得到自动编号
            string strautoid = "";
            int autoid = BillAutoIDManage.GetAutoIDAdd(flag);//得到入库单的单据自增号
            if (autoid < 10)
            {
                strautoid = "000" + autoid.ToString();
            }
            else if (autoid >= 10 && autoid < 100)
            {
                strautoid = "00" + autoid.ToString();
            }
            else if (autoid >= 100 && autoid < 1000)
            {
                strautoid = "0" + autoid.ToString();
            }
            else if (autoid >= 1000 && autoid < 10000)
            {
                strautoid = autoid.ToString();
            }

            strautoid = strOrderName+DateTime.Now.ToString("yyyyMMdd") + strautoid;
            return strautoid;
        }

        /// <summary>
        /// 公共的数据选择窗口，边输边显示出最匹配的数据
        /// </summary>
        public void SelectDataGrid(DataGridView dgvobj,System.Windows.Forms.TextBox txtobj,int objtype,string sqlstr)
        {
            //dgvobj.Top = txtobj.Top + txtobj.Height + 5;
            //dgvobj.Left = txtobj.Left;

            //System.Data.DataTable dtl = new System.Data.DataTable();

            ////针对工作岗位的不同来选择不同中的数据库
            //switch (objtype)
            //{ 
            //    case 1://员工
            //        EmployeeManage empmanage = new EmployeeManage();
            //        dtl = empmanage.GetEmployeeInfo(sqlstr);
            //        dgvobj.DataSource = dtl;
            //        break;
            //    case 2://规格型号（品名）
            //        ProductModelManage productmanage = new ProductModelManage();
            //        dtl = productmanage.GetProductModelInfo(sqlstr);
            //        dgvobj.DataSource = dtl;
            //        break;
            //    case 3://工作组
            //        WorkGroupManage wgm = new WorkGroupManage();
            //        dtl = wgm.GetWorkGroupInfo(sqlstr);
            //        dgvobj.DataSource = dtl;
            //        break;
            
            //}
        }

        /// <summary>
        /// 显示警告信息
        /// </summary>
        /// <param name="strmessage"></param>
        public void ShowAlertMessage(string strmessage)
        {
            MessageBox.Show(strmessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="strmessage"></param>
        public void ShowMessage(string strmessage)
        {
            MessageBox.Show(strmessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示错误提示信息
        /// </summary>
        /// <param name="strmessage"></param>
        public void ShowErrorMessage(string strmessage)
        {
            MessageBox.Show(strmessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //得到当前工资计算月份
        public string GetCurrentSalaryMonth()
        {
           // BagWorkDataManage bagmanage = new BagWorkDataManage();
            //得到当前工资计算月份
          //  return bagmanage.GetCurrentSalaryMonth();
            return "";
        }


        /// <summary>
        /// 绑定下拉列表框，通用方法
        /// </summary>
        ///public void cboDataBind(ComboBox obj, int flag)
        ///{
            //CommonManage commonmanage = new CommonManage();

            //switch (flag)
            //{ 
            //    case 1:  //工作岗位
            //        System.Data.DataTable dtl = commonmanage.GetWorkStation();
            //        for (int i = 0; i < dtl.Rows.Count; i++)
            //        {
            //            obj.Items.Add(dtl.Rows[i]["WorkStation"].ToString());
            //        }
            //        break;

            
            //}
           
          
        ///}

        #region 控件汉化
        /// <summary>
        /// 将控件汉化
        /// </summary>
        public void IniControl_CN()
        {
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();


        }
        #endregion

        /// <summary>
        /// 禁用网格列排序功能
        /// </summary>
        public void DataGridViewColumnNoOrder(DataGridView datagridobj)
        {
            for (int i = 0; i < datagridobj.Columns.Count; i++)
            {
                datagridobj.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            }
        }


        //得到基础数据的名称，根据编号
        public string GetBasicDataNameByID(string strID)
        {
            if (strID == null)
            {
                return "";
            }
            
            if (strID.Trim() == "")
            {
                return "";
            }

            BasicDataManage BasicDataManage = new BasicDataManage();
            return BasicDataManage.GetBasicDataNameByUnitID(strID);
        }

        /// <summary>
        /// 将DataView转换为DataTable
        /// </summary>
        /// <param name="obDataView"></param>
        /// <returns></returns>
        public DataTable GetDataTable(DataView obDataView)
        {
            DataTable obNewDt = obDataView.Table.Clone();
            int idx = 0;
            string[] strColNames = new string[obNewDt.Columns.Count];
            foreach (DataColumn col in obNewDt.Columns)
            {
                strColNames[idx++] = col.ColumnName;
            }

            IEnumerator viewEnumerator = obDataView.GetEnumerator();
            while (viewEnumerator.MoveNext())
            {
                DataRowView drv = (DataRowView)viewEnumerator.Current;
                DataRow dr = obNewDt.NewRow();

                foreach (string strName in strColNames)
                {
                    dr[strName] = drv[strName];
                }

                obNewDt.Rows.Add(dr);
            }
            return obNewDt;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            //IniControl_CN();
        }

        //校验日期型
        public static bool IsDate(string StrSource)
        {

            return Regex.IsMatch(StrSource, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");

        }   
  

    }
}