using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class CategoryManager : CategoryDAO
    {
        public CategoryManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
