using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Daniel.Liu.DAO;

namespace ErpManageLibrary
{
    /// <summary>
    /// 基础数据维护
    /// </summary>
    public class BasicDataManage
    {

        /// <summary>
        /// 辅助数据类别：
        /// </summary>
        /// <param name="Flag">(1-单位 2-规格 3:封装 4:计价法)</param>
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
        /// 辅助数据类别：
        /// </summary>
        /// <param name="Flag">(1:单位  2:币种 3:结算方式  4:车间 5:仓库  6:规格  )</param>
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
        /// 辅助数据类别：
        /// </summary>
        /// <param name="Flag">(1:单位  2:币种 3:结算方式  4:车间 5:仓库  6:规格  )</param>
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

      


        //根据ID得到基础数据的名称
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



        //判断规格是否已经存在
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
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
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
        /// 输入条件返回结果查询
        /// </summary>
        /// <param name="tableid">SQL查询条件</param>
        /// <returns>存放查询结果的DataTable</returns>
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
        /// 选择： 1: //员工  2: //部门  3:  //供应商  4: //客户
        /// </summary>
        /// <param name="flag"> 1: //员工  2: //部门  3:  //供应商  4: //客户</param>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable GetOtherSelectData(int flag,string strsql)
        {
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //员工
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl=EmployeeManage.GetEmployeeDataSelectBySQL(strsql);
                    break;
                case 2: //部门
                    DeptManage DeptManage = new DeptManage();
                    dtl = DeptManage.GetDeptDataSelectBySQL(strsql);
                    break;
                case 3: //供应商
                    SupplierManage SupplierManage=new SupplierManage();
                    dtl=SupplierManage.GetSupplierDataBySelectBySQL(strsql);
                    break;
                case 4: //客户
                    ClientManage ClientManage = new ClientManage();
                    dtl = ClientManage.GetClientDataBySelectBySQL(strsql);
                    break;
            }

            return dtl;
        
        }


        /// <summary>
        /// 选择：供客户订单选择接收部门多选专用 2010-6-4 1: //员工  2: //部门  3:  //供应商  4: //客户
        /// </summary>
        /// <param name="flag"> 1: //员工  2: //部门  3:  //供应商  4: //客户</param>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public DataTable GetOtherSelectData2(int flag, string strsql)
        {
            DataTable dtl = new DataTable();
            switch (flag)
            {
                case 1: //员工
                    EmployeeManage EmployeeManage = new EmployeeManage();
                    dtl = EmployeeManage.GetEmployeeDataSelectBySQL2(strsql);
                    break;
                case 2: //部门
                    DeptManage DeptManage = new DeptManage();
                    dtl = DeptManage.GetDeptDataSelectBySQL2(strsql);
                    break;
                //case 3: //供应商
                //    SupplierManage SupplierManage = new SupplierManage();
                //    dtl = SupplierManage.GetSupplierDataBySelectBySQL(strsql);
                //    break;
                //case 4: //客户
                //    ClientManage ClientManage = new ClientManage();
                //    dtl = ClientManage.GetClientDataBySelectBySQL(strsql);
                //    break;
            }

            return dtl;

        }

    }
}
