using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ExtendedCompositeNameAndIdentificationNumberForOrganizations : BaseField, IExtendedCompositeNameAndIdentificationNumberForOrganizations
    {
        public override ElementDataType DataType => ElementDataType.XON;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "XON.1")]
#endif
}