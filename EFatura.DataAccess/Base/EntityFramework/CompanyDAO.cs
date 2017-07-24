using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class CompanyDAO : EFRepositoryBase<Company, EFaturaDbContext>, ICompanyDAO
    {
        public CompanyDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
