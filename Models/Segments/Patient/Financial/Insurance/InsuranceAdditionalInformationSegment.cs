using HL7Data.Contracts.Segments.Patient.Financial.Insurance;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Financial.Insurance
{
    public class InsuranceAdditionalInformationSegment : BaseSegment, IInsuranceAdditionalInformationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.IN2;
    }
}