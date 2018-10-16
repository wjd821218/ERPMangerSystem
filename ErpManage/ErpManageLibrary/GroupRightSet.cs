using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class GroupRightSet
    {
        public GroupRightSet()
        { }
        #region Model
        private string _groupid;
        private string _moduleid;
        private string _functionid;
        private int _functionright;
        /// <summary>
        /// 组唯一号
        /// </summary>
        public string GroupID
        {
            set { _groupid = value; }
            get { return _groupid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ModuleID
        {
            set { _moduleid = value; }
            get { return _moduleid; }
        }
        /// <summary>
        /// 功能,功能: Save:保存   Delete:删除  Qry:查询 Check: 审核  UnCheck:反审  Print:打印    
        /// </summary>
        public string FunctionID
        {
            set { _functionid = value; }
            get { return _functionid; }
        }
        /// <summary>
        /// 是否有权限，1-有 0-无
        /// </summary>
        public int FunctionRight
        {
            set { _functionright = value; }
            get { return _functionright; }
        }
        #endregion Model

    }
}
