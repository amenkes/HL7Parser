using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Application;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application
{
    public class SoftwareSegment : BaseSegment, ISoftwareSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.SFT;

        [Required]
        [CombineOrder(Order = 1, Name = "SFT.1")]
        [MaxLength(567)] //TODO XON
        public string SoftwareVendorOrganization { get; set; }

        [Required]
        [CombineOrder(Order = 2, Name = "SFT.2")]
        [MaxLength(15)]
        public string SoftwareCertifiedVersionReleaseNumber { get; set; }

        [Required]
        [CombineOrder(Order = 3, Name = "SFT.3")]
        [MaxLength(20)]
        public string SoftwareProductName { get; set; }

        [Required]
        [CombineOrder(Order = 4, Name = "SFT.4")]
        [MaxLength(20)]
        public string SoftwareBinaryId { get; set; }

        [CombineOrder(Order = 5, Name = "SFT.5")]
        [MaxLength(1024)]
        public string SoftwareProductInformation { get; set; }

        [CombineOrder(Order = 6, Name = "SFT.6")]
        public IEventDateTime SoftwareInstallDate { get; set; }
    }
}