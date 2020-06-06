using HL7Data.Contracts.Messages.ReturnClinicalInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnClinicalInformationMessages
{
    public class ReturnClinicalInformation : BaseReturnClinicalInformationMessage, IReturnClinicalInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RCL_I06;
    }
}