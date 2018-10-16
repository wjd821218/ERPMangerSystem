using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��Ʒ���������
    /// </summary>
    public class MaterialManage
    {

        ///<summary>
        /// ��������
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ����</param>
        /// <returns>���ر���ɹ�(true)��ʧ��(false)</returns>
        public bool Save(Material pObj)
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
        public bool SaveStatus(Material pObj)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT MaterialGuid   FROM   Material  " +
                    "where MaterialGuid  ='" + pObj.MaterialGuID + "'";
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
        /// �õ����в�Ʒ������Ϣ
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public DataTable GetMaterialData_CN(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                       +" (select InterName from StorageClass where    InterId=ClassId) as ����,"
                       + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                       + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,"
                       + " Price as ����, "
                       + "case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬,PicID as ͼ��,ClientID as �ͻ����,"
                       + " (select Name from Supplier where Guid=SupplierGuid) as ��Ӧ��, "
                       +" Remark as ��ע  from Material " + strsql + "  order by MaterialId";

                //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId)  as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                //          + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material " + strsql + "  order by MaterialId";
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
        /// �õ����в�Ʒ������Ϣ--���ϼ�ѡ����
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public DataTable GetSelectMaterialData_CN(string strsql)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                      + " (select InterName from StorageClass where    InterId=ClassId)  as ����,"
                      + " (select UnitName from BasicData where UnitID=Spec ) as ���,Price as ����,PicID as ͼ��,ClientID as �ͻ����,"
                      + " case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬    from Material " + strsql + "  order by MaterialId";
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
        /// �õ����в�Ʒ������Ϣ
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public DataTable GetMaterialDataByClassID(string classid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                if (classid != "")
                {
                    //ps_Sql = " select MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                    //+ " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                    //+ " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                    //+ " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,"
                    //+ "  SafeStockSum as  ��ȫ���,"
                    //+ " (select UnitName from BasicData where UnitID=CalculateMethod )  as �ɱ����㷨, "
                    //+ " Place as ��λ,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬,Remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";

                    //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                    //       + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                      + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                      + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                      + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,  Price as ����,PicID as ͼ��,ClientID as �ͻ����,"
                      + " (select Name from Supplier where Guid=SupplierGuid) as ��Ӧ��, "
                      + " case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬  from Material where  ClassId='" + classid + "' order by sortid";


                }
                else
                {
                   //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                   //           + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material   order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                     + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                     + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                     + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,Price as ����,PicID as ͼ��,ClientID as �ͻ����, "
                      + " (select Name from Supplier where Guid=SupplierGuid) as ��Ӧ��, "
                     + " case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬   from Material   order by sortid";



                }
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
        /// �õ����в�Ʒ������Ϣ---����ʾͣ�õ�
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public DataTable GetMaterialDataByClassID_Select(string classid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                if (classid != "")
                {
                    //ps_Sql = " select MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                    //+ " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                    //+ " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                    //+ " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,"
                    //+ "  SafeStockSum as  ��ȫ���,"
                    //+ " (select UnitName from BasicData where UnitID=CalculateMethod )  as �ɱ����㷨, "
                    //+ " Place as ��λ,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬,Remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";

                    //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                    //       + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                      + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                      + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                      + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,  Price as ����,PicID as ͼ��,ClientID as �ͻ���� ,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬  "
                      + "   from Material where  IsEnable=0 and ClassId='" + classid + "' order by sortid";


                }
                else
                {
                    //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                    //           + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material   order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                     + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                     + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                     + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,Price as ����,PicID as ͼ��,ClientID as �ͻ����,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬  "
                     + "  from Material where  IsEnable=0   order by sortid";



                }
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
        /// �õ����в�Ʒ������Ϣ,��ʾ�������ϰ���ͣ�õ�-----��frmSelectMaterialר��
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public DataTable GetMaterialDataByClassID_Select2(string classid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                if (classid != "")
                {
                    //ps_Sql = " select MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                    //+ " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                    //+ " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                    //+ " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,"
                    //+ "  SafeStockSum as  ��ȫ���,"
                    //+ " (select UnitName from BasicData where UnitID=CalculateMethod )  as �ɱ����㷨, "
                    //+ " Place as ��λ,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬,Remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";

                    //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                    //       + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material where  ClassId='" + classid + "' order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                      + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                      + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                      + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,  Price as ����,PicID as ͼ��,ClientID as �ͻ����,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬  "
                      + "   from Material where   ClassId='" + classid + "' order by sortid";


                }
                else
                {
                    //ps_Sql = "select  MaterialGuid,(select InterName from StorageClass where    InterId=ClassId) as ��Ʒ����,MaterialId as ����,MaterialName as Ʒ��,Spec as ���,BarNo as  ������,"
                    //           + "Unit as ��λ,CalculateMethod as �ɱ����㷨,remark as ��ע  from Material   order by MaterialId";
                    ps_Sql = " select 'False' as selectvalue,MaterialGuid ,MaterialId as ���ϱ��,MaterialName ��������, "
                     + " (select InterName from StorageClass where    InterId=ClassId)  ����,"
                     + " (select UnitName from BasicData where UnitID=Unit ) as ��λ,"
                     + " (select UnitName from BasicData where UnitID=Spec ) as ����ͺ�,Price as ����,PicID as ͼ��,ClientID as �ͻ����,case when IsEnable=1 then 'ͣ��' else  '����' end  as ״̬  "
                     + "  from Material    order by sortid";



                }
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


        public Material GetMaterialByGuid(string MaterialGuid)
		{
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  ");
            strSql.Append("MaterialGuid,MaterialId,MaterialName,ClassId,Unit,Spec,SafeStockSum,CalculateMethod,Place,Price,IsEnable,PicID,ClientID,SupplierGuid,Remark ");
            strSql.Append(" from Material ");
            strSql.Append("where MaterialGuid='" + MaterialGuid + "'"); 
            try
            {
                Material Material = new Material();
                DataTable dt = pObj_Comm.ExeForDtl(strSql.ToString());
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {

                    Material.MaterialGuID = dt.Rows[0]["MaterialGuID"].ToString();
                    Material.MaterialID = dt.Rows[0]["MaterialID"].ToString();
                    Material.MaterialName = dt.Rows[0]["MaterialName"].ToString();
                    Material.ClassId = dt.Rows[0]["ClassId"].ToString();
                    Material.Unit = dt.Rows[0]["Unit"].ToString();
                    Material.Spec = dt.Rows[0]["Spec"].ToString();
                    if (dt.Rows[0]["SafeStockSum"].ToString() != "")
                    {
                        Material.SafeStockSum = int.Parse(dt.Rows[0]["SafeStockSum"].ToString());
                    }
                    Material.CalculateMethod = dt.Rows[0]["CalculateMethod"].ToString();
                    Material.Place = dt.Rows[0]["Place"].ToString();
                    if (dt.Rows[0]["IsEnable"].ToString() != "")
                    {
                        Material.IsEnable = int.Parse(dt.Rows[0]["IsEnable"].ToString());
                    }
                    if (dt.Rows[0]["Price"].ToString() != "")
                    {
                        Material.Price = decimal.Parse(dt.Rows[0]["Price"].ToString());
                    }
                    Material.Remark = dt.Rows[0]["Remark"].ToString();
                    Material.PicID = dt.Rows[0]["PicID"].ToString();
                    Material.ClientID = dt.Rows[0]["ClientID"].ToString();
                    Material.SupplierGuid = dt.Rows[0]["SupplierGuid"].ToString();
                }

                return Material;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
		}



        public Material GetMaterialByID(string MaterialID)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 ");
            strSql.Append("MaterialGuid,MaterialId,MaterialName,ClassId,Unit,Spec,SafeStockSum,CalculateMethod,Place,Price,IsEnable,PicID,ClientID,SupplierGuid,Remark ");
            strSql.Append(" from Material ");
            strSql.Append("where MaterialID='" + MaterialID + "'");
            try
            {
                Material Material = new Material();
                DataTable dt = pObj_Comm.ExeForDtl(strSql.ToString());
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {

                    Material.MaterialGuID = dt.Rows[0]["MaterialGuID"].ToString();
                    Material.MaterialID = dt.Rows[0]["MaterialID"].ToString();
                    Material.MaterialName = dt.Rows[0]["MaterialName"].ToString();
                    Material.ClassId = dt.Rows[0]["ClassId"].ToString();
                    Material.Unit = dt.Rows[0]["Unit"].ToString();
                    Material.Spec = dt.Rows[0]["Spec"].ToString();
                    if (dt.Rows[0]["SafeStockSum"].ToString() != "")
                    {
                        Material.SafeStockSum = int.Parse(dt.Rows[0]["SafeStockSum"].ToString());
                    }
                    Material.CalculateMethod = dt.Rows[0]["CalculateMethod"].ToString();
                    Material.Place = dt.Rows[0]["Place"].ToString();
                    if (dt.Rows[0]["IsEnable"].ToString() != "")
                    {
                        Material.IsEnable = int.Parse(dt.Rows[0]["IsEnable"].ToString());
                    }
                    if (dt.Rows[0]["Price"].ToString() != "")
                    {
                        Material.Price = decimal.Parse(dt.Rows[0]["Price"].ToString());
                    }
                    Material.Remark = dt.Rows[0]["Remark"].ToString();
                    Material.PicID = dt.Rows[0]["PicID"].ToString();
                    Material.ClientID = dt.Rows[0]["ClientID"].ToString();
                    Material.SupplierGuid = dt.Rows[0]["SupplierGuid"].ToString();
                }

                return Material;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }




        public DataTable  GetMaterial(string MaterialGuid)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select MaterialGuid ,MaterialId,MaterialName, ClassId,"
                    + " (select InterName from StorageClass where    InterId=ClassId)  as ClassInterName,Unit,"
                    + " (select UnitName from BasicData where UnitID=Unit ) as UnitInterName,Spec,"
                    + " (select UnitName from BasicData where UnitID=Spec ) as SpecInterName,"
                    + "  SafeStockSum ,CalculateMethod,Price,PicID,ClientID,SupplierGuid,"
                    + " (select Name from Supplier where Guid=SupplierGuid) as SupplierName, "
                    + " (select UnitName from BasicData where UnitID=CalculateMethod )  as CalculateMethodInterName, "
                    + " Place ,IsEnable,Remark ");

            //strSql.Append("[MaterialGuid],[MaterialId],[MaterialName],[ClassId],[Unit],[Spec],[SafeStockSum],[CalculateMethod],[Place],[IsEnable],[Remark]  ");
            strSql.Append(" from Material ");
            strSql.Append(" where MaterialGuid='" + MaterialGuid + "'");
            try
            {
                Material Material = new Material();
                DataTable dt = pObj_Comm.ExeForDtl(strSql.ToString());
                pObj_Comm.Close();
                return dt;
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
        public void DeleteMaterial(string MaterialGuid)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "delete  from Material  where  MaterialGuid='" + MaterialGuid + "'";
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
        /// �޸����ϱ��
        /// </summary>
        /// <returns></returns>
        public void ChangeMaterialID(string OldMaterialID,string NewMaterialID)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string ps_Sql = "update  Material set MaterialID='" + NewMaterialID + "' where  MaterialID='" + OldMaterialID + "'";
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
        /// �Ƿ��Ѿ�������ͬ�Ļ�Ʒ
        /// </summary>
        /// <returns></returns>
        public bool IsExistMaterial(string MaterialGuid,string MaterialID, string MaterialName,bool IsEdit)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            string strSql = "";
            if (IsEdit == false)
            {
                //ADD
                strSql = " select MaterialGuid  from Material where MaterialID='" + MaterialID + "'";

            }
            else
            { 
               //Edit
                strSql = " select MaterialGuid  from Material where MaterialID='" + MaterialID + "'";
              
            }
                  
            try
            {
                DataTable dt = pObj_Comm.ExeForDtl(strSql);
                pObj_Comm.Close();
                if (dt.Rows.Count > 0)
                {
                    if (IsEdit == false)
                    {
                        return true;  //Exist
                    }
                    else
                    {
                        string strMaterialGuid = dt.Rows[0]["MaterialGuid"].ToString();
                        if (strMaterialGuid.Trim() != MaterialGuid.Trim())
                        {
                            return true;  //Exist
                        }
                        else
                        {
                            return false; //Not Exist
                        
                        }

                    }
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




        //���ô洢���̵õ����ֿ⵱ǰ������������
        public DataTable sp_GetStorageSumData(String Materialguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialGuid";
                par[0, 1] = Materialguid;

                dset = pComm.ExcuteSp("sp_GetStorageSumData", par);

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
        public DataTable sp_GetBomDataByMaterialGuid(String Materialguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[1, 2];
                par[0, 0] = "@MaterialFatherGuid";
                par[0, 1] = Materialguid;

                dset = pComm.ExcuteSp("sp_GetMaterialBomData_BomQry", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }

        //------------------------------------------------------------------------

        //���ô洢���̣��õ�ĳ�����ϵ���ָ���ֿ��е�����
        public DataTable sp_GetOneStorageSumData(string StorageID, string Materialguid)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                DataSet dset = new DataSet();
                string[,] par;
                par = new string[2, 2];
                par[0, 0] = "@StorageID";
                par[0, 1] = StorageID;
                par[1, 0] = "@MaterialGuid";
                par[1, 1] = Materialguid;

                dset = pComm.ExcuteSp("sp_GetOneStorageSumData", par);

                pComm.Close();
                return dset.Tables[0];
            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }


        ///<summary>
        /// �Ƿ�ִ�г�������Ԥ��
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ��</param>
        /// <returns>����True��False</returns>
        public bool OverNumStorage(string StorageID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT  OverNumStorage   FROM   YJ  ";
                DataTable pDT = pComm.ExeForDtl(pSql);
                pComm.Close();
                if (pDT.Rows.Count > 0)
                {
                    //�жϵ�ǰ����ֿ��Ƿ�����Ԥ��,OverNumStorageֵΪ 25:26:27:37:38:69:343,�м�����־��ǲֿ�ı��
                    if (pDT.Rows[0]["OverNumStorage"].ToString().IndexOf(StorageID) >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                pComm.Close();
                return true;

            }
        }



        ///<summary>
        /// �ж��Ƿ����˵���ɾ��ʱ���б�ĵ���ʹ�ô˵��ݵ�����
        /// </summary>
        /// <param name="pObj">��Ϣ��ʵ��</param>
        /// <returns>����True��False</returns>
        public bool OrderDeleteAlert()
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                string pSql = "";
                pSql = "SELECT  OrderDeleteAlert   FROM   YJ  ";
                DataTable pDT = pComm.ExeForDtl(pSql);
                pComm.Close();
                if (pDT.Rows.Count > 0)
                {
                    //�ж��Ƿ����˵���ɾ��ʱ���б�ĵ���ʹ�ô˵��ݵ�����
                    if (pDT.Rows[0]["OrderDeleteAlert"].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                pComm.Close();
                return true;

            }
        }

    }
}
