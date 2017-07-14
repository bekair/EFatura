using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class PersonManager : PersonDAO
    {
        public PersonManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
