using HL7Data.Contracts.Fields;

namespace HL7Data.Contracts.Base
{
    public interface IParsingInfo
    {
        IEncodingCharacters EncodingCharacters { get; }
        string FieldSeparator { get; }
    }
}