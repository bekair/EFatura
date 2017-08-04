using EFatura.DataAccess.Base.EntityFramework;
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
