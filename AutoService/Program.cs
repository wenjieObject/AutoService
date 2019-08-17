using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BLL;
using DALFactory;
using Model;

namespace AutoService
{
    class Program
    {

        static void Main(string[] args)
        {
            //var dbSession = DBSessionFactory.CreateDbSession();
            //var model2 = PLAN_JOBDISPATCHBLL.LoadEntities(t => t.ID == "76e42a7f-52e7-4945-86b3-551c65cb27ca").FirstOrDefault();
            //model2.JOBNO = "634053";
            //PLAN_JOBDISPATCHBLL.EditEntity(model2);
            //if (dbSession.SaveChanges())
            //{
            //    Console.WriteLine("修改成功");
            //}
            //Console.WriteLine(model2.JOBNO);

            //var myContext= MyContext.CreateDbContext();

            //PLAN_JOBDISPATCH planJobdispatch = new PLAN_JOBDISPATCH();
            //planJobdispatch.ID = Guid.NewGuid().ToString();
            //planJobdispatch.CREATEDATE = DateTime.Now;

            //myContext.PLAN_JOBDISPATCHS.Add(planJobdispatch);
            //myContext.SaveChanges();

            //EF
            //var model1= myContext.Set<PLAN_JOBDISPATCH>().FirstOrDefault(t => t.ID == "bbb7e809-bbcc-4a01-b632-dd9e7c2a577d");
            //var model = myContext.Database.SqlQuery<string>(@" select table_name from user_tables ").ToList();

            //Console.WriteLine(model.JOBNO);
            //Console.WriteLine(model1.ID);
            PLAN_JOBDISPATCHBLL bll=new PLAN_JOBDISPATCHBLL();
            var model = bll.LoadEntities(t => t.ACTIVITY == 1).Take(1).FirstOrDefault();
            Console.WriteLine(model.JOBNO);
            Console.ReadLine();
        }
    }

 
 }
