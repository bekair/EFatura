using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class IndividualManager : IndividualDAO
    {
        public IndividualManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
