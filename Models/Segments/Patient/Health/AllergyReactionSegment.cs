using HL7Data.Contracts.Segments.Patient.Health;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Health
{
    public class AllergyReactionSegment : BaseSegment, IAllergyReactionSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.IAR;
    }
}