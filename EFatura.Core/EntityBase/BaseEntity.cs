using System.ComponentModel.DataAnnotations;

namespace EFatura.Core.EntityBase
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public virtual long? ID { get; set; }
    }
}
