using HL7Data.Contracts.Segments.Patient.Financial;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Financial
{
    public class GroupingReimbursementVisitSegment : BaseSegment, IGroupingReimbursementVisitSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.GP1;
    }
}