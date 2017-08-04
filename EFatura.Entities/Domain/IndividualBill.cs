using EFatura.Entities.OtherEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("INDIVIDUAL_BILLS")]
    public class IndividualBill : Bill
    {
        [Column("INDIVIDUAL_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("ORDER_ID_FOREIGN")]
        public long? OrderID { get; set; }

        //Navigation Property
        public IEnumerable<Order> Order { get; set; }
    }
}
