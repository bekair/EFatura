using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public class CategoryDAO : EFRepositoryBase<Category, EFaturaDbContext>, ICategoryDAO
    {
        public CategoryDAO(EFaturaDbContext context)
            : base(context)
        {
        }
    }
}
