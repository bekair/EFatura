using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class CorporateBillDAO : EFRepositoryBase<CorporateBill, EFaturaDbContext>, ICorporateBillDAO
    {
        public CorporateBillDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
