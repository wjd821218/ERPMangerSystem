using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// ��������ƻ�����
    /// </summary>
    public class MaterialMRPPlan
    {
        #region Model
        private string _materialmrpplanguid;
        private string _materialmrpplanid;
        private DateTime? _materialmrpplandate;
        private string _remark;
        private string _createguid;
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public string MaterialMRPPlanGuid
        {
            set { _materialmrpplanguid = value; }
            get { return _materialmrpplanguid; }
        }
        /// <summary>
        /// ��������ƻ�����
        /// </summary>
        public string MaterialMRPPlanID
        {
            set { _materialmrpplanid = value; }
            get { return _materialmrpplanid; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? MaterialMRPPlanDate
        {
            set { _materialmrpplandate = value; }
            get { return _materialmrpplandate; }
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
