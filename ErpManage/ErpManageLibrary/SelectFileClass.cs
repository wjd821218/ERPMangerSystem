using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 选择文件类别
    /// </summary>
    public class SelectFileClass
    {
        private string _FileClassID;
        private string _FileClassName;


        public string FileClassID
        {
            set { _FileClassID = value; }
            get { return _FileClassID; }
        }

        public string FileClassName
        {
            set { _FileClassName = value; }
            get { return _FileClassName; }
        }


    }
}
