using HL7Data.Contracts.Base;

namespace HL7Data.Configuration
{
    public interface IConfigurationData
    {
        string ApplicationNamespace { get; }
        string DateTimeFormatString { get; }
        IParsingInfo ParsingData { get; }
    }
}