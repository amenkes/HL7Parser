using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.HealthcareInvoiceMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class HealthcareInvoiceFactory : AbstractTriggerEventFactory<HealthcareInvoiceFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EHC_E01:
                    return await Task.FromResult(new SubmitHealthcareServicesInvoice());

                case TriggerEventTypes.EHC_E02:
                    return await Task.FromResult(new CancelHealthcareServicesInvoice());

                case TriggerEventTypes.EHC_E04:
                    return await Task.FromResult(new AssessHealthcareServicesInvoice());

                case TriggerEventTypes.EHC_E10:
                    return await Task.FromResult(new EditAdjudicationResults());

                case TriggerEventTypes.EHC_E12:
                    return await Task.FromResult(new RequestAdditionalInformation());

                case TriggerEventTypes.EHC_E13:
                    return await Task.FromResult(new AdditionalInformationResponse());

                case TriggerEventTypes.EHC_E15:
                    return await Task.FromResult(new PaymentRemittanceAdvice());

                case TriggerEventTypes.EHC_E20:
                    return await Task.FromResult(new SubmitAuthorizationRequest());

                case TriggerEventTypes.EHC_E21:
                    return await Task.FromResult(new CancelAuthorizationRequest());

                case TriggerEventTypes.EHC_E24:
                    return await Task.FromResult(new AuthorizationResponse());

                default:
                    return null;
            }
        }
    }
}