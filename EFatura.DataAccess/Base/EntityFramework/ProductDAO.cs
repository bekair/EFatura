using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class ProductDAO : EFRepositoryBase<Product, EFaturaDbContext>, IProductDAO
    {
        public ProductDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
