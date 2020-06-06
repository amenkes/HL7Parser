using HL7Data.Classes.Attributes;
using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Messages.GeneralAcknowledgmentMessages;
using HL7Data.Contracts.Segments.Application;
using HL7Data.Contracts.Segments.Misc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HL7Data.Models.Messages.GeneralAcknowledgmentMessages
{
    public class GeneralAcknowledgmentMessage : BaseGeneralAcknowledgmentMessage, IGeneralAcknowledgmentMessage
    {
        [CustomAttributes.CombineOrderAttribute(Order = 2)]
        public ICollection<ISoftwareSegment> SoftwareSegment { get; set; }

        [CustomAttributes.CombineOrderAttribute(Order = 3)]
        [Required]
        public IMessageAcknowledgement MessageAcknowledgement { get; set; }

        [CustomAttributes.CombineOrderAttribute(Order = 4)]
        public ICollection<IErrorSegment> Errors { get; set; }
    }
}