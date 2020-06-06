using HL7Data.Contracts.Messages.BloodProductTransfusionDispositionAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductTransfusionDispositionAcknowledgementMessages
{
    public class BloodProductTransfusionDispositionAcknowledgment : BaseBloodProductTransfusionDispositionAcknowledgementMessage, IBloodProductTransfusionDispositionAcknowledgment
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BRT_O32;
    }
}