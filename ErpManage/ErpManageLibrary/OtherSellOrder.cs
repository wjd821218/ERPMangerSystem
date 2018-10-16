using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 其它出库单
    /// </summary>
    public class OtherSellOrder
    {
        #region Model
        private string _othersellorderguid;
        private string _othersellorderid;
        private DateTime? _othersellorderdate;
        private string _client;
        private string _outstorage;
        private string _storageperson;
        private string _qualityperson;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string OtherSellOrderGuid
        {
            set { _othersellorderguid = value; }
            get { return _othersellorderguid; }
        }
        /// <summary>
        /// 销售出库单号
        /// </summary>
        public string OtherSellOrderID
        {
            set { _othersellorderid = value; }
            get { return _othersellorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? OtherSellOrderDate
        {
            set { _othersellorderdate = value; }
            get { return _othersellorderdate; }
        }
        /// <summary>
        /// 客户
        /// </summary>
        public string Client
        {
            set { _client = value; }
            get { return _client; }
        }
        /// <summary>
        /// 出货仓库
        /// </summary>
        public string OutStorage
        {
            set { _outstorage = value; }
            get { return _outstorage; }
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
