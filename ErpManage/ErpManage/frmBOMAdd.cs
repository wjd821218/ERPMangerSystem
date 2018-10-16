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
    /// BOM管理
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
        /// 加载树
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
                            int upLenth = al.Count; //记录上一层节点数
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

        //得到当前父料件下面的子料件，只查找下面一级
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
        /// 物料BOM编辑加载窗口
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        public void EditBom(string MaterialFatherGuid)
        {
            //选择的品名填充
            if (MaterialFatherGuid != "")
            {
                //得到料件的信息
                Material material = new Material();
                material = MaterialManage.GetMaterialByGuid(MaterialFatherGuid);

                //填充数据
                txtMaterialID.Tag = material.MaterialGuID;
                txtMaterialID.Text = material.MaterialID;
                txtMaterialName.Text = material.MaterialName;
                txtUnit.Text = base.GetBasicDataNameByID(material.Unit);
                txtSpec.Text = base.GetBasicDataNameByID(material.Spec);
               

                //得到bom主表的备注信息
                txtRemark.Text = MaterialBOMManage.GetBOMRemarkByMaterialGuid(MaterialFatherGuid);

            }


            //载入子件列表
            LoadMaterialChildData();


            //母件子件按树型显示
            LoadBomTree();
            treeView1.ExpandAll();

            this.ShowDialog();
        }


        //选择物料
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null )
            { 
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;

             
                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //得到料件的信息
                    Material material = new Material();
                    material = MaterialManage.GetMaterialByGuid(lstGuid[0]);

                    //填充数据
                    txtMaterialID.Tag = material.MaterialGuID;
                    txtMaterialID.Text = material.MaterialID;
                    txtMaterialName.Text = material.MaterialName;
                    txtUnit.Text = base.GetBasicDataNameByID(material.Unit);
                    txtSpec.Text = base.GetBasicDataNameByID(material.Spec);

                }

            
                //载入子件列表
                LoadMaterialChildData();


                //母件子件按树型显示
                LoadBomTree();
                treeView1.ExpandAll();


            }
        }

        //添加子件
        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            frmSelectMaterial frmSelectMaterial = new frmSelectMaterial();
            frmSelectMaterial.ShowDialog();

            if (frmSelectMaterial.Tag != null)
            {
                //取出选择的料件Guid
                List<string> lstGuid = frmSelectMaterial.Tag as List<string>;


                //选择的品名填充
                if (lstGuid.Count > 0)
                {
                    //得到料件的信息
                    for (int i = 0; i < lstGuid.Count; i++)
                    {
                        Material material = new Material();
                        material = MaterialManage.GetMaterialByGuid(lstGuid[i]);

                        //填充数据
                        gridView2.AddNewRow();
                        gridView2.SetFocusedRowCellValue(gridMaterialGuid, material.MaterialGuID);
                        gridView2.SetFocusedRowCellValue(gridMaterialID, material.MaterialID);
                        gridView2.SetFocusedRowCellValue(gridMaterialName, material.MaterialName);
                        gridView2.SetFocusedRowCellValue(gridUnit, base.GetBasicDataNameByID(material.Unit));
                        gridView2.SetFocusedRowCellValue(gridSpec, base.GetBasicDataNameByID(material.Spec));
                    }

                    //将行的位置对调
                    
       
                }

            }
        }

        //保存母件信息
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (txtMaterialID.Text.Trim() == "")
            {
                this.ShowMessage("请选择母件！");
                return;
            }

            txtRemark.Focus();
            gridView2.UpdateCurrentRow();

              //将母件的子件存入数据库
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRowView dr = (DataRowView)(gridView2.GetRow(i));
                if (dr["MaterialSum"].ToString().Trim() != "")
                {
                    if (decimal.Parse(dr["MaterialSum"].ToString().Trim()) <= 0)
                    {

                        this.ShowMessage("子件的需求量要大于0！");
                        return;
                    }
                }
                else
                {
                    this.ShowMessage("请输入子件！");
                    return;
                }

            }


       

            //母件信息存入
            MaterialBom materialbom = new MaterialBom();
            materialbom.MaterialGuid = txtMaterialID.Tag.ToString();
            materialbom.MaterialName = txtMaterialName.Text;
            materialbom.Remark = txtRemark.Text;

            List<MaterialBomDetail> listdetail = new List<MaterialBomDetail>();
            MaterialBomDetail materialdetail = new MaterialBomDetail();
            //将母件的子件存入数据库
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

            //写日志
            SysLog.AddOperateLog(SysParams.UserName, "BOM数据", "新增和编辑", SysParams.UserName + "用户新增或编辑了物料（母件）:" + materialbom.MaterialName);


            LoadBomTree();

            this.treeView1.ExpandAll();

            this.ShowMessage("物料BOM数据保存成功!");




        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }

        
        //去掉mouse滚动调数字
        private void repositoryItemSpinEdit1_Spin_1(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        //剪切明细
        private void btnCut_Click(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 1 )
            {
                IsCut = true;
                //存放CUT的行数据
                dt.Clear();
                int[] selectedRowHandle = gridView2.GetSelectedRows();
                foreach (int i in selectedRowHandle)
                {
                    dt.ImportRow(gridView2.GetDataRow(i));
                }
                gridView2.DeleteSelectedRows();
            }


        }
        //粘贴明细
        private void btnPaste_Click(object sender, EventArgs e)
        {
            

            if (   IsCut ==true  &&  dt.Rows.Count>0)
            {
                //插入被CUT的行数据
                int curRowHandle = gridView2.FocusedRowHandle;
                int rowCount = gridView2.RowCount;

                if (curRowHandle < 0)
                {
                    curRowHandle = 0;
                }

                //实现插入行功能
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
                DialogResult dr = MessageBox.Show("确定要删除选择的物料(母件)数据?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    MaterialBOMManage MaterialBOMManage = new MaterialBOMManage();
                    MaterialBOMManage.DetailMaterialBom(txtMaterialID.Tag.ToString());

                    //写日志
                    SysLog.AddOperateLog(SysParams.UserName, "BOM数据", "删除BOM", SysParams.UserName + "用户删除了BOM，物料:" + txtMaterialID.Tag.ToString() + ",物料名称：" + txtMaterialID.Text);

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