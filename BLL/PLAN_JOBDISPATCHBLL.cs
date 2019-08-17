using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using Model;

namespace BLL
{
    public class PLAN_JOBDISPATCHBLL : BaseBLL
    {        
        public IQueryable<PLAN_JOBDISPATCH> LoadEntities(System.Linq.Expressions.Expression<Func<PLAN_JOBDISPATCH, bool>> whereLambda)
        {
            return DbSession.PLAN_JOBDISPATCHDal.LoadEntities(whereLambda);
        }

        public bool EditEntity(PLAN_JOBDISPATCH PLAN_JOBDISPATCH)
        {
            DbSession.PLAN_JOBDISPATCHDal.EditEntity(PLAN_JOBDISPATCH);
            return DbSession.SaveChanges();
        }
    }
}
