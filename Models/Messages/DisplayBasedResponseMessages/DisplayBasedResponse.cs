using HL7Data.Contracts.Messages.DisplayBasedResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DisplayBasedResponseMessages
{
    public class DisplayBasedResponse : BaseDisplayBasedResponseMessage, IDisplayBasedResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RDY_K15;
    }
}