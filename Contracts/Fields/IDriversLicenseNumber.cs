using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IDriversLicenseNumber : IBaseField
    {
        IDateTime ExpirationDate { get; set; }
        string IssuingState { get; set; }
        string LicenseNumber { get; set; }
    }
}