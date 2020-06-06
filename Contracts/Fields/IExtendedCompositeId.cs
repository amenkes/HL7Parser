using HL7Data.Contracts.Base;
using HL7Data.Models.Types;

namespace HL7Data.Contracts.Fields
{
    public interface IExtendedCompositeId : IBaseField
    {
        ICodedWithExceptions AssigningAgencyDepartment { get; }
        IHierarchicDesignator AssigningAuthority { get; }
        IHierarchicDesignator AssigningFacility { get; }
        ICodedWithExceptions AssigningJurisdiction { get; }
        string CheckDigit { get; }
        string CheckDigitScheme { get; }
        IDateTime EffectiveDate { get; }
        IDateTime ExpirationDate { get; }
        string Id { get; }
        IdentifierType IdentifierTypeCode { get; } //TODO: May be issue for NNxxx
    }
}