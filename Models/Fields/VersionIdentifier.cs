using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class VersionIdentifier : BaseField, IVersionIdentifier
    {
        public override ElementDataType DataType => ElementDataType.VID;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "VID.1")]
#endif
}