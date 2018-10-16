using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;


namespace ErpManageLibrary
{
    /// <summary>
    /// 员工管理
    /// </summary>
    public class EmployeeManage
    {
        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
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
        /// 得到当前是新增状态还是修改状态
        /// </summary>
        /// <param name="pObj">信息集实例</param>
        /// <returns>返回True或False</returns>
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
        /// 得到数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmployeeData()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select EmpGuid,EmpID as 员工编号,EmpName as  员工姓名,(select deptname  from Dept where Dept.deptguid=Employee.Dept) as 所在部门,Sex as 性别,Telephone as 电话,Address as  地址,CardID  as 身份证号,"
                       + "  Case when IsEnable=1 then '停用' when IsEnable=0 then '可用' end as 是否可用 from Employee ";
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
        /// 得到数据
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
        /// 得到数据---供文件申请专用
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
        /// 得到数据
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
        /// 得到数据
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
        /// 得到数据---供文件申请页面专用
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
        /// 删除
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
        /// 得到员工所在部门
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
        /// 得到员工所在部门
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
