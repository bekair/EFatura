using EFatura.Core.EntityBase;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

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
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("SURNAME")]
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Column("GENDER")]
        [Required]
        public Gender Gender { get; set; }

        [Column("DATE_OF_BIRTH")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column("MOBILE_PHONE")]
        [Required]
        [MaxLength(20)]
        public string MobilePhone { get; set; }

        [Column("JOB_PHONE")]
        [MaxLength(20)]
        public string JobPhone { get; set; }

        [Column("ADDRESS_ID_FOREIGN")]
        public long AddressID { get; set; }

        //Navigation Property
        public Address Address { get; set; }

        [Column("EMAIL")]
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

    }
}
