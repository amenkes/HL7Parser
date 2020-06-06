using HL7Data.Contracts.Messages.BloodProductDispenseStatusAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductDispenseStatusAcknowledgementMessages
{
    public class BloodProductDispenseStatusAcknowledgment : BaseBloodProductDispenseStatusAcknowledgementMessage, IBloodProductDispenseStatusAcknowledgment
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BRP_O30;
    }
}