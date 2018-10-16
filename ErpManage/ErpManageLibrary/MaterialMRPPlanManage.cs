using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 物料需求计划管理类
    /// </summary>
    public class MaterialMRPPlanManage
    {

      

        ///<summary>
        /// 保存数据----点击保存时用
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(MaterialMRPPlan materialMRPPlan, List<MaterialMRPPlanDetail> materialMRPPlanDetail, List<MaterialMRPPlanCalcSumDetail> materialMRPPlanCalcSumDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from MaterialMRPPlan where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入主表数据
                string strInsertSql = GetAddSQL(materialMRPPlan);
                pComm.Execute(strInsertSql);


                //删除明细表
                strDeleteSql = "Delete from MaterialMRPPlanDetail where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < materialMRPPlanDetail.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL(materialMRPPlanDetail[i]);
                    pComm.Execute(strInsertSql);
                }


                //删除计算明细
                strDeleteSql = "Delete from MaterialMRPPlanCalcSum where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //插入明细表数据
                for (int i = 0; i < materialMRPPlanCalcSumDetail.Count; i++)
                {
                    strInsertSql = GetAddCalcSumSQL(materialMRPPlanCalcSumDetail[i]);
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


        ///<summary>
        ///删除数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void DeleteBill(string materialMRPPlanGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from MaterialMRPPlan where  MaterialMRPPlanGuid='" + materialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from MaterialMRPPlanDetail where  MaterialMRPPlanGuid='" + materialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from MaterialMRPPlanCalcSum where  MaterialMRPPlanGuid='" + materialMRPPlanGuid + "'";
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




        /// <summary>
        /// 得到新增sql
        /// </summary>
        public string GetAddSQL(MaterialMRPPlan MaterialMRPPlan)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterialMRPPlan(");
            strSql.Append("MaterialMRPPlanGuid,MaterialMRPPlanID,MaterialMRPPlanDate,Remark,CreateGuid,CreateDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + MaterialMRPPlan.MaterialMRPPlanGuid + "',");
            strSql.Append("'" + MaterialMRPPlan.MaterialMRPPlanID + "',");
            if (MaterialMRPPlan.MaterialMRPPlanDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + MaterialMRPPlan.MaterialMRPPlanDate + "',");
            }
            strSql.Append("'" + MaterialMRPPlan.Remark + "',");
            strSql.Append("'" + MaterialMRPPlan.CreateGuid + "',");
          
            if (MaterialMRPPlan.CreateDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + MaterialMRPPlan.CreateDate + "'");
            }

            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到物料需求计划明细sql
        /// </summary>
        public string GetAddDetailSQL(MaterialMRPPlanDetail MaterialMRPPlanDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterialMRPPlanDetail(");
            strSql.Append("NoID,MaterialMRPPlanGuid,ClientOrderid,ClientOrderDetailGuid,MaterialGuid,MaterialSum,YCMaterialSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + MaterialMRPPlanDetail.NoID + "',");
            strSql.Append("'" + MaterialMRPPlanDetail.MaterialMRPPlanGuid + "',");
            strSql.Append("'" + MaterialMRPPlanDetail.ClientOrderid + "',");
            strSql.Append("'" + MaterialMRPPlanDetail.ClientOrderDetailGuid + "',");
            strSql.Append("'" + MaterialMRPPlanDetail.MaterialGuid + "',");
            strSql.Append("" + MaterialMRPPlanDetail.MaterialSum + ",");
            strSql.Append("" + MaterialMRPPlanDetail.YCMaterialSum + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// 得到选单sql
        /// </summary>
        public string GetAddCalcSumSQL(MaterialMRPPlanCalcSumDetail MaterialMRPPlanCalcSumDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterialMRPPlanCalcSum(");
            strSql.Append("NoID,MaterialMRPPlanGuid,MaterialGuid,MaterialRequirementSum,MaterialStockSum,MaterialStockInSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + MaterialMRPPlanCalcSumDetail.NoID + "',");
            strSql.Append("'" + MaterialMRPPlanCalcSumDetail.MaterialMRPPlanGuid + "',");
            strSql.Append("'" + MaterialMRPPlanCalcSumDetail.MaterialGuid + "',");
            strSql.Append("" + MaterialMRPPlanCalcSumDetail.MaterialRequirementSum + ",");
            strSql.Append("" + MaterialMRPPlanCalcSumDetail.MaterialStockSum + ",");
            strSql.Append("" + MaterialMRPPlanCalcSumDetail.MaterialStockInSum + "");
            strSql.Append(")");
            return strSql.ToString();
        }


        //将物料需求计划中选择的物料放入到临时表进行计算
        public void InsertIntoSelectMaterial(string strMaterialMRPPlanGuID, string strMaterialGuid, decimal decMaterialSum)
        { 
             CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
             try
             {
                 StringBuilder strSql = new StringBuilder();
                 strSql.Append("insert into Temp_CalcMaterialBom(");
                 strSql.Append("MaterialMRPPlanGuID,MaterialGuid,MaterialSum ");
                 strSql.Append(")");
                 strSql.Append(" values (");
                 strSql.Append("'" + strMaterialMRPPlanGuID + "',");
                 strSql.Append("'" + strMaterialGuid + "',");
                 strSql.Append("" + decMaterialSum + "");
                 strSql.Append(")");
                 pComm.Execute(strSql.ToString());
                 pComm.Close();

             }
             catch (Exception e)
             {

                 pComm.Close();
                 throw e;

             }
        }

        //将物料需求计划中选择的物料放入到临时表进行计算
        public void DeleteSelectMaterial(string strMaterialMRPPlanGuID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {


                string str = "delete from Temp_CalcMaterialBom";
                pComm.Execute(str);
                pComm.Close();

            }
            catch (Exception e)
            {

                pComm.Close();
                throw e;

            }
        }


        //计算客户订单中产品所需要用到的物料需求用量
        public void CalcMaterialBomPlan2(string strMaterialMRPPlanGuID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialMRPPlanGuID";
                par[0, 1] = strMaterialMRPPlanGuID;

                pComm.ExcuteSp("sp_GetMaterialDataByBomCalc2", par);

                pComm.Close();
               
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        
        ////将客户订单中的产品折成倒数第二层组件
        //public void sp_CalHalfRequirementSumByClientOrder(string strMaterialMRPPlanGuID)
        //{

        //    CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
        //    try
        //    {
                
        //        string[,] par;
        //        par = new string[1, 2];
        //        par[0, 0] = "@MaterialMRPPlanGuID";
        //        par[0, 1] = strMaterialMRPPlanGuID;

        //        pComm.ExcuteSp("sp_CalHalfRequirementSumByClientOrder", par);

        //        pComm.Close();
               
        //    }
        //    catch (Exception e)
        //    {
        //        pComm.Close();
        //        throw e;

        //    }

        //}

        ////将库存中成品与半成品折成倒数第二层组件
        //public void sp_CalHalfRequirementSumByStorage()
        //{

        //    CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
        //    try
        //    {
              
        //        string[,] par;
        //        par = new string[1, 2];
        //        par[0, 0] = "@MaterialMRPPlanGuID";
        //        par[0, 1] = "";

        //        pComm.ExcuteSp("sp_CalHalfRequirementSumByStorage ", par);

        //        pComm.Close();
                
        //    }
        //    catch (Exception e)
        //    {
        //        pComm.Close();
        //        throw e;

        //    }

        //}



        //最后将倒数第二层组件的数量折成料件数以展示库存
        public DataTable sp_Calc(string BomPlanGuid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialMRPPlanGuID";
                par[0, 1] = BomPlanGuid;

                dset = pComm.ExcuteSp("sp_Calc", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


        //计算无BOM的物料需求计划
        public DataTable sp_Calc_NoBOM(string BomPlanGuid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialMRPPlanGuID";
                par[0, 1] = BomPlanGuid;

                dset = pComm.ExcuteSp("sp_Calc_NoBOM", par);

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
        /// 得到物料需求计划数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  MaterialMRPPlanGuid,MaterialMRPPlanID as 物料需求计划单号,MaterialMRPPlanDate as 计算日期,Remark  as  备注 ,"
                       + " ( select UserName from LoginUser where UserID=CreateGuid) as 制单人,"
                        +" convert(nvarchar(10),CreateDate,120) as 制单日期 from  MaterialMRPPlan   " + strsql + " order by CreateDate desc";
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
        /// 得到物料需求计划数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanByBomPlanGuid(string BomPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  MaterialMRPPlanGuid,MaterialMRPPlanID,MaterialMRPPlanDate,Remark from   MaterialMRPPlan  where MaterialMRPPlanGuid='" + BomPlanGuid + "'";
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
        /// 得到物料需求计划数据---供采购订单从需求计划选择界面专用
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanBySQL_EN(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  'False' as selectvalue,MaterialMRPPlanGuid,MaterialMRPPlanID,MaterialMRPPlanDate,Remark from   MaterialMRPPlan  " + strsql+" order by MaterialMRPPlanDate desc";
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
        /// 得到物料需求明细数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanDetailByBomPlanGuid(string BomPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select   *,convert(nvarchar(10),MaterialMRPPlanDate,120) as ClientOrderDate     from  V_MaterialMRPPlanDetail_All  where  MaterialMRPPlanGuid='" + BomPlanGuid + "' order by sortid";
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
        /// 得到物料需求计算后的物料需求数据
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanCalcSumByBomPlanGuid(string BomPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *    from  V_MaterialMRPPlanCalcDetail   where  MaterialMRPPlanGuid='" + BomPlanGuid + "' order by sortid";
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
        /// 得到物料需求计算后的物料需求数据,加上采购订单从物料需求计划选择界面专用.
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanCalcSumByBomPlanGuid(string BomPlanGuid,string SupplierGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *    from  V_MaterialMRPPlanCalcDetail   where  MaterialMRPPlanGuid='" + BomPlanGuid + "' and SupplierGuid='" + SupplierGuid + "' order by sortid";
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
        /// 得到物料需求计算后的物料需求数据----供采购订单从物料需求计划中选择专用
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanCalcDataByPlanGuid(string BomPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *   from  V_MaterialMRPPlanCalcDetail2   where  MaterialMRPPlanGuid='" + BomPlanGuid + "' order by sortid";
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
        /// 得到物料需求计算后的物料需求数据----供采购订单从物料需求计划中选择专用,另增加供应商条件
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetMRPPlanCalcDataByPlanGuid(string BomPlanGuid,string SupplierGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *   from  V_MaterialMRPPlanCalcDetail2   where  MaterialMRPPlanGuid='" + BomPlanGuid + "' and SupplierGuid='" + SupplierGuid + "' order by sortid";
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

    }
}
