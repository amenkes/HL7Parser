using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ChannelSensitivityAndUnits : BaseField, IChannelSensitivityAndUnits
    {
        public override ElementDataType DataType => ElementDataType.CSU;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "CSU.1")]
#endif
}