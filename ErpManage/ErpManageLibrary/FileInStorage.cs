using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  文件入库
    /// </summary>
    public class FileInStorage
    {
       public FileInStorage()
		{}
		#region Model
		private string _fileinstorageguid;
		private string _fileinstorageid="";
		private DateTime? _fileinstoragedate;
		private string _fileinstorageperson="入库人";
		private string _remark="";
		private string _createguid="";
		private DateTime? _createdate;
		private string _checkguid="";
		private DateTime? _checkdate;
		private string _checkguid2="";
		private DateTime? _checkdate2;
		/// <summary>
		/// 
		/// </summary>
		public string FileInStorageGuID
		{
			set{ _fileinstorageguid=value;}
			get{return _fileinstorageguid;}
		}
		/// <summary>
		/// 文件入库单号
		/// </summary>
		public string FileInStorageID
		{
			set{ _fileinstorageid=value;}
			get{return _fileinstorageid;}
		}
		/// <summary>
		/// 入库日期
		/// </summary>
		public DateTime? FileInStorageDate
		{
			set{ _fileinstoragedate=value;}
			get{return _fileinstoragedate;}
		}
		/// <summary>
		/// ''
		/// </summary>
		public string FileInStoragePerson
		{
			set{ _fileinstorageperson=value;}
			get{return _fileinstorageperson;}
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
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string CheckGuid
		{
			set{ _checkguid=value;}
			get{return _checkguid;}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? CheckDate
		{
			set{ _checkdate=value;}
			get{return _checkdate;}
		}
		/// <summary>
		/// 二审人
		/// </summary>
		public string CheckGuid2
		{
			set{ _checkguid2=value;}
			get{return _checkguid2;}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? CheckDate2
		{
			set{ _checkdate2=value;}
			get{return _checkdate2;}
		}
		#endregion Model

    }
}
