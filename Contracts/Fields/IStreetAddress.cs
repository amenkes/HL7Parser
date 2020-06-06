using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IStreetAddress : IBaseField
    {
        string StreetOrMailingAddress { get; }
        string StreetName { get; }
        string DwellingNumber { get; }
    }
}