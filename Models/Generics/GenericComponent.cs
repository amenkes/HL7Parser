using HL7Data.Contracts.Generics;

namespace HL7Data.Models.Generics
{
    public class GenericComponent : BaseGenericElement<IGenericComponent, GenericSubcomponent, IGenericSubcomponent, IGenericField>, IGenericComponent
    {
        public override string SeparatorCharacter => ParsingInfo.EncodingCharacters.SubcomponentSeparator;

        protected override void SetSelf<T>()
        {
            Self = this;
        }
    }
}