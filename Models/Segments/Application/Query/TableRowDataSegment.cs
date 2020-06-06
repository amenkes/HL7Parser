using HL7Data.Contracts.Segments.Application.Query;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.Query
{
    public class TableRowDataSegment : BaseSegment, ITableRowDataSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RDT;
    }
}