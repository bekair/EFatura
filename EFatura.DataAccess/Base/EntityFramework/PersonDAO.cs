using EFatura.Core.RepositoryBase.EntityFramework;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.DataAccess.Base.EntityFramework
{
    public abstract class PersonDAO : EFRepositoryBase<Person, EFaturaDbContext>, IPersonDAO
    {
        public PersonDAO(EFaturaDbContext context) 
            : base(context)
        {
        }
    }
}
