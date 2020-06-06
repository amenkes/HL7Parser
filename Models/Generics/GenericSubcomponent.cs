using HL7Data.Contracts.Generics;
using System.Collections.Generic;

namespace HL7Data.Models.Generics
{
    public sealed class GenericSubcomponent : BaseGenericElement<IGenericSubcomponent, GenericNoChildren, IGenericNoChildren, IGenericComponent>, IGenericSubcomponent
    {
        public override IList<IGenericNoChildren> Children
        {
            get => null;
            set { }
        } // do nothing

        public override string SeparatorCharacter => string.Empty;

        protected override void SetSelf<T>()
        {
            Self = this;
        }
    }
}