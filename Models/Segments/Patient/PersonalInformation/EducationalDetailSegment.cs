using HL7Data.Contracts.Segments.Patient.PersonalInformation;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.PersonalInformation
{
    public class EducationalDetailSegment : BaseSegment, IEducationalDetailSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.EDU;
    }
}