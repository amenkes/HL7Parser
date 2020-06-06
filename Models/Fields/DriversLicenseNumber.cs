using System.ComponentModel.DataAnnotations;
using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Fields
{
    public class DriversLicenseNumber : BaseField, IDriversLicenseNumber
    {
        public override ElementDataType DataType => ElementDataType.DLN;

        [Required]
        [CombineOrder(Order = 1, Name = "DLN.1")]
        [MaxLength(20)]
        public string LicenseNumber { get; set; }

        [CombineOrder(Order = 2, Name = "DLN.2")]
        [MaxLength(20)]
        [RestrictToLookup(TableId = 333)]
        public string IssuingState { get; set; }

        [CombineOrder(Order = 3, Name = "DLN.3")]
        [MaxLength(24)]
        public IDateTime ExpirationDate { get; set; }
    }
}