using HL7Data.Contracts.Fields;

namespace HL7Data.Contracts.Generics
{
    public interface IGenericMessageHeader : IGenericSegment
    {
        IMessageType MessageType { get; set; }
    }
}