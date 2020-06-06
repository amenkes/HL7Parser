using HL7Data.Contracts.Messages.MasterFilesApplicationAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesApplicationAcknowledgmentMessages
{
    public class MasterFileApplicationAcknowledgment : BaseMasterFilesApplicationAcknowledgmentMessage, IMasterFileApplicationAcknowledgment
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFK_M01;
    }
}