using HL7Data.Contracts.Segments.Patient.Document;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Document
{
    public class CertificateDetailSegment : BaseSegment, ICertificateDetailSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.CER;
    }
}