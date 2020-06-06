using HL7Data.Contracts.Messages.StockRequisitionOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StockRequisitionOrderAcknowledgmentMessages
{
    public abstract class BaseStockRequisitionOrderAcknowledgmentMessage : BaseMessage, IBaseStockRequisitionOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORS;
    }
}