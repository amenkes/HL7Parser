using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Segments.Custom
{
    public interface ICatchallSegment : ISegment
    {
        string ActualPrefix { get; set; }
    }
}