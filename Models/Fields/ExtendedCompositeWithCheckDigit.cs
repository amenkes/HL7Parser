using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using ElementDataType = HL7Data.Models.Types.ElementDataType;

namespace HL7Data.Models.Fields
{
    public class ExtendedCompositeWithCheckDigit : BaseField, IExtendedCompositeId
    {
        public override ElementDataType DataType => ElementDataType.CX;

        [CombineOrder(Order = 10, Name = "CX.10")]
        [MaxLength(705)]
        public ICodedWithExceptions AssigningAgencyDepartment { get; set; }

        [MaxLength(227)]
        [CombineOrder(Order = 4, Name = "CX.4")]
        [RestrictToLookup(TableId = 363)]
        public IHierarchicDesignator AssigningAuthority { get; set; }

        [CombineOrder(Order = 6, Name = "CX.6")]
        [MaxLength(227)]
        public IHierarchicDesignator AssigningFacility { get; set; }

        [CombineOrder(Order = 9, Name = "CX.9")]
        [MaxLength(705)]
        public ICodedWithExceptions AssigningJurisdiction { get; set; }

        [CombineOrder(Order = 2, Name = "CX.2")]
        [MaxLength(1)]
        public string CheckDigit { get; set; }

        [RestrictToLookup(TableId = 61)]
        [CombineOrder(Order = 3, Name = "CX.3")]
        [MaxLength(3)]
        public string CheckDigitScheme { get; set; }

        [CombineOrder(Order = 7, Name = "CX.7")]
        [MaxLength(8)]
        public IDateTime EffectiveDate { get; set; }

        [CombineOrder(Order = 8, Name = "CX.8")]
        [MaxLength(8)]
        public IDateTime ExpirationDate { get; set; }

        [Required]
        [CombineOrder(Order = 1, Name = "CX.1")]
        [MaxLength(15)]
        public string Id { get; set; }

        [CombineOrder(Order = 5, Name = "CX.5")]
        [MaxLength(5)]
        [RestrictToLookup(TableId = 203)]
        public IdentifierType IdentifierTypeCode { get; set; } //TODO: May be issue for NNxxx
    }
}