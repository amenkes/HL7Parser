using HL7Data.Contracts.Segments.Application.Query;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.Query
{
    public class QueryAcknowledgmentSegment : BaseSegment, IQueryAcknowledgmentSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.QAK;
    }
}