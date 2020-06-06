using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class EntityIdentifier : BaseField, IEntityIdentifier
    {
        public override ElementDataType DataType => ElementDataType.EI;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "EI.1")]
#endif
}