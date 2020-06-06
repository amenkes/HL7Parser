using HL7Data.Contracts.Messages.OrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.OrderMessages
{
    public class OrderMessage : BaseOrderMessage, IOrderMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORM_O01;
    }
}