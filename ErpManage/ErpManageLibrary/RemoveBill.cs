using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    /// 调拨单
    /// </summary>
    public class RemoveBill
    {

      #region Model
		private string _removebillguid;
		private string _removebillid;
		private DateTime _removebilldate;
		private string _depotout;
		private string _depotin;
		private string _handleperson;
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
		public string RemoveBillGuid
		{
		set{ _removebillguid=value;}
		get{return _removebillguid;}
		}
		/// <summary>
		/// 单号
		/// </summary>
		public string RemoveBillID
		{
		set{ _removebillid=value;}
		get{return _removebillid;}
		}
		/// <summary>
		/// 单据日期
		/// </summary>
		public DateTime RemoveBillDate
		{
		set{ _removebilldate=value;}
		get{return _removebilldate;}
		}
		/// <summary>
		/// 调出仓库
		/// </summary>
		public string DepotOut
		{
		set{ _depotout=value;}
		get{return _depotout;}
		}
		/// <summary>
		/// 调入仓库
		/// </summary>
		public string DepotIn
		{
		set{ _depotin=value;}
		get{return _depotin;}
		}
		/// <summary>
		/// 调拨人
		/// </summary>
		public string HandlePerson
		{
		set{ _handleperson=value;}
		get{return _handleperson;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
		set{ _remark=value;}
		get{return _remark;}
		}
		/// <summary>
		/// 制单人
		/// </summary>
		public string CreateGuid
		{
		set{ _createguid=value;}
		get{return _createguid;}
		}
		/// <summary>
		/// 制单时间
		/// </summary>
		public DateTime CreateDate
		{
		set{ _createdate=value;}
		get{return _createdate;}
		}
		/// <summary>
		/// 2审核人
		/// </summary>
		public string CheckGuid
		{
		set{ _checkguid=value;}
		get{return _checkguid;}
		}
		/// <summary>
		/// 2审核时间
		/// </summary>
		public DateTime CheckDate
		{
		set{ _checkdate=value;}
		get{return _checkdate;}
		}


        /// <summary>
        /// 2审核人
        /// </summary>
        public string CheckGuid2
        {
            set { _checkguid2 = value; }
            get { return _checkguid2; }
        }
        /// <summary>
        /// 2审核时间
        /// </summary>
        public DateTime CheckDate2
        {
            set { _checkdate2 = value; }
            get { return _checkdate2; }
        }
		#endregion Model
     
    }
}
