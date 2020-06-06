using HL7Data.Contracts.Messages.DietaryOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DietaryOrderAcknowledgmentMessages
{
    public class DietaryOrderAcknowledgement : BaseDietaryOrderAcknowledgmentMessage, IDietaryOrderAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORD_O04;
    }
}