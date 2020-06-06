using HL7Data.Contracts.Segments.Notification;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Notification
{
    public class NotificationDetailSegment : BaseSegment, INotificationDetailSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.NDS;
    }
}