using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 超领单
    /// </summary>
    public class ExcessOrder
    {
        #region Model
        private string _excessorderguid;
        private string _excessorderid;
        private DateTime _excessorderdate;
        private string _drawperson;
        private string _emitperson;
        private string _outstorage;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _checkguid2;
        private DateTime _checkdate2;
        /// <summary>
        /// 
        /// </summary>
        public string ExcessOrderGuid
        {
            set { _excessorderguid = value; }
            get { return _excessorderguid; }
        }
        /// <summary>
        /// 领料单号
        /// </summary>
        public string ExcessOrderID
        {
            set { _excessorderid = value; }
            get { return _excessorderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime ExcessOrderDate
        {
            set { _excessorderdate = value; }
            get { return _excessorderdate; }
        }
        /// <summary>
        /// 领料人
        /// </summary>
        public string DrawPerson
        {
            set { _drawperson = value; }
            get { return _drawperson; }
        }
        /// <summary>
        /// 发料人
        /// </summary>
        public string EmitPerson
        {
            set { _emitperson = value; }
            get { return _emitperson; }
        }
        /// <summary>
        /// 领料仓库
        /// </summary>
        public string OutStorage
        {
            set { _outstorage = value; }
            get { return _outstorage; }
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
        #endregion Model
    }
}
