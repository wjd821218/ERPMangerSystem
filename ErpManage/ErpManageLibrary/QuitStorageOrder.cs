using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 退料入库单
    /// </summary>
    public class QuitStorageOrder
    {
        #region Model
        private string _quitstorageorderguid;
        private string _quitstorageorderid;
        private DateTime _quitstorageorderdate;
        private string _dept;
        private string _instorage;
        private string _materialperson;
        private string _storageperson;
        private string _qualityperson;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _batchno;

        public string BatchNo
        {
            set { _batchno = value; }
            get { return _batchno; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string QuitStorageOrderGuid
        {
            set { _quitstorageorderguid = value; }
            get { return _quitstorageorderguid; }
        }
        /// <summary>
        /// 送货单号
        /// </summary>
        public string QuitStorageOrderID
        {
            set { _quitstorageorderid = value; }
            get { return _quitstorageorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime QuitStorageOrderDate
        {
            set { _quitstorageorderdate = value; }
            get { return _quitstorageorderdate; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string Dept
        {
            set { _dept = value; }
            get { return _dept; }
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
        /// 物料员
        /// </summary>
        public string MaterialPerson
        {
            set { _materialperson = value; }
            get { return _materialperson; }
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
        /// 品质员
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
