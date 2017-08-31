using EFatura.Entities.OtherEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("INDIVIDUAL_BILLS")]
    public class IndividualBill : Bill
    {
        [Column("INDIVIDUAL_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }


    }
}
