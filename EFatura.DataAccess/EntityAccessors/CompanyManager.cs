using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CompanyManager : CompanyDAO
    {
        public CompanyManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
