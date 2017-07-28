using EFatura.DataAccess.Base.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class IndividualBillManager : IndividualBillDAO
    {
        public IndividualBillManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
