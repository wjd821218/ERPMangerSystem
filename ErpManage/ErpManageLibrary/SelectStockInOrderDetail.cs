using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ����Ӳɹ���ⵥ��ѡ�����ô������ݵ�ʵ��
    /// </summary>
    public class SelectStockInOrderDetail
    {
        #region Model
        private string _stockinorderguid;
        private string _stockinorderid;
        private string _stockinorderdetailguid;
        private DateTime? _stockinorderdate;
        private string _materialguid;
        private string _materialid;
        private decimal _materialprice;
        private decimal _materialmoney;
        private string _materialname;
        private decimal _storagesum;
        private string _suppliername;
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderGuid
        {
            set { _stockinorderguid = value; }
            get { return _stockinorderguid; }
        }

        public string SupplierName
        {
            set { _suppliername = value; }
            get { return _suppliername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderID
        {
            set { _stockinorderid = value; }
            get { return _stockinorderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderDetailGuid
        {
            set { _stockinorderdetailguid = value; }
            get { return _stockinorderdetailguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StockInOrderDate
        {
            set { _stockinorderdate = value; }
            get { return _stockinorderdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialGuID
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialID
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
     
        /// <summary>
        /// 
        /// </summary>
        public decimal StorageSum
        {
            set { _storagesum = value; }
            get { return _storagesum; }
        }


        public decimal MaterialPrice
        {
            set { _materialprice = value; }
            get { return _materialprice; }
        }

        public decimal MaterialMoney
        {
            set { _materialmoney = value; }
            get { return _materialmoney; }
        }
        #endregion Model

    }
}
