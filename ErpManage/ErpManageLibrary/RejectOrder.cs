using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  报废单
    /// </summary>
    public class RejectOrder
    {
        public RejectOrder()
        { }
        #region Model
        private string _rejectorderguid;
        private string _rejectorderid;
        private DateTime _rejectorderdate;
        private string _producttype;
        private string _clientorderid;
        private string _storageperson;
        private string _qualityperson;
        private string _projectperson;
        private string _stockperson;
        private string _produceperson;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _checkguid2;
        private DateTime _checkdate2;
        private string _rejectstorage;



        /// <summary>
        /// 报废仓库
        /// </summary>
        public string RejectStorage
        {
            set { _rejectstorage = value; }
            get { return _rejectstorage; }
        }



        /// <summary>
        /// 
        /// </summary>
        public string RejectOrderGuid
        {
            set { _rejectorderguid = value; }
            get { return _rejectorderguid; }
        }
        /// <summary>
        /// 报废单号
        /// </summary>
        public string RejectOrderID
        {
            set { _rejectorderid = value; }
            get { return _rejectorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime RejectOrderDate
        {
            set { _rejectorderdate = value; }
            get { return _rejectorderdate; }
        }
        /// <summary>
        /// 产品型号
        /// </summary>
        public string ProductType
        {
            set { _producttype = value; }
            get { return _producttype; }
        }
        /// <summary>
        /// 客户订单号
        /// </summary>
        public string ClientOrderID
        {
            set { _clientorderid = value; }
            get { return _clientorderid; }
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
        /// 质检员
        /// </summary>
        public string QualityPerson
        {
            set { _qualityperson = value; }
            get { return _qualityperson; }
        }
        /// <summary>
        /// 工程员
        /// </summary>
        public string ProjectPerson
        {
            set { _projectperson = value; }
            get { return _projectperson; }
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
        /// 生产员
        /// </summary>
        public string ProducePerson
        {
            set { _produceperson = value; }
            get { return _produceperson; }
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
        /// 二审人
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }
      
        #endregion Model

    }
}
