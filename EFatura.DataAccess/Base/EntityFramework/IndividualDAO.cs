using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class IndividualDAO : EFRepositoryBase<Individual, EFaturaDbContext>, IIndividualDAO
    {
        public IndividualDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
