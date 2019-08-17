/**  版本信息模板在安装目录下，可自行修改。
* QA_INSPECT_BILL.cs
*
* 功 能： N/A
* 类 名： QA_INSPECT_BILL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:20   N/A    初版
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
	/// 检验单表
	/// </summary>
	[Serializable]
	public partial class QA_INSPECT_BILL
	{
		public QA_INSPECT_BILL()
		{}
		#region Model
		private string _id;
		private string _inspect_planid;
		private string _inspect_bill_no;
		private string _sn;
		private decimal? _inspect_flag;
		private decimal? _inspect_result;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _isused;
		private string _inspector;
		private DateTime? _checktime;
		private string _jobno;
		private string _materialid;
		private string _inspect_roleid;
		private string _inspect_standardid;
		private string _partnerid;
		private string _inspect_type;
		private string _machingcenterid;
		private string _occasiontime;
		private string _flow_code;
		private string _remark;
		private string _abnormal_reason;
		private string _storeroomid;
		private string _storesiteid;
		private string _snno;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 巡检计划主表ID
		/// </summary>
		public string INSPECT_PLANID
		{
			set{ _inspect_planid=value;}
			get{return _inspect_planid;}
		}
		/// <summary>
		/// 检验单号
		/// </summary>
		public string INSPECT_BILL_NO
		{
			set{ _inspect_bill_no=value;}
			get{return _inspect_bill_no;}
		}
		/// <summary>
		/// 采集 SN（巡检）    PLAN_WIP
		/// </summary>
		public string SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 检验状态（0，待检， 1检验完成，2异常,3未检）
		/// </summary>
		public decimal? INSPECT_FLAG
		{
			set{ _inspect_flag=value;}
			get{return _inspect_flag;}
		}
		/// <summary>
		/// 检验结果 0合格/1不合格
		/// </summary>
		public decimal? INSPECT_RESULT
		{
			set{ _inspect_result=value;}
			get{return _inspect_result;}
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
		/// 0无效1有效
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
		/// 检查人
		/// </summary>
		public string INSPECTOR
		{
			set{ _inspector=value;}
			get{return _inspector;}
		}
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime? CHECKTIME
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 或者 采集JOBNO（巡检）    PLAN_JOBDISPATCH 
		/// </summary>
		public string JOBNO
		{
			set{ _jobno=value;}
			get{return _jobno;}
		}
		/// <summary>
		/// 物料ID
		/// </summary>
		public string MATERIALID
		{
			set{ _materialid=value;}
			get{return _materialid;}
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
		/// 检验标准维护（组套）ID
		/// </summary>
		public string INSPECT_STANDARDID
		{
			set{ _inspect_standardid=value;}
			get{return _inspect_standardid;}
		}
		/// <summary>
		/// 客户ID (供应商单品检验)
		/// </summary>
		public string PARTNERID
		{
			set{ _partnerid=value;}
			get{return _partnerid;}
		}
		/// <summary>
		/// 首检/过程检/产出检，来料检/过程检/产出检）（选择
		/// </summary>
		public string INSPECT_TYPE
		{
			set{ _inspect_type=value;}
			get{return _inspect_type;}
		}
		/// <summary>
		/// 加工中心ID（选填） 
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
		/// <summary>
		/// 流水码
		/// </summary>
		public string FLOW_CODE
		{
			set{ _flow_code=value;}
			get{return _flow_code;}
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
		/// 异常原因
		/// </summary>
		public string ABNORMAL_REASON
		{
			set{ _abnormal_reason=value;}
			get{return _abnormal_reason;}
		}
		/// <summary>
		/// 库房ID【库内检和单品检用】
		/// </summary>
		public string STOREROOMID
		{
			set{ _storeroomid=value;}
			get{return _storeroomid;}
		}
		/// <summary>
		/// 库位ID【库内检和单品检用】
		/// </summary>
		public string STORESITEID
		{
			set{ _storesiteid=value;}
			get{return _storesiteid;}
		}
		/// <summary>
		/// SN[单品检验用]  对应界面 批次号字段哦
		/// </summary>
		public string SNNO
		{
			set{ _snno=value;}
			get{return _snno;}
		}
		#endregion Model

	}
}

