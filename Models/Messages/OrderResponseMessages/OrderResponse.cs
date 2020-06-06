using HL7Data.Contracts.Messages.OrderResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.OrderResponseMessages
{
    public class OrderResponse : BaseOrderResponseMessage, IOrderResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORR_O02;
    }
}