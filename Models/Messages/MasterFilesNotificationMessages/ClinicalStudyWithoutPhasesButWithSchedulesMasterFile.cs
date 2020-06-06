using HL7Data.Contracts.Messages.MasterFilesNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesNotificationMessages
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    public class ClinicalStudyWithoutPhasesButWithSchedulesMasterFile : MasterFilesNotificationMessage, IClinicalStudyWithoutPhasesButWithSchedulesMasterFile
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFN_M07;
    }
}