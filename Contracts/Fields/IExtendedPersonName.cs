using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IExtendedPersonName : IBaseField
    {
        string Degree { get; }
        IEventDateTime EffectiveDate { get; }
        IEventDateTime ExpirationDate { get; }
        string FamilyName { get; }
        string GivenName { get; }
        string NameAssemblyOrder { get; }
        string NameContext { get; }
        string NameRepresentationCode { get; }
        string NameTypeCode { get; }
        string NameValidityRange { get; }
        string ProfessionalSuffix { get; }
        string SecondAndFurtherGivenName { get; }
        string Suffix { get; }
    }
}