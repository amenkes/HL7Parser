using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.MasterFileResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class MasterFileResponseFactory : AbstractTriggerEventFactory<MasterFileResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.MFR_M04:
                    return await Task.FromResult(new MasterFilesResponseM04());

                case TriggerEventTypes.MFR_M05:
                    return await Task.FromResult(new MasterFilesResponseM05());

                case TriggerEventTypes.MFR_M06:
                    return await Task.FromResult(new MasterFilesResponseM06());

                case TriggerEventTypes.MFR_M07:
                    return await Task.FromResult(new MasterFilesResponseM07());

                default:
                    return null;
            }
        }
    }
}