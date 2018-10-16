using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.Web.UI.WebControls;
using System.IO;

namespace ErpManage
{
    /// <summary>
    /// 工程更改单
    /// </summary>
    public partial class frmChangeBillAdd :frmBase
    {
        ChangeBillManage ChangeBillManage = new ChangeBillManage();
        List<ChangeBillDataAttachment> lst = new List<ChangeBillDataAttachment>();
        private bool IsEdit = false;
        public frmChangeBillAdd()
        {
            InitializeComponent();
        }

        //权限判断
        public void SetRight()
        {

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeBillSave", "Save") == false)
            {
                btnAdd.Enabled = false;
                tsbSave.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeBillCheck", "Check") == false)
            {
                tsbCheck.Enabled = false;
            }

            if (rightgroupManage.IsOperateRightByUserID(SysParams.UserID, "ChangeBillUnCheck", "UnCheck") == false)
            {
                tsbUnCheck.Enabled = false;
            }



        }

        //新增
        public void Add()
        {

            txtFileName.Text = "";
            txtOldVersionID.Text = "";
            txtNewVersionID.Text = "";
          
            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            txtCheckGuid.Text = "";
            txtCheckDate.Text = "";


            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

            IsEdit = false;

            SetRight();

            this.ShowDialog();

        }

        //编辑
        public void Edit(string ChangeBillGuID)
        {


            FillData(ChangeBillGuID);

            IsEdit = true;

            SetRight();

            this.ShowDialog();

        }

       
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string ChangeBillGuID)
        {
            ChangeBillManage ChangeBillManage = new ChangeBillManage();

            DataTable dtl = ChangeBillManage.GetChangeBillByChangeBillGuID(ChangeBillGuID);

            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["ChangeBillGuID"].ToString();
                txtChangeBillID.Text = dtl.Rows[0]["ChangeBillID"].ToString();

                if (dtl.Rows[0]["ChangeBillDate"].ToString() != "")
                {
                    dtpChangeBillDate.Text = DateTime.Parse(dtl.Rows[0]["ChangeBillDate"].ToString()).ToString("yyyy-MM-dd");
                }
                txtChangePerson.Text = dtl.Rows[0]["ChangePersonName"].ToString();
                txtChangePerson.Tag = dtl.Rows[0]["ChangePerson"].ToString();

                txtFileID.Text = dtl.Rows[0]["FileID"].ToString();
                txtFileID.Tag = dtl.Rows[0]["FileGuID"].ToString();

                txtFileName.Text = dtl.Rows[0]["FileName"].ToString();

                txtOldVersionID.Text = dtl.Rows[0]["OldVersionID"].ToString();

                txtNewVersionID.Text = dtl.Rows[0]["NewVersionID"].ToString();
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

             

            }



            //加载明细数据

            DataTable dtlDetail = ChangeBillManage.GetChangeBillDataAttachment(ChangeBillGuID);

            for (int i = 0; i < dtlDetail.Rows.Count; i++)
            {
                byte[] byteFile = (byte[])dtlDetail.Rows[i]["FileContent"];

                ChangeBillDataAttachment ChangeBillDataAttachment = new ChangeBillDataAttachment();
                ChangeBillDataAttachment.ChangeBillDataAttachmentGuID = dtlDetail.Rows[i]["ChangeBillDataAttachmentGuID"].ToString();
                ChangeBillDataAttachment.ChangeBillGuID = dtlDetail.Rows[i]["ChangeBillGuID"].ToString();
                ChangeBillDataAttachment.FileContent = byteFile;
                ChangeBillDataAttachment.FileSourceName = dtlDetail.Rows[i]["FileSourceName"].ToString();

                lst.Add(ChangeBillDataAttachment);

                //文件增加到chklist中
                ListItem item = new ListItem();
                item.Text = ChangeBillDataAttachment.FileSourceName;
                item.Value = ChangeBillDataAttachment.ChangeBillDataAttachmentGuID;
                chklstFile.Items.Add(item);


            }

        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtChangeBillID.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入工程更改单号!");
                txtChangeBillID.Focus();
                return;
            }

            if (txtFileID.Text.Trim()== "")
            {
                this.ShowAlertMessage("请选择文件!");
                txtFileID.Focus();
                return;
            }


         
            if (dtpChangeBillDate.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入开单日期!");
                dtpChangeBillDate.Focus();
                return;
            }
            if (txtChangePerson.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入更改人!");
                txtChangePerson.Focus();
                return;
            }
           

            if (txtOldVersionID.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入旧版本!");
                txtOldVersionID.Focus();
                return;
            }

            if (txtNewVersionID.Text.Trim() == "")
            {
                this.ShowAlertMessage("请输入新版本!");
                txtNewVersionID.Focus();
                return;
            }


            ChangeBillManage ChangeBillManage = new ChangeBillManage();


            //判断当前工程更改编号是否已经存在相同的,如果已经存在则给出提示
            if (ChangeBillManage.IsExistChangeBillID(txtChangeBillID.Text.Replace("'", "''"),txtGuid.Text,IsEdit)==true)
            {
                this.ShowAlertMessage("你输入的工程更改编号已经存在,请修改后再确定!");
                return;
            }


            ChangeBill ChangeBill = new ChangeBill();
            ChangeBill.ChangeBillGuID = txtGuid.Text.Replace("'", "''");
            ChangeBill.ChangeBillID = txtChangeBillID.Text.Replace("'", "''");
            ChangeBill.ChangeBillDate = DateTime.Parse(dtpChangeBillDate.Text);
            ChangeBill.FileGuID = txtFileID.Tag.ToString();
            ChangeBill.NewVersionID = txtNewVersionID.Text;
            if (txtChangePerson.Tag != null)
            {
                ChangeBill.ChangePerson = txtChangePerson.Tag.ToString();
            }
            else
            {
                ChangeBill.ChangePerson = "";
            }

            ChangeBill.Remark = txtRemark.Text.Trim().Replace("'", "''");

            ChangeBill.CreateGuid = txtCreateGuid.Tag.ToString();
            ChangeBill.CreateDate = DateTime.Now;
            ChangeBill.CheckGuid = "";
            ChangeBill.CheckDate = DateTime.Parse("1900-01-01");
            ChangeBill.CheckGuid = "";
          

            //保存
            ChangeBillManage.SaveChangeBill(ChangeBill, lst);

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "工程更改单数据", "新增或编辑", SysParams.UserName + "用户新增或编辑了工程更改单，工程更改单:" + ChangeBill.ChangeBillGuID + "," + ChangeBill.ChangeBillID + "," + ChangeBill.NewVersionID);

            IsEdit = true;

            //刷新
            frmChangeBill.frmchangeBill.LoadData();


            tsbSave.Enabled = true;
            tsbCheck.Enabled = true;
            tsbUnCheck.Enabled = false;

            SetRight();

            this.ShowMessage("保存成功!");

        }


        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
          

            txtGuid.Text = Guid.NewGuid().ToString();

            txtGuid.Text = "";
            txtChangeBillID.Text = "";
            dtpChangeBillDate.Text = "";

            txtChangePerson.Text = "";
            txtChangePerson.Tag = "";

            txtFileID.Text = "";
            txtFileID.Tag = "";

            txtFileName.Text = "";
            txtOldVersionID.Text = "";

            txtNewVersionID.Text = "";
            txtRemark.Text = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;
            txtCheckGuid.Text = "";
            txtCheckDate.Text = "";

            lst.Clear();
            chklstFile.Items.Clear();

            tsbSave.Enabled = true;
            tsbCheck.Enabled = false;
            tsbUnCheck.Enabled = false;

            SetRight();

        }

        private void btnAddChangeBillAttachment_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Trim() == "")
            {
                this.ShowAlertMessage("请选择文件！");
                return;
            }
            byte[] byteFile = FileToBinary(txtFilePath.Text.Trim());

            ChangeBillDataAttachment ChangeBillDataAttachment = new ChangeBillDataAttachment();
            ChangeBillDataAttachment.ChangeBillDataAttachmentGuID = Guid.NewGuid().ToString();
            ChangeBillDataAttachment.ChangeBillGuID = txtGuid.Text;
            ChangeBillDataAttachment.FileContent = byteFile;
            ChangeBillDataAttachment.FileSourceName = txtFilePath.Tag.ToString();

            lst.Add(ChangeBillDataAttachment);

            //文件增加到chklist中
            ListItem item = new ListItem();
            item.Text = ChangeBillDataAttachment.FileSourceName;
            item.Value = ChangeBillDataAttachment.ChangeBillDataAttachmentGuID;
            chklstFile.Items.Add(item);



            txtFilePath.Text = "";
            //填充数据
            //gridView1.AddNewRow();
            //gridView1.SetFocusedRowCellValue(gridChangeBillDataAttachmentGuid , Guid.NewGuid().ToString());
            //gridView1.SetFocusedRowCellValue(gridChangeBillGuID,  txtGuid.TextD);
            //gridView1.SetFocusedRowCellValue(ChangeBillContent,byteChangeBill);
            //gridView1.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
            //gridView1.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
        }




        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                txtFilePath.Tag = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(@"\") + 1); ;
            }
        }






        /// <summary>  
        /// 将文件转换为二进制流进行读取  
        /// </summary>  
        /// <param name="fileName">文件完整名</param>  
        /// <returns>二进制流</returns>  
        private byte[] FileToBinary(string fileName)
        {
            try
            {
                FileStream fsRead = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                if (fsRead.CanRead)
                {
                    int fsSize = Convert.ToInt32(fsRead.Length);
                    byte[] btRead = new byte[fsSize];
                    fsRead.Read(btRead, 0, fsSize);
                    return btRead;
                }
                else
                {

                    MessageBox.Show("文件读取错误！");
                    return null;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return null;
            }
        }


        /// <summary>  
        /// 将二进制流转换为对应的文件进行存储  
        /// </summary>  
        /// <param name="filePath">接收的文件</param>  
        /// <param name="btBinary">二进制流</param>  
        /// <returns>转换结果</returns>  
        private bool BinaryToFile(string fileName, byte[] btBinary)
        {
            bool result = false;
            try
            {
                FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                if (fsWrite.CanWrite)
                {
                    fsWrite.Write(btBinary, 0, btBinary.Length);
                    MessageBox.Show("文件写入成功！");
                    result = true;
                }
                else
                {
                    MessageBox.Show("文件些入错误！");
                    result = false;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                result = false;
            }
            return result;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chklstFile_Click(object sender, EventArgs e)
        {


            ((System.Windows.Forms.CheckedListBox)(sender)).CheckOnClick = true;
        }

        private void btnDelChangeBill_Click(object sender, EventArgs e)
        {


            //移除集合中
            for (int i = 0; i < chklstFile.CheckedItems.Count; i++)
            {
                ListItem item = chklstFile.CheckedItems[i] as ListItem;
                for (int j = lst.Count - 1; j >= 0; j--)
                {

                    if (item.Value == lst[j].ChangeBillDataAttachmentGuID)
                    {

                        lst.RemoveAt(j);
                    }
                }

            }

            //移除列表中
            chklstFile.Items.Remove(chklstFile.SelectedItem);

        }

        private void chklstFile_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked) return;
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);
            }
            e.NewValue = CheckState.Checked;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectChangePerson_Click(object sender, EventArgs e)
        {

            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(1);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {

                    txtChangePerson.Text = ""; //名称
                    txtChangePerson.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtChangePerson.Text = arrValue[1]; //名称
                        txtChangePerson.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }

        private void btnSelectFileID_Click(object sender, EventArgs e)
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
                    FileDataManage FileDataManage = new FileDataManage();
                    FileData filedata = new FileData();
                    filedata = FileDataManage.GetFileData(lstGuid[0]);

                    txtFileID.Text = filedata.FileID;
                    txtFileID.Tag = filedata.FileGuID;
                    txtFileName.Text = filedata.FileName;
                    txtOldVersionID.Text = filedata.VersionID;

                }

            }
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定审核该工程更改单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (ChangeBillManage.IsExistChangeBillID(txtFileID.Text, txtNewVersionID.Text.Replace("'", "''")) == true)
                {
                    this.ShowAlertMessage("[文件编号+新版本号]已经存在,不能审核时自动创建,不能审核!");
                    return;
                }


                //更新审核状态
                ChangeBillManage.CheckBill(txtGuid.Text, 1, txtFileID.Tag.ToString(), txtNewVersionID.Text);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = DateTime.Now.ToString();
                txtCheckGuid.Tag = SysParams.UserID;
                txtCheckGuid.Text = SysParams.UserName;


                tsbCheck.Enabled = false;
                tsbUnCheck.Enabled = true;


                tsbSave.Enabled = false;

                SetRight();

                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "工程更改单审核", "审核", SysParams.UserName + "用户审核工程更改单,唯一号:" + txtGuid.Text + ",工程更改单号:" + txtChangeBillID.Text);

                //刷新列表界面

                frmChangeBill.frmchangeBill.LoadData();
            }
        }

        private void tsbUnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定反审该工程更改单！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //更新审核状态
                ChangeBillManage.CheckBill(txtGuid.Text, 0,txtFileID.Tag.ToString(),txtNewVersionID.Text);

                //设置为：已审核
                //SetControlEnable(1);

                txtCheckDate.Text = "";
                txtCheckGuid.Tag = "";
                txtCheckGuid.Text = "";



                tsbCheck.Enabled = true;
                tsbUnCheck.Enabled = false;



                tsbSave.Enabled = true;

                 SetRight();


                //写日志
                SysLog.AddOperateLog(SysParams.UserName, "工程更改单反审", "反审", SysParams.UserName + "用户反审工程更改单,唯一号:" + txtGuid.Text + ",工程更改单号:" + txtChangeBillID.Text);

                //刷新列表界面

                frmChangeBill.frmchangeBill.LoadData();
            }
        }


    }
}