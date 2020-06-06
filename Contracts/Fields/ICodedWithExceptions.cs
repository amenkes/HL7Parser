using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface ICodedWithExceptions : IBaseField
    {
        string AlternateCodingSystemName { get; }
        string AlternateCodingSystemVersion { get; }
        string AlternateIdentifier { get; }
        string AlternateText { get; }
        string CodingSystemName { get; }
        string CodingSystemVersion { get; }
        string Id { get; }
        string OriginalText { get; }
        string Text { get; }
    }
}