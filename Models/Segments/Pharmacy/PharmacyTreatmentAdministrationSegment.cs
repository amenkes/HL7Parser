using HL7Data.Contracts.Segments.Pharmacy;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Pharmacy
{
    public class PharmacyTreatmentAdministrationSegment : BaseSegment, IPharmacyTreatmentAdministrationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RXA;
    }
}