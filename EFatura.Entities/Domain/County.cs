using EFatura.Core.EntityBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFatura.Entities.Domain
{
    [Table("COUNTIES")]
    public class County : BaseEntity
    {
        [Column("COUNTY_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long ID { get => base.ID; set => base.ID = value; }

        [Column("COUNTY_NAME")]
        [Required]
        public string CountyName { get; set; } //County:İlçe

        [Column("CITY_ID_FOREIGN")]
        public long CityID { get; set; }

        //Navigation Property
        public City City { get; set; }
        
    }
}