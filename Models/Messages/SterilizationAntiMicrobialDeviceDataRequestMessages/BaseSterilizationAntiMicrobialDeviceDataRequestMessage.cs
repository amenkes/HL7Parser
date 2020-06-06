using HL7Data.Contracts.Messages.SterilizationAntiMicrobialDeviceDataRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SterilizationAntiMicrobialDeviceDataRequestMessages
{
    public abstract class BaseSterilizationAntimicrobialDeviceDataRequestMessage : BaseMessage, IBaseSterilizationAntimicrobialDeviceDataRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SDR;
    }
}