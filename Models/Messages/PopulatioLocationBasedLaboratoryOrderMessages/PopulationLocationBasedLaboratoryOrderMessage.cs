using HL7Data.Contracts.Messages.PopulatioLocationBasedLaboratoryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PopulatioLocationBasedLaboratoryOrderMessages
{
    public class PopulationLocationBasedLaboratoryOrderMessage : BasePopulatioLocationBasedLaboratoryOrderMessage, IPopulationLocationBasedLaboratoryOrderMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OPL_O37;
    }
}