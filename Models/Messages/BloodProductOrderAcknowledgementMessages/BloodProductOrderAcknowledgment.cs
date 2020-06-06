using HL7Data.Contracts.Messages.BloodProductOrderAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductOrderAcknowledgementMessages
{
    public class BloodProductOrderAcknowledgment : BaseBloodProductOrderAcknowledgementMessage, IBloodProductOrderAcknowledgment
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORB_O28;
    }
}