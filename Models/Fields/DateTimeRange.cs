using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class DateTimeRange : BaseField, IDateTimeRange
    {
        public override ElementDataType DataType => ElementDataType.DR;

        [CombineOrder(Order = 2, Name = "DR.2")]
        [MaxLength(26)]
        public IDateTime EndDateTime { get; set; }

        [CombineOrder(Order = 1, Name = "DR.1")]
        [MaxLength(26)]
        public IDateTime StartDateTime { get; set; }
    }
}