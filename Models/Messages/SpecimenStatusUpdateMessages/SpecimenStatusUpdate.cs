using HL7Data.Contracts.Messages.SpecimenStatusUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SpecimenStatusUpdateMessages
{
    public class SpecimenStatusUpdate : BaseSpecimenStatusUpdateMessage, ISpecimenStatusUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SSU_U03;
    }
}