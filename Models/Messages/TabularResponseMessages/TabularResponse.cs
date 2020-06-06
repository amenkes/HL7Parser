using HL7Data.Contracts.Triggers;

namespace HL7Data.Models.Triggers
{
    public class TabularResponse : BaseTabularResponseMessage, ITabularResponse
    {
        public override Constants.Enumerations.HL7Types.TriggerEventTypes TriggerEventType => Constants.Enumerations.HL7Types.TriggerEventTypes.RTB_Z74;
    }
}