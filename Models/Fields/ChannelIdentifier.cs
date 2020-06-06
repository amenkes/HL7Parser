using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ChannelIdentifier : BaseField, IChannelIdentifier
    {
        public override ElementDataType DataType => ElementDataType.WVI;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "WVI.1")]
#endif
}