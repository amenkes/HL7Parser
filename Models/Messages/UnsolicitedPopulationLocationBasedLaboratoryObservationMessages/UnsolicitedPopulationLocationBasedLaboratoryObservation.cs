using HL7Data.Contracts.Messages.UnsolicitedPopulationLocationBasedLaboratoryObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedPopulationLocationBasedLaboratoryObservationMessages
{
    public class UnsolicitedPopulationLocationBasedLaboratoryObservation : BaseUnsolicitedPopulationLocationBasedLaboratoryObservationMessage, IUnsolicitedPopulationLocationBasedLaboratoryObservation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OPU_R25;
    }
}