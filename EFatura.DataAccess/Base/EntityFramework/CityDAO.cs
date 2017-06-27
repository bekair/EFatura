using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;


namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class CityDAO : EFRepositoryBase<City, EFaturaDbContext>, ICityDAO
    {
        public CityDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
