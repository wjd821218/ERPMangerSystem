using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErpManage.Business
{
    /// <summary>
    /// �������񹤵���ѯ
    /// </summary>
    public partial class frmProduceOrder : Form
    {
        public frmProduceOrder()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProduceOrderAdd frmProduceOrderAdd = new frmProduceOrderAdd();
            frmProduceOrderAdd.Show(this);
        }
    }
}