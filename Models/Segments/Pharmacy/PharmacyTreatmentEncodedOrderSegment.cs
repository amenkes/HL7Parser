using HL7Data.Contracts.Segments.Pharmacy;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Pharmacy
{
    public class PharmacyTreatmentEncodedOrderSegment : BaseSegment, IPharmacyTreatmentEncodedOrderSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RXE;
    }
}