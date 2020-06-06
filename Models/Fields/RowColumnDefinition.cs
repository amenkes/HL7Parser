using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class RowColumnDefinition : BaseField, IRowColumnDefinition
    {
        public override ElementDataType DataType => ElementDataType.RCD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RCD.1")]
#endif
}