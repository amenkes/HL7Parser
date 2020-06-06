using HL7Data.Contracts.Messages.CreateSubscriptionMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CreateSubscriptionMessages
{
    public class CreateSubscription : BaseCreateSubscriptionMessage, ICreateSubscription
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QSB_Q16;
    }
}