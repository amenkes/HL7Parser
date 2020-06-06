using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class CodedElementWithFormattedValues : BaseField, ICodedElementWithFormattedValues
    {
        public override ElementDataType DataType => ElementDataType.CF;
         [CombineOrder(Order = 4, Name = "CF.4")]
        [MaxLength(20)]
        public string AlternateIdentifier { get; set; }

        [CombineOrder(Order = 5, Name = "CF.5")]
        [MaxLength(65536)]
        public string AlternateText { get; set; }

        [IgnoreForPopulate]
        public string AlternateFormattedText => AlternateText;

        [CombineOrder(Order = 6, Name = "CF.6")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string AlternateCodingSystemName { get; set; }

        [CombineOrder(Order = 3, Name = "CF.3")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string CodingSystemName { get; set; }

        [IgnoreForPopulate]
        public string FormattedText => Text;

        [CombineOrder(Order = 1, Name = "CF.1")]
        [MaxLength(20)]
        public string Identifier { get; set; }

        [CombineOrder(Order = 2, Name = "CF.2")]
        [MaxLength(65536)]
        public string Text { get; set; }
    }

#if TODO
    [CombineOrder(Order = 1, Name = "CF.1")]
#endif
}