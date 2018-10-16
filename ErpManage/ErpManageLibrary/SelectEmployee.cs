using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 多员工选择
    /// </summary>
    public class SelectEmployee
    {

        private string _EmpGuid;
        private string _EmpName;


        /// <summary>
        /// 
        /// </summary>
        public string EmpGuid
        {
            set { _EmpGuid = value; }
            get { return _EmpGuid; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string EmpName
        {
            set { _EmpName = value; }
            get { return _EmpName; }
        }

    }
}
