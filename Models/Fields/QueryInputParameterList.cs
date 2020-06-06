using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class QueryInputParameterList : BaseField, IQueryInputParameterList
    {
        public override ElementDataType DataType => ElementDataType.QIP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "QIP.1")]
#endif
}