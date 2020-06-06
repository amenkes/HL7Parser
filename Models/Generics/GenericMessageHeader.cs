using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Fields;
using System.Linq;
using HL7Data.Models.Types;

namespace HL7Data.Models.Generics
{
    public class GenericMessageHeader : GenericSegment, IGenericMessageHeader
    {
        protected const int FieldSeparatorChildPosition = 1;
        protected const int MessageTypeChildPosition = 9; // was 8, but inserting FieldSeparator
        public override SegmentTypes SegmentType { get; protected set; } = SegmentTypes.MSH;
        public IMessageType MessageType { get; set; }

        protected override void ProcessElements(string[] additionalData)
        {
            base.ProcessElements(additionalData);

            var fieldSeparator = GetChildByPosition(FieldSeparatorChildPosition);
            if (fieldSeparator?.Children?.Count != 1) // has encoding, not field separator, so insert it
            {
                var genericField = new GenericField
                {
                    Parent = this,
                    ParsingInfo = ParsingInfo,
                    Source = ParsingInfo.FieldSeparator
                };
                Children.Insert(1, genericField);
            }

            // Set messageType
            var messageData = GetChildByPosition(MessageTypeChildPosition);

            if (messageData?.Children == null || !messageData.Children.Any()) return;
            //TODO:ALM - remove?
            var messageType = new MessageType {GenericReferenceElement = messageData};
            MessageType = messageType;
        }
    }
}