using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.RequestPatientInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class RequestPatientInformationFactory : AbstractTriggerEventFactory<RequestPatientInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RQI_I01:
                    return await Task.FromResult(new RequestForInsuranceInformation());

                case TriggerEventTypes.RQI_I02:
                    return await Task.FromResult(new RequestReceiptOfPatientSelectionDisplayList());

                case TriggerEventTypes.RQI_I03:
                    return await Task.FromResult(new RequestReceiptOfPatientSelectionList());

                default:
                    return null;
            }
        }
    }
}