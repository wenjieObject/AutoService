using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;

namespace BLL
{
    public class BaseBLL
    {
        public DBSession DbSession
        {
            get
            {
                return DBSessionFactory.CreateDbSession();
            }
        }

    }
}
