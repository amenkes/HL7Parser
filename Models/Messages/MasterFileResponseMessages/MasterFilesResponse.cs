using HL7Data.Contracts.Messages.MasterFilesNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFileResponseMessages
{
    public class MasterFilesResponse : BaseMasterFileResponseMessage, IMasterFilesResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFR_M07; //TODO: MFR_M04, 5, 6
    }
}