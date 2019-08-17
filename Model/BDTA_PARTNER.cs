/**  版本信息模板在安装目录下，可自行修改。
* BDTA_PARTNER.cs
*
* 功 能： N/A
* 类 名： BDTA_PARTNER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/8/15 14:46:04   N/A    初版
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
	/// 供应商表
	/// </summary>
	[Serializable]
	public partial class BDTA_PARTNER
	{
		public BDTA_PARTNER()
		{}
		#region Model
		private string _id;
		private string _parno;
		private string _parname;
		private string _partype;
		private string _parcharger;
		private string _partelephone;
		private string _partax;
		private string _parmail;
		private string _paraddress;
		private string _parprovince;
		private string _parpostcode;
		private decimal? _issystem;
		private string _partnerdesc;
		private decimal? _dataversion;
		private DateTime? _createdate;
		private string _creater;
		private DateTime? _updatedate;
		private string _updater;
		private string _extendfield;
		private decimal? _isused;
		private decimal? _activity;
		private decimal? _up2standard;
		private string _supplier_class;
		private string _supplier_type;
		private string _hsf;
		private string _product_type;
		private string _grade;
		private decimal? _state;
		private string _remark;
		private string _country;
		private string _city;
		private string _area;
		private string _street;
		private string _fixed_telephone;
		private string _product_level;
		private string _shipping_mark;
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
		public string PARNO
		{
			set{ _parno=value;}
			get{return _parno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARNAME
		{
			set{ _parname=value;}
			get{return _parname;}
		}
		/// <summary>
		/// 类型：S 供应商C 客户M制造商
		/// </summary>
		public string PARTYPE
		{
			set{ _partype=value;}
			get{return _partype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARCHARGER
		{
			set{ _parcharger=value;}
			get{return _parcharger;}
		}
		/// <summary>
		/// 移动电话
		/// </summary>
		public string PARTELEPHONE
		{
			set{ _partelephone=value;}
			get{return _partelephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARTAX
		{
			set{ _partax=value;}
			get{return _partax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARMAIL
		{
			set{ _parmail=value;}
			get{return _parmail;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string PARADDRESS
		{
			set{ _paraddress=value;}
			get{return _paraddress;}
		}
		/// <summary>
		/// 省
		/// </summary>
		public string PARPROVINCE
		{
			set{ _parprovince=value;}
			get{return _parprovince;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string PARPOSTCODE
		{
			set{ _parpostcode=value;}
			get{return _parpostcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ISSYSTEM
		{
			set{ _issystem=value;}
			get{return _issystem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARTNERDESC
		{
			set{ _partnerdesc=value;}
			get{return _partnerdesc;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? UP2STANDARD
		{
			set{ _up2standard=value;}
			get{return _up2standard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLIER_CLASS
		{
			set{ _supplier_class=value;}
			get{return _supplier_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLIER_TYPE
		{
			set{ _supplier_type=value;}
			get{return _supplier_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HSF
		{
			set{ _hsf=value;}
			get{return _hsf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRODUCT_TYPE
		{
			set{ _product_type=value;}
			get{return _product_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRADE
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? STATE
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 国家
		/// </summary>
		public string COUNTRY
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 城市
		/// </summary>
		public string CITY
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 区
		/// </summary>
		public string AREA
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 街道
		/// </summary>
		public string STREET
		{
			set{ _street=value;}
			get{return _street;}
		}
		/// <summary>
		/// 固定电话
		/// </summary>
		public string FIXED_TELEPHONE
		{
			set{ _fixed_telephone=value;}
			get{return _fixed_telephone;}
		}
		/// <summary>
		/// 产品等级
		/// </summary>
		public string PRODUCT_LEVEL
		{
			set{ _product_level=value;}
			get{return _product_level;}
		}
		/// <summary>
		/// 唛头编码取自数据字典的DIC_NO
		/// </summary>
		public string SHIPPING_MARK
		{
			set{ _shipping_mark=value;}
			get{return _shipping_mark;}
		}
		#endregion Model

	}
}

