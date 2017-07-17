using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class ProductManager : ProductDAO
    {
        public ProductManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
