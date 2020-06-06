using HL7Data.Contracts.Segments.Custom;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Custom
{
    public class ZxxSegment : CatchallSegment, IZxxSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.Zxx;
    }
}