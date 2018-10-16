using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���ϵ�������
    /// </summary>
    public class DrawOrderManage
    {
        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void SaveBill(DrawOrder DrawOrder, List<DrawOrderDetail> DrawOrderDetail)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from DrawOrder where  DrawOrderGuid='" + DrawOrder.DrawOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //������������
                string strInsertSql = GetAddBillSQL(DrawOrder);
                pComm.Execute(strInsertSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from DrawOrderDetail where  DrawOrderGuid='" + DrawOrder.DrawOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < DrawOrderDetail.Count; i++)
                {
                    strInsertSql = GetAddBillDetailSQL(DrawOrderDetail[i]);
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
        public void DeleteBill(string DrawOrderguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from DrawOrder where  DrawOrderGuid='" + DrawOrderguid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from DrawOrderDetail where  DrawOrderGuid='" + DrawOrderguid + "'";
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
        public string GetAddBillSQL(DrawOrder DrawOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DrawOrder(");
            strSql.Append("DrawOrderGuid,DrawOrderID,DrawOrderDate,DrawPerson,EmitPerson,OutStorage,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + DrawOrder.DrawOrderGuid + "',");
            strSql.Append("'" + DrawOrder.DrawOrderID + "',");
            strSql.Append("'" + DrawOrder.DrawOrderDate + "',");
            strSql.Append("'" + DrawOrder.DrawPerson + "',");
            strSql.Append("'" + DrawOrder.EmitPerson + "',");
            strSql.Append("'" + DrawOrder.OutStorage + "',");
            strSql.Append("'" + DrawOrder.Remark + "',");
            strSql.Append("'" + DrawOrder.CreateGuid + "',");
            strSql.Append("'" + DrawOrder.CreateDate + "',");
            strSql.Append("'" + DrawOrder.CheckGuid + "',");
            if (DrawOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + DrawOrder.CheckDate + "'");
            }
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// �õ�����һ����ϸ��SQL
        /// </summary>
        public string GetAddBillDetailSQL(DrawOrderDetail DrawOrderDetail)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DrawOrderDetail(");
            strSql.Append("DrawOrderGuid,MaterialGuID,ConsumeSum,MaterialSum,ApplyMaterialSum,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + DrawOrderDetail.DrawOrderGuid + "',");
            strSql.Append("'" + DrawOrderDetail.MaterialGuID + "',");
            strSql.Append("" + DrawOrderDetail.ConsumeSum + ",");
            strSql.Append("" + DrawOrderDetail.MaterialSum + ",");
            strSql.Append("" + DrawOrderDetail.ApplyMaterialSum + ",");
            strSql.Append("" + DrawOrderDetail.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }



        /// <summary>
        /// �õ����ϵ�����ϸ
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawOrderDetail(string DrawOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select   *   from  V_DrawOrderDetail  where DrawOrderGuid='" + DrawOrderGuid + "' order by sortid";
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
        /// �õ����ϵ���������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_DrawOrder " + strsql + " order by CreateDate desc";
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
        /// �õ��ɹ�������������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetDrawOrderByDrawOrderGuid(string DrawOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select  *   from  V_DrawOrder where DrawOrderGuid='" + DrawOrderGuid + "'";
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
        /// �������״̬��
        /// </summary>
        /// <returns></returns>
        public void CheckBill(string DrawOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //ɾ������
                if (pass == 1)
                {
                    //ͨ��
                    ps_Sql = "update DrawOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where DrawOrderGuid='" + DrawOrderGuid + "'";

                }
                else
                {
                    //��ͨ��
                    ps_Sql = "update DrawOrder  set CheckGuid='',CheckDate=null  where DrawOrderGuid='" + DrawOrderGuid + "'";

                }

                pObj_Comm.Execute(ps_Sql);
                pObj_Comm.Close();
            }
            catch (Exception e)
            {

                pObj_Comm.Close();
                throw e;
            }
        }


        /// <summary>
        /// �õ������Ƿ�����˻��ѽᵥ-
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string DrawOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  DrawOrderGuid,CheckGuid  from   DrawOrder where DrawOrderGuid='" + DrawOrderGuid + "' ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    if (pDTMain.Rows[0]["CheckGuid"].ToString().Trim() != "")
                    {
                        return true;
                    }

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

    }
}
