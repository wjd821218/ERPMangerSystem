using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���Ԥ��
    /// </summary>
    public class StockYJManage
    {
        ///<summary>
        ///ɾ������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public void InsertData(List<StockYJ> lstStockYJ)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                pComm.BeginTrans();


                //��ɾ��
                for (int i = 0; i < lstStockYJ.Count; i++)
                {
                    string strDeleteSql = "Delete from StockYJ where  MaterialGuid='" + lstStockYJ[i].MaterialGuid + "'";
                    pComm.Execute(strDeleteSql);
                }

                //�����
                for (int i = 0; i < lstStockYJ.Count; i++)
                {
                    pComm.Execute(GetInsertSQL(lstStockYJ[i]));
                
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
        /// ����һ������
        /// </summary>
        public string  GetInsertSQL(StockYJ stockyj)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockYJ(");
            strSql.Append("StockYJGuid,MaterialGuid,StockYJDown,StockYJUp,BOMSum");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + stockyj.StockYJGuid + "',");
            strSql.Append("'" + stockyj.MaterialGuid + "',");
            strSql.Append("" + stockyj.StockYJDown + ",");
            strSql.Append("" + stockyj.StockYJUp + ",");
            strSql.Append("" + stockyj.BomSum + "");
            strSql.Append(")");

            return strSql.ToString();

        }


        /// <summary>
        /// �õ�����
        /// </summary>
        /// <returns></returns>
        public DataTable GetStockYJData(string strWheresql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "select   MaterialGuID,MaterialID,MaterialName,UnitID,UnitName,Spec,SpecName,StockYJGuid,isnull(StockYJDown,0) as StockYJDown,isnull(StockYJUp,0) as StockYJUp,isnull(BomSum,0) as BomSum  from V_StockYJ  " + strWheresql + "  Order by MaterialID    ";
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



        //���ô洢���̣��õ�ĳ������BOM�Ӽ�����Table��ʽ����
        public DataTable sp_GetMaterialBomData_BomQry2(String MaterialID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialFatherGuid";
                par[0, 1] = MaterialID;

                dset = pComm.ExcuteSp("sp_GetMaterialBomData_BomQry2", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }



        //���ô洢���̣��õ�ĳ������BOM�Ӽ�����Table��ʽ����
        public DataTable sp_GetOneStorageSumDataByYJ(String MaterialID, string StorageID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@StorageID";
                par[0, 1] = StorageID;
                par[1, 0] = "@MaterialFatherGuid";
                par[1, 1] = MaterialID;


                dset = pComm.ExcuteSp("sp_GetOneStorageSumDataByYJ", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }



        //���ô洢���̣��õ�ĳ������BOM�Ӽ�����Table��ʽ����
        public DataTable sp_GetOneStorageSumDataByYJ2(string StorageID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@StorageID";
                par[0, 1] = StorageID;
              

                dset = pComm.ExcuteSp("sp_GetOneStorageSumDataByYJ2", par);

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
