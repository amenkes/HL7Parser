using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.GeneralClinicalOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class GeneralClinicalOrderFactory : AbstractTriggerEventFactory<GeneralClinicalOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OMG_O19:
                    return await Task.FromResult(new GeneralClinicalOrder());

                default:
                    return null;
            }
        }
    }
}