using HL7Data.Contracts.Segments.Patient.Diagnosis;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Diagnosis
{
    public class DiagnosisRelatedGroupSegment : BaseSegment, IDiagnosisRelatedGroupSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.DRG;
    }
}