using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class ExtendedAddress : BaseField, IExtendedAddress
    {
        public override ElementDataType DataType => ElementDataType.XAD;

        [CombineOrder(Order = 11, Name = "XAD.11")]
        [MaxLength(1)]
        public string AddressRepresentationCode { get; set; }

        [CombineOrder(Order = 7, Name = "XAD.7")]
        [MaxLength(3)]
        public string AddressType { get; set; }

        [CombineOrder(Order = 12, Name = "XAD.12")]
        [MaxLength(53)]
        public IDateTimeRange AddressValidityRange { get; set; }

        [CombineOrder(Order = 10, Name = "XAD.10")]
        [MaxLength(20)]
        public string CensusTract { get; set; }

        [CombineOrder(Order = 3, Name = "XAD.3")]
        [MaxLength(50)]
        public string City { get; set; }

        [CombineOrder(Order = 9, Name = "XAD.9")]
        [MaxLength(20)]
        public string CountyParishCode { get; set; }

        [CombineOrder(Order = 6, Name = "XAD.6")]
        [MaxLength(3)]
        public string Country { get; set; }

        [CombineOrder(Order = 13, Name = "XAD.13")]
        [MaxLength(26)]
        public IEventDateTime EffectiveDate { get; set; }

        [CombineOrder(Order = 14, Name = "XAD.14")]
        [MaxLength(26)]
        public IEventDateTime ExpirationDate { get; set; }

        [CombineOrder(Order = 2, Name = "XAD.2")]
        [MaxLength(120)]
        public string OtherDesignation { get; set; }

        [CombineOrder(Order = 8, Name = "XAD.8")]
        [MaxLength(50)]
        public string OtherGeographicDesignation { get; set; }

        [CombineOrder(Order = 5, Name = "XAD.5")]
        [MaxLength(12)]
        public string PostalCode { get; set; }

        [CombineOrder(Order = 1, Name = "XAD.1")]
        [MaxLength(184)]
        public IStreetAddress StreetAddress { get; set; }

        [CombineOrder(Order = 4, Name = "XAD.4")]
        [MaxLength(50)]
        public string StateOrProvince { get; set; }
    }
}