/**  版本信息模板在安装目录下，可自行修改。
* QA_INSPECT_BILL_DETAIL.cs
*
* 功 能： N/A
* 类 名： QA_INSPECT_BILL_DETAIL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:24   N/A    初版
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
	/// 检验单明细
	/// </summary>
	[Serializable]
	public partial class QA_INSPECT_BILL_DETAIL
	{
		public QA_INSPECT_BILL_DETAIL()
		{}
		#region Model
		private string _id;
		private string _inspect_billid;
		private string _inspect_paramid;
		private string _inspect_method;
		private string _inspect_tool;
		private string _inspect_param_type;
		private string _inspect_type;
		private decimal? _upper_value;
		private decimal? _lower_value;
		private string _remark;
		private string _inspect_roleid;
		private decimal? _detail_inspect_flag;
		private decimal? _detail_inspect_result;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _isused;
		private decimal? _real_value;
		private decimal? _standard_value;
		private string _unit;
		private string _frequency;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 检验单表ID
		/// </summary>
		public string INSPECT_BILLID
		{
			set{ _inspect_billid=value;}
			get{return _inspect_billid;}
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
		/// 检验方法 
		/// </summary>
		public string INSPECT_METHOD
		{
			set{ _inspect_method=value;}
			get{return _inspect_method;}
		}
		/// <summary>
		/// 检查工具 
		/// </summary>
		public string INSPECT_TOOL
		{
			set{ _inspect_tool=value;}
			get{return _inspect_tool;}
		}
		/// <summary>
		/// 类别（定性/定量）
		/// </summary>
		public string INSPECT_PARAM_TYPE
		{
			set{ _inspect_param_type=value;}
			get{return _inspect_param_type;}
		}
		/// <summary>
		/// 来料检/过程检/产出检，来料检/过程检/产出检）（选择）
		/// </summary>
		public string INSPECT_TYPE
		{
			set{ _inspect_type=value;}
			get{return _inspect_type;}
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
		/// 角色ID
		/// </summary>
		public string INSPECT_ROLEID
		{
			set{ _inspect_roleid=value;}
			get{return _inspect_roleid;}
		}
		/// <summary>
		/// 检验状态（0，初始， 1检验完成）
		/// </summary>
		public decimal? DETAIL_INSPECT_FLAG
		{
			set{ _detail_inspect_flag=value;}
			get{return _detail_inspect_flag;}
		}
		/// <summary>
		/// 检验结果 0合格/1不合格
		/// </summary>
		public decimal? DETAIL_INSPECT_RESULT
		{
			set{ _detail_inspect_result=value;}
			get{return _detail_inspect_result;}
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
		/// 实际值
		/// </summary>
		public decimal? REAL_VALUE
		{
			set{ _real_value=value;}
			get{return _real_value;}
		}
		/// <summary>
		/// 标准值
		/// </summary>
		public decimal? STANDARD_VALUE
		{
			set{ _standard_value=value;}
			get{return _standard_value;}
		}
		/// <summary>
		/// 1班次 0 小时  2 架  3 包
		/// </summary>
		public string UNIT
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 频次
		/// </summary>
		public string FREQUENCY
		{
			set{ _frequency=value;}
			get{return _frequency;}
		}
		#endregion Model

	}
}

