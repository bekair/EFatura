using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;

namespace EFatura.DataAccess.EntityAccessors
{
    public class AddressManager : AddressDAO
    {
        public AddressManager(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
