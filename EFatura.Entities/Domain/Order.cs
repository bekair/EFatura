using EFatura.Core.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("ORDERS")]
    public class Order : BaseEntity
    {
        [Column("ORDER_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("INDIVIDUAL_ID_FOREIGN")]
        public long? IndividualID { get; set; }

        //Navigation Property
        public Individual Individual { get; set; }

        [Column("COMPANY_ID_FOREIGN")]
        public long? CompanyID { get; set; }

        //Navigation Property
        public Company Company { get; set; }

        //Navigation Property
        public IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
