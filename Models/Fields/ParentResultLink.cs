using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ParentResultLink : BaseField, IParentResultLink
    {
        public override ElementDataType DataType => ElementDataType.PRL;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PRL.1")]
#endif
}