using System;
using System.Collections.Generic;
using System.Text;
using Daniel.Liu.DAO;
namespace ErpManageLibrary
{
    public class ChangeBillDataAttachment
    {

        #region Model
        private string _changebilldataattachmentguid;
        private string _changebillguid = "";
        private string _fileguid = "";
        private string _filesourcename = "";
        private byte[] _filecontent;
        private int _sortid;
        /// <summary>
        /// 
        /// </summary>
        public string ChangeBillDataAttachmentGuID
        {
            set { _changebilldataattachmentguid = value; }
            get { return _changebilldataattachmentguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChangeBillGuID
        {
            set { _changebillguid = value; }
            get { return _changebillguid; }
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
