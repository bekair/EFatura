using EFatura.Core.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("ADDRESSES")]
    public class Address : BaseEntity
    {
        [Column("ADDRESS_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("NEIGHBOURHOOD")]
        [Required]
        public string Neighbourhood { get; set; } //Neighbourhood => Mahalle

        [Column("AVENUE")]
        public string Avenue { get; set; } //Avenue => Cadde

        [Column("STREET")]
        public string Street { get; set; }

        [Column("BUILDING_NAME")]
        public string BuildingName { get; set; }

        [Column("BUILDING_NUMBER")]
        [Required]
        public int BuildingNumber { get; set; }

        [Column("DOOR_NUMBER")]
        [Required]
        public int DoorNumber { get; set; }

        [Column("POSTAL_CODE")]
        public string PostalCode { get; set; }

        [Column("COUNTRY_ID_FOREIGN")]
        public long? CountryID { get; set; }

        //Navigation Property
        public Country Country { get; set; }

        [Column("CITY_ID_FOREIGN")]
        [Required]
        public long? CityID { get; set; }

        //Navigation Property
        public City City { get; set; }

        [Column("COUNTY_ID_FOREIGN")]
        [Required]
        public long? CountyID { get; set; }

        //Navigation Property
        public County County { get; set; }

        [Column("DISTRICT")]
        //[Required]
        public string District { get; set; } //District => Semt

        //Navigation Property
        public IEnumerable<Individual> People { get; set; }

    }
}
