using HL7Data.Contracts.Messages.ObservationReportMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ObservationReportMessages
{
    public abstract class BaseObservationReportMessage : BaseMessage, IBaseObservationReportMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORA;
    }
}