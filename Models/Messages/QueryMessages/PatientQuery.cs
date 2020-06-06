using HL7Data.Contracts.Messages.QueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryMessages
{
    public class PatientQuery : BaseQueryMessage, IPatientQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QRY_A19;
    }
}