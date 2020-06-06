using HL7Data.Contracts.Messages.NonStockRequisitionGeneralOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NonStockRequisitionGeneralOrderAcknowledgmentMessages
{
    public class NonStockRequisitionAcknowledgement : BaseNonStockRequisitionGeneralOrderAcknowledgmentMessage, INonStockRequisitionAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORN_O08;
    }
}