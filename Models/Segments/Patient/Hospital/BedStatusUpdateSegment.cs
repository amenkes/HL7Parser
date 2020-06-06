using HL7Data.Contracts.Segments.Patient.Hospital;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Hospital
{
    public class BedStatusUpdateSegment : BaseSegment, IBedStatusUpdateSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.NPU;
    }
}