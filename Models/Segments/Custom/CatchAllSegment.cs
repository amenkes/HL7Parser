using HL7Data.Contracts.Segments.Custom;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Custom
{
    public class CatchallSegment : BaseSegment, ICatchallSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.UNK;
        public string ActualPrefix { get; set; }
    }
}