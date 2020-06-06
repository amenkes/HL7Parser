using HL7Data.Contracts.Segments.Notification;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Notification
{
    public class ClearNotificationSegment : BaseSegment, IClearNotificationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.CNS;
    }
}