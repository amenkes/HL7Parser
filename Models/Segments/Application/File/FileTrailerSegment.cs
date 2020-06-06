using HL7Data.Contracts.Segments.Application.File;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.File
{
    public class FileTrailerSegment : BaseSegment, IFileTrailerSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.FTS;
    }
}