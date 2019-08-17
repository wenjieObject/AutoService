using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class MyContext : DbContext
    {

        public MyContext()
            : base("name=OracleDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("R2E5FOUNDATION");
        }

        public static MyContext CreateDbContext()
        {
            MyContext dbContext = (MyContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new MyContext();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }

    }
}
