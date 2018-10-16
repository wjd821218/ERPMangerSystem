using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;
namespace ErpManageLibrary
{
    /// <summary>
    /// 文件类别管理
    /// </summary>
    public class FileClassManage
    {
        /// <summary>
        /// 查找所有文件类别
        /// </summary>
        /// <returns>文件类别</returns>
        public string GetMaxNodeData(string fatherid)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "SELECT Max(convert(int,InterID)) as InterID FROM FileClass where FatherID ='" + fatherid + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
                pObj_Comm.Close();

                if (pDTMain.Rows[0]["InterID"].ToString() == "")
                {
                    return fatherid + "0001";
                }
                else
                {
                    return pDTMain.Rows[0]["InterID"].ToString();
                }
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 插入文件类别数据
        /// </summary>
        public void InsertTypeNode(string strInterID, string InterName, string strFatherID)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {


                string StrSQL = "";
                StrSQL = "insert into  FileClass(InterID,InterName,FatherID,OrderNo) values('" + strInterID + "','" + InterName + "','" + strFatherID + "'," + GetMaxOrderNo().ToString()+ ")";

                pComm.Execute(StrSQL);

                pComm.Close();


            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }



        /// <summary>
        /// 更新类别数据
        /// </summary>
        public void UpdateTypeNode(string InterID, string InterName)
        {
            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {


                string StrSQL = "";
                StrSQL = "Update  FileClass  set  InterName='" + InterName + "'  where InterID='" + InterID + "'";

                pComm.Execute(StrSQL);

                pComm.Close();


            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }

        ///<summary>
        /// 删除类别数据
        /// </summary>
        public void DeleteNodeData(string interid)
        {

            CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {

                string StrSQL = " delete from FileClass where InterID ='" + interid + "'";

                pComm.Execute(StrSQL);
                pComm.Close();


            }
            catch (Exception e)
            {
                pComm.Close();
                throw e;

            }
        }

        /// <summary>
        /// 得到所有产品类另信息
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileClassData()
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select * from FileClass ";
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
        /// 得到所有产品类另信息
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public DataTable GetFileClassDatabyBom()
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select * from FileClass where  InterID='0000'";
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
        /// 得到最大的排序号
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public int GetMaxOrderNo()
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                ps_Sql = "select Max(OrderNo)+1 as OrderNo from FileClass  ";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);


                pObj_Comm.Close();

                return int.Parse(pDTMain.Rows[0]["OrderNo"].ToString());
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



        /// <summary>
        /// 排序-向上,1--上移  2-下移
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public void SetOrderNo_Up(string InterID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //得到当前结点的父结点
                ps_Sql = "select  OrderNo,FatherID from FileClass where InterID='" + InterID + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
                string Old_OrderNo = pDTMain.Rows[0]["OrderNo"].ToString();
                string FatherID = pDTMain.Rows[0]["FatherID"].ToString();

                //得到当前结点父结点下的所有子结点,也就是同级结点
                ps_Sql = "select  InterID,OrderNo from FileClass where FatherID='" + FatherID + "' order by OrderNo";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                string OrderNo2 = "";
                string InterID2="";
                int k = 0;

                for (int i = 0; i < pDTMain.Rows.Count; i++)
                {
                    //找到了当前的结点
                    if (pDTMain.Rows[i]["OrderNo"].ToString() == Old_OrderNo)
                    {
                        if (i != 0)
                        {

                            //将找到的两个类别的OrderNo互换
                            //将当前这个结点更新为上一个结点的OrderNo
                            ps_Sql = "Update  FileClass set OrderNo=" + OrderNo2 + " where InterID='" + InterID + "'";

                            pObj_Comm.Execute(ps_Sql);

                            //更新上一个结点的OrderNo为本结点的
                            ps_Sql = "Update  FileClass set OrderNo=" + Old_OrderNo + " where InterID='" + InterID2 + "'";

                            pObj_Comm.Execute(ps_Sql);

                            break;
                        }

                    }

                    k = i;
                    OrderNo2 = pDTMain.Rows[k]["OrderNo"].ToString();
                    InterID2= pDTMain.Rows[k]["InterID"].ToString();
                }



                pObj_Comm.Close();


            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }



        /// <summary>
        /// 排序-向上,1--上移  2-下移
        /// </summary>
        /// <returns>pDTMain 字段信息集</returns>
        public void SetOrderNo_Down(string InterID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //得到当前结点的父结点
                ps_Sql = "select  OrderNo,FatherID from FileClass where InterID='" + InterID + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
                string Old_OrderNo = pDTMain.Rows[0]["OrderNo"].ToString();
                string FatherID = pDTMain.Rows[0]["FatherID"].ToString();

                //得到当前结点父结点下的所有子结点,也就是同级结点
                ps_Sql = "select  InterID,OrderNo from FileClass where FatherID='" + FatherID + "' order by OrderNo";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                string OrderNo2 = "";
                string InterID2 = "";
                int k = 0;

                for (int i =  pDTMain.Rows.Count-1; i >=0; i--)
                {
                    //找到了当前的结点
                    if (pDTMain.Rows[i]["OrderNo"].ToString() == Old_OrderNo)
                    {
                        if (i != pDTMain.Rows.Count - 1)
                        {

                            //将找到的两个类别的OrderNo互换
                            //将当前这个结点更新为上一个结点的OrderNo
                            ps_Sql = "Update  FileClass set OrderNo=" + OrderNo2 + " where InterID='" + InterID + "'";

                            pObj_Comm.Execute(ps_Sql);

                            //更新上一个结点的OrderNo为本结点的
                            ps_Sql = "Update  FileClass set OrderNo=" + Old_OrderNo + " where InterID='" + InterID2 + "'";

                            pObj_Comm.Execute(ps_Sql);

                            break;
                        }

                    }

                    k = i;
                    OrderNo2 = pDTMain.Rows[k]["OrderNo"].ToString();
                    InterID2 = pDTMain.Rows[k]["InterID"].ToString();
                }



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
