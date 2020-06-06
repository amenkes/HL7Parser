using HL7Data.Contracts.Fields;
using System.Collections.Generic;

namespace HL7Data.Contracts.Segments.Patients
{
    public interface IPatientIdentification
    {
        string AccountNumber { get; } // TODO CX
        ICollection<IExtendedAddress> Addresses { get; }
        ICollection<IExtendedCompositeId> AlternateIds { get; }
        ICollection<IExtendedPersonName> Aliases { get; }
        int BirthOrder { get; }
        string Birthplace { get; }
        ICodedElement BreedCode { get; }
        ICollection<IExtendedTelecommunicationNumber> BusinessPhoneNumbers { get; }
        ICollection<ICodedElement> Citizenship { get; }
        string CountryCode { get; }
        IEventDateTime DateOfBirth { get; }
        IEventDateTime DeathDateTime { get; }
        string DeathIndicator { get; }
        ICollection<ICodedElement> EthnicGroup { get; }
        ICollection<IExtendedTelecommunicationNumber> HomePhoneNumbers { get; }
        IExtendedCompositeId Id { get; }
        ICollection<IExtendedCompositeId> IdentifierList { get; }
        ICollection<string> IdentityReliabilityCodes { get; }
        string IdentityUnknownIndicator { get; }
        IEventDateTime LastUpdate { get; }
        IHierarchicDesignator LastUpdateFacility { get; }
        ICodedElement MaritalStatus { get; }
        ICollection<string> MothersIdentifier { get; } // TODO CX
        ICollection<IExtendedPersonName> MothersMaidenNames { get; }
        bool MultipleBirthIndicator { get; }
        ICollection<IExtendedPersonName> Name { get; }
        ICodedElement Nationality { get; }
        ICodedElement PrimaryLanguage { get; }
        ICodedElement ProductionClassCode { get; }
        ICollection<ICodedElement> Race { get; }
        ICodedElement Religion { get; }
        int SequenceId { get; }
        string Sex { get; }
        string SocialSecurityNumber { get; }
        ICodedElement SpeciesCode { get; }
        string Strain { get; }
        ICollection<ICodedWithExceptions> TribalCitizenship { get; }
        ICodedElement VeteransMilitaryStatus { get; }
    }
}