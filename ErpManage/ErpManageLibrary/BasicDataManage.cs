using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��������ά��
    /// </summary>
    public class BasicDataManage
    {

        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="Flag">(1-��λ 2-��� 3:��װ 4:�Ƽ۷�)</param>
        /// <returns></returns>
        //public DataTable GetBasicData(int Flag)
        //{
          
        //    CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
        //    try
        //    {
        //        string ps_Sql = "select  UnitName  from BasicData where  flag=" + Flag.ToString() + " order by UnitID";
        //        DataTable  pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

        //        pObj_Comm.Close();

        //        return pDTMain;
        //    }
        //    catch (Exception e)
        //    {
        //        pObj_Comm.Close();
        //        throw e;
        //    }
        //}


        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="Flag">(1:��λ  2:���� 3:���㷽ʽ  4:���� 5:�ֿ�  6:���  )</param>
        /// <returns></returns>
        public DataTable GetBasicData(int Flag)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select  UnitID,UnitName  from BasicData where  IsDelete=0 and flag=" + Flag.ToString() + " order by UnitID";
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
        /// �����������
        /// </summary>
        /// <param name="Flag">(1:��λ  2:���� 3:���㷽ʽ  4:���� 5:�ֿ�  6:���  )</param>
        /// <returns></returns>
        public DataTable GetBasicDataByLikeUnitName(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select  UnitID,UnitName  from BasicData " + strsql;
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

      


        //����ID�õ��������ݵ�����
        public string  GetBasicDataNameByUnitID(string strID)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select top 1 UnitName  from BasicData where IsDelete=0 and UnitID=" + strID;
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count > 0)
                {
                    return pDTMain.Rows[0]["UnitName"].ToString();
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



        //�жϹ���Ƿ��Ѿ�����
        public bool IsExistUnit(string flag,string  strValue)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select   UnitName   from BasicData where Flag=" + flag + "  and   UnitName='" + strValue + "'";
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

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





        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public bool Save(BasicData pObj)
        {
            try
            {
               return pObj.Add();
               
            }
            catch (Exception e)
            {
                throw e;

            }
        }


        ///<summary>
        /// �����������ؽ����ѯ
        /// </summary>
        /// <param name="tableid">SQL��ѯ����</param>
        /// <returns>��Ų�ѯ�����DataTable</returns>
        public bool DeleteBasicData(string UnitID)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                string StrSQL = "Update  BasicData  set IsDelete=1  where UnitID=" + UnitID;

                pComm.Execute(StrSQL);
                pComm.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }



        /// <summary>
        /// ѡ�� 1: //Ա��  2: //����  3:  //��Ӧ��  4: //�ͻ�
        /// </summary>
        /// <param name="flag"> 1: //Ա��  2: //����  3:  //��Ӧ��  4: //�ͻ�</param>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable GetOtherSelectData(int flag,string strsql)
        {
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //Ա��
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl=EmployeeManage.GetEmployeeDataSelectBySQL(strsql);
                    break;
                case 2: //����
                    DeptManage DeptManage = new DeptManage();
                    dtl = DeptManage.GetDeptDataSelectBySQL(strsql);
                    break;
                case 3: //��Ӧ��
                    SupplierManage SupplierManage=new SupplierManage();
                    dtl=SupplierManage.GetSupplierDataBySelectBySQL(strsql);
                    break;
                case 4: //�ͻ�
                    ClientManage ClientManage = new ClientManage();
                    dtl = ClientManage.GetClientDataBySelectBySQL(strsql);
                    break;
            }

            return dtl;
        
        }


        /// <summary>
        /// ѡ�񣺹��ͻ�����ѡ����ղ��Ŷ�ѡר�� 2010-6-4 1: //Ա��  2: //����  3:  //��Ӧ��  4: //�ͻ�
        /// </summary>
        /// <param name="flag"> 1: //Ա��  2: //����  3:  //��Ӧ��  4: //�ͻ�</param>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable GetOtherSelectData2(int flag, string strsql)
        {
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //Ա��
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl = EmployeeManage.GetEmployeeDataSelectBySQL2(strsql);
                    break;
                case 2: //����
                    DeptManage DeptManage = new DeptManage();
                    dtl = DeptManage.GetDeptDataSelectBySQL2(strsql);
                    break;
                //case 3: //��Ӧ��
                //    SupplierManage SupplierManage = new SupplierManage();
                //    dtl = SupplierManage.GetSupplierDataBySelectBySQL(strsql);
                //    break;
                //case 4: //�ͻ�
                //    ClientManage ClientManage = new ClientManage();
                //    dtl = ClientManage.GetClientDataBySelectBySQL(strsql);
                //    break;
            }

            return dtl;

        }

    }
}
