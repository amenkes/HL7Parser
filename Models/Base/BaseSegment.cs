using HL7Data.Classes.Conversion;
using HL7Data.Classes.ExtensionMethods;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Segments.Header;
using HL7Data.Models.Types;

namespace HL7Data.Models.Base
{
    public abstract class BaseSegment : BaseElement, ISegment
    {
        public virtual SegmentTypes SegmentType => SegmentTypes.UNK;

        public virtual IMessageHeader MessageHeader { get; set; }

        public override object PrefixType => SegmentType;

        public override string ToString()
        {
            return
                $"{Prefix}{Configuration.Configuration.ConfigurationData.Instance.ParsingData.FieldSeparator}{ConversionMethods.BuildOrderedCollection(this).Result.ToFieldSeparatorString()}";
        }
    }
}