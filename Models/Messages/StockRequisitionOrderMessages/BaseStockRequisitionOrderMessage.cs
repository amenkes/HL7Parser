using HL7Data.Contracts.Messages.StockRequisitionOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StockRequisitionOrderMessages
{
    public abstract class BaseStockRequisitionOrderMessage : BaseMessage, IBaseStockRequisitionOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMS;
    }
}