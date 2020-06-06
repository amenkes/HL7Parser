using HL7Data.Contracts.Messages.UnsolicitedPopulationLocationBasedLaboratoryObservationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedPopulationLocationBasedLaboratoryObservationMessages
{
    public abstract class BaseUnsolicitedPopulationLocationBasedLaboratoryObservationMessage : BaseMessage, IBaseUnsolicitedPopulationLocationBasedLaboratoryObservationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OPU;
    }
}