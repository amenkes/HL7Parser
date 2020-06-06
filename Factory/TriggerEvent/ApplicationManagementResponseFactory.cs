using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ApplicationManagementResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ApplicationManagementResponseFactory : AbstractTriggerEventFactory<ApplicationManagementResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.NMR_N01:
                    return await Task.FromResult(new ApplicationManagementResponse());

                default:
                    return null;
            }
        }
    }
}