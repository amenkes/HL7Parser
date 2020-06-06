using HL7Data.Contracts.Segments.Procedure;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Procedure
{
    public class ProceduresSegment : BaseSegment, IProceduresSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.PR1;
    }
}