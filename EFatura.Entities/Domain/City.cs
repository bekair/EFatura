using EFatura.Core.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("CITIES")]
    public class City : BaseEntity
    {
        [Column("CITY_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("CITY_NAME")]
        public string CityName { get; set; }

        //Navigation Property
        public IEnumerable<County> Counties { get; set; }

        [Column("COUNTRY_ID_FOREIGN")]
        [Required]
        public long? CountryID { get; set; }

        //Navigation Property
        public Country Country { get; set; }
    }
}