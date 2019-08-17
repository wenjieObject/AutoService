/**  版本信息模板在安装目录下，可自行修改。
* PLAN_JOBDISPATCH.cs
*
* 功 能： N/A
* 类 名： PLAN_JOBDISPATCH
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:11   N/A    初版
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
	/// 派工单
	/// </summary>
	[Serializable]
	public partial class PLAN_JOBDISPATCH
	{
		public PLAN_JOBDISPATCH()
		{}
		#region Model
		private string _id;
		private string _mergebill_secondarysplitid;
		private string _jobno;
		private string _materialid;
		private string _material_code;
		private string _material_desc;
		private string _workorder;
		private string _workorder_type;
		private string _sales_order;
		private string _workshopid;
		private string _maching_centerid;
		private decimal? _jobqty;
		private decimal? _job_startqty;
		private decimal? _job_finishqty;
		private decimal? _job_disquanqty;
		private string _routingid;
		private DateTime? _job_schedule;
		private DateTime? _job_plan_online;
		private DateTime? _job_plan_offline;
		private DateTime? _job_begin;
		private DateTime? _job_end;
		private decimal? _job_type;
		private string _workteamid;
		private decimal? _sn_crearemethod;
		private string _job_description;
		private string _job_codestr;
		private string _stack_type;
		private string _sap_routeno;
		private string _mergebillnotype;
		private string _directory_code;
		private string _sap_factory;
		private string _sales_order_item;
		private DateTime? _basic_begin;
		private DateTime? _basic_end;
		private string _occupy_code;
		private decimal? _workorder_totalqty;
		private string _workorder_unit;
		private string _material_group;
		private string _material_group_desc;
		private string _design_colour;
		private string _edge_type;
		private string _door_type;
		private string _alum_edge_pvc;
		private string _series;
		private string _maching_center_elecsaw;
		private string _nostandard_mergebillno;
		private string _catalog_code;
		private decimal? _block_qty;
		private string _complain_content;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private decimal? _job_state;
		private decimal? _kitting_flag;
		private decimal? _job_torrno;
		private string _machine_version;
		private string _environment_property;
		private string _storeroom_id;
		private string _storesite_id;
		private decimal? _job_property;
		private string _producting_area;
		private string _priority_level;
		private string _sales_orderid;
		private string _pack_tagmark;
		private string _productformatid;
		private string _factory_code;
		private string _ori_factory_flag;
		private string _remark;
		private string _package_remark;
		private string _source_arrivalno;
		private decimal? _writer_amt;
		private string _po_job_scheduleid;
		private string _material_applyid;
		private string _packbom_applyid;
		private string _worknumberid;
		private decimal? _hadtosap_qty;
		private decimal? _hadtosap_input;
		private decimal? _hadtosap_output;
		private string _qclevel;
		private decimal? _iscreate_pack;
		private string _exceptioncausecode;
		private decimal? _adjustedplanningquantity;
		private decimal? _workinghoursonline;
		private DateTime? _adjustmenttime;
		private string _adjusts;
		private decimal? _locked;
		private decimal? _jobcomplete_flag;
		private string _qualityproblem;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 不用
		/// </summary>
		public string MERGEBILL_SECONDARYSPLITID
		{
			set{ _mergebill_secondarysplitid=value;}
			get{return _mergebill_secondarysplitid;}
		}
		/// <summary>
		/// 派工单号，自动生产
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
		/// 
		/// </summary>
		public string MATERIAL_CODE
		{
			set{ _material_code=value;}
			get{return _material_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MATERIAL_DESC
		{
			set{ _material_desc=value;}
			get{return _material_desc;}
		}
		/// <summary>
		/// 生产订单编号
		/// </summary>
		public string WORKORDER
		{
			set{ _workorder=value;}
			get{return _workorder;}
		}
		/// <summary>
		/// 不用
		/// </summary>
		public string WORKORDER_TYPE
		{
			set{ _workorder_type=value;}
			get{return _workorder_type;}
		}
		/// <summary>
		/// 不用
		/// </summary>
		public string SALES_ORDER
		{
			set{ _sales_order=value;}
			get{return _sales_order;}
		}
		/// <summary>
		/// 车间ID
		/// </summary>
		public string WORKSHOPID
		{
			set{ _workshopid=value;}
			get{return _workshopid;}
		}
		/// <summary>
		/// 加工中心ID
		/// </summary>
		public string MACHING_CENTERID
		{
			set{ _maching_centerid=value;}
			get{return _maching_centerid;}
		}
		/// <summary>
		/// 对应SCHEDULE_QTY  派工单数量
		/// </summary>
		public decimal? JOBQTY
		{
			set{ _jobqty=value;}
			get{return _jobqty;}
		}
		/// <summary>
		/// 不填  开工数量
		/// </summary>
		public decimal? JOB_STARTQTY
		{
			set{ _job_startqty=value;}
			get{return _job_startqty;}
		}
		/// <summary>
		/// 反填  完工数量
		/// </summary>
		public decimal? JOB_FINISHQTY
		{
			set{ _job_finishqty=value;}
			get{return _job_finishqty;}
		}
		/// <summary>
		/// 不填
		/// </summary>
		public decimal? JOB_DISQUANQTY
		{
			set{ _job_disquanqty=value;}
			get{return _job_disquanqty;}
		}
		/// <summary>
		/// 工艺路线Id
		/// </summary>
		public string ROUTINGID
		{
			set{ _routingid=value;}
			get{return _routingid;}
		}
		/// <summary>
		/// 排产日期
		/// </summary>
		public DateTime? JOB_SCHEDULE
		{
			set{ _job_schedule=value;}
			get{return _job_schedule;}
		}
		/// <summary>
		///  对应 PLAN_BEGIN 计划开工时间
		/// </summary>
		public DateTime? JOB_PLAN_ONLINE
		{
			set{ _job_plan_online=value;}
			get{return _job_plan_online;}
		}
		/// <summary>
		///  对应 PLAN_END 计划完工时间
		/// </summary>
		public DateTime? JOB_PLAN_OFFLINE
		{
			set{ _job_plan_offline=value;}
			get{return _job_plan_offline;}
		}
		/// <summary>
		/// 实际开工时间
		/// </summary>
		public DateTime? JOB_BEGIN
		{
			set{ _job_begin=value;}
			get{return _job_begin;}
		}
		/// <summary>
		/// 完工时间
		/// </summary>
		public DateTime? JOB_END
		{
			set{ _job_end=value;}
			get{return _job_end;}
		}
		/// <summary>
		/// 不用
		/// </summary>
		public decimal? JOB_TYPE
		{
			set{ _job_type=value;}
			get{return _job_type;}
		}
		/// <summary>
		/// 班组ID
		/// </summary>
		public string WORKTEAMID
		{
			set{ _workteamid=value;}
			get{return _workteamid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SN_CREAREMETHOD
		{
			set{ _sn_crearemethod=value;}
			get{return _sn_crearemethod;}
		}
		/// <summary>
		/// 工单描述 默认空
		/// </summary>
		public string JOB_DESCRIPTION
		{
			set{ _job_description=value;}
			get{return _job_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JOB_CODESTR
		{
			set{ _job_codestr=value;}
			get{return _job_codestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STACK_TYPE
		{
			set{ _stack_type=value;}
			get{return _stack_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SAP_ROUTENO
		{
			set{ _sap_routeno=value;}
			get{return _sap_routeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERGEBILLNOTYPE
		{
			set{ _mergebillnotype=value;}
			get{return _mergebillnotype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DIRECTORY_CODE
		{
			set{ _directory_code=value;}
			get{return _directory_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SAP_FACTORY
		{
			set{ _sap_factory=value;}
			get{return _sap_factory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_ORDER_ITEM
		{
			set{ _sales_order_item=value;}
			get{return _sales_order_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BASIC_BEGIN
		{
			set{ _basic_begin=value;}
			get{return _basic_begin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BASIC_END
		{
			set{ _basic_end=value;}
			get{return _basic_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OCCUPY_CODE
		{
			set{ _occupy_code=value;}
			get{return _occupy_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WORKORDER_TOTALQTY
		{
			set{ _workorder_totalqty=value;}
			get{return _workorder_totalqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORKORDER_UNIT
		{
			set{ _workorder_unit=value;}
			get{return _workorder_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MATERIAL_GROUP
		{
			set{ _material_group=value;}
			get{return _material_group;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MATERIAL_GROUP_DESC
		{
			set{ _material_group_desc=value;}
			get{return _material_group_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESIGN_COLOUR
		{
			set{ _design_colour=value;}
			get{return _design_colour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EDGE_TYPE
		{
			set{ _edge_type=value;}
			get{return _edge_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOOR_TYPE
		{
			set{ _door_type=value;}
			get{return _door_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALUM_EDGE_PVC
		{
			set{ _alum_edge_pvc=value;}
			get{return _alum_edge_pvc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SERIES
		{
			set{ _series=value;}
			get{return _series;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MACHING_CENTER_ELECSAW
		{
			set{ _maching_center_elecsaw=value;}
			get{return _maching_center_elecsaw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOSTANDARD_MERGEBILLNO
		{
			set{ _nostandard_mergebillno=value;}
			get{return _nostandard_mergebillno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CATALOG_CODE
		{
			set{ _catalog_code=value;}
			get{return _catalog_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BLOCK_QTY
		{
			set{ _block_qty=value;}
			get{return _block_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPLAIN_CONTENT
		{
			set{ _complain_content=value;}
			get{return _complain_content;}
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
		///  1 开始（手动开工）2 暂停 3完工 4下达
		/// </summary>
		public decimal? JOB_STATE
		{
			set{ _job_state=value;}
			get{return _job_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? KITTING_FLAG
		{
			set{ _kitting_flag=value;}
			get{return _kitting_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JOB_TORRNO
		{
			set{ _job_torrno=value;}
			get{return _job_torrno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MACHINE_VERSION
		{
			set{ _machine_version=value;}
			get{return _machine_version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENVIRONMENT_PROPERTY
		{
			set{ _environment_property=value;}
			get{return _environment_property;}
		}
		/// <summary>
		/// 库房ID 默认空
		/// </summary>
		public string STOREROOM_ID
		{
			set{ _storeroom_id=value;}
			get{return _storeroom_id;}
		}
		/// <summary>
		/// 库位ID默认空
		/// </summary>
		public string STORESITE_ID
		{
			set{ _storesite_id=value;}
			get{return _storesite_id;}
		}
		/// <summary>
		/// 工单属性  0正常、1特殊(0标准、1外协)  默认0 , 增加7 试制
		/// </summary>
		public decimal? JOB_PROPERTY
		{
			set{ _job_property=value;}
			get{return _job_property;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRODUCTING_AREA
		{
			set{ _producting_area=value;}
			get{return _producting_area;}
		}
		/// <summary>
		/// 优先级
		/// </summary>
		public string PRIORITY_LEVEL
		{
			set{ _priority_level=value;}
			get{return _priority_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_ORDERID
		{
			set{ _sales_orderid=value;}
			get{return _sales_orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PACK_TAGMARK
		{
			set{ _pack_tagmark=value;}
			get{return _pack_tagmark;}
		}
		/// <summary>
		/// 物料表的PRODUCTFORMATID 编码格式的ID
		/// </summary>
		public string PRODUCTFORMATID
		{
			set{ _productformatid=value;}
			get{return _productformatid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FACTORY_CODE
		{
			set{ _factory_code=value;}
			get{return _factory_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORI_FACTORY_FLAG
		{
			set{ _ori_factory_flag=value;}
			get{return _ori_factory_flag;}
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
		public string PACKAGE_REMARK
		{
			set{ _package_remark=value;}
			get{return _package_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOURCE_ARRIVALNO
		{
			set{ _source_arrivalno=value;}
			get{return _source_arrivalno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WRITER_AMT
		{
			set{ _writer_amt=value;}
			get{return _writer_amt;}
		}
		/// <summary>
		/// PO_JOB_SCHEDULE.ID
		/// </summary>
		public string PO_JOB_SCHEDULEID
		{
			set{ _po_job_scheduleid=value;}
			get{return _po_job_scheduleid;}
		}
		/// <summary>
		/// 模具领料单ID
		/// </summary>
		public string MATERIAL_APPLYID
		{
			set{ _material_applyid=value;}
			get{return _material_applyid;}
		}
		/// <summary>
		/// 包材领料单
		/// </summary>
		public string PACKBOM_APPLYID
		{
			set{ _packbom_applyid=value;}
			get{return _packbom_applyid;}
		}
		/// <summary>
		/// 班次ID
		/// </summary>
		public string WORKNUMBERID
		{
			set{ _worknumberid=value;}
			get{return _worknumberid;}
		}
		/// <summary>
		/// 已经回报SAP投入数量（专门用于上引回报投料）
		/// </summary>
		public decimal? HADTOSAP_QTY
		{
			set{ _hadtosap_qty=value;}
			get{return _hadtosap_qty;}
		}
		/// <summary>
		/// 已经回报SAP投入数量(用于钟罩炉投料)
		/// </summary>
		public decimal? HADTOSAP_INPUT
		{
			set{ _hadtosap_input=value;}
			get{return _hadtosap_input;}
		}
		/// <summary>
		/// 已经回报SAP产出数量(用于倒大中，电镀，半自动产出，钟罩炉)
		/// </summary>
		public decimal? HADTOSAP_OUTPUT
		{
			set{ _hadtosap_output=value;}
			get{return _hadtosap_output;}
		}
		/// <summary>
		/// 成品表面质量判定（等级维护在数据字典：质量等级中）
		/// </summary>
		public string QCLEVEL
		{
			set{ _qclevel=value;}
			get{return _qclevel;}
		}
		/// <summary>
		/// 是否生成包材需求计划(1生成)
		/// </summary>
		public decimal? ISCREATE_PACK
		{
			set{ _iscreate_pack=value;}
			get{return _iscreate_pack;}
		}
		/// <summary>
		/// 异常原因代码
		/// </summary>
		public string EXCEPTIONCAUSECODE
		{
			set{ _exceptioncausecode=value;}
			get{return _exceptioncausecode;}
		}
		/// <summary>
		/// 调整后计划量
		/// </summary>
		public decimal? ADJUSTEDPLANNINGQUANTITY
		{
			set{ _adjustedplanningquantity=value;}
			get{return _adjustedplanningquantity;}
		}
		/// <summary>
		/// 计划工作时长
		/// </summary>
		public decimal? WORKINGHOURSONLINE
		{
			set{ _workinghoursonline=value;}
			get{return _workinghoursonline;}
		}
		/// <summary>
		/// 调整时间
		/// </summary>
		public DateTime? ADJUSTMENTTIME
		{
			set{ _adjustmenttime=value;}
			get{return _adjustmenttime;}
		}
		/// <summary>
		/// 调整人
		/// </summary>
		public string ADJUSTS
		{
			set{ _adjusts=value;}
			get{return _adjusts;}
		}
		/// <summary>
		/// 锁定状态: 0/null 非锁定 1 锁定
		/// </summary>
		public decimal? LOCKED
		{
			set{ _locked=value;}
			get{return _locked;}
		}
		/// <summary>
		/// 派工单完成状态: 0/null 未完成 1 完成
		/// </summary>
		public decimal? JOBCOMPLETE_FLAG
		{
			set{ _jobcomplete_flag=value;}
			get{return _jobcomplete_flag;}
		}
		/// <summary>
		/// 成品表面不良现象
		/// </summary>
		public string QUALITYPROBLEM
		{
			set{ _qualityproblem=value;}
			get{return _qualityproblem;}
		}
		#endregion Model

	}
}

