using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��Ʒ���������BOM
    /// </summary>
    public class MaterialBOMManage
    {

        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void SaveMaterialBom(MaterialBom materialbom, List<MaterialBomDetail> materialbomdetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //ɾ�������е�bom�Ӽ�����
                string strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBomDetail where MaterialFatherGuid='" + materialbom.MaterialGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ�������е�bomĸ������
                strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBom where MaterialGuid='" + materialbom.MaterialGuid + "' ";
                pComm.Execute(strDeleteSql);

     
                 
                 //����ĸ������
                 string strInsertSql="";
                 strInsertSql = GetAddSQL(materialbom);
                 pComm.Execute(strInsertSql);
                

                //�����Ӽ�����
                 strInsertSql = "";
                 for (int i = 0; i < materialbomdetail.Count; i++)
                 {

                     strInsertSql = GetAddDetailSQL(materialbomdetail[i]);
                     pComm.Execute(strInsertSql);
                 }


                pComm.CommitTrans();

            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }



        /// <summary>
        /// ����һ����������
        /// </summary>
        public string GetAddSQL(MaterialBom materialbom)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [MaterialBom](");
            strSql.Append("MaterialGuid,MaterialName,Remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + materialbom.MaterialGuid + "',");
            strSql.Append("'" + materialbom.MaterialName + "',");
            strSql.Append("'" + materialbom.Remark + "'");
            strSql.Append(")");

            return strSql.ToString();

        }



        /// <summary>
        /// ����һ�������Ӽ�����
        /// </summary>
        public string GetAddDetailSQL(MaterialBomDetail materialBomDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterialBomDetail(");
            strSql.Append("MaterialFatherGuid,MaterialGuid,MaterialName,MaterialSum,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + materialBomDetail.MaterialFatherGuid + "',");
            strSql.Append("'" + materialBomDetail.MaterialGuid + "',");
            strSql.Append("'" + materialBomDetail.MaterialName + "',");
            strSql.Append("" + materialBomDetail.MaterialSum + ",");
            strSql.Append("" + materialBomDetail.SortID + "");
            strSql.Append(")");

            return strSql.ToString();
        }



        ///<summary>
        /// ɾ������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void DetailMaterialBom(string strMaterialFatherGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //ɾ�������е�bom�Ӽ�����
                string strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBomDetail where MaterialFatherGuid='" + strMaterialFatherGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ�������е�bomĸ������
                strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBom where MaterialGuid='" + strMaterialFatherGuid + "' ";
                pComm.Execute(strDeleteSql);

                pComm.CommitTrans();

            }
            catch (Exception e)
            {
                pComm.RollbackTrans();
                pComm.Close();
                throw e;

            }
        }



        //���ô洢���̵õ���������
        public DataTable sp_GetMaterialBomData(String Materialfatherguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialFatherGuid";
                par[0, 1] = Materialfatherguid;
              
                dset = pComm.ExcuteSp("sp_GetMaterialBomData", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }



       /// <summary>
        /// �õ���ǰ�ϼ������ӽ��
       /// </summary>
       /// <param name="FatherMaterialGuid"></param>
       /// <returns></returns>
        public DataTable GetMaterialBOMDetail(string MaterialFatherGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_MaterialBomDetail  where MaterialFatherGuid='" + MaterialFatherGuid + "' order by sortid";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// �õ���ǰ����ĸ��
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMaterialBOM()
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_MaterialBom  order by sortid";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



        /// <summary>
        /// �õ���ǰĸ���µ������Ӽ��������ͽ��ṹ���ز�ѯ���
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMaterialBOMByTree(string MaterialFatherGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_MaterialBomDetail  where MaterialFatherGuid='" + MaterialFatherGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }




        /// <summary>
        /// �õ���ǰĸ����remark��Ϣ
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        /// <returns></returns>
        public string GetBOMRemarkByMaterialGuid(string MaterialGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   Remark   from  MaterialBom  where MaterialGuid='" + MaterialGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return pDTMain.Rows[0]["Remark"].ToString();
                }
                else
                {
                    return "";
                }


            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


        /// <summary>
        ///�Ƿ��Ѿ���BOM�н������Ӽ�����Ķ���
        /// </summary>
        /// <param name="MaterialFatherGuid"></param>
        /// <returns></returns>
        public bool IsExistBOMByMaterialGuid(string MaterialGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  MaterialGuid   from  MaterialBom  where MaterialGuid='" + MaterialGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }




       /// <summary>
        /// �õ���ǰ�Ӽ�������������
       /// </summary>
       /// <param name="MaterialGuid">�ϼ�Guid</param>
       /// <param name="ProductGuid">��ƷGuid</param>
       /// <returns></returns>
        public decimal GetMaterialConsume(string MaterialGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   MaterialSum   from  tempBomConsume  where MaterialGuid='" + MaterialGuid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return decimal.Parse(pDTMain.Rows[0]["MaterialSum"].ToString());
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



        //����һ����Ʒ�������е��Ӽ�
        public DataSet sp_GetMaterialBomConsume(String Materialfatherguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialFatherGuid";
                par[0, 1] = Materialfatherguid;

                dset=pComm.ExcuteSp("sp_GetMaterialBomConsume", par);
                pComm.Close();

                return dset;

            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }


        //-------------------------------------------------------------



        /// <summary>
        /// �õ���ǰ�Ӽ�������������
        /// </summary>
        /// <param name="MaterialGuid">�ϼ�Guid</param>
        /// <param name="ProductGuid">��ƷGuid</param>
        /// <returns></returns>
        public DataSet sp_GetMaterialBomConsumeByDrawOrder(string strsql, string FatherGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@MaterialFatherGuid";
                par[0, 1] = FatherGuid;
                par[1, 0] = "@strsql";
                par[1, 1] = strsql;

                dset = pComm.ExcuteSp("sp_GetMaterialBomConsumeByDrawOrder", par);
                pComm.Close();

                return dset;
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }



        }

    }
}
