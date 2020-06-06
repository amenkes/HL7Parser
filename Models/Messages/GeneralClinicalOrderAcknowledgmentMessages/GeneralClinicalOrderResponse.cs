using HL7Data.Contracts.Messages.GeneralClinicalOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralClinicalOrderAcknowledgmentMessages
{
    public class GeneralClinicalOrderResponse : BaseGeneralClinicalOrderAcknowledgmentMessage, IGeneralClinicalOrderResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORG_O20;
    }
}