using EFatura.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.OtherEntities
{
    public class Customer : BaseEntity
    {
        public virtual CustomerType CustomerType { get; set; }
    }
}
