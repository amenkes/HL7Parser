using HL7Data.Contracts.Messages.DietaryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DietaryOrderMessages
{
    public class DietaryOrder : BaseDietaryOrderMessage, IDietaryOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMD_O03;
    }
}