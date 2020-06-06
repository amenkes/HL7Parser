using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.RequestPatientDemographicsMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class RequestPatientDemographicsFactory : AbstractTriggerEventFactory<RequestPatientDemographicsFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RQP_I04:
                    return await Task.FromResult(new RequestPatientDemographics());

                default:
                    return null;
            }
        }
    }
}