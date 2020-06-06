using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Event;
using System.Collections.Generic;

namespace HL7Data.Contracts.Segments.Header
{
    public interface IMessageHeader : IEventTimeSegment
    {
        string AcceptAcknowledgementType { get; set; }
        string ApplicationAcknowledgementType { get; set; }
        ICollection<string> CharacterSet { get; set; }
        string ContinuationPointer { get; set; }
        string CountryCode { get; set; }
        IEncodingCharacters EncodingCharacters { get; set; }
        string FieldSeparator { get; set; }
        IMessageType MessageType { get; set; }
        string MessageControlId { get; set; }
        IParsingInfo ParsingInfo { get; }
        IProcessingType ProcessingId { get; set; }
        IHierarchicDesignator ReceivingApplication { get; }
        IHierarchicDesignator ReceivingFacility { get; set; }
        string Security { get; set; }
        IHierarchicDesignator SendingApplication { get; set; }
        IHierarchicDesignator SendingFacility { get; set; }
        string SequenceNumber { get; set; }
        string VersionId { get; set; }
    }
}