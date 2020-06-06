using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class InsuranceCertificationDefinition : BaseField, IInsuranceCertificationDefinition
    {
        public override ElementDataType DataType => ElementDataType.ICD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "ICD.1")]
#endif
}