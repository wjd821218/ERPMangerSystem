using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace ErpManage
{
    /// <summary>
    /// 文件查看，查看有权限的文件
    /// </summary>
    public partial class frmFileView : frmBase
    {
        FileDataManage FileDataManage = new FileDataManage();
        public frmFileView()
        {
            InitializeComponent();
        }

        private void frmFileView_Load(object sender, EventArgs e)
        {
            LoadFileClassTree();

            LoadFileData(GetSQL());
            LoadFileDetailData("");


            treeView1.ExpandAll();

            treeView1.SelectedNode = treeView1.Nodes[0];

          
        }

        /// <summary>
        /// 加载树
        /// </summary>
        public void LoadFileClassTree()
        {

            DataTable mdt = new DataTable();
            FileClassManage pmc = new FileClassManage();
            mdt = pmc.GetFileClassData();

            this.treeView1.ImageList = imageList2;
            if (mdt.Rows.Count > 0)
            {
                int MaxLayer = 10;
                ArrayList al = new ArrayList();
                for (int i = 1; i <= MaxLayer; i++)
                {

                    if (i == 1)
                    {
                        DataRow[] dr;
                        dr = mdt.Select("FatherID='0'", "OrderNo");
                        for (int j = 0; j < dr.Length; j++)
                        {
                            TreeNode tn = new TreeNode();
                            tn.Text = dr[j]["InterName"].ToString();

                            tn.Tag = dr[j]["InterID"].ToString();

                            this.treeView1.Nodes.Add(tn);
                            al.Add(tn);

                        }
                        dr = null;
                    }
                    else
                    {
                        int upLenth = al.Count; //记录上一层节点数
                        for (int k = 0; k < upLenth; k++)
                        {
                            TreeNode tvn = (TreeNode)al[k];
                            DataRow[] dr = mdt.Select("FatherID='" + tvn.Tag.ToString() + "'", "OrderNo");
                            for (int j = 0; j < dr.Length; j++)
                            {
                                TreeNode tn = new TreeNode();
                                tn.Text = dr[j]["InterName"].ToString();
                                tn.Tag = dr[j]["InterID"].ToString();
                                tvn.Nodes.Add(tn);
                                al.Add(tn); //增加本层节点，以便下一层加载
                            }
                            dr = null;
                        }
                        for (int k = upLenth - 1; k >= 0; k--)
                        {
                            al.RemoveAt(k); //删除上一层节点的引用
                        }
                        if (al.Count == 0)
                        {
                            break;
                        }
                    }
                }
                al = null;
            }

            mdt.Dispose();
        }



        //载入货品数据
        public void LoadFileData(string strsql)
        {
            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileAllView", "Qry") == true)
            {
                DataTable dtl = FileDataManage.sp_GetFileDataView(SysParams.UserID, SysParams.UserName, strsql,"1");
                gridControl1.DataSource = dtl;
            }
            else
            {
                DataTable dtl = FileDataManage.sp_GetFileDataView(SysParams.UserID, SysParams.UserName, strsql,"0");
                gridControl1.DataSource = dtl;
            
            }


            gridView1.Columns["FileGuID"].Visible = false;

        }


        public void LoadFileDetailData(string FileGuid)
        {
            //加载明细数据
            FileDataAttachmentManage FileDataAttachmentManage = new FileDataAttachmentManage();
            DataTable dtlDetail = FileDataAttachmentManage.GetFileDataAttachmentByFileGuID(FileGuid);

            gridControl2.DataSource = dtlDetail;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
             if (gridView1.RowCount > 0)
            {
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuid"].ToString();

                LoadFileDetailData(guid);
           
            }

         
        }

    
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            //获取当前文件的FileDataAttachmentGuid
            if (gridView2.RowCount > 0)
            {
                //判断是否为自己创建的文件
                //if (FileDataManage.GetFileCreateName(((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuid"].ToString()) != SysParams.UserID)
                //{
                //    this.ShowAlertMessage("你没有权限查看此文件!");
                //    return;
                //}


                string guid = ((DataRowView)(gridView2.GetFocusedRow())).Row["FileDataAttachmentGuid"].ToString();

                string FileSourceName = ((DataRowView)(gridView2.GetFocusedRow())).Row["FileSourceName"].ToString();

              
                if (FileSourceName.ToLower().IndexOf(".pdf") > 0)
                {
                    //PDF文档才用专门的窗口打开，别的文档直接调用系统的安装程序直接打开
                    //调用pdf显示窗口显示文档
                    frmViewPDF frmViewPDF = new frmViewPDF();
                    frmViewPDF.ViewPDF(guid);

                }
                else
                {
                    //打开文件，不包括pdf文件
                    OpenFile(guid);
                }
            }  
        }

        /// <summary>
        /// 显示文件,不包括PDF文件
        /// </summary>
        /// <param name="FileDataAttachmentGuid"></param>
        public void OpenFile(string FileDataAttachmentGuid)
        {
            FileDataManage FileDataManage = new FileDataManage();
            DataTable dtl = FileDataManage.GetFileDataAttachmentByAttachmentGuid(FileDataAttachmentGuid);

            if (dtl.Rows.Count > 0)
            {
                Byte[] bytes = (Byte[])dtl.Rows[0]["FileContent"];
                string strFileSourceName = dtl.Rows[0]["FileSourceName"].ToString();

                Random ran = new Random();
                int num = ran.Next(1, 10);

                //先将文件下载到本地
                txtFilePath.Text = Application.StartupPath + @"\FileAttachment\" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + num.ToString() + strFileSourceName;
                FileStream fs = new FileStream(txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();

                try
                {
                    //打开文件
                    Process p = new Process();
                    p.StartInfo.FileName = txtFilePath.Text;
                    p.StartInfo.Arguments = "/FileAttachment";
                    p.Start();

                }
                catch
                {
                    this.ShowAlertMessage("当前文件无法打开，本地没有安装此文件的安装程序!");
                }
                
            }
            


            
        }

        //下载
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            //获取当前文件的FileDataAttachmentGuid
            if (gridView2.RowCount > 0)
            {
                //得到当前登陆人员所在部门
                EmployeeManage EmployeeManage = new EmployeeManage();
                string strDept = EmployeeManage.GetEmpDeptByEmpName(SysParams.UserName);

                string strEmpGuid = EmployeeManage.GetEmpGuIDByEmpName(SysParams.UserName);

                string strFileGuID = ((DataRowView)(gridView1.GetFocusedRow())).Row["FileGuid"].ToString();

                if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileAllView", "Qry") == false)
                {

                    //判断是否有下载权限
                    FileApplyManage FileApplyManage = new FileApplyManage();
                    if (FileApplyManage.IsDownloadByUserID(strEmpGuid, strDept, strFileGuID) == false)
                    {
                        this.ShowAlertMessage("你没有权限下载此文件！");
                        return;
                    }


                   // this.ShowAlertMessage("你没有权限下载此文件！");
                   // return;

                }


              



               

                string guid = ((DataRowView)(gridView2.GetFocusedRow())).Row["FileDataAttachmentGuid"].ToString();



                FileDataManage FileDataManage = new FileDataManage();
                DataTable dtl = FileDataManage.GetFileDataAttachmentByAttachmentGuid(guid);

                if (dtl.Rows.Count > 0)
                {
                    Byte[] bytes = (Byte[])dtl.Rows[0]["FileContent"];

                 
                    //先将文件下载到本地
                    SaveFileDialog SaveFileDialog1=new SaveFileDialog();
                    SaveFileDialog1.FileName=dtl.Rows[0]["FileSourceName"].ToString();
                    SaveFileDialog1.Filter = "All   files   (*.*)|*.* "; 

                    SaveFileDialog1.RestoreDirectory = true; 

                    if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        string strfilepath = SaveFileDialog1.FileName ;
                        FileStream fs = new FileStream(strfilepath, FileMode.OpenOrCreate, FileAccess.Write);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                    }


                }
                
               
             

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFileControlType_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(9);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtControlType.Text = ""; //名称
                    txtControlType.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtControlType.Text = arrValue[1]; //名称
                        txtControlType.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnQry_Click(object sender, EventArgs e)
        {
            LoadFileData(GetSQL());
            LoadFileDetailData("");
        }


        private string GetSQL()
        {
            string strsql = " where  IsEnable='0' ";


            if (txtFileID.Text.Trim() != "")
            {
                strsql = strsql + " and FileID like '" + txtFileID.Text.Trim().Replace("'", "''") + "%'";
            }

            if (txtFileName.Text.Trim() != "")
            {
                strsql = strsql + " and FileName like '" + txtFileName.Text.Trim().Replace("'", "''") + "%'";
            }

            if (dePublishBeginDate.Text != "")
            {
                strsql = strsql + " and PublishDate>='" + dePublishBeginDate.Text.Trim() + " 00:00:00'";
            }

            if (dePublishEndDate.Text.Trim() != "")
            {
                strsql = strsql + " and PublishDate<='" + dePublishEndDate.Text.Trim() + " 23:59:59'";
            }

            if (txtProductName.Text.Trim() != "")
            {
                strsql = strsql + " and ProductName like '" + txtProductName.Text.Trim().Replace("'", "''") + "%'";
            }

            if (txtVersionID.Text.Trim() != "")
            {
                strsql = strsql + " and VersionID like '" + txtVersionID.Text.Trim().Replace("'", "''") + "%'";
            }

            if (txtControlType.Text.Trim() != "")
            {
                strsql = strsql + " and ControlType like '" + txtControlType.Tag.ToString() + "'";
            }

            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text != "文件类别")
                {
                    strsql = strsql + " and FileType like '" + treeView1.SelectedNode.Tag.ToString() + "'";
                }
            }


            return strsql;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //加载数据
            if (treeView1.SelectedNode.Text != "文件类别")
            {

                this.LoadFileData(GetSQL());
            }
            else
            {
                this.LoadFileData("where  IsEnable='0'");
            }
        }

       

    }
}