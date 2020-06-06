using HL7Data.Contracts.Messages.SpecimenStatusUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SpecimenStatusUpdateMessages
{
    public abstract class BaseSpecimenStatusUpdateMessage : BaseMessage, IBaseSpecimenStatusUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SSU;
    }
}