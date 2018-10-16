using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;


namespace ErpManageLibrary
{
    /// <summary>
    /// ��Ӧ��
    /// </summary>
    public class ClientManage
    {

        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public bool Save(Client pObj)
        {
            try
            {
                if (SaveStatus(pObj) == false)
                {
                    return pObj.Add();
                }
                else
                {

                    return pObj.Update();
                }
            }
            catch (Exception e)
            {
                throw e;

            }
        }


        ///<summary>
        /// �õ���ǰ������״̬�����޸�״̬
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ��</param>
        /// <returns>����True��False</returns>
        public bool SaveStatus(Client pObj)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT Guid   FROM   Client  " +
                    "where Guid  ='" + pObj.Guid + "'";
                DataTable pDT = pComm.ExeForDtl(pSql);
                pComm.Close();
                if (pDT.Rows.Count > 0)
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
                pComm.Close();
                throw e;

            }
        }


        /// <summary>
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetClientData()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName as  �ͻ����,[Name] as �ͻ�����,LinkMan as ��ϵ��,Telephone as �绰,Fax as ����,Address as ��ַ,Zip as �ʱ�,SellType as �������,ProductName as ��Ʒ����,Remark as  ��ע,Case when IsEnable=1 then 'ͣ��' when IsEnable=0 then '����' end as �Ƿ����  from Client ";
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetClientData(string ClientGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName as  �ͻ����,[Name] as �ͻ�����,LinkMan as ��ϵ��,Telephone as �绰,Fax as ����,Address as ��ַ,Zip as �ʱ�,SellType as �������,ProductName as ��Ʒ����,Remark as  ��ע,Case when IsEnable=1 then 'ͣ��' when IsEnable=0 then '����' end as �Ƿ���� from Client where Guid='" + ClientGuid + "'";
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetClientData_CN(string ClientGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName,[Name] ,LinkMan,Telephone ,Fax ,Address,Zip ,SellType ,ProductName,Remark,IsEnable,IsEnable from Client where Guid='" + ClientGuid + "'";
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetClientDataBySelectBySQL(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,Name  from Client " + strsql;
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetClientDataBySelect()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,[Name]   from Client ";
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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
        /// ɾ��
        /// </summary>
        /// <returns></returns>
        public void DeleteClient(string ClientGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "delete  from Client  where  Guid='" + ClientGuid + "'";
                pObj_Comm.Execute(ps_Sql);

                pObj_Comm.Close();


            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }


    }
}
