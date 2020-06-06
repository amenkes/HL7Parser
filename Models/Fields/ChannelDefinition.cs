using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ChannelDefinition : BaseField, IChannelDefinition
    {
        public override ElementDataType DataType => ElementDataType.CD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "CD.1")]
#endif
}