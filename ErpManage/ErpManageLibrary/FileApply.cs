using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  文件申请
    /// </summary>
    public class FileApply
    {
        public FileApply()
		{}
        #region Model
        private string _fileapplyguid;
        private string _fileapplyid = "";
        private DateTime? _fileapplydate;
        private string _fileapplytype = "";
        private string _fileapplyperson = "";
        private string _fileapplydept = "";
        private string _remark = "";
        private string _createguid = "";
        private DateTime? _createdate;
        private string _checkguid = "";
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string FileApplyGuID
        {
            set { _fileapplyguid = value; }
            get { return _fileapplyguid; }
        }
        /// <summary>
        /// 申请单号
        /// </summary>
        public string FileApplyID
        {
            set { _fileapplyid = value; }
            get { return _fileapplyid; }
        }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime? FileApplyDate
        {
            set { _fileapplydate = value; }
            get { return _fileapplydate; }
        }
        /// <summary>
        /// 1-员工 2-部门
        /// </summary>
        public string FileApplyType
        {
            set { _fileapplytype = value; }
            get { return _fileapplytype; }
        }
        /// <summary>
        /// 申请人
        /// </summary>
        public string FileApplyPerson
        {
            set { _fileapplyperson = value; }
            get { return _fileapplyperson; }
        }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string FileApplyDept
        {
            set { _fileapplydept = value; }
            get { return _fileapplydept; }
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
