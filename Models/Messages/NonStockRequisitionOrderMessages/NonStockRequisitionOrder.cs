using HL7Data.Contracts.Messages.NonStockRequisitionOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NonStockRequisitionOrderMessages
{
    public class NonStockRequisitionOrder : BaseNonStockRequisitionOrderMessage, INonStockRequisitionOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMN_O07;
    }
}