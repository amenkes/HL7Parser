using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;
using static HL7Data.Classes.Attributes.CustomAttributes.UsageOptionAttribute.PropertyUsage;

namespace HL7Data.Models.Fields
{
    public class CodedWithNoExceptions : BaseField, ICodedWithNoExceptions
    {
        public override ElementDataType DataType => ElementDataType.CNE;
        [CombineOrder(Order = 6, Name = "CNE.6")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string AlternateCodingSystemName { get; set; }

        [CombineOrder(Order = 8, Name = "CNE.8")]
        [MaxLength(10)]
        public string AlternateCodingSystemVersion { get; set; }

        [CombineOrder(Order = 4, Name = "CNE.4")]
        [MaxLength(20)]
        public string AlternateIdentifier { get; set; }

        [CombineOrder(Order = 5, Name = "CNE.5")]
        [MaxLength(199)]
        public string AlternateText { get; set; }

        [CombineOrder(Order = 3, Name = "CNE.3")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 396)]
        public string CodingSystemName { get; set; }

        [CombineOrder(Order = 7, Name = "CNE.7"), UsageOption(Usage = Conditional)]
        [MaxLength(10)]
        public string CodingSystemVersion { get; set; }

        [Required, UsageOption(Usage = Required)] // Note: Not required for CWE.1
        [CombineOrder(Order = 1, Name = "CNE.1")]
        [MaxLength(20)]
        public string Id { get; set; }

        [CombineOrder(Order = 9, Name = "CNE.9")]
        [MaxLength(199)]
        public string OriginalText { get; set; }

        [CombineOrder(Order = 2, Name = "CNE.2")]
        [MaxLength(199)]
        public string Text { get; set; }
    }
}