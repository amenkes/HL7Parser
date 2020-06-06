using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class CodedValueForUserDefinedTables : BaseField, ICodedValueForUserDefinedTables
    {
        public override ElementDataType DataType => ElementDataType.IS;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "IS.1")]
#endif
}