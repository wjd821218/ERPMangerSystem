using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Web.UI.WebControls;

namespace ErpManage
{
    /// <summary>
    /// 用户权限组管理(用户属于那个权限组)
    /// </summary>
    public partial class frmRight : frmBase 
    {
        public frmRight()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 组功能权限设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmGroupRightSet frmGroupRightSet = new frmGroupRightSet();
            frmGroupRightSet.ShowDialog();
        }

        /// <summary>
        /// 组管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmRightGroup frmRightGroup = new frmRightGroup();
            frmRightGroup.ShowDialog();

            LoadRightGroup();
        }

        private void frmRight_Load(object sender, EventArgs e)
        {
            LoadLoginUser();

            LoadRightGroup();
        }


        /// <summary>
        /// 加载当前所有用户
        /// </summary>
        private void LoadLoginUser()
        {
            LoginUserManage LoginUserManage = new LoginUserManage();
            DataTable dtl = LoginUserManage.GetLoginUserInfo();

            ListItem listitem = new ListItem();
            chklstUser.Items.Clear();

            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                listitem = new ListItem();
                listitem.Text = dtl.Rows[i]["UserName"].ToString();
                listitem.Value = dtl.Rows[i]["UserID"].ToString();
                chklstUser.Items.Add(listitem);

            }

        }


        /// <summary>
        /// 加载权限组
        /// </summary>
        private void LoadRightGroup()
        {
            RightGroupManage RightGroupManage = new RightGroupManage();
            DataTable dtl = RightGroupManage.GetRightGroupInfo();

            ListItem listitem = new ListItem();
            chklstGroup.Items.Clear();
             
            for (int i = 0; i < dtl.Rows.Count; i++)
            {
                listitem = new ListItem();
                listitem.Text = dtl.Rows[i]["GroupName"].ToString();
                listitem.Value = dtl.Rows[i]["GroupGuid"].ToString();
                chklstGroup.Items.Add(listitem);

            }

        }

        //保存
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            //先判断是否有选择操作员
            if (chklstUser.CheckedItems.Count <= 0)
            {
                this.ShowMessage("请选择操作员!");
                return;
            }


            List<string> lstUser = new List<string>();
            List<string> lstGroup = new List<string>();
            ListItem listitem = new ListItem();

            for (int i = 0; i < chklstUser.CheckedItems.Count; i++)
            {

                listitem = chklstUser.CheckedItems[i] as ListItem;

          
                lstUser.Add(listitem.Value);
            }

            listitem = new ListItem();
            for (int i = 0; i < chklstGroup.CheckedItems.Count; i++)
            {
                listitem = chklstGroup.CheckedItems[i] as ListItem;

                lstGroup.Add(listitem.Value);
            }

            RightGroupManage RightGroupManage = new RightGroupManage();

            RightGroupManage.SaveUserRightGroup(lstUser, lstGroup);

            this.ShowMessage("用户权限设置保存成功!");

        }

        private void chklstUser_Click(object sender, EventArgs e)
        {
           

          
        }

        private void chklstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstGroup.Items.Count; i++)
            {
                chklstGroup.SetItemChecked(i, false);
            }

            RightGroupManage RightGroupManage = new RightGroupManage();
            string userid = ((ListItem)chklstUser.SelectedItem).Value;
            DataTable dtl = RightGroupManage.GetUserGroup(userid);
            ListItem listitem = new ListItem();
            for (int i = 0; i < chklstGroup.Items.Count; i++)
            {
                listitem = chklstGroup.Items[i] as ListItem;

                for (int j = 0; j < dtl.Rows.Count; j++)
                {
                    if (dtl.Rows[j]["GroupID"].ToString().Trim() == listitem.Value)
                    {
                        chklstGroup.SetItemChecked(i, true);
                        break;
                    }

                }
            }
        }

        private void chkAllUser_Click(object sender, EventArgs e)
        {
            if (chkAllUser.Checked == true)
            {
                for (int i = 0; i < chklstUser.Items.Count; i++)
                {
                    chklstUser.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chklstUser.Items.Count; i++)
                {
                    chklstUser.SetItemChecked(i, false);
                }
            }
        }

        private void chkAllGroup_Click(object sender, EventArgs e)
        {
            if (chkAllGroup.Checked == true)
            {
                for (int i = 0; i < chklstGroup.Items.Count; i++)
                {
                    chklstGroup.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chklstGroup.Items.Count; i++)
                {
                    chklstGroup.SetItemChecked(i, false);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chklstUser_Click_1(object sender, EventArgs e)
        {
            ((System.Windows.Forms.CheckedListBox)(sender)).CheckOnClick = true;
        }

        private void chklstGroup_Click(object sender, EventArgs e)
        {
            ((System.Windows.Forms.CheckedListBox)(sender)).CheckOnClick = true;
        }
    }
}