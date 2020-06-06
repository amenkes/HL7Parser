using HL7Data.Contracts.Messages.MasterFilesNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesNotificationMessages
{
    public class TestCalculatedObservationsMasterFile : BaseMasterFileNotificationMessages, ITestCalculatedObservationsMasterFile
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFN_M11;
    }
}