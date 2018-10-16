using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��������ƻ�������
    /// </summary>
    public class MaterialMRPPlanManage
    {

      

        ///<summary>
        /// ��������----�������ʱ��
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void SaveBill(MaterialMRPPlan materialMRPPlan, List<MaterialMRPPlanDetail> materialMRPPlanDetail, List<MaterialMRPPlanCalcSumDetail> materialMRPPlanCalcSumDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from MaterialMRPPlan where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������������
                string strInsertSql = GetAddSQL(materialMRPPlan);
                pComm.Execute(strInsertSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from MaterialMRPPlanDetail where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < materialMRPPlanDetail.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL(materialMRPPlanDetail[i]);
                    pComm.Execute(strInsertSql);
                }


                //ɾ��������ϸ
                strDeleteSql = "Delete from MaterialMRPPlanCalcSum where  MaterialMRPPlanGuid='" + materialMRPPlan.MaterialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
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
        ///ɾ������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void DeleteBill(string materialMRPPlanGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from MaterialMRPPlan where  MaterialMRPPlanGuid='" + materialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from MaterialMRPPlanDetail where  MaterialMRPPlanGuid='" + materialMRPPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��
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
        /// �õ�����sql
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
        /// �õ���������ƻ���ϸsql
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
        /// �õ�ѡ��sql
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


        //����������ƻ���ѡ������Ϸ��뵽��ʱ����м���
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

        //����������ƻ���ѡ������Ϸ��뵽��ʱ����м���
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


        //����ͻ������в�Ʒ����Ҫ�õ���������������
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


        
        ////���ͻ������еĲ�Ʒ�۳ɵ����ڶ������
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

        ////������г�Ʒ����Ʒ�۳ɵ����ڶ������
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



        //��󽫵����ڶ�������������۳��ϼ�����չʾ���
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


        //������BOM����������ƻ�
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
        /// �õ���������ƻ�����
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
                ps_Sql = " select  MaterialMRPPlanGuid,MaterialMRPPlanID as ��������ƻ�����,MaterialMRPPlanDate as ��������,Remark  as  ��ע ,"
                       + " ( select UserName from LoginUser where UserID=CreateGuid) as �Ƶ���,"
                        +" convert(nvarchar(10),CreateDate,120) as �Ƶ����� from  MaterialMRPPlan   " + strsql + " order by CreateDate desc";
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
        /// �õ���������ƻ�����
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
        /// �õ���������ƻ�����---���ɹ�����������ƻ�ѡ�����ר��
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
        /// �õ�����������ϸ����
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
        /// �õ��������������������������
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
        /// �õ��������������������������,���ϲɹ���������������ƻ�ѡ�����ר��.
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
        /// �õ��������������������������----���ɹ���������������ƻ���ѡ��ר��
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
        /// �õ��������������������������----���ɹ���������������ƻ���ѡ��ר��,�����ӹ�Ӧ������
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
