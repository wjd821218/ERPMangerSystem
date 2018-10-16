using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;


namespace ErpManageLibrary
{
    /// <summary>
    /// Ա������
    /// </summary>
    public class EmployeeManage
    {
        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public bool Save(Employee pObj)
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
        public bool SaveStatus(Employee pObj)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT EmpGuid   FROM   Employee  " +
                    "where EmpGuid  ='" + pObj.EmpGuid + "'";
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
        public DataTable GetEmployeeData()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid,EmpID as Ա�����,EmpName as  Ա������,(select deptname  from Dept where Dept.deptguid=Employee.Dept) as ���ڲ���,Sex as �Ա�,Telephone as �绰,Address as  ��ַ,CardID  as ���֤��,"
                       + "  Case when IsEnable=1 then 'ͣ��' when IsEnable=0 then '����' end as �Ƿ���� from Employee ";
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
        public DataTable GetEmployeeDataSelectBySQL(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid,EmpID,EmpName  from Employee " + strsql;
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
        /// �õ�����---���ļ�����ר��
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployeeDataSelectBySQL2(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select 'False' as selectvalue,EmpGuid,EmpID,EmpName  from Employee " + strsql;
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
        public DataTable GetEmployeeData(string EmpGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid,EmpID,EmpName,Sex,Telephone,Address,CardID,dept,IsEnable from Employee where EmpGuid='" + EmpGuid + "'";
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
        public DataTable GetEmployeeDataBySelect()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid,EmpID,EmpName,(select DeptName from  dept where DeptGuid=Dept) as  DeptName from Employee order by Dept,EmpID";
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
        /// �õ�����---���ļ�����ҳ��ר��
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployeeDataBySelect2()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select 'False' as selectvalue,EmpGuid,EmpID,EmpName,(select DeptName from  dept where DeptGuid=Dept) as  DeptName from Employee order by Dept,EmpID";
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
        public void DeleteEmployee(string EmpGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "delete  from Employee  where  EmpGuid='" + EmpGuid + "'";
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
        /// �õ�Ա�����ڲ���
        /// </summary>
        /// <param name="EmpGuid"></param>
        public string  GetEmpDeptByEmpName(string EmpName)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select Dept  from Employee  where  EmpName='" + EmpName + "'";
                DataTable dtl=new DataTable();
                dtl=pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (dtl.Rows.Count>0)
                {
                    return dtl.Rows[0]["Dept"].ToString();
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
        /// �õ�Ա�����ڲ���
        /// </summary>
        /// <param name="EmpGuid"></param>
        public string GetEmpGuIDByEmpName(string EmpName)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid  from Employee  where  EmpName='" + EmpName + "'";
                DataTable dtl = new DataTable();
                dtl = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                if (dtl.Rows.Count > 0)
                {
                    return dtl.Rows[0]["EmpGuid"].ToString();
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
    }
}
