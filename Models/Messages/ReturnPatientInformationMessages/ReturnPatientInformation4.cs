using HL7Data.Contracts.Messages.ReturnPatientInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientInformationMessages
{
    public class ReturnPatientInformation4 : BaseReturnPatientInformationMessage, IReturnPatientInformation4
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RPI_I04;
    }
}