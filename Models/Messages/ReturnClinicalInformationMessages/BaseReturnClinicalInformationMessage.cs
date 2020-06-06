using HL7Data.Contracts.Messages.ReturnClinicalInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnClinicalInformationMessages
{
    public abstract class BaseReturnClinicalInformationMessage : BaseMessage, IBaseReturnClinicalInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RCL;
    }
}