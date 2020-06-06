using HL7Data.Contracts.Generics;

namespace HL7Data.Models.Generics
{
    public class GenericField : BaseGenericElement<IGenericField, GenericComponent, IGenericComponent, IGenericSegment>, IGenericField
    {
        public override string SeparatorCharacter => ParsingInfo.EncodingCharacters.ComponentSeparator;

        protected override void SetSelf<T>()
        {
            Self = this;
        }
    }
}