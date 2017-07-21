using EFatura.Core.EntityBase;
using EFatura.Entities.OtherEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.Domain
{
    [Table("ORDER_PRODUCTS")]
    public class OrderProduct : BaseEntity
    {
        [Column("ORDER_PRODUCT_ID")]
        public override long ID { get => base.ID; set => base.ID = value; }

        [Column("CUSTOMER_ID_FOREIGN")]
        public Customer CustomerID { get; set; }

        //Navigation Property
        public Customer Customer { get; set; }

        [Column("PRODUCT_ID_FOREIGN")]
        public long ProductID { get; set; }

        //Navigation Property
        public Product Product { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("TOTAL_PRICE")]
        public double TotalPrice { get; set; }

        [Column("CUSTOMER_TYPE")]
        public CustomerType CustomerType { get; set; }
    }
}
