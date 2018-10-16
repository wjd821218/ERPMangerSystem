using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 设备管理
    /// </summary>
    public class EquipmentManage
    {

        ///<summary>
        /// 保存数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void SaveBill(Equipment Equipment, EquipmentDie EquipmentDie, EquipmentFrock EquipmentFrock, EquipmentGage EquipmentGage, EquipmentOffice EquipmentOffice, EquipmentInformation EquipmentInformation)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from Equipment where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                pComm.Execute(strDeleteSql);

                //插入Equipment数据
                string strInsertSql = GetEquipment_AddSQL(Equipment);
                pComm.Execute(strInsertSql);


                switch (Equipment.EquipmentType)
                {
                    case "1":
                        //删除EquipmentDie表
                        strDeleteSql = "Delete from EquipmentDie where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                        pComm.Execute(strDeleteSql);

                        //插入EquipmentDie数据
                        strInsertSql = GetEquipmentDie_AddSQL(EquipmentDie);
                        pComm.Execute(strInsertSql);
                        break;


               

                    case "2":
                        //删除EquipmentGage表
                        strDeleteSql = "Delete from EquipmentGage where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                        pComm.Execute(strDeleteSql);




                        //插入EquipmentGage数据
                        strInsertSql = GetEquipmentGage_AddSQL(EquipmentGage);
                        pComm.Execute(strInsertSql);

                        break;


                    case "3":
                        //删除EquipmentInformation表
                        strDeleteSql = "Delete from EquipmentInformation where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                        pComm.Execute(strDeleteSql);



                        //插入EquipmentInformation数据
                        strInsertSql = GetEquipmentInformation_AddSQL(EquipmentInformation);
                        pComm.Execute(strInsertSql);

                        break;

                    case "4":
                        //删除EquipmentOffice表
                        strDeleteSql = "Delete from EquipmentOffice where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                        pComm.Execute(strDeleteSql);




                        //插入EquipmentOffice数据
                        strInsertSql = GetEquipmentOffice_AddSQL(EquipmentOffice);
                        pComm.Execute(strInsertSql);

                        break;




                    case "5":
                        //删除EquipmentFrock表
                        strDeleteSql = "Delete from EquipmentFrock where  EquipmentGuid='" + Equipment.EquipmentGuID + "'";
                        pComm.Execute(strDeleteSql);



                        //插入EquipmentFrock数据
                        strInsertSql = GetEquipmentFrock_AddSQL(EquipmentFrock);
                        pComm.Execute(strInsertSql);

                        break;
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


      


        /// <summary>
        /// 得到新增Equipment
        /// </summary>
        public string GetEquipment_AddSQL(Equipment Equipment)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Equipment](");
            strSql.Append("EquipmentGuID,EquipmentID,EquipmentName,EquipmentType,UsePerson,EquipmentState,SavePlace,Remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + Equipment.EquipmentGuID + "',");
            strSql.Append("'" + Equipment.EquipmentID + "',");
            strSql.Append("'" + Equipment.EquipmentName + "',");
            strSql.Append("'" + Equipment.EquipmentType + "',");
            strSql.Append("'" + Equipment.UsePerson + "',");
            strSql.Append("'" + Equipment.EquipmentState + "',");
            strSql.Append("'" + Equipment.SavePlace + "',");
            strSql.Append("'" + Equipment.Remark + "'");
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到新增EquipmentFrock
        /// </summary>
        public string GetEquipmentFrock_AddSQL(EquipmentFrock EquipmentFrock)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [EquipmentFrock](");
            strSql.Append("EquipmentFrockGuID,EquipmentGuID,ProductClass,WorkEfficiency,EquipmentStuff,EquipmentFormal,FrockSource");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + EquipmentFrock.EquipmentFrockGuID + "',");
            strSql.Append("'" + EquipmentFrock.EquipmentGuID + "',");
            strSql.Append("'" + EquipmentFrock.ProductClass + "',");
            strSql.Append("'" + EquipmentFrock.WorkEfficiency + "',");
            strSql.Append("'" + EquipmentFrock.EquipmentStuff + "',");
            strSql.Append("'" + EquipmentFrock.EquipmentFormal + "',");
            strSql.Append("'" + EquipmentFrock.FrockSource + "'");
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到新增EquipmentGage
        /// </summary>
        public string GetEquipmentGage_AddSQL(EquipmentGage EquipmentGage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [EquipmentGage](");
            strSql.Append("GageGuID,EquipmentGuID,GageSpec,LeaveFactoryID,ScaleArea,ScalePrecision,ManageLevel,CheckType,CheckCycle,CheckUnit,AppraisalRecord");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + EquipmentGage.GageGuID + "',");
            strSql.Append("'" + EquipmentGage.EquipmentGuID + "',");
            strSql.Append("'" + EquipmentGage.GageSpec + "',");
            strSql.Append("'" + EquipmentGage.LeaveFactoryID + "',");
            strSql.Append("'" + EquipmentGage.ScaleArea + "',");
            strSql.Append("'" + EquipmentGage.ScalePrecision + "',");
            strSql.Append("'" + EquipmentGage.ManageLevel + "',");
            strSql.Append("'" + EquipmentGage.CheckType + "',");
            strSql.Append("'" + EquipmentGage.CheckCycle + "',");
            strSql.Append("'" + EquipmentGage.CheckUnit + "',");
            strSql.Append("'" + EquipmentGage.AppraisalRecord + "'");
            strSql.Append(")");
            return strSql.ToString();

        }


        /// <summary>
        /// 得到新增EquipmentGage
        /// </summary>
        public string GetEquipmentOffice_AddSQL(EquipmentOffice EquipmentOffice)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [EquipmentOffice](");
            strSql.Append("EquipmentOfficeGuID,EquipmentGuID,Brand,EquipmentOfficeSpec,DiskSize,CPU,Memory,DisplayCar");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + EquipmentOffice.EquipmentOfficeGuID + "',");
            strSql.Append("'" + EquipmentOffice.EquipmentGuID + "',");
            strSql.Append("'" + EquipmentOffice.Brand + "',");
            strSql.Append("'" + EquipmentOffice.EquipmentOfficeSpec + "',");
            strSql.Append("'" + EquipmentOffice.DiskSize + "',");
            strSql.Append("'" + EquipmentOffice.CPU + "',");
            strSql.Append("'" + EquipmentOffice.Memory + "',");
            strSql.Append("'" + EquipmentOffice.DisplayCar + "'");
            strSql.Append(")");
            return strSql.ToString();

        }

        /// <summary>
        /// 得到新增EquipmentInformation
        /// </summary>
        public string GetEquipmentInformation_AddSQL(EquipmentInformation EquipmentInformation)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [EquipmentInformation](");
            strSql.Append("EquipmentInformationGuID,EquipmentGuID,EquipmentInformationSpec,MadeManufacturer,MadeDate,UseDate,HistoryRecord");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + EquipmentInformation.EquipmentInformationGuID + "',");
            strSql.Append("'" + EquipmentInformation.EquipmentGuID + "',");
            strSql.Append("'" + EquipmentInformation.EquipmentInformationSpec + "',");
            strSql.Append("'" + EquipmentInformation.MadeManufacturer + "',");
            strSql.Append("'" + EquipmentInformation.MadeDate + "',");
            strSql.Append("'" + EquipmentInformation.UseDate + "',");
            strSql.Append("'" + EquipmentInformation.HistoryRecord + "'");
            strSql.Append(")");
            return strSql.ToString();

        }

        /// <summary>
        /// 得到新增EquipmentDie
        /// </summary>
        public string GetEquipmentDie_AddSQL(EquipmentDie EquipmentDie)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [EquipmentDie](");
            strSql.Append("DieGuID,EquipmentGuID,DieType,ProductType,Life,Energy,PartName,PartID,ExteriorSize,Datum,DieSource,Aperture");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + EquipmentDie.DieGuID + "',");
            strSql.Append("'" + EquipmentDie.EquipmentGuID + "',");
            strSql.Append("'" + EquipmentDie.DieType + "',");
            strSql.Append("'" + EquipmentDie.ProductType + "',");
            strSql.Append("'" + EquipmentDie.Life + "',");
            strSql.Append("'" + EquipmentDie.Energy + "',");
            strSql.Append("'" + EquipmentDie.PartName + "',");
            strSql.Append("'" + EquipmentDie.PartID + "',");
            strSql.Append("'" + EquipmentDie.ExteriorSize + "',");
            strSql.Append("'" + EquipmentDie.Datum + "',");
            strSql.Append("'" + EquipmentDie.DieSource + "',");
            strSql.Append("'" + EquipmentDie.Aperture + "'");
            strSql.Append(")");
            return strSql.ToString();

        }
    
        ///<summary>
        ///删除数据
        /// </summary>
        /// <param name="pObj">信息集实体类</param>
        /// <returns>返回保存成功(true)或失败(false)</returns>
        public void DeleteBill(string Equipmentguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();

                //保存单据主表数据
                //先删除主表数据
                string strDeleteSql = "Delete from Equipment where  EquipmentGuid='" + Equipmentguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from EquipmentDie where  EquipmentGuid='" + Equipmentguid + "'";
                pComm.Execute(strDeleteSql);

                //删除明细表
                strDeleteSql = "Delete from EquipmentFrock where  EquipmentGuid='" + Equipmentguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from EquipmentGage where  EquipmentGuid='" + Equipmentguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from EquipmentInformation where  EquipmentGuid='" + Equipmentguid + "'";
                pComm.Execute(strDeleteSql);


                //删除明细表
                strDeleteSql = "Delete from EquipmentOffice where  EquipmentGuid='" + Equipmentguid + "'";
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

        //得到设备数据
        public DataTable GetEquipmentData(string strsql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select  *,case  EquipmentState when '1' then  '正常' when '0' then '停用' end as EquipmentStateName,case EquipmentType when 1 then  '模具' when 2 then '计量器具' when 3 then '生产设备' when 4 then '办公设备' when 5 then '工装' end as  EquipmentTypeName  from Equipment " + strsql;
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



        //得到设备数据
        public DataTable GetEquipmentDataByEquipmentGuID(string EquipmentGuID)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select  *,case  EquipmentState when '1' then  '正常' when '0' then '停用' end as EquipmentStateName,case EquipmentType when 1 then  '模具' when 2 then '计量器具' when 3 then '生产设备' when 4 then '办公设备' when 5 then '工装' end as  EquipmentTypeName  from Equipment where EquipmentGuID='" + EquipmentGuID + "'";
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

        //得到设备明细数据，包括五类明细:
        public DataTable GetEquipmentDetailData(string EquipmentGuID, string EquipmentType)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                
                string ps_Sql = "" ;
                switch (EquipmentType)
                {
                    case "1":// '模具信息'
                        ps_Sql = " select *  from EquipmentDie where EquipmentGuID='" + EquipmentGuID + "'";

                        break;
                    case "2":// '计量器信息'
                        ps_Sql = " select *  from EquipmentGage where EquipmentGuID='" + EquipmentGuID + "'";

                        break;
                    case "3":// '设备信息'
                        ps_Sql = " select *  from EquipmentInformation where EquipmentGuID='" + EquipmentGuID + "'";

                        break;
                    case "4":// '办公设备'

                        ps_Sql = " select *  from EquipmentOffice where EquipmentGuID='" + EquipmentGuID + "'";
                        break;
                    case "5"://'工装设备' 
                        ps_Sql = " select *  from EquipmentFrock where EquipmentGuID='" + EquipmentGuID + "'";


                        break;
                
                }
                
                
                
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
        /// <param name="EquipmentType"></param>
        /// <returns></returns>
        public DataTable GetEquipmentDataByEquipmentType(string EquipmentType)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                string ps_Sql = "";
                switch (EquipmentType)
                {
                    case "1":// '模具信息'
                        ps_Sql = " select  *,case EquipmentState when '1' then '正常' when '0' then '停用' end as  EquipmentStateName from V_EquipmentDie   order by EquipmentID";

                        break;
                    case "2":// '计量器信息'
                        ps_Sql = " select *,case EquipmentState when '1' then '正常' when '0' then '停用' end as  EquipmentStateName  from V_EquipmentGage order by EquipmentID";

                        break;
                    case "3":// '设备信息'
                        ps_Sql = " select *,case EquipmentState when '1' then '正常' when '0' then '停用' end as  EquipmentStateName  from V_EquipmentInformation  order by EquipmentID";


                        break;
                    case "4":// '办公设备'

                        ps_Sql = " select *,case EquipmentState when '1' then '正常' when '0' then '停用' end as  EquipmentStateName  from V_EquipmentOffice  order by EquipmentID";

                        break;
                    case "5"://'工装设备' 
                        ps_Sql = " select *,case EquipmentState when '1' then '正常' when '0' then '停用' end as  EquipmentStateName  from V_EquipmentFrock  order by EquipmentID";



                        break;

                }



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
        /// 是否已经存在相同的设备编号
        /// </summary>
        /// <returns></returns>
        public bool IsExistEquipementID(string EquipmentGuid, string EquipmentID)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            string strSql = "";

            strSql = " select EquipmentID  from Equipment where EquipmentGuid<>'" + EquipmentGuid + "' and EquipmentID='" + EquipmentID + "'";

            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(strSql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;  //Exist


                }
                else
                {
                    return false; //Not Exist
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
