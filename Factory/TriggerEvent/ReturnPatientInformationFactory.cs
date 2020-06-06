using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ReturnPatientInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ReturnPatientInformationFactory : AbstractTriggerEventFactory<ReturnPatientInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            //TODO
            switch (triggerEventType)
            {
                case TriggerEventTypes.RPI_I01:
                    return await Task.FromResult(new ReturnPatientInformation1()); //TODO
                case TriggerEventTypes.RPI_I04:
                    return await Task.FromResult(new ReturnPatientInformation4()); //TODO
                default:
                    return null;
            }
        }
    }
}