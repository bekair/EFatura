using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CityManager : CityDAO
    {
        public CityManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
