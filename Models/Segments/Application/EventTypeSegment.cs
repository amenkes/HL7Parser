using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Application;
using HL7Data.Models.Base;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application
{
    public class EventTypeSegment : BaseSegment, IEventTypeEvnSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.EVN;

        [MaxLength(26)]
        [CombineOrder(Order = 3, Name = "EVN.3")]
        public IEventDateTime PlannedEvent { get; set; }

        [RestrictToLookup(TableId = 62)]
        [MaxLength(3)]
        [CombineOrder(Order = 4, Name = "EVN.4")]
        public string EventReasonCode { get; set; }

        [RestrictToLookup(TableId = 188)]
        [MaxLength(250)]
        [CombineOrder(Order = 5, Name = "EVN.5")]
        public IExtendedCompositeId OperatorId { get; set; }

        [MaxLength(26)]
        [CombineOrder(Order = 6, Name = "EVN.6")]
        public IEventDateTime EventOccurred { get; set; }

        [MaxLength(241)]
        [CombineOrder(Order = 7, Name = "EVN.7")]
        public IHierarchicDesignator EventFacility { get; set; }

        [Required]
        [MaxLength(3)]
        [RestrictToLookup(TableId = 3)]
        [CombineOrder(Order = 1, Name = "EVN.1")]
        public string EventTypeCode { get; set; }

        [Required]
        [MaxLength(26)]
        [CombineOrder(Order = 2, Name = "EVN.2")]
        public IEventDateTime EventTime { get; set; } // Recorded Date/Time
    }
}