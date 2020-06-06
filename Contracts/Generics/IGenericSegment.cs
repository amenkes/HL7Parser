using HL7Data.Models.Types;

namespace HL7Data.Contracts.Generics
{
    public interface IGenericSegment : IGenericElement<IGenericSegment, IGenericField, IGenericMessage>
    {
        SegmentTypes SegmentType { get; }
        string Prefix { get; }
    }
}