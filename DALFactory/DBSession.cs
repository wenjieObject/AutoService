using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DALFactory
{
    public partial class DBSession
    {
        public MyContext Db
        {
            get
            {
                return MyContext.CreateDbContext();
            }
        }

        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }

        private static readonly string AssemblyPath = "DAL";

        #region 泛型生成
        /// <summary>
        /// 创建数据层接口。
        /// </summary>  
        public static T Create<T>(string ClassName)
        {
            string ClassNamespace = AssemblyPath + "." + ClassName;
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (T)objType;
        }

        #endregion

        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = DataCache.GetCache(classNamespace);
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                    DataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
    }

    public class DBSessionFactory
    {
        public static DBSession CreateDbSession()
        {
            DBSession dbSession = (DBSession)CallContext.GetData("dbSession");
            if (dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData("dbSession", dbSession);
            }
            return dbSession;
        }
    }
}
