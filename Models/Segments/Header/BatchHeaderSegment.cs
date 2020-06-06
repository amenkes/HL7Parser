using HL7Data.Contracts.Segments.Header;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Header
{
    public class BatchHeaderSegment : BaseSegment, IBatchHeaderSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.BHS;
    }
}