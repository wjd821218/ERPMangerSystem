using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  文件申请明细
    /// </summary>
    public class FileApplyDetail
    {

        public FileApplyDetail()
		{}
        #region Model
        private string _fileapplydetailguid = "";
        private string _fileapplyguid = "";
        private string _fileguid = "";
        private string _isdownload = "";
        private int _sortid = 0;
        /// <summary>
        /// 
        /// </summary>
        public string FileApplyDetailGuID
        {
            set { _fileapplydetailguid = value; }
            get { return _fileapplydetailguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileApplyGuID
        {
            set { _fileapplyguid = value; }
            get { return _fileapplyguid; }
        }
        /// <summary>
        /// 文件Guid
        /// </summary>
        public string FileGuID
        {
            set { _fileguid = value; }
            get { return _fileguid; }
        }

        /// <summary>
        /// 是否下载
        /// </summary>
        public string IsDownload
        {
            set { _isdownload = value; }
            get { return _isdownload; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int SortID
        {
            set { _sortid = value; }
            get { return _sortid; }
        }
        #endregion Model
    }
}
