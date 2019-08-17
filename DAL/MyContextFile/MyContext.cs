using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class MyContext
    {
	
 public DbSet<BDTA_INSPECT_STANDARD> BDTA_INSPECT_STANDARDS { get; set; }
 public DbSet<BDTA_INSPECT_STANDARD_DETAIL> BDTA_INSPECT_STANDARD_DETAILS { get; set; }
 public DbSet<BDTA_PARTNER> BDTA_PARTNERS { get; set; }
 public DbSet<PLAN_JOBDISPATCH> PLAN_JOBDISPATCHS { get; set; }
 public DbSet<BDTA_SETUP> BDTA_SETUPS { get; set; }
 public DbSet<PO_WORKORDER> PO_WORKORDERS { get; set; }
 public DbSet<QA_INSPECT_BILL> QA_INSPECT_BILLS { get; set; }
 public DbSet<QA_INSPECT_BILL_DETAIL> QA_INSPECT_BILL_DETAILS { get; set; }
 public DbSet<SALESORDER> SALESORDERS { get; set; }


    }
}