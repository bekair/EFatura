using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;


namespace EFatura.DataAccess.Base.EntityFramework
{
    public class CountyDAO : EFRepositoryBase<County, EFaturaDbContext>, ICountyDAO
    {
        public CountyDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
