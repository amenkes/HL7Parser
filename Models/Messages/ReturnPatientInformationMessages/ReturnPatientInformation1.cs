using HL7Data.Contracts.Messages.ReturnPatientInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientInformationMessages
{
    public class ReturnPatientInformation1 : BaseReturnPatientInformationMessage, IReturnPatientInformation1
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RPI_I01;
    }
}