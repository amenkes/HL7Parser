using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class RoomCoverage : BaseField, IRoomCoverage
    {
        public override ElementDataType DataType => ElementDataType.RMC;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RMC.1")]
#endif
}