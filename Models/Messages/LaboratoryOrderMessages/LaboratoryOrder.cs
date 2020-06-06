using HL7Data.Contracts.Messages.LaboratoryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.LaboratoryOrderMessages
{
    public class LaboratoryOrder : BaseLaboratoryOrderMessage, ILaboratoryOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OML_O21;
    }
}