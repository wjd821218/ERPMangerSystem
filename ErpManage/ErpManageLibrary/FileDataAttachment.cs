using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 文件附件实体类
    /// </summary>
    public class FileDataAttachment
    {
        #region Model
        private string _filedataattachmentguid;
        private string _fileguid = "";
        private string _filesourcename = "";
        private byte[] _filecontent;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string FileDataAttachmentGuid
        {
            set { _filedataattachmentguid = value; }
            get { return _filedataattachmentguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileGuID
        {
            set { _fileguid = value; }
            get { return _fileguid; }
        }
        /// <summary>
        /// 文件源名
        /// </summary>
        public string FileSourceName
        {
            set { _filesourcename = value; }
            get { return _filesourcename; }
        }
        /// <summary>
        /// 附件
        /// </summary>
        public byte[] FileContent
        {
            set { _filecontent = value; }
            get { return _filecontent; }
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
