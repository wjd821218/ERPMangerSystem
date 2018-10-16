using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class ClientOrder
    {

        public ClientOrder()
        { }
        #region Model
        private string _clientorderguid;
        private string _clientorderid;
        private DateTime _clientorderdate;
        private DateTime _encasementdate;
        private string _contractid;
        private string _checkbatchid;
        private string _downdept;
        private string _receivedept;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _endguid;
        private DateTime _enddate;
        private string _checkguid2;
        private DateTime _checkdate2;
        private string _ordertype;
        /// <summary>
        /// 客户订单唯一号
        /// </summary>
        public string ClientOrderGuid
        {
            set { _clientorderguid = value; }
            get { return _clientorderguid; }
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
        /// 下单日期
        /// </summary>
        public DateTime ClientOrderDate
        {
            set { _clientorderdate = value; }
            get { return _clientorderdate; }
        }
        /// <summary>
        /// 装箱日期
        /// </summary>
        public DateTime EncasementDate
        {
            set { _encasementdate = value; }
            get { return _encasementdate; }
        }
        /// <summary>
        /// 合同号
        /// </summary>
        public string ContractID
        {
            set { _contractid = value; }
            get { return _contractid; }
        }
        /// <summary>
        /// 商检批号
        /// </summary>
        public string CheckBatchID
        {
            set { _checkbatchid = value; }
            get { return _checkbatchid; }
        }
        /// <summary>
        /// 下单部门
        /// </summary>
        public string DownDept
        {
            set { _downdept = value; }
            get { return _downdept; }
        }
        /// <summary>
        /// 收单部门
        /// </summary>
        public string ReceiveDept
        {
            set { _receivedept = value; }
            get { return _receivedept; }
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
        /// <summary>
        /// 二级审核人
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// 二级审核日期
        /// </summary>
        public DateTime CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }

        /// <summary>
        /// 订单类别：内部订单、客户订单
        /// </summary>
        public string OrderType
        {
            set { _ordertype = value; }
            get { return _ordertype; }
        }
        #endregion Model

       

    }
}
