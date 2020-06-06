using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Patient.PersonalInformation;
using HL7Data.Models.Base;
using System.Collections.Generic;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.PersonalInformation
{
    public class NextOfKin : BaseSegment, IAssociatedPartySegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.NK1;
        public ICollection<IExtendedAddress> Address { get; set; }
        public string AdministrativeSex { get; set; }
        public ICollection<string> AmbulatoryStatus { get; set; }
        public ICollection<IExtendedTelecommunicationNumber> BusinessPhoneNumber { get; set; }
        public ICollection<ICodedElement> Citizenship { get; set; }
        public ICollection<IExtendedAddress> ContactPersonAddresses { get; set; }
        public ICollection<IExtendedPersonName> ContactPersonNames { get; set; }
        public ICollection<ICodedElement> ContactReason { get; set; }
        public ICodedElement ContactRole { get; set; }
        public IEventDateTime DateOfBirth { get; set; }
        public IDateTime EndDate { get; set; }
        public IExtendedCompositeId EmployeeNumber { get; set; }
        public ICollection<ICodedElement> EthnicGroup { get; set; }
        public string JobCode { get; set; }
        public string JobTitle { get; set; }
        public string LivingArrangement { get; set; }
        public ICollection<string> LivingDependencies { get; set; }
        public ICodedElement MaritalStatus { get; set; }
        public ICollection<IExtendedPersonName> MothersMaidenNames { get; set; }
        public ICollection<IExtendedPersonName> Names { get; set; }
        public ICodedElement Nationality { get; set; }
        public ICollection<string> OrganizationName { get; set; }
        public ICollection<IExtendedTelecommunicationNumber> PhoneNumber { get; set; }
        public ICodedElement PrimaryLanguage { get; set; }
        public string ProtectionIndicator { get; set; }
        public ICodedElement PublicityCode { get; set; }
        public ICodedElement Relationship { get; set; }
        public ICodedElement Religion { get; set; }
        public string SetId { get; set; }
        public IDateTime StartDate { get; set; }
        public string StudentIndicator { get; set; }
    }
}