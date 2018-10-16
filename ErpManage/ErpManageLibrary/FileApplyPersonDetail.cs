using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class FileApplyPersonDetail
    {
        #region Model
        private string _fileapplypersondetailguid;
        private string _fileapplyguid = "";
        private string _personguid = "";
        private int _sortid = 0;
        /// <summary>
        /// 
        /// </summary>
        public string FileApplyPersonDetailGuID
        {
            set { _fileapplypersondetailguid = value; }
            get { return _fileapplypersondetailguid; }
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
        /// 
        /// </summary>
        public string PersonGuID
        {
            set { _personguid = value; }
            get { return _personguid; }
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
