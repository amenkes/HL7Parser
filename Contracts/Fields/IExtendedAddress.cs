using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IExtendedAddress : IBaseField
    {
        string AddressRepresentationCode { get; }
        string AddressType { get; }
        IDateTimeRange AddressValidityRange { get; }
        string CensusTract { get; }
        string City { get; }
        string CountyParishCode { get; }
        string Country { get; }
        IEventDateTime EffectiveDate { get; }
        IEventDateTime ExpirationDate { get; }
        string OtherDesignation { get; }
        string OtherGeographicDesignation { get; }
        string PostalCode { get; }
        IStreetAddress StreetAddress { get; }
        string StateOrProvince { get; }
    }
}