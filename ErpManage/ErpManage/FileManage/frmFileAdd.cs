using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.IO;
using System.Web.UI.WebControls;

namespace ErpManage
{
    /// <summary>
    /// �ļ�����
    /// </summary>
    public partial class frmFileAdd : frmBase
    {

        public static frmFileAdd frmfileadd;
        private bool IsEdit = false;
        List<FileDataAttachment> lst = new List<FileDataAttachment>();
        
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public frmFileAdd()
        {
            InitializeComponent();
            frmfileadd = this;



        }


        ////��ʼ�����
        //private DataTable IniBindTable()
        //{
        //    DataTable _dt = new DataTable();
        //    DataColumn _datacol1 = new DataColumn("FileDataAttachmentGuid");
        //    DataColumn _datacol2 = new DataColumn("FileGuID");
        //    DataColumn _datacol3 = new DataColumn("FileContent");
        //    DataColumn _datacol4 = new DataColumn("FileSourceName");
          
        //    _dt.Columns.Add(_datacol1);
        //    _dt.Columns.Add(_datacol2);
        //    _dt.Columns.Add(_datacol3);
        //    _dt.Columns.Add(_datacol4);
           
        //    return _dt;

        //}


      

        //����
        public void FileAdd(string classid, string classname)
        {
            txtFileClass.Text = classname;
            txtFileClass.Tag = classid;

            IsEdit = false;

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;


            if (txtGuid.Text == "")
            {
                txtGuid.Text = Guid.NewGuid().ToString();
            }

            this.ShowDialog();

        }

        //�༭
        public void FileEdit(string FileGuid)
        {


            FillData(FileGuid);

            IsEdit = true;

            //�жϴ��ļ��Ƿ��Ѿ�������������ⵥ��ˣ���˺�Ͳ����޸�
            FileInStorageManage FileInStorageManage=new FileInStorageManage();
            if (FileInStorageManage.GetFileInStorageIsCheck(FileGuid) == true)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }

            this.ShowDialog();

        }


        //����ʱ��ѡ���ļ���𴰿ڷ��������ø����ֵ
        public void GetFileClass(string classid, string classname)
        {
            txtFileClass.Text = classname;
            txtFileClass.Tag = classid;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="MaterialGuid"></param>
        private void FillData(string FileGuid)
        {
            FileDataManage FileDataManage = new FileDataManage();

            DataTable  dtl = FileDataManage.GetFileDataByFileGuID(FileGuid);

            if (dtl.Rows.Count > 0)
            {
                txtGuid.Text = dtl.Rows[0]["FileGuID"].ToString();
                txtFileID.Text = dtl.Rows[0]["FileID"].ToString();
                txtFileName.Text = dtl.Rows[0]["FileName"].ToString();
                txtControlType.Text = dtl.Rows[0]["ControlTypeName"].ToString();
                txtControlType.Tag = dtl.Rows[0]["ControlType"].ToString();

                txtWriteDept.Text = dtl.Rows[0]["WriteDeptName"].ToString();
                txtWriteDept.Tag = dtl.Rows[0]["WriteDept"].ToString();

                txtFileClass.Text = dtl.Rows[0]["FileTypeName"].ToString();
                txtFileClass.Tag = dtl.Rows[0]["FileType"].ToString();

                txtRemark.Text = dtl.Rows[0]["Remark"].ToString();
                txtVersionID.Text = dtl.Rows[0]["VersionID"].ToString();

            
                dePublishDate.Text =DateTime.Parse(dtl.Rows[0]["PublishDate"].ToString()).ToString("yyyy-MM-dd");



                if (dtl.Rows[0]["IsEnable"].ToString().Trim() == "1")
                {
                    chkStop.Checked = true;
                }

                txtProductName.Text = dtl.Rows[0]["ProductName"].ToString().Trim();

                txtCreateGuid.Text = dtl.Rows[0]["CreateName"].ToString().Trim();
                txtCreateGuid.Tag = dtl.Rows[0]["CreateGuid"].ToString().Trim();
                txtCreateDate.Text= dtl.Rows[0]["CreateDate"].ToString().Trim();

                
                if (dtl.Rows[0]["CreateGuid"].ToString().Trim() != SysParams.UserID)
                {

                    btnSave.Enabled = false;
                    btnDelFile.Enabled = false;
                    btnAddFileAttachment.Enabled = false;
                }

            }



            //������ϸ����
            FileDataAttachmentManage FileDataAttachmentManage = new FileDataAttachmentManage();
            DataTable dtlDetail = FileDataAttachmentManage.GetFileDataAttachmentByFileGuID(FileGuid);

            for (int i = 0; i < dtlDetail.Rows.Count; i++)
            {
                byte[] bytefile = (byte[])dtlDetail.Rows[i]["FileContent"];

                FileDataAttachment FileDataAttachment = new FileDataAttachment();
                FileDataAttachment.FileDataAttachmentGuid = dtlDetail.Rows[i]["FileDataAttachmentGuid"].ToString();
                FileDataAttachment.FileGuID = dtlDetail.Rows[i]["FileGuID"].ToString();
                FileDataAttachment.FileContent = bytefile;
                FileDataAttachment.FileSourceName = dtlDetail.Rows[i]["FileSourceName"].ToString();

                lst.Add(FileDataAttachment);

                //�ļ����ӵ�chklist��
                ListItem item = new ListItem();
                item.Text = FileDataAttachment.FileSourceName;
                item.Value = FileDataAttachment.FileDataAttachmentGuid;
                chklstFile.Items.Add(item);
            
            
            }
          
        }

        //����
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFileClass.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ���ļ����!");
                return;
            }

            if (txtFileClass.Text.Trim() == "�ļ����")
            {
                this.ShowAlertMessage("��ѡ���������ļ����,[�ļ����]Ϊ�������ѡ��!");
                return;
            }

            if (txtFileID.Text.Trim() == "")
            {
                this.ShowAlertMessage("�������ļ����!");
                txtFileName.Focus();
                return;
            }
            if (txtFileName.Text.Trim() == "")
            {
                this.ShowAlertMessage("�������ļ�����!");
                txtFileName.Focus();
                return;
            }
            if (txtWriteDept.Text.Trim() == "")
            {
                this.ShowAlertMessage("�������д��λ!");
                txtWriteDept.Focus();
                return;
            }

            if (txtVersionID.Text.Trim() == "")
            {
                this.ShowAlertMessage("������汾!");
                txtVersionID.Focus();
                return;
            }

            if (dePublishDate.Text == "")
            {
                this.ShowAlertMessage("�����뷢������!");
                dePublishDate.Focus();
                return;
            }



            FileDataManage FileDataManage = new FileDataManage();


            //�жϵ�ǰ�ļ�����Ƿ��Ѿ�������ͬ��,����Ѿ������������ʾ
            if (FileDataManage.IsExistFile(txtGuid.Text, txtFileID.Text.Replace("'", "''"), txtVersionID.Text.Replace("'", "''"), IsEdit))
            {
                this.ShowAlertMessage("��������ļ���Ϣ[�ļ����+�汾]�Ѿ�����,���޸ĺ���ȷ��!");
                return;
            }


            FileData FileData = new FileData();
            FileData.FileGuID = txtGuid.Text.Replace("'","''");
            FileData.FileID = txtFileID.Text.Replace("'","''");
            FileData.FileName = txtFileName.Text.Replace("'","''");
            if (txtControlType.Tag != null)
            {
                FileData.ControlType = txtControlType.Tag.ToString();
            }
            else
            {
                FileData.ControlType = "";
            }
            if (txtWriteDept.Tag != null)
            {
                FileData.WriteDept = txtWriteDept.Tag.ToString();
            }
            else
            {
                FileData.WriteDept = "";
            }
            FileData.FileType = txtFileClass.Tag.ToString();

            FileData.Remark = txtRemark.Text.Trim().Replace("'","''");

            FileData.ProductName = txtProductName.Text.Replace("'","''");

            FileData.VersionID = txtVersionID.Text.Replace("'", "''");

            if (chkStop.Checked == true)
            {
                FileData.IsEnable = 1; //ͣ��
            }
            else
            {
                FileData.IsEnable = 0;//����
            }

            FileData.PublishDate = DateTime.Parse(dePublishDate.Text);

            FileData.CreateDate = DateTime.Parse(txtCreateDate.Text);

            FileData.CreateGuid = txtCreateGuid.Tag.ToString();


            //�жϸ����Ƿ��޸Ĺ��������ļ���С���ļ�����ͬ��С��ͬ��û���޸Ĺ��������ͬ���޸Ĺ�
            try
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    int intFileLength = FileDataManage.GetFileLength(FileData.FileGuID, lst[i].FileSourceName);
                    if (intFileLength != lst[i].FileContent.Length)
                    {
                        FileDataManage.AddFileChangeRecord(FileData.FileGuID, lst[i].FileSourceName, SysParams.UserID);
                    }
                }
            }catch
            {
            
            }


            //����
            FileDataManage.SaveFile(FileData, lst);


     


            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "�ļ�����", "������༭", SysParams.UserName + "�û�������༭���ļ����ļ�:" + FileData.FileGuID + "," + FileData.FileID + "," + FileData.FileName);

            IsEdit = true;

            //ˢ��
            string strsql = " where FileType='" + txtFileClass.Tag.ToString() + "'";

            frmFileManage.frmfileManage.LoadFileData(strsql);


            this.ShowMessage("����ɹ�!");
            
        }


        /// <summary>
        /// ѡ���ļ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectFileClass frmSelectFileClass = new frmSelectFileClass();
            frmSelectFileClass.InValue = 0;
            frmSelectFileClass.ShowDialog();

            if (frmSelectFileClass.Tag != null)
            {
                SelectFileClass SelectFileClass = frmSelectFileClass.Tag as SelectFileClass;

                txtFileClass.Text = SelectFileClass.FileClassName;
                txtFileClass.Tag = SelectFileClass.FileClassID;

            }
        }

     
     
        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsEdit = false;

            txtGuid.Text = Guid.NewGuid().ToString();

            txtFileID.Text = "";
            txtFileName.Text = "";
            txtControlType.Text = "";
            txtControlType.Tag = "";
            txtWriteDept.Text = "";
            txtWriteDept.Tag = "";
            txtRemark.Text = "";
            txtProductName.Text = "";
            txtVersionID.Text = "";
            dePublishDate.Text = "";
            chkStop.Checked = false;
            txtFilePath.Text = "";

            txtCreateDate.Text = DateTime.Now.ToString();
            txtCreateGuid.Text = SysParams.UserName;
            txtCreateGuid.Tag = SysParams.UserID;

            btnSave.Enabled = true;
            btnDelFile.Enabled = true;
            btnAddFileAttachment.Enabled = true;

            lst.Clear();
            chklstFile.Items.Clear();


         
        }

        private void btnAddFileAttachment_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Trim() == "")
            {
                this.ShowAlertMessage("��ѡ���ļ���");
                return;
            }
            byte[] bytefile = FileToBinary(txtFilePath.Text.Trim());

            FileDataAttachment FileDataAttachment = new FileDataAttachment();
            FileDataAttachment.FileDataAttachmentGuid = Guid.NewGuid().ToString();
            FileDataAttachment.FileGuID = txtGuid.Text;
            FileDataAttachment.FileContent = bytefile;
            FileDataAttachment.FileSourceName = txtFilePath.Tag.ToString();

            lst.Add(FileDataAttachment);

            //�ļ����ӵ�chklist��
            ListItem item = new ListItem();
            item.Text = FileDataAttachment.FileSourceName;
            item.Value = FileDataAttachment.FileDataAttachmentGuid;
            chklstFile.Items.Add(item);



            txtFilePath.Text = "";
            //�������
            //gridView1.AddNewRow();
            //gridView1.SetFocusedRowCellValue(gridFileDataAttachmentGuid , Guid.NewGuid().ToString());
            //gridView1.SetFocusedRowCellValue(gridFileGuID,  txtGuid.TextD);
            //gridView1.SetFocusedRowCellValue(FileContent,bytefile);
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


        //�ܿ����ѡ��
        private void btnSelectSpec_Click(object sender, EventArgs e)
        {
            frmSelectBasicData frmSelectBasicData = new frmSelectBasicData();
            frmSelectBasicData.ShowSelectBasicDataFrm(9);
            if (frmSelectBasicData.Tag != null)
            {
                if (frmSelectBasicData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtControlType.Text = ""; //����
                    txtControlType.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectBasicData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtControlType.Text = arrValue[1]; //����
                        txtControlType.Tag = arrValue[0];  //Guid
                    }
                }
            }

        }

        //��д����ѡ��
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            frmSelectOtherData frmSelectOtherData = new frmSelectOtherData();
            frmSelectOtherData.ShowSelectData(2);
            if (frmSelectOtherData.Tag != null)
            {
                if (frmSelectOtherData.Tag.ToString().Trim() == "ClearTextBox")
                {
                    txtWriteDept.Text = ""; //����
                    txtWriteDept.Tag = "";  //Guid
                }
                else
                {
                    string[] arrValue = frmSelectOtherData.Tag.ToString().Split('|');

                    if (arrValue.Length > 0)
                    {
                        txtWriteDept.Text = arrValue[1]; //����
                        txtWriteDept.Tag = arrValue[0];  //Guid
                    }
                }
            }
        }


        /// <summary>  
        /// ���ļ�ת��Ϊ�����������ж�ȡ  
        /// </summary>  
        /// <param name="fileName">�ļ�������</param>  
        /// <returns>��������</returns>  
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

                    MessageBox.Show("�ļ���ȡ����");
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
        /// ����������ת��Ϊ��Ӧ���ļ����д洢  
        /// </summary>  
        /// <param name="filePath">���յ��ļ�</param>  
        /// <param name="btBinary">��������</param>  
        /// <returns>ת�����</returns>  
        private bool BinaryToFile(string fileName, byte[] btBinary)
        {
            bool result = false;
            try
            {
                FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                if (fsWrite.CanWrite)
                {
                    fsWrite.Write(btBinary, 0, btBinary.Length);
                    MessageBox.Show("�ļ�д��ɹ���");
                    result = true;
                }
                else
                {
                    MessageBox.Show("�ļ�Щ�����");
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

        private void btnDelFile_Click(object sender, EventArgs e)
        {
          

            //�Ƴ�������
            for (int i = 0; i < chklstFile.CheckedItems.Count; i++)
            {
                ListItem item = chklstFile.CheckedItems[i] as ListItem;
                for (int j=lst.Count-1; j >=0 ; j--)
                {
                   
                    if (item.Value == lst[j].FileDataAttachmentGuid)
                    {

                        lst.RemoveAt(j);
                    }
                }
            
            }

            //�Ƴ��б���
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


    }
}