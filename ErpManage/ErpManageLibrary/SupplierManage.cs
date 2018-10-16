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
    public class SupplierManage
    {

        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public bool Save(Supplier pObj)
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
        public bool SaveStatus(Supplier pObj)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT Guid   FROM   Supplier  " +
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
        public DataTable GetSupplierData()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName as  ��Ӧ�̼��,[Name] as ��Ӧ������,LinkMan as ��ϵ��,Telephone as �绰,Fax as ����,Address as ��ַ,Zip as �ʱ�,ProduceType as ��������,Remark as  ��ע,Case when IsEnable=1 then 'ͣ��' when IsEnable=0 then '����' end as �Ƿ���� from Supplier   ";
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
        public DataTable GetSupplierDataBySelectBySQL(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,Name   from Supplier " + strsql;
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
        public DataTable GetSupplierDataBySelect()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,[Name]   from Supplier where IsEnable=0  ";
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
        public DataTable GetSupplierData(string SupplierGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName as  ��Ӧ�̼��,[Name] as ��Ӧ������,LinkMan as ��ϵ��,Telephone as �绰,Fax as ����,Address as ��ַ,Zip as �ʱ�,ProduceType as ��������,Remark as  ��ע,Case when IsEnable=1 then 'ͣ��' when IsEnable=0 then '����' end as �Ƿ���� from Supplier where Guid='" + SupplierGuid + "'";
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
        public DataTable GetSupplierData_CN(string SupplierGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Guid,SimpName,[Name] ,LinkMan,Telephone ,Fax ,Address,Zip ,ProduceType ,Remark,IsEnable from Supplier where Guid='" + SupplierGuid + "'";
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
        public void DeleteSupplier(string SupplierGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "delete  from Supplier  where  Guid='" + SupplierGuid + "'";
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
