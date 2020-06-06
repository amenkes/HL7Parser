namespace HL7Data.Contracts.Fields
{
    public interface IEncodingCharacters
    {
        string ComponentSeparator { get; }
        string EscapeCharacter { get; }
        string RepetitionSeparator { get; }
        string SubcomponentSeparator { get; }
    }
}