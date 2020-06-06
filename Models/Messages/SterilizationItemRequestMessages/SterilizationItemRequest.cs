using HL7Data.Contracts.Messages.SterilizationItemRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SterilizationItemRequestMessages
{
    public class SterilizationItemRequest : BaseSterilizationItemRequestMessage, ISterilizationItemRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.STI_S30;
    }
}