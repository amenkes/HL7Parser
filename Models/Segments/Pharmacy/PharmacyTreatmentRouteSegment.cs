using HL7Data.Contracts.Segments.Pharmacy;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Pharmacy
{
    public class PharmacyTreatmentRouteSegment : BaseSegment, IPharmacyTreatmentRouteSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RXR;
    }
}