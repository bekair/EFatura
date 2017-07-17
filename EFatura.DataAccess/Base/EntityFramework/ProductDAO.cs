using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public class ProductDAO : EFRepositoryBase<Product, EFaturaDbContext>, IProductDAO
    {
        public ProductDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
