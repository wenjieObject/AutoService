using System;
using System.Reflection;
using System.Configuration;
using AutoService.IDAL;
namespace AutoService.DALFactory
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口) 
	/// DataCache类在导出代码的文件夹里
	/// <appSettings> 
	/// <add key="DAL" value="AutoService.OracleDAL" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess//<t>
	{
		private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string AssemblyPath,string ClassNamespace)
		{
			object objType = DataCache.GetCache(ClassNamespace);//从缓存读取
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(ClassNamespace);//反射创建
					DataCache.SetCache(ClassNamespace, objType);// 写入缓存
				}
				catch
				{}
			}
			return objType;
		}
		/// <summary>
		/// 创建数据层接口
		/// </summary>
		//public static t Create(string ClassName)
		//{
			//string ClassNamespace = AssemblyPath +"."+ ClassName;
			//object objType = CreateObject(AssemblyPath, ClassNamespace);
			//return (t)objType;
		//}
		/// <summary>
		/// 创建BDTA_INSPECT_STANDARD数据层接口。检验标准维护（组套）
		/// </summary>
		public static AutoService.IDAL.IBDTA_INSPECT_STANDARD CreateBDTA_INSPECT_STANDARD()
		{

			string ClassNamespace = AssemblyPath +".BDTA_INSPECT_STANDARD";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IBDTA_INSPECT_STANDARD)objType;
		}


		/// <summary>
		/// 创建BDTA_INSPECT_STANDARD_DETAIL数据层接口。检验标准明细
		/// </summary>
		public static AutoService.IDAL.IBDTA_INSPECT_STANDARD_DETAIL CreateBDTA_INSPECT_STANDARD_DETAIL()
		{

			string ClassNamespace = AssemblyPath +".BDTA_INSPECT_STANDARD_DETAIL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IBDTA_INSPECT_STANDARD_DETAIL)objType;
		}

		/// <summary>
		/// 创建BDTA_PARTNER数据层接口。供应商表
		/// </summary>
		public static AutoService.IDAL.IBDTA_PARTNER CreateBDTA_PARTNER()
		{

			string ClassNamespace = AssemblyPath +".BDTA_PARTNER";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IBDTA_PARTNER)objType;
		}

		/// <summary>
		/// 创建BDTA_SETUP数据层接口。
		/// </summary>
		public static AutoService.IDAL.IBDTA_SETUP CreateBDTA_SETUP()
		{

			string ClassNamespace = AssemblyPath +".BDTA_SETUP";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IBDTA_SETUP)objType;
		}

		/// <summary>
		/// 创建PLAN_JOBDISPATCH数据层接口。派工单
		/// </summary>
		public static AutoService.IDAL.IPLAN_JOBDISPATCH CreatePLAN_JOBDISPATCH()
		{

			string ClassNamespace = AssemblyPath +".PLAN_JOBDISPATCH";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IPLAN_JOBDISPATCH)objType;
		}

		/// <summary>
		/// 创建PO_WORKORDER数据层接口。生产订单
		/// </summary>
		public static AutoService.IDAL.IPO_WORKORDER CreatePO_WORKORDER()
		{

			string ClassNamespace = AssemblyPath +".PO_WORKORDER";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IPO_WORKORDER)objType;
		}

		/// <summary>
		/// 创建QA_INSPECT_BILL数据层接口。检验单表
		/// </summary>
		public static AutoService.IDAL.IQA_INSPECT_BILL CreateQA_INSPECT_BILL()
		{

			string ClassNamespace = AssemblyPath +".QA_INSPECT_BILL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IQA_INSPECT_BILL)objType;
		}

		/// <summary>
		/// 创建QA_INSPECT_BILL_DETAIL数据层接口。检验单明细
		/// </summary>
		public static AutoService.IDAL.IQA_INSPECT_BILL_DETAIL CreateQA_INSPECT_BILL_DETAIL()
		{

			string ClassNamespace = AssemblyPath +".QA_INSPECT_BILL_DETAIL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.IQA_INSPECT_BILL_DETAIL)objType;
		}

		/// <summary>
		/// 创建SALESORDER数据层接口。销售订单
		/// </summary>
		public static AutoService.IDAL.ISALESORDER CreateSALESORDER()
		{

			string ClassNamespace = AssemblyPath +".SALESORDER";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (AutoService.IDAL.ISALESORDER)objType;
		}

}
}