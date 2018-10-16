using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;
namespace ErpManageLibrary
{
    /// <summary>
    ///  货品实体类
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
        /// 物料编号
        /// </summary>
        public string MaterialID
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 货物类别
        /// </summary>
        public string ClassId
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec
        {
            set { _spec = value; }
            get { return _spec; }
        }
        /// <summary>
        /// 安全库存
        /// </summary>
        public int SafeStockSum
        {
            set { _safestocksum = value; }
            get { return _safestocksum; }
        }
        /// <summary>
        /// 计价方法
        /// </summary>
        public string CalculateMethod
        {
            set { _calculatemethod = value; }
            get { return _calculatemethod; }
        }
        /// <summary>
        /// 货位
        /// </summary>
        public string Place
        {
            set { _place = value; }
            get { return _place; }
        }
        /// <summary>
        /// 是否停用(1：停用 0:可用)
        /// </summary>
        public int IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 图号
        /// </summary>
        public string PicID
        {
            set { _picid = value; }
            get { return _picid; }
        }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string ClientID
        {
            set { _clientid = value; }
            get { return _clientid; }
        }

        /// <summary>
        /// 供应商
        /// </summary>
        public string SupplierGuid
        {
            set { _SupplierGuid = value; }
            get { return _SupplierGuid; }
        }
        #endregion Model


		#region  成员方法

		/// <summary>
		/// 增加一条数据
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
                pComm.Execute(strSql.ToString());//执行Sql语句无返回值
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
		/// 更新一条数据
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
                pComm.Execute(strSql.ToString());//执行Sql语句无返回值
                pComm.Close();
                return true;
            }
            catch (System.Exception e)
            {
                pComm.Close();
                throw e;
            }		
		}
		#endregion  成员方法
	}
}

