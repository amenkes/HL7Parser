using HL7Data.Contracts.Messages.EnhancedDisplayResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EnhancedDisplayResponseMessages
{
    public class EnhancedDisplayResponse : BaseEnhancedDisplayResponseMessage, IEnhancedDisplayResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EDR_R07;
    }
}