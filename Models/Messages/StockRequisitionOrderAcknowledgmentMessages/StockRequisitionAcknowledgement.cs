using HL7Data.Contracts.Messages.StockRequisitionOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StockRequisitionOrderAcknowledgmentMessages
{
    public class StockRequisitionAcknowledgement : BaseStockRequisitionOrderAcknowledgmentMessage, IStockRequisitionAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORS_O06;
    }
}