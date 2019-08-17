using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
//using DALFactory;

namespace CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {

            var myContext = MyContext.CreateDbContext();
            //var models = myContext.Database.SqlQuery<string>(@" select table_name from user_tables ").ToList();


            var names = new List<string>() { "BDTA_INSPECT_STANDARD", "BDTA_INSPECT_STANDARD_DETAIL", "BDTA_PARTNER", "PLAN_JOBDISPATCH", "BDTA_SETUP", "PO_WORKORDER", "QA_INSPECT_BILL", "QA_INSPECT_BILL_DETAIL", "SALESORDER" };

            GenerateIDal(names, true);
            GenerateDal(names, true);
            GenerateMyContext(names, true);
            GenerateDBSession(names, true);
            Console.ReadLine();
        }

        private static void GenerateDBSession(List<string> tableNames, bool ifExsitedCovered = true)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("CodeGeneration\\bin\\Debug", "");
            baseDirectory = baseDirectory.Replace("CodeGeneration\\bin\\Release", "");
            var iRepositoryPath = baseDirectory + "DALFactory";

            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + "\\" + "DBSessionPart.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var dBSession = ReadTemplate("DBSession.txt");
            var dBSessionPart = ReadTemplate("DBSessionPart.txt");

            var result = "";
            foreach (var tableName in tableNames)
            {
                var tmp = dBSessionPart.Replace("{modelName}", tableName);
                result += tmp + "\n";
            }

            dBSession = dBSession.Replace("{content}", result);
            WriteAndSave(fullPath, dBSession);
        }

        private static void GenerateMyContext(List<string> tableNames , bool ifExsitedCovered = true)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("CodeGeneration\\bin\\Debug", "");
            baseDirectory = baseDirectory.Replace("CodeGeneration\\bin\\Release", "");
            var iRepositoryPath = baseDirectory + "DAL\\MyContextFile";

            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + "\\" + "MyContext.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyContext.txt");

            var result = "";
            string functionStr = " public DbSet<{ModelName}> {ModelName}S { get; set; }" ;

            foreach (var tableName in tableNames)
            {
                var tmp = functionStr.Replace("{ModelName}", tableName);
                result += tmp + "\n";
            }

            content = content.Replace("{DbSetModelName}", result);
            WriteAndSave(fullPath, content);
        }

        private static void GenerateDal(List<string> tableNames, bool ifExsitedCovered = true)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("CodeGeneration\\bin\\Debug", "");
            baseDirectory = baseDirectory.Replace("CodeGeneration\\bin\\Release", "");
            var iRepositoryPath = baseDirectory + "DAL";

            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + "\\EntityDal.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;

            var content = ReadTemplate("DalTemplate.txt");
            var functionStr = " public partial class {ModelName}Dal : BaseDal<{ModelName}>, I{ModelName}Dal { } ";
            var result = "";

            foreach (var tableName in tableNames)
            {
                var tmp = functionStr.Replace("{ModelName}", tableName);
                result += tmp + "\n";
            }

            content = content.Replace("{DalTemplateName}", result);
            WriteAndSave(fullPath, content);
        }

        private static void GenerateIDal(List<string> tableNames, bool ifExsitedCovered = true)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("CodeGeneration\\bin\\Debug", "");
            baseDirectory = baseDirectory.Replace("CodeGeneration\\bin\\Release", ""); 
            var iRepositoryPath =  baseDirectory+"IDAL";

            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + "\\IEntityDal.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;

            var functionStr = " public partial interface I{ModelName}Dal : IBaseDal<{ModelName}> {} ";
            string result = "";
            var content = ReadTemplate("IDalTemplate.txt");

            foreach (var tableName in tableNames)
            {
                var tmp = functionStr.Replace("{ModelName}", tableName);
                result += tmp + "\n";
            }

            content = content.Replace("{IDalTemplateName}", result);
            WriteAndSave(fullPath, content);
        }

                /// <summary>
        /// 从代码模板中读取内容
        /// </summary>
        /// <param name="templateName">模板名称，应包括文件扩展名称。比如：template.txt</param>
        /// <returns></returns>
        private static string ReadTemplate(string templateName)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var content = string.Empty;
            using (var stream = currentAssembly.GetManifestResourceStream(string.Format("{0}.CodeTemplate.{1}",currentAssembly.GetName().Name,templateName)))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                    }
                }
            }
            return content;
        }


        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        private static void WriteAndSave(string fileName, string content)
        {
            //实例化一个文件流--->与写入文件相关联
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                //实例化一个StreamWriter-->与fs相关联
                using (var sw = new StreamWriter(fs))
                {
                    //开始写入
                    sw.Write(content);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }



    }
}
