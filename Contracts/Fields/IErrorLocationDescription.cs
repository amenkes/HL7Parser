using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IErrorLocationDescription : IBaseField
    {
        string SegmentId { get; }
        string SegmentSequence { get; }
        int FieldPosition { get; }
        string CodeIdentifyingError { get; }
    }
}