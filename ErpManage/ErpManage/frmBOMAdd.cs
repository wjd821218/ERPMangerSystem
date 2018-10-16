using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ErpManageLibrary;

namespace ErpManage
{
    /// <summary>
    /// BOM����
    /// </summary>
    public partial class frmBOMAdd : frmBase
    {
        public static frmBOMAdd frmbomadd;
        MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
        MaterialManage MaterialManage = new MaterialManage();
        DataTable dt = new DataTable();
        bool IsCut = false;
        public frmBOMAdd()
        {
            InitializeComponent();
            frmbomadd = this;

         
        }

        /// <summary>
        /// ������
        /// </summary>
        public void LoadBomTree()
        {
            this.treeView1.Nodes.Clear();

            if (txtMaterialID.Tag != null)
            {

                DataTable mdt = new DataTable();
                mdt = MaterialBOMManage.sp_GetMaterialBomData(txtMaterialID.Tag.ToString());

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
                            dr = mdt.Select("MaterialFatherGuid=''");
                            for (int j = 0; j < dr.Length; j++)
                            {
                                TreeNode tn = new TreeNode();
                                tn.Text = dr[j]["MaterialID"].ToString() + " " + dr[j]["MaterialName"].ToString();

                                tn.Tag = dr[j]["MaterialGuID"].ToString();

                                this.treeView1.Nodes.Add(tn);
                                al.Add(tn);

                            }
                            dr = null;
                        }
                        else
                        {
                            int upLenth = al.Count; //��¼��һ��ڵ���
                            for (int k = 0; k < upLenth; k++)
                            {
                                TreeNode tvn = (TreeNode)al[k];
                                DataRow[] dr = mdt.Select("MaterialFatherGuid='" + tvn.Tag.ToString() + "'");
                                for (int j = 0; j < dr.Length; j++)
                                {
                                    TreeNode tn = new TreeNode();
                                    decimal dec=decimal.Parse(dr[j]["MaterialSum"].ToString());
                                    tn.Text = dr[j]["MaterialID"].ToString() + " " + dr[j]["MaterialName"].ToString() + "(" + dec.ToString("g0") +")";
                                    tn.Tag = dr[j]["MaterialGuID"].ToString();

                                    tvn.Nodes.Add(tn);

                                    al.Add(tn); //���ӱ���ڵ㣬�Ա���һ�����
                                }
                                dr = null;
                            }
                            for (int k = upLenth - 1; k >= 0; k--)
                            {
                                al.RemoveAt(k); //ɾ����һ��ڵ������
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
          
        }



        public void FillData()
        {
            treeView1.Nodes.Clear();
           
            treeView1.ExpandAll();

            this.ShowDialog();
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaterialID.Text = "";
            txtMaterialID.Tag = "";
            txtMaterialName.Text = "";
            txtSpec.Text = "";
            txtUnit.Text = "";
            txtRemark.Text = "";

            treeView1.Nodes.Clear();

            gridView2.SelectAll();
            gridView2.DeleteSelectedRows();

        }

    

        private void frmStorageClass_Load(object sender, EventArgs e)
        {
         
        }

        //�õ���ǰ���ϼ���������ϼ���ֻ��������һ��
        private void LoadMaterialChildData()
        {
            if (txtMaterialID.Tag != null)
            {
                DataTable dtl=MaterialBOMManage.GetMaterialBOMDetail(txtMaterialID.Tag.ToString());
                this.gridControl2.DataSource = dtl;
                dt = dtl.Copy();

            
                
            }
        
        }

        /// <summary>
        /// ����BOM�༭���ش���
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        public void EditBom(string MaterialFatherGuid)
        {
            //ѡ���Ʒ�����
            if (MaterialFatherGuid != "")
            {
                //�õ��ϼ�����Ϣ
                Material material = new Material();
                material = MaterialManage.GetMaterialByGuid(MaterialFatherGuid);

                //�������
                txtMaterialID.Tag = material.MaterialGuID;
                txtMaterialID.Text = material.MaterialID;
                txtMaterialName.Text = material.MaterialName;
                txtUnit.Text = base.GetBasicDataNameByID(material.Unit);
                txtSpec.Text = base.GetBasicDataNameByID(material.Spec);
               

                //�õ�bom����ı�ע��Ϣ
                txtRemark.Text = MaterialBOMManage.GetBOMRemarkByMaterialGuid(MaterialFatherGuid);

            }


            //�����Ӽ��б�
            LoadMaterialChildData();


            //ĸ���Ӽ���������ʾ
            LoadBomTree();
            treeView1.ExpandAll();

            this.ShowDialog();
        }


        //ѡ������
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null )
            { 
                //ȡ��ѡ����ϼ�Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;

             
                //ѡ���Ʒ�����
                if (lstGuid.Count > 0)
                {
                    //�õ��ϼ�����Ϣ
                    Material material = new Material();
                    material = MaterialManage.GetMaterialByGuid(lstGuid[0]);

                    //�������
                    txtMaterialID.Tag = material.MaterialGuID;
                    txtMaterialID.Text = material.MaterialID;
                    txtMaterialName.Text = material.MaterialName;
                    txtUnit.Text = base.GetBasicDataNameByID(material.Unit);
                    txtSpec.Text = base.GetBasicDataNameByID(material.Spec);

                }

            
                //�����Ӽ��б�
                LoadMaterialChildData();


                //ĸ���Ӽ���������ʾ
                LoadBomTree();
                treeView1.ExpandAll();


            }
        }

        //����Ӽ�
        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null)
            {
                //ȡ��ѡ����ϼ�Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //ѡ���Ʒ�����
                if (lstGuid.Count > 0)
                {
                    //�õ��ϼ�����Ϣ
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        Material material = new Material();
                        material = MaterialManage.GetMaterialByGuid(lstGuid[i]);

                        //�������
                        gridView2.AddNewRow();
                        gridView2.SetFocusedRowCellValue(gridMaterialGuid, material.MaterialGuID);
                        gridView2.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView2.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView2.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView2.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
                    }

                    //���е�λ�öԵ�
                    
       
                }

            }
        }

        //����ĸ����Ϣ
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (txtMaterialID.Text.Trim() == "")
            {
                this.ShowMessage("��ѡ��ĸ����");
                return;
            }

            txtRemark.Focus();
            gridView2.UpdateCurrentRow();

              //��ĸ�����Ӽ��������ݿ�
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView2.GetRow(i));
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    if (decimal.Parse(dr["MaterialSum"].ToString().Trim()) <= 0)
                    {

                        this.ShowMessage("�Ӽ���������Ҫ����0��");
                        return;
                    }
                }
                else
                {
                    this.ShowMessage("�������Ӽ���");
                    return;
                }

            }


       

            //ĸ����Ϣ����
            MaterialBom materialbom = new MaterialBom();
            materialbom.MaterialGuid = txtMaterialID.Tag.ToString();
            materialbom.MaterialName = txtMaterialName.Text;
            materialbom.Remark = txtRemark.Text;

            List<MaterialBomDetail> listdetail = new List<MaterialBomDetail>();
            MaterialBomDetail materialdetail = new MaterialBomDetail();
            //��ĸ�����Ӽ��������ݿ�
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView2.GetRow(i));

                materialdetail = new MaterialBomDetail();
                materialdetail.MaterialGuid = dr["MaterialGuid"].ToString();
                materialdetail.MaterialName = dr["MaterialName"].ToString();
                materialdetail.MaterialFatherGuid = txtMaterialID.Tag.ToString();
                
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    materialdetail.MaterialSum = decimal.Parse(dr["MaterialSum"].ToString());
                }
                else
                {
                    materialdetail.MaterialSum = 0;
                }
                materialdetail.SortID = i;

                listdetail.Add(materialdetail);
            }

            MaterialBOMManage.SaveMaterialBom(materialbom,listdetail);

            //д��־
            SysLog.AddOperateLog(SysParams.UserName, "BOM����", "�����ͱ༭", SysParams.UserName + "�û�������༭�����ϣ�ĸ����:" + materialbom.MaterialName);


            LoadBomTree();

            this.treeView1.ExpandAll();

            this.ShowMessage("����BOM���ݱ���ɹ�!");




        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        
        //ȥ��mouse����������
        private void repositoryItemSpinEdit1_Spin_1(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        //������ϸ
        private void btnCut_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 1 )
            {
                IsCut = true;
                //���CUT��������
                dt.Clear();
                int[] selectedRowHandle = gridView2.GetSelectedRows();
                foreach (int i in selectedRowHandle)
                {
                    dt.ImportRow(gridView2.GetDataRow(i));
                }
                gridView2.DeleteSelectedRows();
            }


        }
        //ճ����ϸ
        private void btnPaste_Click(object sender, EventArgs e)
        {
            

            if (   IsCut ==true  &&  dt.Rows.Count>0)
            {
                //���뱻CUT��������
                int curRowHandle = gridView2.FocusedRowHandle;
                int rowCount = gridView2.RowCount;

                if (curRowHandle < 0)
                {
                    curRowHandle = 0;
                }

                //ʵ�ֲ����й���
                if (curRowHandle < rowCount)
                {
                    for (int i = curRowHandle; i <= rowCount; i++)
                    {
                        dt.ImportRow(gridView2.GetDataRow(i));
                        gridView2.SelectRow(i);

                    }

                    gridView2.DeleteSelectedRows();

                }

                foreach (DataRow dataRow in dt.Rows)
                {
                    gridView2.AddNewRow();

                    int rowHandle = gridView2.FocusedRowHandle;

                    DataRow newRow = gridView2.GetDataRow(rowHandle);
                    if (newRow != null)
                    {
                        newRow.ItemArray = dataRow.ItemArray;
                    }
                }
                gridView2.SelectRow(curRowHandle);

                IsCut = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaterialID.Tag != null)
            {
                DialogResult dr = MessageBox.Show("ȷ��Ҫɾ��ѡ�������(ĸ��)����?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                    MaterialBOMManage.DetailMaterialBom(txtMaterialID.Tag.ToString());

                    //д��־
                    SysLog.AddOperateLog(SysParams.UserName, "BOM����", "ɾ��BOM", SysParams.UserName + "�û�ɾ����BOM������:" + txtMaterialID.Tag.ToString() + ",�������ƣ�" + txtMaterialID.Text);

                    txtMaterialID.Text = "";
                    txtMaterialID.Tag = "";
                    txtMaterialName.Text = "";
                    txtSpec.Text = "";
                    txtUnit.Text = "";
                    txtRemark.Text = "";

                    treeView1.Nodes.Clear();

                    gridView2.SelectAll();
                    gridView2.DeleteSelectedRows();

                }
            }
           
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

     
    }
}