using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Patient.PersonalInformation;
using HL7Data.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.PersonalInformation
{
    public class PatientIdentification : BaseSegment, IPatientIdentificationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.PID;

        [CombineOrder(Order = 18, Name = "PID.18")]
        [MaxLength(250)]
        public virtual IExtendedCompositeId AccountNumber { get; set; }

        [CombineOrder(Order = 11, Name = "PID.11")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedAddress> Addresses { get; set; }

        [CombineOrder(Order = 4, Name = "PID.4")]
        [MaxLength(20)]
        public virtual ICollection<IExtendedCompositeId> AlternateIds { get; set; }

        [CombineOrder(Order = 9, Name = "PID.9")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedPersonName> Aliases { get; set; }

        [CombineOrder(Order = 25, Name = "PID.25")]
        public virtual int BirthOrder { get; set; }

        [CombineOrder(Order = 23, Name = "PID.23")]
        [MaxLength(250)]
        public virtual string Birthplace { get; set; }

        [CombineOrder(Order = 36, Name = "PID.36")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 447)]
        public virtual ICodedElement BreedCode { get; set; }

        [CombineOrder(Order = 14, Name = "PID.14")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedTelecommunicationNumber> BusinessPhoneNumbers { get; set; }

        [CombineOrder(Order = 26, Name = "PID.26")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 171)]
        public virtual ICollection<ICodedElement> Citizenship { get; set; }

        [CombineOrder(Order = 12, Name = "PID.12")]
        [MaxLength(4)]
        [RestrictToLookup(TableId = 289)]
        public virtual string CountyCode { get; set; }

        [CombineOrder(Order = 7, Name = "PID.7")]
        public virtual IEventDateTime DateOfBirth { get; set; }

        [CombineOrder(Order = 29, Name = "PID.29")]
        public virtual IEventDateTime DeathDateTime { get; set; }

        [CombineOrder(Order = 30, Name = "PID.30")]
        [RestrictToLookup(TableId = 136)]
        public virtual bool DeathIndicator { get; set; }

        [CombineOrder(Order = 20, Name = "PID.20")]
        [MaxLength(25)]
        public virtual IDriversLicenseNumber DriversLicenseNumber { get; set; }

        [CombineOrder(Order = 22, Name = "PID.22")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 189)]
        public virtual ICollection<ICodedElement> EthnicGroup { get; set; }

        [CombineOrder(Order = 13, Name = "PID.13")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedTelecommunicationNumber> HomePhoneNumbers { get; set; }

        [CombineOrder(Order = 2, Name = "PID.2")]
        [MaxLength(20)]
        public virtual IExtendedCompositeId Id { get; set; }

        [Required]
        [CombineOrder(Order = 3, Name = "PID.3")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedCompositeId> IdentifierList { get; set; }

        [CombineOrder(Order = 32, Name = "PID.32")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 445)]
        public virtual ICollection<string> IdentityReliabilityCodes { get; set; }

        [CombineOrder(Order = 31, Name = "PID.31")]
        public virtual bool IdentityUnknownIndicator { get; set; }

        [CombineOrder(Order = 33, Name = "PID.33")]
        public virtual IEventDateTime LastUpdate { get; set; }

        [CombineOrder(Order = 34, Name = "PID.34")]
        [MaxLength(241)]
        public virtual IHierarchicDesignator LastUpdateFacility { get; set; }

        [CombineOrder(Order = 16, Name = "PID.16")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 2)]
        public virtual ICodedElement MaritalStatus { get; set; }

        [CombineOrder(Order = 21, Name = "PID.21")]
        [MaxLength(250)]
        public virtual ICollection<string> MothersIdentifier { get; set; }

        [CombineOrder(Order = 6, Name = "PID.6")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedPersonName> MothersMaidenNames { get; set; }

        [CombineOrder(Order = 24, Name = "PID.24")]
        [MaxLength(1)]
        [RestrictToLookup(TableId = 136)]
        public virtual bool MultipleBirthIndicator { get; set; }

        [Required]
        [CombineOrder(Order = 5, Name = "PID.5")]
        [MaxLength(250)]
        public virtual ICollection<IExtendedPersonName> Name { get; set; }

        [CombineOrder(Order = 28, Name = "PID.28")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 212)]
        public virtual ICodedElement Nationality { get; set; }

        [CombineOrder(Order = 15, Name = "PID.15")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 296)]
        public virtual ICodedElement PrimaryLanguage { get; set; }

        [CombineOrder(Order = 38, Name = "PID.38")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 429)]
        public virtual ICodedElement ProductionClassCode { get; set; }

        [CombineOrder(Order = 10, Name = "PID.10")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 5)]
        public virtual ICollection<ICodedElement> Race { get; set; }

        [CombineOrder(Order = 17, Name = "PID.17")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 6)]
        public virtual ICodedElement Religion { get; set; }

        [CombineOrder(Order = 1, Name = "PID.1")]
        public virtual int SequenceId { get; set; }

        [CombineOrder(Order = 8, Name = "PID.8")]
        [MaxLength(1)]
        [RestrictToLookup(TableId = 1)]
        public virtual string Sex { get; set; }

        [CombineOrder(Order = 19, Name = "PID.19")]
        [MaxLength(16)]
        public virtual string SocialSecurityNumber { get; set; }

        [CombineOrder(Order = 35, Name = "PID.35")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 446)]
        public virtual ICodedElement SpeciesCode { get; set; }

        [CombineOrder(Order = 37, Name = "PID.37")]
        [MaxLength(80)]
        public virtual string Strain { get; set; }

        [CombineOrder(Order = 39, Name = "PID.39")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 171)]
        public virtual ICollection<ICodedWithExceptions> TribalCitizenship { get; set; }

        [CombineOrder(Order = 27, Name = "PID.27")]
        [MaxLength(250)]
        [RestrictToLookup(TableId = 172)]
        public virtual ICodedElement VeteransMilitaryStatus { get; set; }
    }
}