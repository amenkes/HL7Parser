using HL7Data.Classes.ExtensionMethods;
using HL7Data.Contracts.Generics;
using System.Linq;
using HL7Data.Models.Types;

namespace HL7Data.Models.Generics
{
    public class GenericSegment : BaseGenericElement<IGenericSegment, GenericField, IGenericField, IGenericMessage>, IGenericSegment
    {
        public virtual SegmentTypes SegmentType { get; protected set; } = SegmentTypes.UNK;
        public string Prefix => SegmentType.ToString();
        public override string SeparatorCharacter => ParsingInfo.FieldSeparator;

        protected override void SetSelf<T>()
        {
            Self = this;
        }

        protected override void ProcessElements(string[] additionalData)
        {
            SegmentType = Children?.First()?.Source?.ToEnum<SegmentTypes>(true, SegmentTypes.UNK) ?? SegmentTypes.UNK;
        }
    }
}