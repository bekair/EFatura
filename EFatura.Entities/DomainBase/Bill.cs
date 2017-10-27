using EFatura.Core.EntityBase;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.OtherEntities
{
    public abstract class Bill : BaseEntity
    {
        [Column("ORDER_ID_FOREIGN")]
        [Required]
        public long? OrderID { get; set; }

        //Navigation Property
        public IEnumerable<Order> Order { get; set; }

        [Column("SCENARIO_TYPE")]
        [Required]
        public virtual ScenarioType Scenario { get; set; }

        [Column("CREATION_DATE")]
        [Required]
        public string CreationDate
        {
            get => CreationDate;
            set => value = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        [Column("BILL_TYPE")]
        [Required]
        public BillType BillType { get; set; }
    }
}

