using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.IO;
using System.Diagnostics;

namespace ErpManage
{
    /// <summary>
    /// 文件申请新增
    /// </summary>
    public partial class frmFileApplyAdd : frmBase
    {
        FileDataManage FileDataManage = new FileDataManage();
        FileApplyManage FileApplyManage = new FileApplyManage();
        DataSet ds = new DataSet();
        public frmFileApplyAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileApplySave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileApplyCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileApplyUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }


          





        }



        //新增
        public void AddBill()
        {

            txtFileApplyGuID.Text = Guid.NewGuid().ToString();
            txtFileApplyID.Text = GetAutoId("FileApply");

            rdoPerson.Checked = true;
            rdoDept.Checked = false;

            txtFileApplyPerson.Enabled = true;
            btnSelectFileApplyPerson.Enabled = true;

            txtFileApplyDept.Enabled = false;
            btnSelectFileApplyDept.Enabled = false;

            txtFileApplyPerson.Text = "";
            txtFileApplyPerson.Tag = "";

            txtFileApplyDept.Text = "";
            txtFileApplyDept.Tag = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtCheckGuid.Text = "";
            txtCreateDate.Text = "";

            txtRemark.Text = "";

            this.gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
           
            SetRight();

            this.ShowDialog();

        }



        //编辑
        public void EditBill(string FileApplyGuID)
        {
            txtFileApplyGuID.Text = FileApplyGuID;
            DataTable dtl = FileApplyManage.GetFileApplyByFileApplyGuid(FileApplyGuID);

            txtFileApplyID.Text = dtl.Rows[0]["FileApplyID"].ToString();
            dtpFileApplyDate.Text = DateTime.Parse(dtl.Rows[0]["FileApplyDate"].ToString()).ToString("yyyy-MM-dd");

            if (dtl.Rows[0]["FileApplyType"].ToString().Trim() == "1")
            {
                rdoPerson.Checked = true;
                rdoDept.Checked = false;

                //txtFileApplyPerson.Text = dtl.Rows[0]["FileApplyPerson"].ToString();
                //txtFileApplyPerson.Tag = dtl.Rows[0]["FileApplyPerson"].ToString();

                txtFileApplyDept.Text = "";
                txtFileApplyDept.Tag = "";

                txtFileApplyPerson.Enabled = true;
                btnSelectFileApplyPerson.Enabled = true;

                txtFileApplyDept.Enabled = false;
                btnSelectFileApplyDept.Enabled = false;
            }
            else
            {
                rdoPerson.Checked = false;
                rdoDept.Checked = true;

                txtFileApplyDept.Text = dtl.Rows[0]["FileApplyDeptName"].ToString();
                txtFileApplyDept.Tag = dtl.Rows[0]["FileApplyDept"].ToString();

                txtFileApplyPerson.Text = "";
                txtFileApplyPerson.Tag = "";


                txtFileApplyPerson.Enabled = false;
                btnSelectFileApplyPerson.Enabled = false;

                txtFileApplyDept.Enabled = true;
                btnSelectFileApplyDept.Enabled = true;
            }




            txtRemark.Text = dtl.Rows[0]["Remark"].ToString();

            txtCreateGuid.Tag = dtl.Rows[0]["CreateGuid"].ToString();
            txtCreateGuid.Text = dtl.Rows[0]["CreateName"].ToString();
            if (dtl.Rows[0]["CreateDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCreateDate.Text = dtl.Rows[0]["CreateDate"].ToString();
            }
            else
            {
                txtCreateDate.Text = "";
            }


            txtCheckGuid.Tag = dtl.Rows[0]["CheckGuid"].ToString();
            txtCheckGuid.Text = dtl.Rows[0]["CheckName"].ToString();




            if (dtl.Rows[0]["CheckDate"].ToString().Contains("1900-01-01") == false)
            {
                txtCheckDate.Text = dtl.Rows[0]["CheckDate"].ToString();
            }
            else
            {
                txtCheckDate.Text = "";
            }




            //是否一级审核
            if (txtCheckGuid.Text.Trim() != "")
            {
                tsbSave.Enabled = false;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;



            }
            else
            {
                tsbSave.Enabled = true;

                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;



            }


            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = FileApplyManage.GetFileApplyDetail(FileApplyGuID);
            gridControl1.DataSource = dtl2;

            //加载明细
            List<SelectEmployee> lstemp = new List<SelectEmployee>();
            SelectEmployee SelectEmployee = new SelectEmployee();
            DataTable dtl3 = new DataTable();
            dtl3 = FileApplyManage.GetFileApplyPersonDetail(FileApplyGuID);
            string strPersonName = "";
            for (int i = 0; i < dtl3.Rows.Count; i++)
            {
                SelectEmployee = new SelectEmployee();
                SelectEmployee.EmpGuid = dtl3.Rows[i]["PersonGuID"].ToString();
                SelectEmployee.EmpName = dtl3.Rows[i]["PersonName"].ToString();
                lstemp.Add(SelectEmployee);

                strPersonName = strPersonName + " " + dtl3.Rows[i]["PersonName"].ToString();

            }

            txtFileApplyPerson.Text = strPersonName.Trim();
            txtFileApplyPerson.Tag = lstemp;


            //用于打印
            DataTable dtl4 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl4.Copy());
            ds.Tables[0].TableName = "FileApplyDetail";

             SetRight();
            this.ShowDialog();
        }



        //初始经表格
        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("FileGuID");
            DataColumn _datacol2 = new DataColumn("FileID");
            DataColumn _datacol3 = new DataColumn("FileName");
            DataColumn _datacol4 = new DataColumn("FileTypeName");
            DataColumn _datacol5 = new DataColumn("ControlTypeName");
            DataColumn _datacol6 = new DataColumn("Remark");
            DataColumn _datacol7 = new DataColumn("VersionID");
            DataColumn _datacol8 = new DataColumn("PublishDate");
            DataColumn _datacol9 = new DataColumn("IsDownload");
        

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);


            return _dt;
        }


        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmSelectFile frmSelectFile = new frmSelectFile();
            frmSelectFile.ShowDialog();



            if (frmSelectFile.Tag != null)
            {
                //取出选择的文件Guid
                List<string> lstGuid = frmSelectFile.Tag as List<string>;


                //选择的文件填充
                if (lstGuid.Count > 0)
                {
                    //得到文件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        //判断当前文件是否已经选在表格中了
                        if (IsExistFileGuID(lstGuid[i]) == false)
                        {

                            FileData filedata = new FileData();
                            filedata = FileDataManage.GetFileData(lstGuid[i]);


                            //填充数据
                            gridView1.AddNewRow();
                            gridView1.SetFocusedRowCellValue(gridFileGuID, filedata.FileGuID);
                            gridView1.SetFocusedRowCellValue(gridFileID, filedata.FileID);
                            gridView1.SetFocusedRowCellValue(gridFileName, filedata.FileName);
                            gridView1.SetFocusedRowCellValue(gridVersionID, filedata.VersionID);
                            gridView1.SetFocusedRowCellValue(gridPublishDate, DateTime.Parse(filedata.PublishDate.ToString()).ToString("yyyy-MM-dd"));
                            gridView1.SetFocusedRowCellValue(gridFileTypeName, FileDataManage.GetFileTypeName(filedata.FileType));
                            gridView1.SetFocusedRowCellValue(gridControlTypeName, base.GetBasicDataNameByID(filedata.ControlType));

                           
                        }
                    }




                }

            }

        }

        /// <summary>
        /// 判断是否已经存在已选网格中
        /// </summary>
        /// <param name="strFileGuID"></param>
        /// <returns></returns>
        public bool IsExistFileGuID(string strFileGuID)
        {
            txtRemark.Focus();
            gridView1.UpdateCurrentRow();

            bool value = false;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));
                if (dr["FileGuID"].ToString().Trim() == strFileGuID)
                {
                    value=true;
                    break;
                }
              
            }

            return value;
        }




        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFileApplyID.Text = GetAutoId("FileApply");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtCheckGuid.Text = "";
            txtCheckDate.Text = "";

            txtFileApplyGuID.Text = Guid.NewGuid().ToString();


            txtFileApplyPerson.Text = "";
            txtFileApplyPerson.Tag = "";


            txtFileApplyDept.Text = "";
            txtFileApplyDept.Tag = "";

            txtRemark.Text = "";
            gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;


            SetRight();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            txtRemark.Focus();
            gridView1.UpdateCurrentRow();



            if (dtpFileApplyDate.Text == "")
            {
                this.ShowAlertMessage("必须输入申请单日期!");
                return;
            }

            if (rdoPerson.Checked == true)
            {
                if (txtFileApplyPerson.Text.Trim() == "")
                {
                    this.ShowAlertMessage("必须输入申请人!");
                    return;
                }
            }

            if (rdoDept.Checked == true)
            {
                if (txtFileApplyDept.Text.Trim() == "")
                {
                    this.ShowAlertMessage("必须输入申请部门!");
                    return;
                }
            }


            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }



            FileApply FileApply = new FileApply();
            FileApply.FileApplyGuID = txtFileApplyGuID.Text;
            FileApply.FileApplyID = txtFileApplyID.Text;
            FileApply.FileApplyDate = DateTime.Parse(dtpFileApplyDate.Text);

            if (rdoPerson.Checked == true)
            {
                FileApply.FileApplyType = "1";
            }
            else if (rdoDept.Checked == true)
            {
                FileApply.FileApplyType = "2";
            
            }


            if (txtFileApplyPerson.Tag != null)
            {
                FileApply.FileApplyPerson = txtFileApplyPerson.Text;
            }

            if (txtFileApplyDept.Tag != null)
            {
                FileApply.FileApplyDept = txtFileApplyDept.Tag.ToString();
            }

            FileApply.Remark = txtRemark.Text.Replace("'", "''");

            FileApply.CreateGuid = txtCreateGuid.Tag.ToString();
            FileApply.CreateDate = DateTime.Now;
            FileApply.CheckGuid = "";
            FileApply.CheckDate = DateTime.Parse("1900-01-01");
            FileApply.CheckGuid = "";
          




            List<FileApplyDetail> list = new List<FileApplyDetail>();
            FileApplyDetail FileApplyDetail = new FileApplyDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                FileApplyDetail = new FileApplyDetail();
                FileApplyDetail.FileApplyDetailGuID = Guid.NewGuid().ToString();
                FileApplyDetail.FileApplyGuID = txtFileApplyGuID.Text;
                FileApplyDetail.FileGuID = dr["FileGuID"].ToString();
                if (dr["IsDownload"].ToString().ToUpper() == "TRUE")
                {
                    FileApplyDetail.IsDownload = "1"; //有下载权限
                }
                else
                {
                    FileApplyDetail.IsDownload = "0";//无下载权限
                }
            


                FileApplyDetail.SortID = i;
                list.Add(FileApplyDetail);
            }



            List<FileApplyPersonDetail> lst2 = new List<FileApplyPersonDetail>();
            FileApplyPersonDetail FileApplyPersonDetail = new FileApplyPersonDetail();
            if (txtFileApplyPerson.Text.Trim() != null)
            {
                List<SelectEmployee> lstSelect = txtFileApplyPerson.Tag as List<SelectEmployee>;
                if (lstSelect != null)
                {
                    for (int i = 0; i < lstSelect.Count; i++)
                    {
                        FileApplyPersonDetail = new FileApplyPersonDetail();

                        FileApplyPersonDetail.FileApplyPersonDetailGuID = Guid.NewGuid().ToString();
                        FileApplyPersonDetail.FileApplyGuID = txtFileApplyGuID.Text;
                        FileApplyPersonDetail.PersonGuID = lstSelect[i].EmpGuid;
                        FileApplyPersonDetail.SortID = i;
                        lst2.Add(FileApplyPersonDetail);
                    }
                }

            }


            //保存
            FileApplyManage.SaveBill(FileApply, list, lst2);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "文件申请单保存", "保存", SysParams.UserName + "用户保存文件申请单,唯一号:" + txtFileApplyGuID.Text + ",文件申请单号:" + txtFileApplyID.Text);

            //用于打印
            DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            ds.Tables.Clear();
            ds.Tables.Add(dtl3.Copy());
            ds.Tables[0].TableName = "FileApplyDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmFileApply.frmfileapply.LoadData();
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该文件申请单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileApplyManage.CheckBill(txtFileApplyGuID.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;



                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


            



                tsbSave.Enabled = false;

                //SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件申请单审核", "审核", SysParams.UserName + "用户审核文件申请单,唯一号:" + txtFileApplyGuID.Text + ",文件申请单号:" + txtFileApplyID.Text);

                //刷新列表界面

                frmFileApply.frmfileapply.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该文件申请单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileApplyManage.CheckBill(txtFileApplyGuID.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";



                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

              

                tsbSave.Enabled = true;

                // SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件申请单反审", "反审", SysParams.UserName + "用户反审文件申请单,唯一号:" + txtFileApplyGuID.Text + ",文件申请单号:" + txtFileApplyID.Text);

                //刷新列表界面

                frmFileApply.frmfileapply.LoadData();
            }
        }


        private void btnSelectFileApplyPerson_Click(object sender, EventArgs e)
        {
           
            frmSelectOtherData3 frmSelectOtherData3 = new frmSelectOtherData3();
            frmSelectOtherData3.ShowSelectData(1);
            if (frmSelectOtherData3.Tag != null)
            {
                if (frmSelectOtherData3.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtFileApplyPerson.Text = ""; //名称
                    txtFileApplyPerson.Tag = "";  //Guid
                }
                else
                {
                   
                    List<SelectEmployee> lst = new List<SelectEmployee>();
                    lst = frmSelectOtherData3.Tag as List<SelectEmployee>;
                     //string strGuid="";
                    string strName="";
                    if (lst.Count > 0)
                    {
                       
                        for (int i = 0; i < lst.Count; i++)
                        {
                            //strGuid = strGuid +" "+ lst[i].EmpGuid;
                            strName = strName + " "+lst[i].EmpName;
                        
                        }

                        txtFileApplyPerson.Text = strName.Trim(); //名称
                        txtFileApplyPerson.Tag = lst;  //Guid
                    }
                }
            }
        }

        private void btnSelectFileApplyDept_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtFileApplyDept.Text = ""; //名称
                    txtFileApplyDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtFileApplyDept.Text = arrValue[1]; //名称
                        txtFileApplyDept.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void rdoPerson_Click(object sender, EventArgs e)
        {
            if (rdoPerson.Checked == true)
            {
                rdoDept.Checked = false;

                txtFileApplyDept.Text = "";
                txtFileApplyDept.Tag = "";


                txtFileApplyPerson.Enabled = true;
                btnSelectFileApplyPerson.Enabled = true;

                txtFileApplyDept.Enabled = false;
                btnSelectFileApplyDept.Enabled = false;
            }
            else if (rdoDept.Checked == true)
            {
                rdoPerson.Checked = false;
                txtFileApplyPerson.Text = "";
                txtFileApplyPerson.Tag = "";


                txtFileApplyPerson.Enabled = false;
                btnSelectFileApplyPerson.Enabled = false;

                txtFileApplyDept.Enabled = true;
                btnSelectFileApplyDept.Enabled = true;
            }


        }

        private void rdoDept_Click(object sender, EventArgs e)
        {

            if (rdoPerson.Checked == true)
            {
                rdoDept.Checked = false;

                txtFileApplyDept.Text = "";
                txtFileApplyDept.Tag = "";


                txtFileApplyPerson.Enabled = true;
                btnSelectFileApplyPerson.Enabled = true;

                txtFileApplyDept.Enabled = false;
                btnSelectFileApplyDept.Enabled = false;
            }
            else if (rdoDept.Checked == true)
            {
                rdoPerson.Checked = false;
                txtFileApplyPerson.Text = "";
                txtFileApplyPerson.Tag = "";


                txtFileApplyPerson.Enabled = false;
                btnSelectFileApplyPerson.Enabled = false;

                txtFileApplyDept.Enabled = true;
                btnSelectFileApplyDept.Enabled = true;
            }


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

                if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileAllView", "Qry") == false)
                {
                    if (rdoPerson.Checked == true)
                    {
                        if (FileApplyManage.IsViewRight_User(txtFileApplyGuID.Text, SysParams.UserName) == false)
                        {
                            this.ShowAlertMessage("你没有权限查看此文件,申请单中不存在当前登陆用户!");
                            return;
                        }
                    }
                    else if (rdoDept.Checked == true)
                    {
                        if (FileApplyManage.IsViewRight_Dept(txtFileApplyGuID.Text, SysParams.UserName) == false)
                        {
                            this.ShowAlertMessage("你没有权限查看此文件,申请单中不存在当前登陆人所在部门!");
                            return;
                        }
                    }

                }


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
                //if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileAllView", "Qry") == false)
                //{
                //    this.ShowAlertMessage("你没有权限下载此文件！");
                //    return;

                //}
                
                //得到当前登陆人员所在部门
                EmployeeManage EmployeeManage = new EmployeeManage();
                string strDept = EmployeeManage.GetEmpDeptByEmpName(SysParams.UserName);


                //判断是否有下载权限
                if (FileApplyManage.IsDownloadByUserID(SysParams.UserID, strDept, txtFileApplyGuID.Text) == false)
                {
                    this.ShowAlertMessage("你没有权限下载此文件！");
                    return;
                }



                string guid = ((DataRowView)(gridView2.GetFocusedRow())).Row["FileDataAttachmentGuid"].ToString();



                FileDataManage FileDataManage = new FileDataManage();
                DataTable dtl = FileDataManage.GetFileDataAttachmentByAttachmentGuid(guid);

                if (dtl.Rows.Count > 0)
                {
                    Byte[] bytes = (Byte[])dtl.Rows[0]["FileContent"];


                    //先将文件下载到本地
                    SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                    SaveFileDialog1.FileName = dtl.Rows[0]["FileSourceName"].ToString();
                    SaveFileDialog1.Filter = "All   files   (*.*)|*.* ";

                    SaveFileDialog1.RestoreDirectory = true;

                    if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        string strfilepath = SaveFileDialog1.FileName;
                        FileStream fs = new FileStream(strfilepath, FileMode.OpenOrCreate, FileAccess.Write);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                    }


                }




            }
        }



        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "True";//默认为选中 
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto case "True";
                case "No":
                    goto case "False";
                case "1":
                    goto case "True";
                case "0":
                    goto case "False";
                default:
                    e.CheckState = CheckState.Checked;
                    break;
            }
            e.Handled = true;

        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

            if (ds.Tables.Count <= 0)
            {
                this.ShowAlertMessage("请保存数据后再打印!");
                return;
            }

            string strFileType = "";
            if (rdoDept.Checked == true)
            {
                strFileType = "部门";
            }
            else if (rdoPerson.Checked == true)
            {
                strFileType = "员工";
            }



            
            //打印入库单
            XtraFileApply XtraFileApply = new XtraFileApply(ds, txtFileApplyID.Text, dtpFileApplyDate.Text, strFileType, txtFileApplyDept.Text, txtFileApplyPerson.Text,
                                                             txtRemark.Text,txtCreateGuid.Text, txtCreateDate.Text, txtCheckGuid.Text, txtCheckDate.Text);
            XtraFileApply.ShowPreview();
        }
      
    }
}