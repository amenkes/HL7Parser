using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ApplicationManagementDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ApplicationManagementDataFactory : AbstractTriggerEventFactory<ApplicationManagementDataFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.NMD_N02:
                    return await Task.FromResult(new ApplicationManagementData());

                default:
                    return null;
            }
        }
    }
}