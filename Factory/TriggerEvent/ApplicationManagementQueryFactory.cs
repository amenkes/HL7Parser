using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ApplicationManagementQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ApplicationManagementQueryFactory : AbstractTriggerEventFactory<ApplicationManagementQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.NMQ_N01:
                    return await Task.FromResult(new ApplicationManagementQuery());

                default:
                    return null;
            }
        }
    }
}