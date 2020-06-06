using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HL7Data.Constants.Protocols;

namespace HL7Data.Models.Generics
{
    public sealed class GenericPackage : BaseGenericElement<IGenericPackage, GenericMessage, IGenericMessage, GenericNoParent<IGenericMessage>>, IGenericPackage
    {
        #region ctors

        public GenericPackage() { }

        public GenericPackage(string sourceData)
        {
            if (sourceData == null) return;
            Source = sourceData;
        }

        #endregion ctors

        public bool IsMllp => Source.StartsWith(MlpConstants.MessagePrefix);
        public string Data => ExtractMllpData(Source);

        IGenericNoParent IHasParent<IGenericNoParent>.Parent
        {
            get => null;
            set { }
        } // do nothing

        public override string SeparatorCharacter => Environment.NewLine;

        protected override void ProcessData<TGenericCurrentItem, TGenericChildItem>(string ignored)
        {
            // In case of MLLP, use Data instead of Source
            base.ProcessData<TGenericCurrentItem, TGenericChildItem>(Data);
        }

        protected override void ProcessElements(string[] dataArrayAdditionalProcessing)
        {
            if (dataArrayAdditionalProcessing == null || !dataArrayAdditionalProcessing.Any()) return;

            IGenericMessage message = null;
            IParsingInfo parsingInfo = null;

            foreach (var messageLine in dataArrayAdditionalProcessing)
            {
                IGenericSegment genericSegment;
                if (StringHelpers.IsMessageHeader(messageLine))
                {
                    message = new GenericMessage {Children = new List<IGenericSegment>()};
                    var genericMessageHeader = new GenericMessageHeader
                    {
                        Parent = message,
                        Source = messageLine
                    };
                    message.ParsingInfo = genericMessageHeader.ParsingInfo;
                    parsingInfo = genericMessageHeader.ParsingInfo;
                    message.Self = message;
                    message.Parent = this;
                    genericSegment = genericMessageHeader;
                    var messageHeader = MessageHeaderFactory.Instance.CreateAsync(genericMessageHeader).Result;
                    messageHeader.MessageHeader = messageHeader;
                    Children.Add(message);
                }
                else
                {
                    if (message == null || parsingInfo == null) continue;

                    genericSegment = new GenericSegment
                    {
                        Parent = message,
                        ParsingInfo = parsingInfo,
                        Source = messageLine
                    };
                    var segment = SegmentFactory.Instance.CreateAsync(genericSegment).Result;
                    genericSegment.ReferenceElement = segment;
                }

                message.SetSourceDirect(string.Concat(message.Source, string.IsNullOrWhiteSpace(message.Source)
                    ? string.Empty
                    : Environment.NewLine, messageLine)); // Bypass Source, set directly

                message.Children.Add(genericSegment);
            }
        }

        protected override Task<IGenericMessage> ProcessGenericChildElement(string ignored)
        {
            return base.ProcessGenericChildElement(Data);
        }

        protected override void SetParsingInfo(string ignored)
        {
            base.SetParsingInfo(Data);
        }

        protected override void SetSelf<T>()
        {
            Self = this;
        }

        private static string ExtractMllpData(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return data;

            if (data.StartsWith(MlpConstants.MessagePrefix) && data.EndsWith(MlpConstants.MessageSuffix))
            {
                return data.Substring(MlpConstants.MessagePrefix.Length,
                    data.Length - MlpConstants.MessagePrefix.Length - MlpConstants.MessageSuffix.Length);
            }

            return data;
        }
    }
}