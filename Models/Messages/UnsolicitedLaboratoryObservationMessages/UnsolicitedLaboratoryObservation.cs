using HL7Data.Contracts.Messages.UnsolicitedLaboratoryObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedLaboratoryObservationMessages
{
    public class UnsolicitedLaboratoryObservation : BaseUnsolicitedLaboratoryObservationMessage, IUnsolicitedLaboratoryObservation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OUL_R21;
    }
}