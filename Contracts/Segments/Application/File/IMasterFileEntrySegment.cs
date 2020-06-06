using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Segments.Application.File
{
    public interface IMasterFileEntrySegment : ISegment
    {
        string RecordLevelEventCode { get; }
        string PrimaryKeyValue { get; }
    }
}