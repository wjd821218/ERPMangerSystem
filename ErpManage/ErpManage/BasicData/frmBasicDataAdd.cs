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
    /// 常用选项
    /// </summary>
    public partial class frmBasicDataAdd :frmBase
    {
        BasicDataManage BasicDataManage = new BasicDataManage();
        public frmBasicDataAdd()
        {
            InitializeComponent();
        }

       

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void loaddata()
        {
            
            int flag = 0;
            switch (listSelect.SelectedItem.ToString().Trim())
            {
                case "单位":
                    flag = 1; 
                    break;
                case "币种":
                    flag = 2;
                    break;
                case "结算方式":
                    flag = 3;
                    break;
                case "车间":
                    flag = 4;
                    break;
                case "仓库":
                    flag = 5;
                    break;
                case "规格":
                    flag = 6;
                    break;
                case "计价方法":
                    flag = 7;
                    break;
                case "财务科目":
                    flag = 8;
                    break;
                case "模具类别":
                    flag = 12;
                    break;
                case "产品类别":
                    flag = 13;
                    break;
            }

            //绑定仓库
            DataTable dtl = BasicDataManage.GetBasicData(flag);
            this.gridSelect.DataSource = dtl;
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string str = "";
            switch (listSelect.SelectedItem.ToString().Trim())
            {
                case "单位":
                    flag = 1;
                    str = "单位";
                    break;
                case "币种":
                    flag = 2;
                    str = "币种";
                    break;
                case "结算方式":
                    flag = 3;
                    str = "结算方式";
                    break;
                case "车间":
                    flag = 4;
                    str = "车间";
                    break;
                case "仓库":
                    flag = 5;
                    str = "仓库";
                    break;
                case "规格":
                    flag = 6;
                    str = "规格";
                    break;
                case "计价方法":
                    flag = 7;
                    str = "计价方法";
                    break;
                case "财务科目":
                    flag =8;
                    str = "财务科目";
                    break;
                case "模具类别":
                    flag = 12;
                    str = "模具类别";
                    break;
                case "产品类别":
                    flag =13;
                    str = "产品类别";
                    break;

            }

            if (BasicDataManage.IsExistUnit(flag.ToString(), txtValue.Text.Trim()) == true)
            {
                this.ShowMessage(str+"选项值已存在，请重输！");
                return;
            
            }



            ErpManageLibrary.BasicData basicData = new ErpManageLibrary.BasicData();
            basicData.UnitName = txtValue.Text;
            basicData.flag = flag;

            BasicDataManage.Save(basicData);

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "辅助数据新增", "新增", SysParams.UserName + "新增了flag=" + flag.ToString() + ", UnitName为" + txtValue.Text + "的辅助数据");


            loaddata();

           
        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (gridVProGroup.RowCount > 0)
            {
               
                switch (listSelect.SelectedItem.ToString().Trim())
                {
                    case "单位":
                        flag = 1;
                        break;
                    case "币种":
                        flag = 2;
                        break;
                    case "结算方式":
                        flag = 3;
                        break;
                    case "车间":
                        flag = 4;
                        break;
                    case "仓库":
                        flag = 5;
                        break;
                    case "规格":
                        flag = 6;
                        break;
                    case "计价方法":
                        flag = 7;
                        break;
                    case "财务科目":
                        flag = 8;
                        break;
                    case "模具类别":
                        flag = 12;
                        break;
                    case "产品类别":
                        flag = 13;
                        break;
                }
                DialogResult dr = MessageBox.Show("确定要删除所选择的记录吗", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string unitid = ((DataRowView)(gridVProGroup.GetFocusedRow())).Row[0].ToString();


                    BasicDataManage.DeleteBasicData(unitid);

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "辅助数据删除", "删除", SysParams.UserName + "删除了flag="+flag.ToString()+",Guid为" + unitid + "的辅助数据");


                    loaddata();
                }

            }
        }

        private void listSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}