using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CorporateBillManager : CorporateBillDAO
    {
        public CorporateBillManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
