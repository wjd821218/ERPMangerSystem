using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    public class ClientOrderDetail
    {
        #region Model
        private string _clientorderguid;
        private string _materialguid;
        private decimal _materialsum;
        private string _remark;
        /// <summary>
        /// �ͻ�������
        /// </summary>
        public string ClientOrderGuid
        {
            set { _clientorderguid = value; }
            get { return _clientorderguid; }
        }
        /// <summary>
        /// ����Guid��
        /// </summary>
        public string MaterialGuid
        {
            set { _materialguid = value; }
            get { return _materialguid; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal MaterialSum
        {
            set { _materialsum = value; }
            get { return _materialsum; }
        }
        /// <summary>
        /// ˵��
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model
    }
}
