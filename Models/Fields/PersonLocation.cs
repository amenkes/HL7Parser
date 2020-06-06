using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class PersonLocation : BaseField, IPersonLocation
    {
        public override ElementDataType DataType => ElementDataType.PL;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PL.1")]
#endif
}