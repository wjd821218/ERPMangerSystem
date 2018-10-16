using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;
namespace ErpManageLibrary
{
    /// <summary>
    /// �ļ�������
    /// </summary>
    public class FileClassManage
    {
        /// <summary>
        /// ���������ļ����
        /// </summary>
        /// <returns>�ļ����</returns>
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
        /// �����ļ��������
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
        /// �����������
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
        /// ɾ���������
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
        /// �õ����в�Ʒ������Ϣ
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
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
        /// �õ����в�Ʒ������Ϣ
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
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
        /// �õ����������
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
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
        /// ����-����,1--����  2-����
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public void SetOrderNo_Up(string InterID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //�õ���ǰ���ĸ����
                ps_Sql = "select  OrderNo,FatherID from FileClass where InterID='" + InterID + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
                string Old_OrderNo = pDTMain.Rows[0]["OrderNo"].ToString();
                string FatherID = pDTMain.Rows[0]["FatherID"].ToString();

                //�õ���ǰ��㸸����µ������ӽ��,Ҳ����ͬ�����
                ps_Sql = "select  InterID,OrderNo from FileClass where FatherID='" + FatherID + "' order by OrderNo";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                string OrderNo2 = "";
                string InterID2="";
                int k = 0;

                for (int i = 0; i < pDTMain.Rows.Count; i++)
                {
                    //�ҵ��˵�ǰ�Ľ��
                    if (pDTMain.Rows[i]["OrderNo"].ToString() == Old_OrderNo)
                    {
                        if (i != 0)
                        {

                            //���ҵ�����������OrderNo����
                            //����ǰ���������Ϊ��һ������OrderNo
                            ps_Sql = "Update  FileClass set OrderNo=" + OrderNo2 + " where InterID='" + InterID + "'";

                            pObj_Comm.Execute(ps_Sql);

                            //������һ������OrderNoΪ������
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
        /// ����-����,1--����  2-����
        /// </summary>
        /// <returns>pDTMain �ֶ���Ϣ��</returns>
        public void SetOrderNo_Down(string InterID)
        {
            string ps_Sql = "";
            DataTable pDTMain = new DataTable();
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.sql);
            try
            {
                //�õ���ǰ���ĸ����
                ps_Sql = "select  OrderNo,FatherID from FileClass where InterID='" + InterID + "'";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);
                string Old_OrderNo = pDTMain.Rows[0]["OrderNo"].ToString();
                string FatherID = pDTMain.Rows[0]["FatherID"].ToString();

                //�õ���ǰ��㸸����µ������ӽ��,Ҳ����ͬ�����
                ps_Sql = "select  InterID,OrderNo from FileClass where FatherID='" + FatherID + "' order by OrderNo";
                pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                string OrderNo2 = "";
                string InterID2 = "";
                int k = 0;

                for (int i =  pDTMain.Rows.Count-1; i >=0; i--)
                {
                    //�ҵ��˵�ǰ�Ľ��
                    if (pDTMain.Rows[i]["OrderNo"].ToString() == Old_OrderNo)
                    {
                        if (i != pDTMain.Rows.Count - 1)
                        {

                            //���ҵ�����������OrderNo����
                            //����ǰ���������Ϊ��һ������OrderNo
                            ps_Sql = "Update  FileClass set OrderNo=" + OrderNo2 + " where InterID='" + InterID + "'";

                            pObj_Comm.Execute(ps_Sql);

                            //������һ������OrderNoΪ������
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
