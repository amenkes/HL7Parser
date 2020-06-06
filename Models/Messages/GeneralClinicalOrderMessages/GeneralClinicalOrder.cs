using HL7Data.Contracts.Messages.GeneralClinicalOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralClinicalOrderMessages
{
    public class GeneralClinicalOrder : BaseGeneralClinicalOrderMessage, IGeneralClinicalOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMG_O19;
    }
}