using HL7Data.Classes.ExtensionMethods;
using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class MessageType : BaseField, IMessageType
    {
        public override ElementDataType DataType => ElementDataType.MSG;

        [Required, RestrictToLookup(TableId = 76)]
        [MaxLength(3)]
        [CombineOrder(Order = 1, Name = "MSG.1")]
        public string MessageCode { get; set; }

        [Required]
        [RestrictToLookup(TableId = 354)] //TODO
        [MaxLength(7)]
        [CombineOrder(Order = 3, Name = "MSG.3")]
        public string MessageStructure { get; set; }

        [Required, RestrictToLookup(TableId = 3)]
        [MaxLength(3)]
        [CombineOrder(Order = 2, Name = "MSG.2")]
        public string TriggerEvent { get; set; }

        public HL7MessageType MessageTypeValue => MessageCode.ToEnum<HL7MessageType>(true, HL7MessageType.Unknown);

        public TriggerEventTypes TriggerEventTypeValue => $"{MessageCode}_{TriggerEvent}"
                                                              .ToEnum<TriggerEventTypes>(true, TriggerEventTypes.Unknown) != TriggerEventTypes.Unknown
            ? $"{MessageCode}_{TriggerEvent}".ToEnum<TriggerEventTypes>()
            : TriggerEvent.ToEnum<TriggerEventTypes>(true, TriggerEventTypes.Unknown) != TriggerEventTypes.Unknown
                ? TriggerEvent.ToEnum<TriggerEventTypes>()
                : MessageCode.ToEnum<TriggerEventTypes>(true, TriggerEventTypes.Unknown) != TriggerEventTypes.Unknown
                    ? MessageCode.ToEnum<TriggerEventTypes>()
                    : TriggerEventTypes.Unknown;

        public override async Task PopulateData()
        {
            await base.PopulateData();
            if (MessageStructure == null)
            {
                MessageStructure = TriggerEventTypeValue.ToString();
            }
        }
    }
}