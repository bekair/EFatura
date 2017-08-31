using EFatura.Core.EntityBase;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.OtherEntities
{
    public class Bill : BaseEntity
    {
        [Column("ORDER_ID_FOREIGN")]
        public long? OrderID { get; set; }

        //Navigation Property
        public IEnumerable<Order> Order { get; set; }

        [Column("BILL_DATE")]
        public DateTime BillDate { get => BillDate; set => value = DateTime.Today; }

        [Column("SCENARIO_TYPE")]
        public ScenarioType Scenario { get; set; }

    }
}
