using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using System.Collections.Generic;

namespace HL7Data.Contracts.Segments.Patient.PersonalInformation
{
    public interface IAssociatedPartySegment : ISegment
    {
        ICollection<IExtendedAddress> Address { get; }
        string AdministrativeSex { get; }
        ICollection<string> AmbulatoryStatus { get; }
        ICollection<IExtendedTelecommunicationNumber> BusinessPhoneNumber { get; }
        ICollection<ICodedElement> Citizenship { get; }
        ICollection<IExtendedAddress> ContactPersonAddresses { get; }
        ICollection<IExtendedPersonName> ContactPersonNames { get; }
        ICollection<ICodedElement> ContactReason { get; }
        ICodedElement ContactRole { get; }
        IEventDateTime DateOfBirth { get; }
        IDateTime EndDate { get; }
        IExtendedCompositeId EmployeeNumber { get; }
        ICollection<ICodedElement> EthnicGroup { get; }
        string JobCode { get; } //TODO: JCC
        string JobTitle { get; }
        string LivingArrangement { get; }
        ICollection<string> LivingDependencies { get; }
        ICodedElement MaritalStatus { get; }
        ICollection<IExtendedPersonName> MothersMaidenNames { get; }
        ICollection<IExtendedPersonName> Names { get; }
        ICodedElement Nationality { get; }
        ICollection<string> OrganizationName { get; } //TODO: XON
        ICollection<IExtendedTelecommunicationNumber> PhoneNumber { get; }
        ICodedElement PrimaryLanguage { get; }
        string ProtectionIndicator { get; }
        ICodedElement PublicityCode { get; }
        ICodedElement Relationship { get; }
        ICodedElement Religion { get; }
        string SetId { get; }
        IDateTime StartDate { get; }
        string StudentIndicator { get; }
    }
}