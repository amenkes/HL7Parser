using HL7Data.Contracts.Messages.ResponseToQueryTransmissionOfRequestedObservationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ResponseToQueryTransmissionOfRequestedObservationMessages
{
    public abstract class BaseResponseToQueryTransmissionOfRequestedObservationMessage : BaseMessage, IBaseResponseToQueryTransmissionOfRequestedObservationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORF;
    }
}