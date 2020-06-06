using HL7Data.Contracts.Messages.PopulationLocationBasedLaboratoryOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PopulationLocationBasedLaboratoryOrderAcknowledgmentMessages
{
    public class PopulationLocationBasedLaboratoryOrderAcknowledgment : BasePopulationLocationBasedLaboratoryOrderAcknowledgmentMessage, IPopulationLocationBasedLaboratoryOrderAcknowledgment
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OPR_O38;
    }
}