using HL7Data.Contracts.Messages.NonStockRequisitionGeneralOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NonStockRequisitionGeneralOrderAcknowledgmentMessages
{
    public abstract class BaseNonStockRequisitionGeneralOrderAcknowledgmentMessage : BaseMessage, IBaseNonStockRequisitionGeneralOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORN;
    }
}