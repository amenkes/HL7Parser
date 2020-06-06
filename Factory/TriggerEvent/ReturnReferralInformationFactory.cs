using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ReturnReferralInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ReturnReferralInformationFactory : AbstractTriggerEventFactory<ReturnReferralInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RRI_I12:
                    return await Task.FromResult(new ReturnReferralInformation());

                default:
                    return null;
            }
        }
    }
}