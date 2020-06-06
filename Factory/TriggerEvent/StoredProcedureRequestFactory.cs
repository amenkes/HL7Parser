using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.StoredProcedureRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class StoredProcedureRequestFactory : AbstractTriggerEventFactory<StoredProcedureRequestFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SPQ_Q08:
                    return await Task.FromResult(new StoredProcedureRequest());

                default:
                    return null;
            }
        }
    }
}