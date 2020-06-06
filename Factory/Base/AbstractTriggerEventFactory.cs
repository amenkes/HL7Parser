using HL7Data.Contracts.Base;
using HL7Data.Contracts.Factory;
using HL7Data.Contracts.Generics;
using System.Threading.Tasks;
using HL7Data.Models.Types;

namespace HL7Data.Factory.Base
{
    public abstract class AbstractTriggerEventFactory<TFactory> : AbstractFactory<TFactory, TriggerEventTypes, IMessage, IGenericMessage, IMessage>
        where TFactory : class, IFactory, new()
    {
        public override async Task<TriggerEventTypes> GetParameterType(IGenericMessage genericMessage)
        {
            return await Task.FromResult(genericMessage.GenericMessageHeader.MessageType.TriggerEventTypeValue);
        }
    }
}