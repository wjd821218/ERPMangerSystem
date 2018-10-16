using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���
    /// </summary>
    public class PaymentOrderManage
    {

        ///<summary>
        /// ��������----�������ʱ��
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void SaveBill(PaymentOrder PaymentOrder, List<PaymentOrderDetail1> PaymentOrderDetail1, List<PaymentOrderDetail2> PaymentOrderDetail2)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from PaymentOrder where  PaymentOrderGuid='" + PaymentOrder.PaymentOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //������������
                string strInsertSql = GetAddSQL(PaymentOrder);
                pComm.Execute(strInsertSql);


                //ɾ����ϸ��
                strDeleteSql = "Delete from PaymentOrderDetail1 where  PaymentOrderGuid='" + PaymentOrder.PaymentOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < PaymentOrderDetail1.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL1(PaymentOrderDetail1[i]);
                    pComm.Execute(strInsertSql);
                }


                //ɾ��������ϸ
                strDeleteSql = "Delete from PaymentOrderDetail2 where  PaymentOrderGuid='" + PaymentOrder.PaymentOrderGuid + "'";
                pComm.Execute(strDeleteSql);

                //������ϸ������
                for (int i = 0; i < PaymentOrderDetail2.Count; i++)
                {
                    strInsertSql = GetAddDetailSQL2(PaymentOrderDetail2[i]);
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
        public void DeleteBill(string PaymentOrderGuid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //���浥����������
                //��ɾ����������
                string strDeleteSql = "Delete from PaymentOrder where  PaymentOrderGuid='" + PaymentOrderGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��1
                strDeleteSql = "Delete from PaymentOrderDetail1 where  PaymentOrderGuid='" + PaymentOrderGuid + "'";
                pComm.Execute(strDeleteSql);


                //ɾ����ϸ��2
                strDeleteSql = "Delete from PaymentOrderDetail2 where  PaymentOrderGuid='" + PaymentOrderGuid + "'";
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
        public string GetAddSQL(PaymentOrder PaymentOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PaymentOrder(");
            strSql.Append("PaymentOrderGuid,PaymentOrderID,PaymentOrderDate,SupplierGuid,PayPerson,BankID,PayID,Remark,CreateGuid,CreateDate,CheckGuid,CheckDate");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + PaymentOrder.PaymentOrderGuid + "',");
            strSql.Append("'" + PaymentOrder.PaymentOrderID + "',");
            if (PaymentOrder.PaymentOrderDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null,");
            }
            else            
            {
                strSql.Append("'" + PaymentOrder.PaymentOrderDate + "',");
            }
            strSql.Append("'" + PaymentOrder.SupplierGuid + "',");
            strSql.Append("'" + PaymentOrder.PayPerson + "',");
            strSql.Append("'" + PaymentOrder.BankID + "',");
            strSql.Append("'" + PaymentOrder.PayID + "',");
            strSql.Append("'" + PaymentOrder.Remark + "',");
            strSql.Append("'" + PaymentOrder.CreateGuid + "',");
            strSql.Append("'" + PaymentOrder.CreateDate + "',");
            strSql.Append("'" + PaymentOrder.CheckGuid + "',");
            if (PaymentOrder.CheckDate == DateTime.Parse("1900-01-01"))
            {
                strSql.Append("null");
            }
            else
            {
                strSql.Append("'" + PaymentOrder.CreateDate + "'");
            }

            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// �õ��������ϼƻ���ϸsql
        /// </summary>
        public string GetAddDetailSQL1(PaymentOrderDetail1 PaymentOrderDetail1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PaymentOrderDetail1(");
            strSql.Append("PaymentOrderGuid,PayID,PayMoney,CNY,PayType,Remark,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + PaymentOrderDetail1.PaymentOrderGuid + "',");
            strSql.Append("'" + PaymentOrderDetail1.PayID + "',");
            strSql.Append("" + PaymentOrderDetail1.PayMoney + ",");
            strSql.Append("'" + PaymentOrderDetail1.CNY + "',");
            strSql.Append("'" + PaymentOrderDetail1.PayType + "',");
            strSql.Append("'" + PaymentOrderDetail1.Remark + "',");
            strSql.Append("" + PaymentOrderDetail1.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }

        /// <summary>
        /// �õ��������ϼƻ���ϸsql
        /// </summary>
        public string GetAddDetailSQL2(PaymentOrderDetail2 PaymentOrderDetail2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PaymentOrderDetail2(");
            strSql.Append("PaymentOrderGuid,StockInOrderID,StockInOrderDate,SupplierName,MaterialGuID,MaterialID,MaterialName,MaterialPrice,MaterialSum,MaterialMoney,Remark,OrderFlag,SortID");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + PaymentOrderDetail2.PaymentOrderGuid + "',");
            strSql.Append("'" + PaymentOrderDetail2.StockInOrderID + "',");
            strSql.Append("'" + PaymentOrderDetail2.StockInOrderDate + "',");
            strSql.Append("'" + PaymentOrderDetail2.SupplierName + "',");
            strSql.Append("'" + PaymentOrderDetail2.MaterialGuID + "',");
            strSql.Append("'" + PaymentOrderDetail2.MaterialID + "',");
            strSql.Append("'" + PaymentOrderDetail2.MaterialName + "',");
            strSql.Append("" + PaymentOrderDetail2.MaterialPrice + ",");
            strSql.Append("" + PaymentOrderDetail2.MaterialSum + ",");
            strSql.Append("" + PaymentOrderDetail2.MaterialMoney + ",");
            strSql.Append("'" + PaymentOrderDetail2.Remark + "',");
            strSql.Append("'" + PaymentOrderDetail2.OrderFlag + "',");
            strSql.Append("" + PaymentOrderDetail2.SortID + "");
            strSql.Append(")");
            return strSql.ToString();
        }



      



        /// <summary>
        /// �õ��������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetPaymentOrderBySQL(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select   'False' as selectvalue,*  from  V_PaymentOrder   " + strsql + " order by CreateDate desc";
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
        /// �õ��������
        /// </summary>
        public DataTable GetPaymentOrderByPaymentGuid(string guid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *  from  V_PaymentOrder  where  PaymentOrderGuid='" + guid + "'";
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
        /// �õ�����ʻ�����
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetPaymentOrderDetail1ByGuid(string PaymentOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *  from    V_PaymentOrderDetail1  where PaymentOrderGuid='" + PaymentOrderGuid + "' order by sortid";
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
        /// �õ��ɹ���������
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public DataTable GetPaymentOrderDetail2ByGuid(string PaymentOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select  *  from  PaymentOrderDetail2  where PaymentOrderGuid='" + PaymentOrderGuid + "' order by sortid";
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
        public void CheckBill(string PaymentOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //ɾ������
                if (pass == 1)
                {
                    //ͨ��
                    ps_Sql = "update PaymentOrder  set CheckGuid='" + SysParams.UserID + "',CheckDate='" + DateTime.Now.ToString() + "'  where PaymentOrderGuid='" + PaymentOrderGuid + "'";

                }
                else
                {
                    //��ͨ��
                    ps_Sql = "update PaymentOrder  set CheckGuid='',CheckDate=null  where PaymentOrderGuid='" + PaymentOrderGuid + "'";

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
        /// ���¶����״̬��
        /// </summary>
        /// <returns></returns>
        public void CheckBill2(string PaymentOrderGuid, int pass)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "";
                //ɾ������
                if (pass == 1)
                {
                    //ͨ��
                    ps_Sql = "update PaymentOrder  set CheckGuid2='" + SysParams.UserID + "',CheckDate2='" + DateTime.Now.ToString() + "'  where PaymentOrderGuid='" + PaymentOrderGuid + "'";

                }
                else
                {
                    //��ͨ��
                    ps_Sql = "update PaymentOrder  set CheckGuid2='',CheckDate2=null  where PaymentOrderGuid='" + PaymentOrderGuid + "'";

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
        /// �õ������Ƿ�����˻��ѽᵥ
        /// </summary>
        /// <param name="FatherMaterialGuid"></param>
        /// <returns></returns>
        public bool GetIsCheck(string PaymentOrderGuid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select PaymentOrderGuid,CheckGuid  from   PaymentOrder where PaymentOrderGuid='" + PaymentOrderGuid + "' ";
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



        //�ɹ���ⵥ��,����Ӳɹ���ⵥ��ѡ��
        public DataTable sp_GetSelectStockInOrder(string PaymentID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@PaymentID";
                par[0, 1] = PaymentID;


                dset = pComm.ExcuteSp("sp_GetSelectStockInOrder", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }

        }


    }
}
