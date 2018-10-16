using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 退料单
    /// </summary>
    public class QuitOrder
    {
        #region Model
        private string _quitorderguid;
        private string _quitorderid;
        private DateTime _quitorderdate;
        private string _supplierguid;
        private string _delivergoodsperson;
        private string _storageperson;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _checkguid2;
        private DateTime _checkdate2;
        private string _outstorage;
        /// <summary>
        /// 
        /// </summary>
        public string QuitOrderGuid
        {
            set { _quitorderguid = value; }
            get { return _quitorderguid; }
        }
        /// <summary>
        /// 送货单号
        /// </summary>
        public string QuitOrderID
        {
            set { _quitorderid = value; }
            get { return _quitorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime QuitOrderDate
        {
            set { _quitorderdate = value; }
            get { return _quitorderdate; }
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
        /// 收货人
        /// </summary>
        public string DeliverGoodsPerson
        {
            set { _delivergoodsperson = value; }
            get { return _delivergoodsperson; }
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
        /// 退料仓库
        /// </summary>
        public string OutStorage
        {
            set { _outstorage = value; }
            get { return _outstorage; }
        }
        #endregion Model
    }
}
