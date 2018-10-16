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
    public partial class frmFileChangeRecord : Form
    {

        public frmFileChangeRecord(string fileGuid)
        {
            InitializeComponent();

            FileDataManage FileDataManage = new FileDataManage();
            gridControl1.DataSource= FileDataManage.GetFileChangeRecord(fileGuid);
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFileChangeRecord_Load(object sender, EventArgs e)
        {
           
        }
    }
}