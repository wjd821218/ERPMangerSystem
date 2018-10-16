using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购入库单
    /// </summary>
    public class StockInOrder
    {
        public StockInOrder()
        { }
        #region Model
        private string _stockinorderguid;
        private string _stockinorderid;
        private DateTime _stockinorderdate;
        private string _supplierguid;
        private string _instorage;
        private string _stockperson;
        private string _storageperson;
        private string _batchno;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string StockInOrderGuid
        {
            set { _stockinorderguid = value; }
            get { return _stockinorderguid; }
        }
        /// <summary>
        /// 采购入库单号
        /// </summary>
        public string StockInOrderID
        {
            set { _stockinorderid = value; }
            get { return _stockinorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime StockInOrderDate
        {
            set { _stockinorderdate = value; }
            get { return _stockinorderdate; }
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public string SupplierGuid
        {
            set { _supplierguid = value; }
            get { return _supplierguid; }
        }
        /// <summary>
        /// 收货仓库
        /// </summary>
        public string InStorage
        {
            set { _instorage = value; }
            get { return _instorage; }
        }
        /// <summary>
        /// 采购员
        /// </summary>
        public string StockPerson
        {
            set { _stockperson = value; }
            get { return _stockperson; }
        }
        /// <summary>
        /// 仓管员
        /// </summary>
        public string StoragePerson
        {
            set { _storageperson = value; }
            get { return _storageperson; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNO
        {
            set { _batchno = value; }
            get { return _batchno; }
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
        /// 制单人
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model
    }
}
