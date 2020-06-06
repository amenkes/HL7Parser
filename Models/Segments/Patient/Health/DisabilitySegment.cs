using HL7Data.Contracts.Segments.Patient.Health;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Health
{
    public class DisabilitySegment : BaseSegment, IDisabilitySegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.DB1;
    }
}