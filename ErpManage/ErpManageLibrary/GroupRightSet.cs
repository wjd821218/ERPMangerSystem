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
        /// ��Ψһ��
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
        /// ����,����: Save:����   Delete:ɾ��  Qry:��ѯ Check: ���  UnCheck:����  Print:��ӡ    
        /// </summary>
        public string FunctionID
        {
            set { _functionid = value; }
            get { return _functionid; }
        }
        /// <summary>
        /// �Ƿ���Ȩ�ޣ�1-�� 0-��
        /// </summary>
        public int FunctionRight
        {
            set { _functionright = value; }
            get { return _functionright; }
        }
        #endregion Model

    }
}
