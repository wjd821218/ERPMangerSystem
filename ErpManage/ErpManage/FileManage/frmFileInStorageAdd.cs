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
    /// 文件入库
    /// </summary>
    public partial class frmFileInStorageAdd :frmBase
    {
        FileInStorageManage FileInStorageManage = new FileInStorageManage();
        public frmFileInStorageAdd()
        {
            InitializeComponent();
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


            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);

            return _dt;
        }



        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }



            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageCheck2", "Check2") == false)
            {
                tsbCheck2.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "FileInStorageUnCheck2", "UnCheck2") == false)
            {
                tsbUnCheck2.Enabled = false;
            }

        }



        //新增
        public void AddBill()
        {

            txtFileInStorageGuID.Text = Guid.NewGuid().ToString();
            txtFileInStorageID.Text = GetAutoId("FileInStorage");

            txtStoragePerson.Text = "";
            txtStoragePerson.Tag = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtRemark.Text = "";

            this.gridControl1.DataSource = IniBindTable();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;
            tsbCheck2.Enabled = false;
            tsbUnCheck2.Enabled = false;
            
            SetRight();

            this.ShowDialog();

        }

         

        //编辑
        public void EditBill(string FileInStorageGuID)
        {
            txtFileInStorageGuID.Text= FileInStorageGuID;
            DataTable dtl = FileInStorageManage.GetFileInStorageByFileInStorageGuid(FileInStorageGuID);

            txtFileInStorageID.Text = dtl.Rows[0]["FileInStorageID"].ToString();
            dtpFileInStorageDate.Text = DateTime.Parse(dtl.Rows[0]["FileInStorageDate"].ToString()).ToString("yyyy-MM-dd");

            txtStoragePerson.Text = dtl.Rows[0]["FileInStoragePersonName"].ToString();
            txtStoragePerson.Tag = dtl.Rows[0]["FileInStoragePerson"].ToString();


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


           txtCheckGuid2.Tag = dtl.Rows[0]["CheckGuid2"].ToString();
           txtCheckGuid2.Text = dtl.Rows[0]["CheckName2"].ToString();

           if (dtl.Rows[0]["CheckDate2"].ToString().Contains("1900-01-01") == false)
           {
               txtCheckDate2.Text = dtl.Rows[0]["CheckDate2"].ToString();
           }
           else
           {
               txtCheckDate2.Text = "";
           }


           //判断是否已经二级审核
           if (txtCheckGuid2.Text.Trim() != "")
           {
               tsbSave.Enabled = false;

               tsbCheck.Enabled = false;
               tsbUnCheck.Enabled = false;

               tsbCheck2.Enabled = false;
               tsbUnCheck2.Enabled = true;


           }
           else
           {   //是否一级审核
               if (txtCheckGuid.Text.Trim() != "")
               {
                   tsbSave.Enabled = false;

                   tsbCheck.Enabled = false;
                   tsbUnCheck.Enabled = true;

                   tsbCheck2.Enabled = true;
                   tsbUnCheck2.Enabled = false;

               }
               else
               {
                   tsbSave.Enabled = true;

                   tsbCheck.Enabled = true;
                   tsbUnCheck.Enabled = false;

                   tsbCheck2.Enabled = false;
                   tsbUnCheck2.Enabled = false;


               }
           }
            

            //加载明细
            DataTable dtl2 = new DataTable();
            dtl2 = FileInStorageManage.GetFileInStorageDetail(FileInStorageGuID);
            gridControl1.DataSource = dtl2;


            //用于打印
            //DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            //ds.Tables.Clear();
            //ds.Tables.Add(dtl3.Copy());
            //ds.Tables[0].TableName = "ConsignOutDetail";

            SetRight();
            this.ShowDialog();
        }
    

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            FileDataManage FileDataManage = new FileDataManage();
            frmSelectFile_InStorage frmSelectFile_InStorage = new frmSelectFile_InStorage();
            frmSelectFile_InStorage.ShowDialog();



            if (frmSelectFile_InStorage.Tag != null)
            {
                //取出选择的文件Guid
                List<string> lstGuid = frmSelectFile_InStorage.Tag as List<string>;


                //选择的文件填充
                if (lstGuid.Count > 0)
                {
                    //得到文件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
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
                        gridView1.SetFocusedRowCellValue(gridFileTypeName, FileDataManage.GetFileTypeName(filedata.FileType));
                        gridView1.SetFocusedRowCellValue(gridControlTypeName, base.GetBasicDataNameByID(filedata.ControlType));



                    }




                }

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void btnSelectStoragePerson_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtStoragePerson.Text = ""; //名称
                    txtStoragePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtStoragePerson.Text = arrValue[1]; //名称
                        txtStoragePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFileInStorageID.Text = GetAutoId("FileInStorage");
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtFileInStorageGuID.Text = Guid.NewGuid().ToString();


            txtStoragePerson.Text = "";
            txtStoragePerson.Tag = "";

            dtpFileInStorageDate.Text = "";

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

         

            if (dtpFileInStorageDate.Text == "")
            {
                this.ShowAlertMessage("必须输入库单日期!");
                return;
            }

            if (gridView1.RowCount <= 0)
            {
                this.ShowAlertMessage("必须增加明细数据!");
                return;
            }



            FileInStorage FileInStorage = new FileInStorage();
            FileInStorage.FileInStorageGuID = txtFileInStorageGuID.Text;
            FileInStorage.FileInStorageID = txtFileInStorageID.Text;
            FileInStorage.FileInStorageDate = DateTime.Parse(dtpFileInStorageDate.Text);
            if (txtStoragePerson.Tag!= null)
            {
                FileInStorage.FileInStoragePerson = txtStoragePerson.Tag.ToString();
            }

            FileInStorage.Remark = txtRemark.Text.Replace("'","''");

            FileInStorage.CreateGuid = txtCreateGuid.Tag.ToString();
            FileInStorage.CreateDate = DateTime.Now;
            FileInStorage.CheckGuid = "";
            FileInStorage.CheckDate = DateTime.Parse("1900-01-01");
            FileInStorage.CheckGuid = "";
            FileInStorage.CheckDate2 = DateTime.Parse("1900-01-01");




            List<FileInStorageDetail> list = new List<FileInStorageDetail>();
            FileInStorageDetail FileInStorageDetail = new FileInStorageDetail();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView1.GetRow(i));

                FileInStorageDetail= new FileInStorageDetail();
                FileInStorageDetail.FileInStorageDetailGuID = Guid.NewGuid().ToString();
                FileInStorageDetail.FileInStorageGuID =txtFileInStorageGuID.Text;
                FileInStorageDetail.FileGuID = dr["FileGuID"].ToString();


                FileInStorageDetail.SortID = i;
                list.Add(FileInStorageDetail);
            }



            //保存
            FileInStorageManage.SaveBill(FileInStorage, list);

            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "文件入库单保存", "保存", SysParams.UserName + "用户保存文件入库单,唯一号:" + txtFileInStorageGuID.Text + ",文件入库单号:" + txtFileInStorageID.Text);

            //用于打印
            //DataTable dtl3 = base.GetDataTable((DataView)gridView1.DataSource);
            //ds.Tables.Clear();
            //ds.Tables.Add(dtl3.Copy());
            //ds.Tables[0].TableName = "FileInStorageDetail";


            this.Tag = "edit";
            this.ShowMessage("保存成功");

            frmFileInStorage.frmfileinstorage.LoadData();
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该文件入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileInStorageManage.CheckBill(txtFileInStorageGuID.Text, 1);
                 
                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;



                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;



                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件入库单审核", "审核", SysParams.UserName + "用户审核文件入库单,唯一号:" + txtFileInStorageGuID.Text+ ",文件入库单号:" +txtFileInStorageID.Text);

                //刷新列表界面

                frmFileInStorage.frmfileinstorage.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该文件入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileInStorageManage.CheckBill(txtFileInStorageGuID.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";



                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = false;

                tsbSave.Enabled = true;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件入库单反审", "反审", SysParams.UserName + "用户反审文件入库单,唯一号:" + txtFileInStorageGuID.Text + ",文件入库单号:" + txtFileInStorageID.Text);

                //刷新列表界面

                frmFileInStorage.frmfileinstorage.LoadData();
            }
        }



        private void tsbCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级审该文件入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileInStorageManage.CheckBill2(txtFileInStorageGuID.Text, 1);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = DateTime.Now.ToString();
                txtCheckGuid2.Tag = SysParams.UserID;
                txtCheckGuid2.Text = SysParams.UserName;

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = false;

                tsbCheck2.Enabled = false;
                tsbUnCheck2.Enabled = true;

                tsbSave.Enabled = false;

                SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件入库单二级审该", "二级审该", SysParams.UserName + "用户二级审该文件入库单,唯一号:" + txtFileInStorageGuID.Text + ",文件入库单号:" + txtFileInStorageID.Text);


                frmFileInStorage.frmfileinstorage.LoadData();
            }
        }

        private void tsbUnCheck2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定二级反审文件入库单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                FileInStorageManage.CheckBill2(txtFileInStorageGuID.Text, 0);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate2.Text = "";
                txtCheckGuid2.Tag = "";
                txtCheckGuid2.Text = "";

                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;

                tsbCheck2.Enabled = true;
                tsbUnCheck2.Enabled = false;

                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "文件入库单二级反审", "二级反审", SysParams.UserName + "用户二级反审文件入库单号,唯一号:" + txtFileInStorageGuID.Text + ",文件入库单号:" + txtFileInStorageID.Text);


                frmFileInStorage.frmfileinstorage.LoadData();
            }
        }
    }
}