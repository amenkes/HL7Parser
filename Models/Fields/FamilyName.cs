using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class FamilyName : BaseField, IFamilyName
    {
        public override ElementDataType DataType => ElementDataType.FN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "FN.1")]
#endif
}