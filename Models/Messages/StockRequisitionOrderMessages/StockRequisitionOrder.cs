using HL7Data.Contracts.Messages.StockRequisitionOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StockRequisitionOrderMessages
{
    public class StockRequisitionOrder : BaseStockRequisitionOrderMessage, IStockRequisitionOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMS_O05;
    }
}