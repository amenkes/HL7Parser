using HL7Data.Contracts.Messages.NonStockRequisitionOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NonStockRequisitionOrderMessages
{
    public abstract class BaseNonStockRequisitionOrderMessage : BaseMessage, IBaseNonStockRequisitionOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMN;
    }
}