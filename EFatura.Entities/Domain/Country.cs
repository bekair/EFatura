using EFatura.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.Entities.Domain
{
    [Table("COUNTRIES")]
    public class Country : BaseEntity
    {
        [Column("COUNTRY_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long ID { get => base.ID; set => base.ID = value; }

        [Column("COUNTRY_NAME")]
        [Required]
        public string CountryName { get; set; }

        //Navigation Property
        public IEnumerable<City> Cities { get; set; }
    }
}
