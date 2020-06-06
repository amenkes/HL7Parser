using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class SpecialtyDescription : BaseField, ISpecialtyDescription
    {
        public override ElementDataType DataType => ElementDataType.SPD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SPD.1")]
#endif
}