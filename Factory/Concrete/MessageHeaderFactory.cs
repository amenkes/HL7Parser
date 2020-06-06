using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Generics;
using HL7Data.Contracts.Segments.Header;
using HL7Data.Factory.Base;
using System.Threading.Tasks;

namespace HL7Data.Factory.Concrete
{
    public sealed class MessageHeaderFactory : AbstractFactory<MessageHeaderFactory, IMessageType, IMessageHeader, IGenericMessageHeader, IMessageHeader>
    {
        public override async Task<IMessageType> GetParameterType(IGenericMessageHeader genericMessageHeader)
        {
            Ensure.ArgumentNotNull(nameof(genericMessageHeader), genericMessageHeader);
            var messageType = genericMessageHeader.MessageType;
            return await Task.FromResult(messageType);
        }

        public override async Task<IMessageHeader> GetElementFromType(IMessageType type, IGenericMessageHeader genericMessageHeader)
        {
            var segment = await SegmentFactory.Instance.CreateAsync(genericMessageHeader);
            return await Task.FromResult(segment as IMessageHeader);
        }
    }
}