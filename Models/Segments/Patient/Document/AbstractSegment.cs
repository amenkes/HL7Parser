using HL7Data.Contracts.Segments.Patient.Document;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Document
{
    public class AbstractSegment : BaseSegment, IAbstractSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ABS;
    }
}