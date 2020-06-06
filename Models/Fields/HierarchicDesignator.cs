using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class HierarchicDesignator : BaseField, IHierarchicDesignator
    {
        public override ElementDataType DataType => ElementDataType.HD;

        [CombineOrder(Order = 1, Name = "HD.1")]
        [MaxLength(20)]
        public string NamespaceId { get; set; }

        [CombineOrder(Order = 2, Name = "HD.2")]
        [MaxLength(199)]
        public string UniversalId { get; set; }

        [CombineOrder(Order = 3, Name = "HD.3")]
        [MaxLength(6)]
        public string UniversalIdType { get; set; }
    }
}