using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class IndividualBillDAO : EFRepositoryBase<IndividualBill, EFaturaDbContext>, IIndividualBillDAO
    {
        public IndividualBillDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
