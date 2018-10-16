using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���쵥
    /// </summary>
    public class ExcessOrder
    {
        #region Model
        private string _excessorderguid;
        private string _excessorderid;
        private DateTime _excessorderdate;
        private string _drawperson;
        private string _emitperson;
        private string _outstorage;
        private string _remark;
        private string _createguid;
        private DateTime _createdate;
        private string _checkguid;
        private DateTime _checkdate;
        private string _checkguid2;
        private DateTime _checkdate2;
        /// <summary>
        /// 
        /// </summary>
        public string ExcessOrderGuid
        {
            set { _excessorderguid = value; }
            get { return _excessorderguid; }
        }
        /// <summary>
        /// ���ϵ���
        /// </summary>
        public string ExcessOrderID
        {
            set { _excessorderid = value; }
            get { return _excessorderid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime ExcessOrderDate
        {
            set { _excessorderdate = value; }
            get { return _excessorderdate; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string DrawPerson
        {
            set { _drawperson = value; }
            get { return _drawperson; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string EmitPerson
        {
            set { _emitperson = value; }
            get { return _emitperson; }
        }
        /// <summary>
        /// ���ϲֿ�
        /// </summary>
        public string OutStorage
        {
            set { _outstorage = value; }
            get { return _outstorage; }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// �Ƶ���
        /// </summary>
        public string CreateGuid
        {
            set { _createguid = value; }
            get { return _createguid; }
        }
        /// <summary>
        /// �Ƶ�ʱ��
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string CheckGuid
        {
            set { _checkguid = value; }
            get { return _checkguid; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// �����������
        /// </summary>
        public DateTime CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }
        #endregion Model
    }
}
