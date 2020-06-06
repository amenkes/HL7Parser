using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ContinuityOfCareRecordMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ContinuityOfCareRecordFactory : AbstractTriggerEventFactory<ContinuityOfCareRecordFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CCR_I16:
                    return await Task.FromResult(new CollaborativeCareReferral());

                case TriggerEventTypes.CCR_I17:
                    return await Task.FromResult(new ModifyCollaborativeCareReferral());

                case TriggerEventTypes.CCR_I18:
                    return await Task.FromResult(new CancelCollaborativeCareReferral());

                default:
                    return null;
            }
        }
    }
}