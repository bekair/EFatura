using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CountryManager : CountryDAO
    {
        public CountryManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
