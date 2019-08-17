/**  版本信息模板在安装目录下，可自行修改。
* SALESORDER.cs
*
* 功 能： N/A
* 类 名： SALESORDER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:28   N/A    初版
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
	/// 销售订单
	/// </summary>
	[Serializable]
	public partial class SALESORDER
	{
		public SALESORDER()
		{}
		#region Model
		private string _id;
		private string _sales_order;
		private string _ending_customer;
		private string _city;
		private string _province_code;
		private string _province_name;
		private string _carrier;
		private string _sales_remark;
		private string _case_qty;
		private string _customer_short;
		private string _sales_org;
		private string _sales_org_desc;
		private string _distribution_channel;
		private string _distribution_channel_desc;
		private string _product_group;
		private string _product_group_desc;
		private string _crm_so;
		private DateTime? _order_delivery_time;
		private string _order_reason;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _activity;
		private string _suite_number;
		private string _despatch_factory;
		private decimal? _suite_total;
		private decimal? _suite_seqno;
		private string _so_contract_no;
		private string _so_contract_type;
		private DateTime? _so_arrival_date;
		private string _so_item_name;
		private string _sales_people;
		private string _so_remark;
		private string _salesorder_type;
		private string _sales_grp;
		private string _partn_numb;
		private DateTime? _req_date_h;
		private string _partn_numbs;
		private string _customer_grp;
		private string _create_people;
		private string _po_number;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 销售订单号
		/// </summary>
		public string SALES_ORDER
		{
			set{ _sales_order=value;}
			get{return _sales_order;}
		}
		/// <summary>
		/// 客户号
		/// </summary>
		public string ENDING_CUSTOMER
		{
			set{ _ending_customer=value;}
			get{return _ending_customer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CITY
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROVINCE_CODE
		{
			set{ _province_code=value;}
			get{return _province_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROVINCE_NAME
		{
			set{ _province_name=value;}
			get{return _province_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CARRIER
		{
			set{ _carrier=value;}
			get{return _carrier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_REMARK
		{
			set{ _sales_remark=value;}
			get{return _sales_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CASE_QTY
		{
			set{ _case_qty=value;}
			get{return _case_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOMER_SHORT
		{
			set{ _customer_short=value;}
			get{return _customer_short;}
		}
		/// <summary>
		/// 销售组织
		/// </summary>
		public string SALES_ORG
		{
			set{ _sales_org=value;}
			get{return _sales_org;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_ORG_DESC
		{
			set{ _sales_org_desc=value;}
			get{return _sales_org_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISTRIBUTION_CHANNEL
		{
			set{ _distribution_channel=value;}
			get{return _distribution_channel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISTRIBUTION_CHANNEL_DESC
		{
			set{ _distribution_channel_desc=value;}
			get{return _distribution_channel_desc;}
		}
		/// <summary>
		/// 销售组
		/// </summary>
		public string PRODUCT_GROUP
		{
			set{ _product_group=value;}
			get{return _product_group;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRODUCT_GROUP_DESC
		{
			set{ _product_group_desc=value;}
			get{return _product_group_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRM_SO
		{
			set{ _crm_so=value;}
			get{return _crm_so;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ORDER_DELIVERY_TIME
		{
			set{ _order_delivery_time=value;}
			get{return _order_delivery_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORDER_REASON
		{
			set{ _order_reason=value;}
			get{return _order_reason;}
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
		public string SUITE_NUMBER
		{
			set{ _suite_number=value;}
			get{return _suite_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESPATCH_FACTORY
		{
			set{ _despatch_factory=value;}
			get{return _despatch_factory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SUITE_TOTAL
		{
			set{ _suite_total=value;}
			get{return _suite_total;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SUITE_SEQNO
		{
			set{ _suite_seqno=value;}
			get{return _suite_seqno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SO_CONTRACT_NO
		{
			set{ _so_contract_no=value;}
			get{return _so_contract_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SO_CONTRACT_TYPE
		{
			set{ _so_contract_type=value;}
			get{return _so_contract_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SO_ARRIVAL_DATE
		{
			set{ _so_arrival_date=value;}
			get{return _so_arrival_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SO_ITEM_NAME
		{
			set{ _so_item_name=value;}
			get{return _so_item_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_PEOPLE
		{
			set{ _sales_people=value;}
			get{return _sales_people;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SO_REMARK
		{
			set{ _so_remark=value;}
			get{return _so_remark;}
		}
		/// <summary>
		/// 销售订单类型（SAP传入）
		/// </summary>
		public string SALESORDER_TYPE
		{
			set{ _salesorder_type=value;}
			get{return _salesorder_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALES_GRP
		{
			set{ _sales_grp=value;}
			get{return _sales_grp;}
		}
		/// <summary>
		/// 送达方（根据合作伙伴功能区分）
		/// </summary>
		public string PARTN_NUMB
		{
			set{ _partn_numb=value;}
			get{return _partn_numb;}
		}
		/// <summary>
		/// 交货日期
		/// </summary>
		public DateTime? REQ_DATE_H
		{
			set{ _req_date_h=value;}
			get{return _req_date_h;}
		}
		/// <summary>
		/// 售达方（根据合作伙伴功能区分）
		/// </summary>
		public string PARTN_NUMBS
		{
			set{ _partn_numbs=value;}
			get{return _partn_numbs;}
		}
		/// <summary>
		/// 客户组
		/// </summary>
		public string CUSTOMER_GRP
		{
			set{ _customer_grp=value;}
			get{return _customer_grp;}
		}
		/// <summary>
		/// 销售订单创建人
		/// </summary>
		public string CREATE_PEOPLE
		{
			set{ _create_people=value;}
			get{return _create_people;}
		}
		/// <summary>
		/// 客户采购订单
		/// </summary>
		public string PO_NUMBER
		{
			set{ _po_number=value;}
			get{return _po_number;}
		}
		#endregion Model

	}
}

