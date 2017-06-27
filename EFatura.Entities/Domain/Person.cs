using EFatura.Core.EntityBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFatura.Entities.Domain
{
    [Table("PEOPLE")]
    public class Person : BaseEntity
    {
        [Column("PERSON_ID_NUMBER")]
        //TCKNAttribute YAZ!!
        [MaxLength(11)]
        public override long ID { get => base.ID; set => base.ID = value; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("SURNAME")]
        public string Surname { get; set; }

        [Column("MOBILE_PHONE")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int MobilePhone { get; set; }

        [Column("JOB_PHONE")]
        [DataType(DataType.PhoneNumber)]
        public int JobPhone { get; set; }

        [Column("ADDRESS_ID_FOREIGN")]
        public long AddressID { get; set; }

        //Navigation Property
        public Address Address { get; set; } //virtual: Lazy Loading
    }
}
