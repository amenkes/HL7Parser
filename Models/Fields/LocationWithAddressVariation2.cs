using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class LocationWithAddressVariation2 : BaseField, ILocationWithAddressVariation2
    {
        public override ElementDataType DataType => ElementDataType.LA2;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "LA2.1")]
#endif
}