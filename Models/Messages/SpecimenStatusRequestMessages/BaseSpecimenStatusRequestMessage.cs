using HL7Data.Contracts.Messages.SpecimenStatusRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SpecimenStatusRequestMessages
{
    public abstract class BaseSpecimenStatusRequestMessage : BaseMessage, IBaseSpecimenStatusRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SSR;
    }
}