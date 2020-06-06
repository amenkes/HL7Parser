using HL7Data.Contracts.Messages.SterilizationAntiMicrobialDeviceCycleDataRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SterilizationAntiMicrobialDeviceCycleDataRequestMessages
{
    public abstract class BaseSterilizationAntimicrobialDeviceCycleDataRequestMessage : BaseMessage, IBaseSterilizationAntimicrobialDeviceCycleDataRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SMD;
    }
}