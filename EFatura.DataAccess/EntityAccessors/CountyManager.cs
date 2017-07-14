using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CountyManager : CountyDAO
    {
        public CountyManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
