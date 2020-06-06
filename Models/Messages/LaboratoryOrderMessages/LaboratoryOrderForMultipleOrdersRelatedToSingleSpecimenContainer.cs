using HL7Data.Contracts.Messages.LaboratoryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.LaboratoryOrderMessages
{
    public class LaboratoryOrderForMultipleOrdersRelatedToSingleSpecimenContainer : BaseLaboratoryOrderMessage, ILaboratoryOrderForMultipleOrdersRelatedToSingleSpecimenContainer
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OML_O35;
    }
}