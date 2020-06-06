using HL7Data.Contracts.Segments.Header;

namespace HL7Data.Contracts.Base
{
    public interface ISegment : IElement
    {
        IMessageHeader MessageHeader { get; set; }
    }
}