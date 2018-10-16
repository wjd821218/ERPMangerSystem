using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 领料单实体
    /// </summary>
    public class DrawOrder
    {

        #region Model
        private string _draworderguid;
        private string _draworderid;
        private DateTime? _draworderdate;
        private string _drawperson;
        private string _emitperson;
        private string _outstorage;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string DrawOrderGuid
        {
            set { _draworderguid = value; }
            get { return _draworderguid; }
        }
        /// <summary>
        /// 领料单号
        /// </summary>
        public string DrawOrderID
        {
            set { _draworderid = value; }
            get { return _draworderid; }
        }
        /// <summary>
        /// 开单日期
        /// </summary>
        public DateTime? DrawOrderDate
        {
            set { _draworderdate = value; }
            get { return _draworderdate; }
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
