using HL7Data.Contracts.Segments.Misc;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Misc
{
    public class RiskManagementIncidentSegment : BaseSegment, IRiskManagementIncidentSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RMI;
    }
}