using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
using System.Data;

namespace ErpManageLibrary
{
    /// <summary>
    /// 文件管理实体类
    /// </summary>
    public  class FileData
    {
        #region Model
        private string _fileguid;
        private string _fileid = "";
        private string _filename = "";
        private string _filetype = "";
        private string _productname = "";
        private DateTime? _publishdate;
        private string _versionid = "";
        private string _writedept = "";
        private string _controltype = "";
        private int _isenable = 0;
        private string _remark = "";
        private string _createguid = "";
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public string FileGuID
        {
            set { _fileguid = value; }
            get { return _fileguid; }
        }
        /// <summary>
        /// 文件编号
        /// </summary>
        public string FileID
        {
            set { _fileid = value; }
            get { return _fileid; }
        }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName
        {
            set { _filename = value; }
            get { return _filename; }
        }
        /// <summary>
        /// 文件类别
        /// </summary>
        public string FileType
        {
            set { _filetype = value; }
            get { return _filetype; }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName
        {
            set { _productname = value; }
            get { return _productname; }
        }
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime? PublishDate
        {
            set { _publishdate = value; }
            get { return _publishdate; }
        }
        /// <summary>
        /// 版本号
        /// </summary>
        public string VersionID
        {
            set { _versionid = value; }
            get { return _versionid; }
        }
        /// <summary>
        /// 编写部门
        /// </summary>
        public string WriteDept
        {
            set { _writedept = value; }
            get { return _writedept; }
        }
        /// <summary>
        /// 控制类别
        /// </summary>
        public string ControlType
        {
            set { _controltype = value; }
            get { return _controltype; }
        }
        /// <summary>
        /// 是否停用(1:停用 0-启用)
        /// </summary>
        public int IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
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
        #endregion Model


       

       


    }
}
