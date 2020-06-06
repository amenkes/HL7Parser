using HL7Data.Contracts.Messages.PersonnelMasterMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PersonnelMasterMessages
{
    public abstract class BasePersonnelMasterMessage : BaseMessage, IBasePersonnelMasterMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PMU;
    }
}