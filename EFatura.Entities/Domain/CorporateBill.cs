using EFatura.Entities.OtherEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("CORPORATE_BILLS")]
    public class CorporateBill : Bill
    {
        [Column("CORPORATE_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }


    }
}
