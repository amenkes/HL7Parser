using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.RequestPatientAuthorizationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class RequestPatientAuthorizationFactory : AbstractTriggerEventFactory<RequestPatientAuthorizationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RQA_I08:
                    return await Task.FromResult(new RequestTreatmentAuthorizationInformation());

                case TriggerEventTypes.RQA_I09:
                    return await Task.FromResult(new RequestModificationToAuthorization());

                case TriggerEventTypes.RQA_I10:
                    return await Task.FromResult(new RequestResubmissionOfAuthorization());

                case TriggerEventTypes.RQA_I11:
                    return await Task.FromResult(new RequestCancellationOfAuthorization());

                default:
                    return null;
            }
        }
    }
}