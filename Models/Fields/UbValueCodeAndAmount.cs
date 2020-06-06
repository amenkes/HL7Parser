using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class UbValueCodeAndAmount : BaseField, IUbValueCodeAndAmount
    {
        public override ElementDataType DataType => ElementDataType.UVC;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "UVC.1")]
#endif
}