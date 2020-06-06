using HL7Data.Contracts.Segments.Provider;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider
{
    public class ReferralInformationSegment : BaseSegment, IReferralInformationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RF1;
    }
}