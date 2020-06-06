using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ReturnPatientAuthorizationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ReturnPatientAuthorizationFactory : AbstractTriggerEventFactory<ReturnPatientAuthorizationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RPA_I08:
                    return await Task.FromResult(new ReturnPatientAuthorization());

                default:
                    return null;
            }
        }
    }
}