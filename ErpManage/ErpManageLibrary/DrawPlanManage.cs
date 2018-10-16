using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// �������ϼƻ�������
    /// 
    /// �޸�1   ʱ�䣺2010-7-12  ��BOM�Ĳ㼶�����س�����
    /// </summary>
    public class DrawPlanManage
    {

      

        ///<summary>
        /// ��������----�������ʱ��
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void SaveBill(DrawPlan DrawPlan, List<DrawPlanDetail> DrawPlanDetail, List<DrawPlanCalcSumDetail> DrawPlanCalcSumDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from DrawPlan where  DrawPlanGuid='" + DrawPlan.DrawPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������������
                string strInsertSql = GetAddSQL(DrawPlan);
                pComm.Execute(strInsertSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from DrawPlanDetail where  DrawPlanGuid='" + DrawPlan.DrawPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < DrawPlanDetail.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL(DrawPlanDetail[i]);
                    pComm.Execute(strInsertSql);
                }


                //ɾ��������ϸ
                strDeleteSql = "Delete from DrawPlanCalcSum where  DrawPlanGuid='" + DrawPlan.DrawPlanGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < DrawPlanCalcSumDetail.Count; i++)
                {
                    strInsertSql = GetAddCalcSumSQL(DrawPlanCalcSumDetail[i]);
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
        public void DeleteBill(string DrawPlanGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from DrawPlan where  DrawPlanGuid='" + DrawPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from DrawPlanDetail where  DrawPlanGuid='" + DrawPlanGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from DrawPlanCalcSum where  DrawPlanGuid='" + DrawPlanGuid + "'";
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
        public string GetAddSQL(DrawPlan DrawPlan)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DrawPlan(");
            strSql.Append("DrawPlanGuid,DrawPlanID,DrawPlanDate,Remark,CreateGuid,CreateDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + DrawPlan.DrawPlanGuid + "',");
            strSql.Append("'" + DrawPlan.DrawPlanID + "',");
            if (DrawPlan.DrawPlanDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + DrawPlan.DrawPlanDate + "',");
            }
            strSql.Append("'" + DrawPlan.Remark + "',");
            strSql.Append("'" + DrawPlan.CreateGuid + "',");
          
            if (DrawPlan.CreateDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else
            {
                strSql.Append("'" + DrawPlan.CreateDate + "'");
            }

            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// �õ��������ϼƻ���ϸsql
        /// </summary>
        public string GetAddDetailSQL(DrawPlanDetail DrawPlanDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DrawPlanDetail(");
            strSql.Append("NoID,DrawPlanGuid,ClientOrderid,ClientOrderDetailGuid,MaterialGuid,MaterialSum,YCMaterialSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + DrawPlanDetail.NoID + "',");
            strSql.Append("'" + DrawPlanDetail.DrawPlanGuid + "',");
            strSql.Append("'" + DrawPlanDetail.ClientOrderid + "',");
            strSql.Append("'" + DrawPlanDetail.ClientOrderDetailGuid + "',");
            strSql.Append("'" + DrawPlanDetail.MaterialGuid + "',");
            strSql.Append("" + DrawPlanDetail.MaterialSum + ",");
            strSql.Append("" + DrawPlanDetail.YCMaterialSum + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// �õ�ѡ��sql
        /// </summary>
        public string GetAddCalcSumSQL(DrawPlanCalcSumDetail DrawPlanCalcSumDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DrawPlanCalcSum(");
            strSql.Append("NoID,DrawPlanGuid,MaterialGuid,MaterialRequirementSum,MaterialStockSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + DrawPlanCalcSumDetail.NoID + "',");
            strSql.Append("'" + DrawPlanCalcSumDetail.DrawPlanGuid + "',");
            strSql.Append("'" + DrawPlanCalcSumDetail.MaterialGuid + "',");
            strSql.Append("" + DrawPlanCalcSumDetail.MaterialRequirementSum + ",");
            strSql.Append("" + DrawPlanCalcSumDetail.MaterialStockSum + "");
            strSql.Append(")");
            return strSql.ToString();
        }


        //���������ϼƻ���ѡ������Ϸ��뵽��ʱ����м���
        public void InsertIntoSelectMaterial(string strDrawPlanGuID, string strMaterialGuid, decimal decMaterialSum)
        { 
             CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
             try
             {
                 StringBuilder strSql = new StringBuilder();
                 strSql.Append("insert into Temp_DrawPlanCalcMaterialBom(");
                 strSql.Append("DrawPlanGuID,MaterialGuid,MaterialSum ");
                 strSql.Append(")");
                 strSql.Append(" values (");
                 strSql.Append("'" + strDrawPlanGuID + "',");
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

        //���������ϼƻ���ѡ������Ϸ��뵽��ʱ����м���
        public void DeleteSelectMaterial(string strDrawPlanGuID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {


                string str = "delete from Temp_DrawPlanCalcMaterialBom";
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
        public DataTable CalcMaterialDrawPlan(string strDrawPlanGuID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@DrawPlanGuID";
                par[0, 1] = strDrawPlanGuID;

                dset = pComm.ExcuteSp("sp_GetMaterialDataByDrawPlanCalc", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        //����ͻ������в�Ʒ����Ҫ�õ���������������--�������������(�������Ҫ���س��Ӽ�)
        public DataTable CalcMaterialDrawPlan2(string strDrawPlanGuID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@DrawPlanGuID";
                par[0, 1] = strDrawPlanGuID;

                dset = pComm.ExcuteSp("sp_GetMaterialDataByDrawPlanCalc2", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }

        //�޸�1  
        //����ͻ������в�Ʒ����Ҫ�õ���������������--��BOM�Ĳ㼶�����س�����
        public DataTable CalcMaterialDrawPlan3(string strDrawPlanGuID,string strlevel)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@DrawPlanGuID";
                par[0, 1] = strDrawPlanGuID;
                par[1, 0] = "@Level";
                par[1, 1] = strlevel;

                dset = pComm.ExcuteSp("sp_GetMaterialDataByDrawPlanCalc3", par);

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
        /// �õ��������ϼƻ�����
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  DrawPlanGuid,DrawPlanID as �������ϼƻ�����,DrawPlanDate as ��������,Remark  as  ��ע ,"
                       + " ( select UserName from LoginUser where UserID=CreateGuid) as �Ƶ���,"
                        +" convert(nvarchar(10),CreateDate,120) as �Ƶ����� from  DrawPlan   " + strsql + " order by CreateDate desc";
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
        /// �õ��������ϼƻ�����
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanByDrawPlanGuid(string DrawPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  DrawPlanGuid,DrawPlanID,DrawPlanDate,Remark from   DrawPlan  where DrawPlanGuid='" + DrawPlanGuid + "'";
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
        /// �õ��������ϼƻ�����---���ɹ�����������ƻ�ѡ�����ר��
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanBySQL_EN(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  'False' as selectvalue,DrawPlanGuid,DrawPlanID,DrawPlanDate,Remark from   DrawPlan  " + strsql+" order by DrawPlanDate desc";
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
        public DataTable GetDrawPlanDetailByDrawPlanGuid(string DrawPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select   *,convert(nvarchar(10),DrawPlanDate,120) as ClientOrderDate     from  V_DrawPlanDetail_All  where  DrawPlanGuid='" + DrawPlanGuid + "' order by sortid";
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
        /// �õ��������ϼ�����������������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanCalcSumByDrawPlanGuid(string DrawPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *    from  V_DrawPlanCalcDetail   where  DrawPlanGuid='" + DrawPlanGuid + "' order by sortid";
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
        /// �õ��������ϼ�����������������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanCalcSumByDrawPlanGuid(string DrawPlanGuid,string ClassID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *    from  V_DrawPlanCalcDetail   where  DrawPlanGuid='" + DrawPlanGuid + "' and ClassID='" + ClassID + "' order by sortid";
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
        /// �õ��������ϼ�����������������----���ɹ��������������ϼƻ���ѡ��ר��
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanCalcDataByPlanGuid(string DrawPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *   from  V_DrawPlanCalcDetail2   where  DrawPlanGuid='" + DrawPlanGuid + "' order by sortid";
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
        /// �õ��������ϼ�����������������----���ɹ��������������ϼƻ���ѡ��ר��
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanCalcDataByPlanGuid(string DrawPlanGuid,string ClassID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *   from  V_DrawPlanCalcDetail2   where  DrawPlanGuid='" + DrawPlanGuid + "' and ClassID='" + ClassID + "'order by sortid";
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
        /// �õ��������ϼƻ�����---�����ϵ����������ϼƻ�ѡ�����ר��
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanBySQL_Select(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  'False' as selectvalue,DrawPlanGuid,DrawPlanID,DrawPlanDate,Remark from   DrawPlan  " + strsql + " order by DrawPlanDate desc";
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
        /// �õ��������ϼƻ���ϸ����
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawPlanDetailByDrawPlanGuid_Select(string DrawPlanGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select   *,convert(nvarchar(10),DrawPlanDate,120) as DrawPlanDate     from  V_DrawPlanDetail_All  where  DrawPlanGuid='" + DrawPlanGuid + "' order by sortid";
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
        /// �õ��������ϼƻ����е�ĸ��Guid
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public string GetDrawPlanFatherMaterialGuid(string DrawPlanGuid)
        {
            string returnvalue = "";
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  top 1 MaterialGuid   from  DrawPlanDetail   where  DrawPlanGuid='" + DrawPlanGuid +"'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    returnvalue=pDTMain.Rows[0]["MaterialGuid"].ToString().Trim();
                }
                else
                {
                    returnvalue="";
                }

                return returnvalue;
               
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



    }
}
