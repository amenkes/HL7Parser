using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class CompositeQuantityWithUnits : BaseField, ICompositeQuantityWithUnits
    {
        public override ElementDataType DataType => ElementDataType.CQ;

        [CombineOrder(Order = 1, Name = "CQ.1")]
        [MaxLength(16)]
        public decimal Quantity { get; set; }

        [CombineOrder(Order = 2, Name = "CQ.2")]
        [MaxLength(483)]
        public string Units { get; set; }
    }
}