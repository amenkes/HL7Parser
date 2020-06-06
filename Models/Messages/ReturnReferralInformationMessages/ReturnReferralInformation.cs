using HL7Data.Contracts.Messages.ReturnReferralInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnReferralInformationMessages
{
    public class ReturnReferralInformation : BaseReturnReferralInformationMessage, IReturnReferralInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RRI_I12;
    }
}