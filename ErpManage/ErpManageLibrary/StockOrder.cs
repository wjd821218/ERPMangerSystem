using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 采购订单实体
    /// </summary>
    public class StockOrder
    {
        public StockOrder()
        { }
        #region Model
        private string _stockorderguid;
        private string _stockorderid;
        private string _supplierguid;
        private DateTime _stockorderdate;
        private string _linkman;
        private string _telephone;
        private string _fax;
        private string _malinkman;
        private string _matelephone;
        private string _mafax;
      
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _endguid;
        private DateTime _enddate;
        /// <summary>
        /// 采购订单Guid
        /// </summary>
        public string StockOrderGuid
        {
            set { _stockorderguid = value; }
            get { return _stockorderguid; }
        }
        /// <summary>
        /// 采购订单号
        /// </summary>
        public string StockOrderID
        {
            set { _stockorderid = value; }
            get { return _stockorderid; }
        }
        /// <summary>
        /// 供应商Guid
        /// </summary>
        public string SupplierGuid
        {
            set { _supplierguid = value; }
            get { return _supplierguid; }
        }
        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime StockOrderDate
        {
            set { _stockorderdate = value; }
            get { return _stockorderdate; }
        }
        /// <summary>
        /// 联系
        /// </summary>
        public string Linkman
        {
            set { _linkman = value; }
            get { return _linkman; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Fax
        {
            set { _fax = value; }
            get { return _fax; }
        }

        /// <summary>
        /// 联系
        /// </summary>
        public string MALinkman
        {
            set { _malinkman = value; }
            get { return _malinkman; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string MATelephone
        {
            set { _matelephone = value; }
            get { return _matelephone; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string MAFax
        {
            set { _mafax = value; }
            get { return _mafax; }
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
        /// <summary>
        /// 结单人
        /// </summary>
        public string EndGuid
        {
            set { _endguid = value; }
            get { return _endguid; }
        }
        /// <summary>
        /// 结单时间
        /// </summary>
        public DateTime EndDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        #endregion Model

    }
}
