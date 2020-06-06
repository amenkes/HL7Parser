using HL7Data.Contracts.Segments.Pharmacy;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Pharmacy
{
    public class PharmacyTreatmentDispenseSegment : BaseSegment, IPharmacyTreatmentDispenseSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RXD;
    }
}