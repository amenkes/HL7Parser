using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class ErrorLocationDescription : BaseField, IErrorLocationDescription
    {
        public override ElementDataType DataType => ElementDataType.ELD;

        [CombineOrder(Order = 1, Name = "ELD.1")]
        public string SegmentId { get; set; }

        [CombineOrder(Order = 1, Name = "ELD.2")]
        public string SegmentSequence { get; set; }

        [CombineOrder(Order = 1, Name = "ELD.3")]
        public int FieldPosition { get; set; }

        [CombineOrder(Order = 1, Name = "ELD.4")]
        public string CodeIdentifyingError { get; set; }
    }
}