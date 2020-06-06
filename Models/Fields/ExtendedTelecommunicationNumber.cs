using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class ExtendedTelecommunicationNumber : BaseField, IExtendedTelecommunicationNumber
    {
        public override ElementDataType DataType => ElementDataType.XTN;

        [CombineOrder(Order = 9, Name = "XTN.9")]
        [MaxLength(199)]
        public string AnyText { get; set; }

        [CombineOrder(Order = 6, Name = "XTN.6")]
        [MaxLength(5)]
        public int AreaCityCode { get; set; }

        [CombineOrder(Order = 5, Name = "XTN.5")]
        [MaxLength(3)]
        public int CountryCode { get; set; }

        [CombineOrder(Order = 4, Name = "XTN.4")]
        [MaxLength(199)]
        public string EmailAddress { get; set; }

        [CombineOrder(Order = 8, Name = "XTN.8")]
        [MaxLength(5)]
        public int Extension { get; set; }

        [CombineOrder(Order = 10, Name = "XTN.10")]
        [MaxLength(4)]
        public string ExtensionPrefix { get; set; }

        [CombineOrder(Order = 7, Name = "XTN.7")]
        [MaxLength(9)]
        public int LocalNumber { get; set; }

        [CombineOrder(Order = 11, Name = "XTN.11")]
        [MaxLength(6)]
        public string SpeedDialCode { get; set; }

        [CombineOrder(Order = 3, Name = "XTN.3")]
        [MaxLength(8)]
        [RestrictToLookup(TableId = 202)]
        public string TelecommunicationEquipmentType { get; set; }

        [CombineOrder(Order = 2, Name = "XTN.2")]
        [MaxLength(3)]
        [RestrictToLookup(TableId = 201)]
        public string TelecommunicationUseCode { get; set; }

        [CombineOrder(Order = 1, Name = "XTN.1")]
        [MaxLength(199)]
        public string TelephoneNumber { get; set; }

        [CombineOrder(Order = 12, Name = "XTN.12")]
        [MaxLength(199)]
        public string UnformattedTelephoneNumber { get; set; }
    }
}