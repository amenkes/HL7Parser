using HL7Data.Contracts.Segments.Patient.Blood;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Blood
{
    public class BloodProductTransfusionSegment : BaseSegment, IBloodProductTransfusionSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.BTX;
    }
}