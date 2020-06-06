using HL7Data.Contracts.Segments.Misc;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Misc
{
    public class NotesAndCommentsSegment : BaseSegment, INotesAndCommentsSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.NTE;
    }
}