using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 员工管理
    /// </summary>
    public class DeptManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public bool Save(Dept pObj)
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
        public bool SaveStatus(Dept pObj)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT DeptGuid   FROM   Dept  " +
                    "where DeptGuid  ='" + pObj.DeptGuid + "'";
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
        public DataTable GetDeptData()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select DeptGuid,DeptName as 部门名称,DeptPerson as  负责人,Telephone as 电话,Fax as  传真,address as 地址,Case when IsEnable=1 then '停用' when IsEnable=0 then '可用' end as 是否可用 from Dept ";
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
        public DataTable GetDeptDataSelectBySQL(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql =  "select DeptGuid,DeptName   from Dept "+strsql;
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
        /// 得到数据----供客户订单选部门时专用 2010-6-4
        /// </summary>
        /// <returns></returns>
        public DataTable GetDeptDataSelectBySQL2(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select 'False' as selectvalue,DeptGuid,DeptName   from Dept " + strsql;
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
        public DataTable GetDeptData(string DeptGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select DeptGuid,DeptName,DeptPerson,Telephone,Fax,address,IsEnable from Dept where DeptGuid='" + DeptGuid + "'";
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
        public DataTable GetDeptDataBySelect()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select DeptGuid,DeptName     from Dept ";
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
        /// 得到数据-----供客户订单选部门时专用 2010-6-4
        /// </summary>
        /// <returns></returns>
        public DataTable GetDeptDataBySelect2()
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select  'False' as selectvalue,DeptGuid,DeptName     from Dept ";
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
        public void DeleteDept(string DeptGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "delete  from Dept  where  DeptGuid='" + DeptGuid + "'";
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
