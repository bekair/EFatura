using EFatura.Entities.OtherEntities;
using System.ComponentModel.DataAnnotations.Schema;
using EFatura.Core.EnumBase;
using static EFatura.Core.EnumBase.EnumsArea;
using System.ComponentModel.DataAnnotations;

namespace EFatura.Entities.Domain
{
    [Table("INDIVIDUAL_BILLS")]
    public class IndividualBill : Bill
    {
        [Column("INDIVIDUAL_BILL_ID")]
        public override long? ID { get => base.ID; set => base.ID = value; }

        [Column("SCENARIO_TYPE")]
        [Required]
        public override ScenarioType Scenario
        {
            get => base.Scenario;
            set => base.Scenario = ScenarioType.Basic;
        }

        [Column("INDIVIDUAL_ID_FOREIGN")]
        [Required]
        public long? IndividualID { get; set; }

        //Navigation Property
        public Individual Individual { get; set; }

    }
}
