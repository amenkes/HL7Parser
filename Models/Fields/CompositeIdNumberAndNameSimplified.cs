using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using static HL7Data.Classes.Attributes.CustomAttributes.UsageOptionAttribute.PropertyUsage;

namespace HL7Data.Models.Fields
{
    public class CompositeIdNumberAndNameSimplified : BaseField, ICompositeIdNumberAndNameSimplified
    {
        public override ElementDataType DataType => ElementDataType.CNN;

        [CombineOrder(Order = 7, Name = "CNN.7")]
        [MaxLength(5)]
        [RestrictToLookup(TableId = 360)]
        public string Degree { get; set; }

        [CombineOrder(Order = 3, Name = "CNN.3")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [CombineOrder(Order = 1, Name = "CNN.1")]
        [MaxLength(15)]
        public string Id { get; set; }

        [CombineOrder(Order = 2, Name = "CNN.2")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [CombineOrder(Order = 6, Name = "CNN.6")]
        [MaxLength(20)]
        public string NamePrefix { get; set; }

        [CombineOrder(Order = 9, Name = "CNN.9"), UsageOption(Usage = Conditional)]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 363)]
        public string NamespaceId { get; set; }

        [CombineOrder(Order = 5, Name = "CNN.5")]
        [MaxLength(20)]
        public string NameSuffix { get; set; }

        [CombineOrder(Order = 4, Name = "CNN.4")]
        [MaxLength(30)]
        public string SecondName { get; set; }

        [CombineOrder(Order = 8, Name = "CNN.8"), UsageOption(Usage = Conditional)]
        [MaxLength(4)]
        [RestrictToLookup(TableId = 297)]
        public string SourceTable { get; set; }

        [CombineOrder(Order = 10, Name = "CNN.10"), UsageOption(Usage = Conditional)]
        [MaxLength(199)]
        public string UniversalId { get; set; }

        [CombineOrder(Order = 11, Name = "CNN.11"), UsageOption(Usage = Conditional)]
        [MaxLength(6)]
        [RestrictToLookup(TableId = 301)]
        public string UniversalIdType { get; set; }
    }
}