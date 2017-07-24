using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class OrderDetailManager : OrderDetailDAO
    {
        public OrderDetailManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
