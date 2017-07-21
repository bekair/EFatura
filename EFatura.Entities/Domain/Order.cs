using EFatura.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.Entities.Domain
{
    [Table("ORDERS")]
    public class Order : BaseEntity
    {
        [Column("ORDER_ID")]
        public override long ID { get => base.ID; set => base.ID = value; }

        [Column("ORDER_PRODUCT_ID_FOREIGN")]
        public long OrderProductID { get; set; }

        //Navigation Property
        public List<OrderProduct> OrderDetails { get; set; }

    }
}
