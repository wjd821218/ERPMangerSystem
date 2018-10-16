using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 付款单从退料单中选择所用传输数据的实体
    /// </summary>
    public class SelectQuitOrderDetail
    {
        #region Model
        private string _Quitorderguid;
        private string _Quitorderid;
        private string _Quitorderdetailguid;
        private DateTime? _Quitorderdate;
        private string _materialguid;
        private string _materialid;
        private decimal _materialprice;
        private decimal _materialmoney;
        private string _materialname;
        private decimal _materialsum;
        private string _suppliername;
        /// <summary>
        /// 
        /// </summary>
        public string QuitOrderGuid
        {
            set { _Quitorderguid = value; }
            get { return _Quitorderguid; }
        }

        public string SupplierName
        {
            set { _suppliername = value; }
            get { return _suppliername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QuitOrderID
        {
            set { _Quitorderid = value; }
            get { return _Quitorderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QuitOrderDetailGuid
        {
            set { _Quitorderdetailguid = value; }
            get { return _Quitorderdetailguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? QuitOrderDate
        {
            set { _Quitorderdate = value; }
            get { return _Quitorderdate; }
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
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
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
