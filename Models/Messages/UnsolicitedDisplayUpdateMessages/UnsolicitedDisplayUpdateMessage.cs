using HL7Data.Contracts.Messages.UnsolicitedDisplayUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedDisplayUpdateMessages
{
    public class UnsolicitedDisplayUpdateMessage : BaseUnsolicitedDisplayUpdateMessage, IUnsolicitedDisplayUpdateMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.UDM_Q05;
    }
}