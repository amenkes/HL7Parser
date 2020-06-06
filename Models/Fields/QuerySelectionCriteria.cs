using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class QuerySelectionCriteria : BaseField, IQuerySelectionCriteria
    {
        public override ElementDataType DataType => ElementDataType.QSC;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "QSC.1")]
#endif
}