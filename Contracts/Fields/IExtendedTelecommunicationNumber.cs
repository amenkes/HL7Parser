using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IExtendedTelecommunicationNumber : IBaseField
    {
        string AnyText { get; }
        int AreaCityCode { get; }
        int CountryCode { get; }
        string EmailAddress { get; }
        int Extension { get; }
        string ExtensionPrefix { get; }
        int LocalNumber { get; }
        string SpeedDialCode { get; }
        string TelecommunicationUseCode { get; }
        string TelecommunicationEquipmentType { get; }
        string TelephoneNumber { get; }
        string UnformattedTelephoneNumber { get; }
    }
}