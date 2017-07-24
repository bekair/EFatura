using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;


namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class OrderDAO : EFRepositoryBase<Order, EFaturaDbContext>, IOrderDAO
    {
        public OrderDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
