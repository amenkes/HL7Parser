using HL7Data.Contracts.Segments.Application.File;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.File
{
    public class MasterFileEntrySegment : BaseSegment, IMasterFileEntrySegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.MFE;

        public string RecordLevelEventCode { get; set; }

        public string PrimaryKeyValue { get; set; }

        //TODO: rest
    }
}