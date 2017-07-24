using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class CountryDAO : EFRepositoryBase<Country, EFaturaDbContext>, ICountryDAO
    {
        public CountryDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
