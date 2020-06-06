using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;
using static HL7Data.Configuration.Configuration;

namespace HL7Data.Models.Fields
{
    public class EventDateTime : BaseField, IEventDateTime
    {
        public override ElementDataType DataType => ElementDataType.TS;

        [CombineOrder(Order = 1, Name = "TS.1")]
        public IDateTime EventDateTimestamp { get; set; } = new DateTime {SystemDateTime = System.DateTime.Now};

        [MaxLength(24)]
        public string DateTimeFormatted => (EventDateTimestamp?.SystemDateTime ??
                                            System.DateTime.Now).ToString(ConfigurationData.Instance.DateTimeFormatString);

        [CombineOrder(Order = 2, Name = "TS.2")]
        [MaxLength(1)]
        public string Precision => ConfigurationData.Instance.DefaultDateTimePrecision.ToString();

        public override string ToString()
        {
            return DateTimeFormatted;
        }
    }
}