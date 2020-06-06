using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class CodedElement : BaseField, ICodedElement
    {
        public override ElementDataType DataType => ElementDataType.CE;

        [CombineOrder(Order = 4, Name = "CE.4")]
        [MaxLength(20)]
        public string AlternateIdentifier { get; set; }

        [CombineOrder(Order = 5, Name = "CE.5")]
        [MaxLength(199)]
        public string AlternateText { get; set; }

        [CombineOrder(Order = 6, Name = "CE.6")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string AlternateCodingSystemName { get; set; }

        [CombineOrder(Order = 3, Name = "CE.3")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string CodingSystemName { get; set; }

        [CombineOrder(Order = 1, Name = "CE.1")]
        [MaxLength(20)]
        public string Identifier { get; set; }

        [CombineOrder(Order = 2, Name = "CE.2")]
        [MaxLength(199)]
        public string Text { get; set; }
    }
}