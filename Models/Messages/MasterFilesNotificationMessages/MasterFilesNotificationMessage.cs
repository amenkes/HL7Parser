using HL7Data.Contracts.Messages.MasterFilesNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesNotificationMessages
{
    public class MasterFilesNotificationMessage : BaseMasterFileNotificationMessages, IMasterFilesNotificationMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFN_M12;
#if TODO
        public IMasterFileIdentificationSegment EventType { get; set; }
        public IMasterFileEntrySegment MasterFileEntry { get; set; }
        public IStaffIdentificationSegment StaffIdentification { get; set; }
        public IPractitionerDetailSegment PractitionerDetail { get; set; }
#endif
    }
}