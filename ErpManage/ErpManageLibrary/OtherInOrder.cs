using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 其它入库单
    /// </summary>
    public class OtherInOrder
    {
        #region Model
        private string _OtherInOrderguid;
        private string _OtherInOrderid;
        private DateTime? _OtherInOrderdate;
        private string _instorage;
        private string _storageperson;
        private string _qualityperson;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        private string _batchno;


        public string BatchNo
        {
            set { _batchno = value; }
            get { return _batchno; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OtherInOrderGuid
        {
            set { _OtherInOrderguid = value; }
            get { return _OtherInOrderguid; }
        }
        /// <summary>
        /// 其它入库单号
        /// </summary>
        public string OtherInOrderID
        {
            set { _OtherInOrderid = value; }
            get { return _OtherInOrderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? OtherInOrderDate
        {
            set { _OtherInOrderdate = value; }
            get { return _OtherInOrderdate; }
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
