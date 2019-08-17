/**  版本信息模板在安装目录下，可自行修改。
* BDTA_SETUP.cs
*
* 功 能： N/A
* 类 名： BDTA_SETUP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:07   N/A    初版
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
	/// BDTA_SETUP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BDTA_SETUP
	{
		public BDTA_SETUP()
		{}
		#region Model
		private string _id;
		private string _setup_no;
		private string _setup_contents;
		private string _setup_key;
		private string _setup_type;
		private string _setup_parameter;
		private string _setup_max;
		private string _setup_min;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _isused;
		private decimal? _activity;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_NO
		{
			set{ _setup_no=value;}
			get{return _setup_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_CONTENTS
		{
			set{ _setup_contents=value;}
			get{return _setup_contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_KEY
		{
			set{ _setup_key=value;}
			get{return _setup_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_TYPE
		{
			set{ _setup_type=value;}
			get{return _setup_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_PARAMETER
		{
			set{ _setup_parameter=value;}
			get{return _setup_parameter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_MAX
		{
			set{ _setup_max=value;}
			get{return _setup_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETUP_MIN
		{
			set{ _setup_min=value;}
			get{return _setup_min;}
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
		public decimal? ISUSED
		{
			set{ _isused=value;}
			get{return _isused;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ACTIVITY
		{
			set{ _activity=value;}
			get{return _activity;}
		}
		#endregion Model

	}
}

