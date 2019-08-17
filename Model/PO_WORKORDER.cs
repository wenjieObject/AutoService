/**  版本信息模板在安装目录下，可自行修改。
* PO_WORKORDER.cs
*
* 功 能： N/A
* 类 名： PO_WORKORDER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:16   N/A    初版
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
	/// 生产订单
	/// </summary>
	[Serializable]
	public partial class PO_WORKORDER
	{
		public PO_WORKORDER()
		{}
		#region Model
		private string _id;
		private string _workorder_no;
		private string _workorder_type;
		private string _materialid;
		private decimal? _workorder_qty;
		private DateTime? _plan_begin;
		private DateTime? _plan_end;
		private DateTime? _actual_begin;
		private DateTime? _actual_end;
		private decimal? _scheduledqty;
		private decimal? _wo_complete_qty;
		private string _salesorderid;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _isused;
		private decimal? _workorder_state;
		private string _salesorder_item;
		private string _workorder_mold;
		private string _sapdoc;
		private string _workorder_materialversion;
		private string _workorder_property;
		private string _remarks;
		private string _orderproperty_polenumber;
		private string _orderproperty_productclass;
		private string _orderproperty_lev;
		private string _orderproperty_salescategory;
		private string _orderproperty_placeofsale;
		private string _orderproperty_specifications;
		private string _orderproperty_deliver;
		private string _mes_source_workorder_no;
		private string _workorder_model;
		private decimal? _backup_overschedule_qty;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 生产订单编号
		/// </summary>
		public string WORKORDER_NO
		{
			set{ _workorder_no=value;}
			get{return _workorder_no;}
		}
		/// <summary>
		/// 生产订单来源0 ERP 1 自建
		/// </summary>
		public string WORKORDER_TYPE
		{
			set{ _workorder_type=value;}
			get{return _workorder_type;}
		}
		/// <summary>
		/// 成品物料ID
		/// </summary>
		public string MATERIALID
		{
			set{ _materialid=value;}
			get{return _materialid;}
		}
		/// <summary>
		/// 订单数量
		/// </summary>
		public decimal? WORKORDER_QTY
		{
			set{ _workorder_qty=value;}
			get{return _workorder_qty;}
		}
		/// <summary>
		/// 计划开工时间
		/// </summary>
		public DateTime? PLAN_BEGIN
		{
			set{ _plan_begin=value;}
			get{return _plan_begin;}
		}
		/// <summary>
		/// 计划完工时间（计划交期）
		/// </summary>
		public DateTime? PLAN_END
		{
			set{ _plan_end=value;}
			get{return _plan_end;}
		}
		/// <summary>
		/// 实际开工时间
		/// </summary>
		public DateTime? ACTUAL_BEGIN
		{
			set{ _actual_begin=value;}
			get{return _actual_begin;}
		}
		/// <summary>
		/// 实际完工时间
		/// </summary>
		public DateTime? ACTUAL_END
		{
			set{ _actual_end=value;}
			get{return _actual_end;}
		}
		/// <summary>
		/// 已（车间排产）排产数量
		/// </summary>
		public decimal? SCHEDULEDQTY
		{
			set{ _scheduledqty=value;}
			get{return _scheduledqty;}
		}
		/// <summary>
		/// 完成数
		/// </summary>
		public decimal? WO_COMPLETE_QTY
		{
			set{ _wo_complete_qty=value;}
			get{return _wo_complete_qty;}
		}
		/// <summary>
		/// 销售订单ID
		/// </summary>
		public string SALESORDERID
		{
			set{ _salesorderid=value;}
			get{return _salesorderid;}
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
		/// 0 初始 1 下达 2 已排完 3 关单
		/// </summary>
		public decimal? WORKORDER_STATE
		{
			set{ _workorder_state=value;}
			get{return _workorder_state;}
		}
		/// <summary>
		/// 销售订单行项目
		/// </summary>
		public string SALESORDER_ITEM
		{
			set{ _salesorder_item=value;}
			get{return _salesorder_item;}
		}
		/// <summary>
		/// 生产订单类型 -- 标准ZMT1/研发ZMT2/进料加工ZMT3/改制ZMT4/注塑ZMT5
		/// </summary>
		public string WORKORDER_MOLD
		{
			set{ _workorder_mold=value;}
			get{return _workorder_mold;}
		}
		/// <summary>
		/// SAP凭证号
		/// </summary>
		public string SAPDOC
		{
			set{ _sapdoc=value;}
			get{return _sapdoc;}
		}
		/// <summary>
		/// 生产订单物料版本号
		/// </summary>
		public string WORKORDER_MATERIALVERSION
		{
			set{ _workorder_materialversion=value;}
			get{return _workorder_materialversion;}
		}
		/// <summary>
		/// 生产订单属性 0: 标准订单 1:重复制造
		/// </summary>
		public string WORKORDER_PROPERTY
		{
			set{ _workorder_property=value;}
			get{return _workorder_property;}
		}
		/// <summary>
		/// 备注  【销售订单转生产订单输入长文本】
		/// </summary>
		public string REMARKS
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_POLENUMBER
		{
			set{ _orderproperty_polenumber=value;}
			get{return _orderproperty_polenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_PRODUCTCLASS
		{
			set{ _orderproperty_productclass=value;}
			get{return _orderproperty_productclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_LEV
		{
			set{ _orderproperty_lev=value;}
			get{return _orderproperty_lev;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_SALESCATEGORY
		{
			set{ _orderproperty_salescategory=value;}
			get{return _orderproperty_salescategory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_PLACEOFSALE
		{
			set{ _orderproperty_placeofsale=value;}
			get{return _orderproperty_placeofsale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_SPECIFICATIONS
		{
			set{ _orderproperty_specifications=value;}
			get{return _orderproperty_specifications;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDERPROPERTY_DELIVER
		{
			set{ _orderproperty_deliver=value;}
			get{return _orderproperty_deliver;}
		}
		/// <summary>
		/// MES原始生产订单号
		/// </summary>
		public string MES_SOURCE_WORKORDER_NO
		{
			set{ _mes_source_workorder_no=value;}
			get{return _mes_source_workorder_no;}
		}
		/// <summary>
		/// 生产订单规格：“客户订单”  “备库订单”
		/// </summary>
		public string WORKORDER_MODEL
		{
			set{ _workorder_model=value;}
			get{return _workorder_model;}
		}
		/// <summary>
		/// 备库订单超排数
		/// </summary>
		public decimal? BACKUP_OVERSCHEDULE_QTY
		{
			set{ _backup_overschedule_qty=value;}
			get{return _backup_overschedule_qty;}
		}
		#endregion Model

	}
}

