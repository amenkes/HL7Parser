using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class StreetAddress : BaseField, IStreetAddress
    {
        public override ElementDataType DataType => ElementDataType.SAD;

        [CombineOrder(Order = 1, Name = "SAD.1")]
        [MaxLength(120)]
        public string StreetOrMailingAddress { get; set; }

        [CombineOrder(Order = 2, Name = "SAD.2")]
        [MaxLength(50)]
        public string StreetName { get; set; }

        [CombineOrder(Order = 3, Name = "SAD.3")]
        [MaxLength(12)]
        public string DwellingNumber { get; set; }
    }
}