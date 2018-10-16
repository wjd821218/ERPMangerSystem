using System;
using System.Collections.Generic;
using System.Text;

namespace ErpManageLibrary
{
    /// <summary>
    ///  文件入库明细
    /// </summary>
    public class FileInStorageDetail
    {

       public FileInStorageDetail()
		{}
		#region Model
		private string _fileinstoragedetailguid="";
		private string _fileinstorageguid="";
		private string _fileguid="";
		private int _sortid=0;
		/// <summary>
		/// 
		/// </summary>
		public string FileInStorageDetailGuID
		{
			set{ _fileinstoragedetailguid=value;}
			get{return _fileinstoragedetailguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileInStorageGuID
		{
			set{ _fileinstorageguid=value;}
			get{return _fileinstorageguid;}
		}
		/// <summary>
		/// 物料Guid
		/// </summary>
		public string FileGuID
		{
			set{ _fileguid=value;}
			get{return _fileguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SortID
		{
			set{ _sortid=value;}
			get{return _sortid;}
		}
		#endregion Model
    }
}
