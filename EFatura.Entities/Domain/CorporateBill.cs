using EFatura.Entities.OtherEntities;
using System.ComponentModel.DataAnnotations.Schema;
using static EFatura.Core.EnumBase.EnumsArea;

namespace EFatura.Entities.Domain
{
    [Table("CORPORATE_BILLS")]
    public class CorporateBill : Bill
    {
        [Column("CORPORATE_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        //This variable will be nullable, when its Scenario = Commercial this wont be empty
        [Column("COMMERCIAL_SCENARIO_STATUS")]
        public CommercialScenarioStatus CommercialScenarioStatus { get; set; }
    }
}
