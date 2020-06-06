using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class WaveformSource : BaseField, IWaveformSource
    {
        public override ElementDataType DataType => ElementDataType.WVS;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "WVS.1")]
#endif
}