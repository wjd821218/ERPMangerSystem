using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;
namespace ErpManageLibrary
{
    /// <summary>
    ///  ��Ʒʵ����
    /// </summary>
    public class Material
    {
        #region Model
        private string _materialguid;
        private string _materialid;
        private string _materialname;
        private string _classid;
        private string _unit;
        private string _spec;
        private int _safestocksum;
        private string _calculatemethod;
        private string _place;
        private int _isenable;
        private string _remark;
        private decimal _price;
        private string _picid;
        private string _clientid;
        private string _SupplierGuid;
        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// ���ϱ��
        /// </summary>
        public string MaterialID
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string ClassId
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// ������λ
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// ����ͺ�
        /// </summary>
        public string Spec
        {
            set { _spec = value; }
            get { return _spec; }
        }
        /// <summary>
        /// ��ȫ���
        /// </summary>
        public int SafeStockSum
        {
            set { _safestocksum = value; }
            get { return _safestocksum; }
        }
        /// <summary>
        /// �Ƽ۷���
        /// </summary>
        public string CalculateMethod
        {
            set { _calculatemethod = value; }
            get { return _calculatemethod; }
        }
        /// <summary>
        /// ��λ
        /// </summary>
        public string Place
        {
            set { _place = value; }
            get { return _place; }
        }
        /// <summary>
        /// �Ƿ�ͣ��(1��ͣ�� 0:����)
        /// </summary>
        public int IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// ͼ��
        /// </summary>
        public string PicID
        {
            set { _picid = value; }
            get { return _picid; }
        }
        /// <summary>
        /// �ͻ����
        /// </summary>
        public string ClientID
        {
            set { _clientid = value; }
            get { return _clientid; }
        }

        /// <summary>
        /// ��Ӧ��
        /// </summary>
        public string SupplierGuid
        {
            set { _SupplierGuid = value; }
            get { return _SupplierGuid; }
        }
        #endregion Model


		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add()
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Material](");
            strSql.Append("MaterialGuID,MaterialID,MaterialName,ClassId,Unit,Spec,SafeStockSum,CalculateMethod,Place,IsEnable,Remark,Price,PicID,ClientID,SupplierGuid");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + MaterialGuID + "',");
            strSql.Append("'" + MaterialID + "',");
            strSql.Append("'" + MaterialName + "',");
            strSql.Append("'" + ClassId + "',");
            strSql.Append("'" + Unit + "',");
            strSql.Append("'" + Spec + "',");
            strSql.Append("" + SafeStockSum + ",");
            strSql.Append("'" + CalculateMethod + "',");
            strSql.Append("'" + Place + "',");
            strSql.Append("" + IsEnable + ",");
            strSql.Append("'" + Remark + "',");
            strSql.Append("" + Price + ",");
            strSql.Append("'" + PicID + "',");
            strSql.Append("'" + ClientID + "',");
            strSql.Append("'" + SupplierGuid + "'");
            strSql.Append(")");
			CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }		
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update Material set ");
            strSql.Append("MaterialID='" + MaterialID + "',");
            strSql.Append("MaterialName='" + MaterialName + "',");
            strSql.Append("ClassId='" + ClassId + "',");
            strSql.Append("Unit='" + Unit + "',");
            strSql.Append("Spec='" + Spec + "',");
            strSql.Append("SafeStockSum=" + SafeStockSum + ",");
            strSql.Append("CalculateMethod='" + CalculateMethod + "',");
            strSql.Append("Place='" + Place + "',");
            strSql.Append("IsEnable=" + IsEnable + ",");
            strSql.Append("Remark='" + Remark + "',");
            strSql.Append("Price=" + Price + ",");
            strSql.Append("PicID='" + PicID + "',");
            strSql.Append("ClientID='" + ClientID + "',");
            strSql.Append("SupplierGuid='" + SupplierGuid + "'");
			strSql.Append(" where MaterialGuID='"+MaterialGuID +"' ");
			CommonInterface pComm = CommonFactory.CreateInstance(CommonData.sql);

            try
            {
                pComm.Execute(strSql.ToString());//ִ��Sql����޷���ֵ
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }		
		}
		#endregion  ��Ա����
	}
}

