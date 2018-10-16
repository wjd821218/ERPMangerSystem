using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ErpManageLibrary;
using System.IO;
using AcroPDFLib;
using iTextSharp.text.pdf;

namespace ErpManage
{
    /// <summary>
    /// 显示pdf文件
    /// </summary>
    public partial class frmViewPDF : Form
    {

        [System.Runtime.InteropServices.DllImport("ole32.dll")]
        static extern void CoFreeUnusedLibraries();  

        public frmViewPDF()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 显示pdf文件
        /// </summary>
        /// <param name="FileDataAttachmentGuid"></param>
        public void ViewPDF(string FileDataAttachmentGuid)
        {
            FileDataManage FileDataManage = new FileDataManage();
            DataTable dtl=FileDataManage.GetFileDataAttachmentByAttachmentGuid(FileDataAttachmentGuid);

            if (dtl.Rows.Count > 0)
            {
                Byte[] bytes = (Byte[])dtl.Rows[0]["FileContent"];

                Random ran=new Random();
                int num=ran.Next(1,10);
                

                //先将文件下载到本地
                //判断目录是否存在，如果不存在，则创建
                if (Directory.Exists(Application.StartupPath + @"\FileAttachment") == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\FileAttachment");
                }

                txtFilePath.Text = Application.StartupPath + @"\FileAttachment\" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + num.ToString() + ".pdf";
                FileStream fs = new FileStream(txtFilePath.Text, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                

                //加密PDF文件，加密后不可复制与打印---此方法有些版本pdf会报错
               // PDFSecurity(txtFilePath.Text, txtFilePath.Text, false, "P@ssw0rd");


                //加密PDF文件，加密后不可复制与打印
                pdfreadonly(txtFilePath.Text);

                //载入pdf文件
                axAcroPDF1.LoadFile(txtFilePath.Text);
                axAcroPDF1.setShowToolbar(false);
                axAcroPDF1.setZoom(100);

                this.ShowDialog();
            
            }



        
        }

        //加密pdf,使其不能打印，不能复制
        public void pdfreadonly(string pdfname)
        {
            string pdfFile = pdfname;// "d:\\sample.pdf";

            //把文件读入内存可立即释放文件句柄，方便信息覆盖原文件
            PdfReader reader = new PdfReader(File.ReadAllBytes(pdfFile));

            //获取到本文件的 MetaData 信息
            // Dictionary<string, string> info =reader.Info;
            //  reader.Close();

            //覆盖掉原 PDF 文件中
            PdfStamper stamper = new PdfStamper(reader, new FileStream(pdfFile, FileMode.Create, FileAccess.Write));

            stamper.MoreInfo = reader.Info;
            stamper.SetEncryption(PdfWriter.STRENGTH40BITS, null, null, PdfWriter.AllowScreenReaders);
            stamper.Close();

        }




        //PDF文件加密，传入的PDF不加密的，经过此方法后，此PDF文件就不能复制与打印
        public void PDFSecurity(string strSourcePDFFile, string strDestPDFFile, bool AddUserPassword, string strPassword)
        {

            try
            {

                PdfSharp.Pdf.PdfDocument pdfsourcedoc = PdfSharp.Pdf.IO.PdfReader.Open(strSourcePDFFile, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify);
                pdfsourcedoc.SecuritySettings.DocumentSecurityLevel = PdfSharp.Pdf.Security.PdfDocumentSecurityLevel.Encrypted128Bit;
                pdfsourcedoc.SecuritySettings.OwnerPassword = "P@ssw0rd";
                pdfsourcedoc.SecuritySettings.PermitAccessibilityExtractContent = false;
                pdfsourcedoc.SecuritySettings.PermitAnnotations = false;
                pdfsourcedoc.SecuritySettings.PermitAssembleDocument = false;
                pdfsourcedoc.SecuritySettings.PermitExtractContent = false;
                pdfsourcedoc.SecuritySettings.PermitFormsFill = false;

                pdfsourcedoc.SecuritySettings.PermitFullQualityPrint = false;

                pdfsourcedoc.SecuritySettings.PermitModifyDocument = false;


                pdfsourcedoc.SecuritySettings.PermitPrint = false;

                if (AddUserPassword == true)
                {
                    pdfsourcedoc.SecuritySettings.UserPassword = strPassword;

                }

                pdfsourcedoc.Save(strDestPDFFile);
                pdfsourcedoc.Close();

              
            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        private void frmViewPDF_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (axAcroPDF1 != null)
            {
                axAcroPDF1.Dispose();
                System.Windows.Forms.Application.DoEvents();
                CoFreeUnusedLibraries();

                if (txtFilePath.Text.Trim() != "")
                {
                    try
                    {
                        if (File.Exists(txtFilePath.Text.Trim()) == true)
                        {
                            File.Delete(txtFilePath.Text.Trim());
                        }
                    }
                    catch
                    { }
                   
                
                }
            }

            this.Close();
        }

        /// <summary>
        /// 放大
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoom_Click(object sender, EventArgs e)
        {
            
        }

        //缩小
        private void btnZoom2_Click(object sender, EventArgs e)
        {

        }

     

        private void rdo50_CheckedChanged(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(50);
        }

        private void rdo75_Click(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(75);
        }

        private void rdo100_Click(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(100);
        }

        private void rdo150_Click(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(150);
        }

        private void rdo200_Click(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (axAcroPDF1 != null)
            {
                axAcroPDF1.Dispose();
                System.Windows.Forms.Application.DoEvents();
                CoFreeUnusedLibraries();

                if (txtFilePath.Text.Trim() != "")
                {
                    try
                    {
                        if (File.Exists(txtFilePath.Text.Trim()) == true)
                        {
                            File.Delete(txtFilePath.Text.Trim());
                        }
                    }
                    catch
                    { }


                } 

                
            }

            this.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            axAcroPDF1.setZoom(float.Parse(numericUpDown1.Value.ToString()));
        }



    }
}