using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Date")]
    public class Date : BaseField, IDate
    {
        public override ElementDataType DataType => ElementDataType.DT;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "DT.1")]
#endif
}