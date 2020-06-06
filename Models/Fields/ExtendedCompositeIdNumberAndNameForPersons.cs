using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ExtendedCompositeIdNumberAndNameForPersons : BaseField, IExtendedCompositeIdNumberAndNameForPersons
    {
        public override ElementDataType DataType => ElementDataType.XCN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "XCN.1")]
#endif
}