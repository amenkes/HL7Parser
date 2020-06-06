using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class LocationWithAddressVariation1 : BaseField, ILocationWithAddressVariation1
    {
        public override ElementDataType DataType => ElementDataType.LA1;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "LA1.1")]
#endif
}