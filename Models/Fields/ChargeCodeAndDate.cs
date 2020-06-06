using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using static HL7Data.Classes.Attributes.CustomAttributes.UsageOptionAttribute.PropertyUsage;

namespace HL7Data.Models.Fields
{
    public class ChargeCodeAndDate : BaseField, IChargeCodeAndDate
    {
        public override ElementDataType DataType => ElementDataType.CCD;

        [Required, UsageOption(Usage = Required)]
        [CombineOrder(Order = 1, Name = "CCD.1")]
        [MaxLength(1)]
        [RestrictToLookup(TableId = 100)]
        public string InvocationEvent { get; set; }

        [CombineOrder(Order = 2, Name = "CCD.2")]
        [MaxLength(26)]
        public IDateTime DateTime { get; set; }
    }
}