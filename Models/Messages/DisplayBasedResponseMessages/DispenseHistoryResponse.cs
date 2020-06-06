using HL7Data.Contracts.Messages.DisplayBasedResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DisplayBasedResponseMessages
{
    public class DispenseHistoryResponse : BaseDisplayBasedResponseMessage, IDispenseHistoryResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RDY_Z98;
    }
}