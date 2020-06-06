using HL7Data.Contracts.Segments.Patient.Blood;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Blood
{
    public class BloodProductOrderSegment : BaseSegment, IBloodProductOrderSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.BPO;
    }
}