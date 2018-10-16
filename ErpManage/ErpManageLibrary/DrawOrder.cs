using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ���ϵ�ʵ��
    /// </summary>
    public class DrawOrder
    {

        #region Model
        private string _draworderguid;
        private string _draworderid;
        private DateTime? _draworderdate;
        private string _drawperson;
        private string _emitperson;
        private string _outstorage;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        private string _checkguid;
        private DateTime? _checkdate;
        /// <summary>
        /// 
        /// </summary>
        public string DrawOrderGuid
        {
            set { _draworderguid = value; }
            get { return _draworderguid; }
        }
        /// <summary>
        /// ���ϵ���
        /// </summary>
        public string DrawOrderID
        {
            set { _draworderid = value; }
            get { return _draworderid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? DrawOrderDate
        {
            set { _draworderdate = value; }
            get { return _draworderdate; }
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
        public DateTime? CreateDate
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
        public DateTime? CheckDate
        {
            set { _checkdate = value; }
            get { return _checkdate; }
        }
        #endregion Model


    }
}
