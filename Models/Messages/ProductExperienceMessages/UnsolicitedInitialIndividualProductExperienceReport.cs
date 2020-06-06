using HL7Data.Contracts.Messages.ProductExperienceMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ProductExperienceMessages
{
    public class UnsolicitedInitialIndividualProductExperienceReport : BaseProductExperienceMessage, IUnsolicitedInitialIndividualProductExperienceReport
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.PEX_P07;
    }
}