/**  版本信息模板在安装目录下，可自行修改。
* BDTA_INSPECT_STANDARD.cs
*
* 功 能： N/A
* 类 名： BDTA_INSPECT_STANDARD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:45:59   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Model
{
	/// <summary>
	/// 检验标准维护（组套）
	/// </summary>
	[Serializable]
	public partial class BDTA_INSPECT_STANDARD
	{
		public BDTA_INSPECT_STANDARD()
		{}
		#region Model
		private string _id;
		private string _inspect_standard_code;
		private string _inspect_standard_name;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _isused;
		private string _inspect_type;
		private string _inspect_roleid;
		private string _workshopid;
		private string _machingcenterid;
		private string _occasiontime;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 检验标准号 
		/// </summary>
		public string INSPECT_STANDARD_CODE
		{
			set{ _inspect_standard_code=value;}
			get{return _inspect_standard_code;}
		}
		/// <summary>
		/// 检验标准名称 
		/// </summary>
		public string INSPECT_STANDARD_NAME
		{
			set{ _inspect_standard_name=value;}
			get{return _inspect_standard_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DATAVERSION
		{
			set{ _dataversion=value;}
			get{return _dataversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATEDATE
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATER
		{
			set{ _creater=value;}
			get{return _creater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATEDATE
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATER
		{
			set{ _updater=value;}
			get{return _updater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXTENDFIELD
		{
			set{ _extendfield=value;}
			get{return _extendfield;}
		}
		/// <summary>
		/// 1 启用  0停用
		/// </summary>
		public decimal? ACTIVITY
		{
			set{ _activity=value;}
			get{return _activity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISUSED
		{
			set{ _isused=value;}
			get{return _isused;}
		}
		/// <summary>
		/// 首检/过程检/产出检，配置在数据字典
		/// </summary>
		public string INSPECT_TYPE
		{
			set{ _inspect_type=value;}
			get{return _inspect_type;}
		}
		/// <summary>
		/// 检查角色ID
		/// </summary>
		public string INSPECT_ROLEID
		{
			set{ _inspect_roleid=value;}
			get{return _inspect_roleid;}
		}
		/// <summary>
		/// 工作中心（车间表ID）
		/// </summary>
		public string WORKSHOPID
		{
			set{ _workshopid=value;}
			get{return _workshopid;}
		}
		/// <summary>
		/// 加工中心ID(bdta_maching_center)  20180307 新增
		/// </summary>
		public string MACHINGCENTERID
		{
			set{ _machingcenterid=value;}
			get{return _machingcenterid;}
		}
		/// <summary>
		/// 时机
		/// </summary>
		public string OCCASIONTIME
		{
			set{ _occasiontime=value;}
			get{return _occasiontime;}
		}
		#endregion Model

	}
}

