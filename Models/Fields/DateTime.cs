using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class DateTime : BaseField, IDateTime
    {
        public override ElementDataType DataType => ElementDataType.DTM;

        [CombineOrder(Order = 1, Name = "DTM.1")]
        public System.DateTime SystemDateTime { get; set; }
    }
}