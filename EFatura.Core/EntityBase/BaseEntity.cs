using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFatura.Core.EntityBase
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public virtual long ID { get; set; }
    }
}
