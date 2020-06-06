using HL7Data.Classes.Conversion;
using HL7Data.Classes.ExtensionMethods;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Generics;
using HL7Data.Contracts.Segments.Header;
using HL7Data.Models.Base;
using HL7Data.Models.Fields;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static HL7Data.Classes.Attributes.CustomAttributes;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Header
{
    public class MessageHeader : BaseSegment, IMessageHeader
    {
        private IParsingInfo _parsingInfo;
        public override SegmentTypes SegmentType => SegmentTypes.MSH;

        public IParsingInfo ParsingInfo => _parsingInfo ?? (_parsingInfo = new ParsingInfo {EncodingCharacters = EncodingCharacters, FieldSeparator = FieldSeparator});

        [Required]
        [IgnoreForPopulate]
        [CombineOrder(Order = 1, Name = "MSH.1")]
        [MinLength(1)]
        [MaxLength(1)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 3, Length = 1)]
        public string FieldSeparator { get; set; } = Configuration.Configuration.ConfigurationData.Instance.ParsingData.FieldSeparator;

        [Required]
        [IgnoreForPopulate]
        [CombineOrder(Order = 2, Name = "MSH.2")]
        [MinLength(4)]
        [MaxLength(4)]
        [DefaultStringPosition(IsFixedLength = true, StartIndex = 4, Length = 4)]
        public IEncodingCharacters EncodingCharacters { get; set; } = new EncodingCharacters();

        [CombineOrder(Order = 3, Name = "MSH.3")]
        [MaxLength(227)]
        public IHierarchicDesignator SendingApplication { get; set; }

        [CombineOrder(Order = 4, Name = "MSH.4")]
        [MaxLength(227)]
        public IHierarchicDesignator SendingFacility { get; set; }

        [CombineOrder(Order = 5, Name = "MSH.5")]
        [MaxLength(227)]
        public IHierarchicDesignator ReceivingApplication => new HierarchicDesignator
        {
            NamespaceId = Configuration.Configuration.ConfigurationData.Instance.ApplicationNamespace
        };

        [CombineOrder(Order = 6, Name = "MSH.6")]
        [MaxLength(227)]
        public IHierarchicDesignator ReceivingFacility { get; set; }

        [Required]
        [CombineOrder(Order = 7, Name = "MSH.7")]
        [MaxLength(26)]
        public IEventDateTime EventTime { get; set; } = new EventDateTime();

        [CombineOrder(Order = 8, Name = "MSH.8")]
        [MaxLength(40)]
        public string Security { get; set; }

        [Required]
        [CombineOrder(Order = 9, Name = "MSH.9")]
        [MaxLength(13)]
        [RestrictToLookup(TableId = 76)]
        public IMessageType MessageType { get; set; }

        [Required]
        [CombineOrder(Order = 10, Name = "MSH.10")]
        [MaxLength(20)]
        public string MessageControlId { get; set; }

        [Required]
        [CombineOrder(Order = 11, Name = "MSH.11")]
        [MaxLength(3)]
        [RestrictToLookup(TableId = 103)]
        public IProcessingType ProcessingId { get; set; }

        [Required]
        [CombineOrder(Order = 12, Name = "MSH.12")]
        [MaxLength(60)]
        [RestrictToLookup(TableId = 104)]
        public string VersionId { get; set; }

        [CombineOrder(Order = 13, Name = "MSH.13")]
        [MaxLength(15)]
        public string SequenceNumber { get; set; }

        [CombineOrder(Order = 14, Name = "MSH.14")]
        [MaxLength(180)]
        public string ContinuationPointer { get; set; }

        [CombineOrder(Order = 15, Name = "MSH.15")]
        [MaxLength(2)]
        public string AcceptAcknowledgementType { get; set; }

        [CombineOrder(Order = 16, Name = "MSH.16")]
        [MaxLength(2)]
        public string ApplicationAcknowledgementType { get; set; }

        [CombineOrder(Order = 17, Name = "MSH.17")]
        [MaxLength(3)]
        public string CountryCode { get; set; }

        [CombineOrder(Order = 18, Name = "MSH.18")]
        [MaxLength(6)]
        public ICollection<string> CharacterSet { get; set; }

        //Not Implemented - MSH.19 -> MSH.21
        public override string ToString()
        {
            return
                $"{Prefix}{FieldSeparator}{ConversionMethods.BuildOrderedCollection(this).Result.ToFieldSeparatorString()}";
        }

        protected override void Preprocess(IGenericRootItem genericReferenceElement)
        {
            if (genericReferenceElement?.ParsingInfo == null) return;
            EncodingCharacters = genericReferenceElement.ParsingInfo.EncodingCharacters;
            FieldSeparator = genericReferenceElement.ParsingInfo.FieldSeparator;
            genericReferenceElement.ReferenceElement = this;
        }
    }
}