using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 收款单
    /// </summary>
    public class IncomeOrder
    {
        #region Model
        private string _IncomeOrderguid;
        private string _IncomeOrderid;
        private DateTime? _IncomeOrderdate;
        private string _clientguid;
        private string _Incomeperson;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string IncomeOrderGuid
        {
            set { _IncomeOrderguid = value; }
            get { return _IncomeOrderguid; }
        }
        /// <summary>
        /// 付款单号
        /// </summary>
        public string IncomeOrderID
        {
            set { _IncomeOrderid = value; }
            get { return _IncomeOrderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? IncomeOrderDate
        {
            set { _IncomeOrderdate = value; }
            get { return _IncomeOrderdate; }
        }
        /// <summary>
        /// 客户
        /// </summary>
        public string ClientGuid
        {
            set { _clientguid = value; }
            get { return _clientguid; }
        }
        /// <summary>
        /// 付款人
        /// </summary>
        public string IncomePerson
        {
            set { _Incomeperson = value; }
            get { return _Incomeperson; }
        }
        /// <summary>
        /// 
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
        public DateTime? CreateDate
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
        public DateTime? CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model

    }
}
