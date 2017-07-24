using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;


namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class OrderDetailDAO : EFRepositoryBase<OrderDetail, EFaturaDbContext>, IOrderDetailDAO
    {
        public OrderDetailDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
