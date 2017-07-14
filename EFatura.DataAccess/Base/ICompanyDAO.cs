using EFatura.Core.RepositoryBase;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.DataAccess.Base
{
    public interface ICompanyDAO : IRepository<Company>
    {
    }
}
