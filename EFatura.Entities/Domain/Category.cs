using System.Collections.Generic;
using EFatura.Core.EntityBase;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.Domain
{
    [Table("CATEGORIES")]
    public class Category : BaseEntity
    {
        [Column("CATEGORY_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("TOP_CATEGORY")]//TOP_CATEGORY_ID
        [Required]
        public long? TopCategoryID { get; set; } = 0; //Default is '0' = top category.

        [Column("CATEGORY_NAME")]
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        //Navigation Property
        public IEnumerable<Product> Products { get; set; }
    }
}
