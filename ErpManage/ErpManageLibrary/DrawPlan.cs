using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// �������ϼƻ�����
    /// </summary>
    public class DrawPlan
    {
        #region Model
        private string _DrawPlanguid;
        private string _DrawPlanid;
        private DateTime? _DrawPlandate;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public string DrawPlanGuid
        {
            set { _DrawPlanguid = value; }
            get { return _DrawPlanguid; }
        }
        /// <summary>
        /// ��������ƻ�����
        /// </summary>
        public string DrawPlanID
        {
            set { _DrawPlanid = value; }
            get { return _DrawPlanid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? DrawPlanDate
        {
            set { _DrawPlandate = value; }
            get { return _DrawPlandate; }
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
        #endregion Model


    }
}
