using HL7Data.Contracts.Messages.RequestPatientDemographicsMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientDemographicsMessages
{
    public abstract class BaseRequestPatientDemographicsMessage : BaseMessage, IBaseRequestPatientDemographicsMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RQP;
    }
}