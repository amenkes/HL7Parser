using HL7Data.Contracts.Messages.TabularDataResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.TabularDataResponseMessages
{
    public class TabularDataResponse : BaseTabularDataResponseMessage, ITabularDataResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.TBR_R08;
    }
}