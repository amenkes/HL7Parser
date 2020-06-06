using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class ProcessingType : BaseField, IProcessingType
    {
        public override ElementDataType DataType => ElementDataType.PT;

        [CombineOrder(Order = 1, Name = "PT.1")]
        [MaxLength(1)]
        public string ProcessingId { get; set; }

        [CombineOrder(Order = 2, Name = "PT.2")]
        [MaxLength(1)]
        public string ProcessingMode { get; set; }
    }
}