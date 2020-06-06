using HL7Data.Contracts.Messages.PopulationLocationBasedLaboratoryOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PopulationLocationBasedLaboratoryOrderAcknowledgmentMessages
{
    public abstract class BasePopulationLocationBasedLaboratoryOrderAcknowledgmentMessage : BaseMessage, IBasePopulationLocationBasedLaboratoryOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OPR;
    }
}