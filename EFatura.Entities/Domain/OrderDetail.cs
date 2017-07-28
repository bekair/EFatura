using EFatura.Core.EntityBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("ORDER_DETAILS")]
    public class OrderDetail : BaseEntity
    {
        [Column("ORDER_DETAIL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("PRODUCT_ID_FOREIGN")]
        [Required]
        public long? ProductID { get; set; }

        //Navigation Property
        public Product Product { get; set; }

        [Column("ORDER_ID_FOREIGN")]
        [Required]
        public long? OrderID { get; set; }

        //Navigation Property
        public Order Order { get; set; }

        [Column("QUANTITY")]
        [Required]
        public int Quantity { get; set; }

        [Column("UNIT_PRICE")]
        [Required]
        public double UnitPrice { get; set; }

        [Column("TOTAL_PRICE")]
        [Required]
        public double TotalPrice { get; set; }

    }
}
