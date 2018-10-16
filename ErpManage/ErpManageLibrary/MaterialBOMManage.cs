using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 货品管理控制类BOM
    /// </summary>
    public class MaterialBOMManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveMaterialBom(MaterialBom materialbom, List<MaterialBomDetail> materialbomdetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //删除集合中的bom子件数据
                string strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBomDetail where MaterialFatherGuid='" + materialbom.MaterialGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除集合中的bom母件数据
                strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBom where MaterialGuid='" + materialbom.MaterialGuid + "' ";
                pComm.Execute(strDeleteSql);

     
                 
                 //插入母件数据
                 string strInsertSql="";
                 strInsertSql = GetAddSQL(materialbom);
                 pComm.Execute(strInsertSql);
                

                //插入子件数据
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
        /// 增加一条主表数据
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
        /// 增加一条主表子件数据
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
        /// 删除数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void DetailMaterialBom(string strMaterialFatherGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //删除集合中的bom子件数据
                string strDeleteSql = "";
                strDeleteSql = "Delete from MaterialBomDetail where MaterialFatherGuid='" + strMaterialFatherGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除集合中的bom母件数据
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



        //调用存储过程得到订单数据
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
        /// 得到当前料件的下子结点
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
        /// 得到当前所有母件
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
        /// 得到当前母件下的所有子件，以树型结点结构返回查询结果
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
        /// 得到当前母件的remark信息
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
        ///是否已经在BOM中进行了子件情况的定义
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
        /// 得到当前子件的用量即单耗
       /// </summary>
       /// <param name="MaterialGuid">料件Guid</param>
       /// <param name="ProductGuid">产品Guid</param>
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



        //生成一个产品下面所有的子件
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
        /// 得到当前子件的用量即单耗
        /// </summary>
        /// <param name="MaterialGuid">料件Guid</param>
        /// <param name="ProductGuid">产品Guid</param>
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
