using HL7Data.Contracts.Messages.CancelQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CancelQueryMessages
{
    public class CancelQueryAcknowledgeMessage : BaseCancelQueryMessage, ICancelQueryAcknowledgeMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QCN_J01;
    }
}