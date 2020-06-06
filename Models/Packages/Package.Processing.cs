using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HL7Data.Models.Types;
using HL7Data.Services.Parsing;

namespace HL7Data.Models.Packages
{
    public partial class Package
    {
        private IList<IMessage> GetMessages()
        {
            var genericMessages = GenericPackage?.Children.ToArray();
            if (genericMessages == null) return null;
            var messagesArray = new IMessage[genericMessages.Length];
            Parallel.For(0, genericMessages.Length,
                async λ => { messagesArray[λ] = await GetMessage(genericMessages[λ]); });

            return messagesArray.ToList();
        }

        private static async Task<IMessage> GetMessage(IGenericMessage genericMessage)
        {
            var concreteMessage = await ConvertGenericMessagesAsync(genericMessage);
            return concreteMessage;
        }

        internal static async Task<IMessage> ConvertGenericMessagesAsync(IGenericMessage genericMessage)
        {
            Ensure.ArgumentNotNull(nameof(genericMessage), genericMessage);

            var concreteMessage = await MessageFactory.Instance.CreateAsync(genericMessage);
            if (concreteMessage == null) return null;

            var segmentArray = genericMessage.Children.ToArray();
            for (var i = 1; i < segmentArray.Length; i++)
            {
                var concreteSegment = await SegmentFactory.Instance.CreateAsync(segmentArray[0]);
                concreteSegment.MessageHeader = concreteMessage.MessageHeader;
            }

            foreach (var genericSegment in genericMessage.Children.ToList())
            {
                var segment = await SegmentFactory.Instance.CreateAsync(genericSegment);
                segment.MessageHeader = concreteMessage.MessageHeader;
                ParsingService.UpdateReferences(segment, genericSegment);
                concreteMessage.Segments.Add(segment);
            }
            return concreteMessage;
        }

        protected override void Postprocess(IGenericRootItem genericReferenceElement)
        {
            if (ProviderType == InterfaceType.HL7Standard) return;

        }
    }
}