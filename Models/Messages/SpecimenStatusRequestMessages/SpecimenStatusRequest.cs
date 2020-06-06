using HL7Data.Contracts.Messages.SpecimenStatusRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SpecimenStatusRequestMessages
{
    public class SpecimenStatusRequest : BaseSpecimenStatusRequestMessage, ISpecimenStatusRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SSR_U04;
    }
}