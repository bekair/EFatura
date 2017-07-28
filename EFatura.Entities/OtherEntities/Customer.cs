using EFatura.Core.EntityBase;
using EFatura.Entities.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.OtherEntities
{
    public abstract class Customer : BaseEntity
    {
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("ADDRESS_ID_FOREIGN")]
        [Required]
        public long? AddressID { get; set; }

        //Navigation Property
        public Address Address { get; set; }

        [Column("TAX_IDENTIFICATION_NO")]
        [Required]
        [StringLength(20)]
        public string TaxIdentificationNo { get; set; } //TaxIdentificationNo => Vergi Kimlik Numarası (VKN)

        [Column("CUSTOMER_TYPE")]
        public virtual CustomerType CustomerType { get; set; }
    }
}
