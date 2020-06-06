using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Misc;
using HL7Data.Models.Base;
using System.Collections.Generic;
using static HL7Data.Classes.Attributes.CustomAttributes;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Misc
{
    public class ErrorSegment : BaseSegment, IErrorSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ERR;

        [CombineOrder(Order = 1, Name = "ERR.1")]
        public ICollection<IErrorLocationDescription> ErrorLocationAndDescriptions { get; set; }

        [CombineOrder(Order = 2, Name = "ERR.2")]
        public ICollection<string> ErrorLocations { get; set; }

        [CombineOrder(Order = 3, Name = "ERR.3")]
        public string HL7ErrorCode { get; set; }

        [CombineOrder(Order = 4, Name = "ERR.4")]
        public string Severity { get; set; }

        [CombineOrder(Order = 5, Name = "ERR.5")]
        public string ApplicationErrorCode { get; set; }

        [CombineOrder(Order = 6, Name = "ERR.6")]
        public ICollection<string> ApplicationErrorParameters { get; set; }

        [CombineOrder(Order = 7, Name = "ERR.7")]
        public string DiagnosticInformation { get; set; }

        [CombineOrder(Order = 8, Name = "ERR.8")]
        public string UserMessage { get; set; }

        [CombineOrder(Order = 9, Name = "ERR.9")]
        public ICollection<string> InformPersonIndicators { get; set; }

        [CombineOrder(Order = 10, Name = "ERR.10")]
        public string OverrideType { get; set; }

        [CombineOrder(Order = 11, Name = "ERR.11")]
        public ICollection<string> OverrideReasonCodes { get; set; }

        [CombineOrder(Order = 12, Name = "ERR.12")]
        public ICollection<IExtendedTelecommunicationNumber> HelpdeskContactPoints { get; set; }
    }
}