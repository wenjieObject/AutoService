/**  版本信息模板在安装目录下，可自行修改。
* BDTA_INSPECT_STANDARD_DETAIL.cs
*
* 功 能： N/A
* 类 名： BDTA_INSPECT_STANDARD_DETAIL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:00   N/A    初版
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
	/// 检验标准明细
	/// </summary>
	[Serializable]
	public partial class BDTA_INSPECT_STANDARD_DETAIL
	{
		public BDTA_INSPECT_STANDARD_DETAIL()
		{}
		#region Model
		private string _id;
		private string _inspect_standardid;
		private string _inspect_paramid;
		private decimal? _upper_value;
		private decimal? _lower_value;
		private string _remark;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _isused;
		private string _frequency;
		private decimal? _standardvalue;
		private string _unit;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 检验标准维护（组套）ID
		/// </summary>
		public string INSPECT_STANDARDID
		{
			set{ _inspect_standardid=value;}
			get{return _inspect_standardid;}
		}
		/// <summary>
		/// 基础检验参数项ID
		/// </summary>
		public string INSPECT_PARAMID
		{
			set{ _inspect_paramid=value;}
			get{return _inspect_paramid;}
		}
		/// <summary>
		/// 上限
		/// </summary>
		public decimal? UPPER_VALUE
		{
			set{ _upper_value=value;}
			get{return _upper_value;}
		}
		/// <summary>
		/// 下限
		/// </summary>
		public decimal? LOWER_VALUE
		{
			set{ _lower_value=value;}
			get{return _lower_value;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
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
		/// 
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
		/// 频次（班次、2小时、4小时。。。）班次默认1
		/// </summary>
		public string FREQUENCY
		{
			set{ _frequency=value;}
			get{return _frequency;}
		}
		/// <summary>
		/// 标准值
		/// </summary>
		public decimal? STANDARDVALUE
		{
			set{ _standardvalue=value;}
			get{return _standardvalue;}
		}
		/// <summary>
		/// 1班次 0 小时  2 架  3 包
		/// </summary>
		public string UNIT
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		#endregion Model

	}
}

