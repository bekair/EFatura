using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class OrderManager : OrderDAO
    {
        public OrderManager(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
