using HL7Data.Contracts.Messages.GeneralClinicalOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralClinicalOrderMessages
{
    public abstract class BaseGeneralClinicalOrderMessage : BaseMessage, IBaseGeneralClinicalOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMG;
    }
}