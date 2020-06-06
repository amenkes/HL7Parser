using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using System.Collections.Generic;

namespace HL7Data.Models.Generics
{
    public class GenericNoChildren : IGenericNoChildren, IGenericElement<GenericNoChildren, IGenericRootItem, IGenericSubcomponent>
    {
        public IList<IGenericRootItem> Children
        {
            get => null;
            set { } // Do nothing
        }

        public GenericNoChildren Self { get; set; }

        public virtual void SetSourceDirect(string data)
        {
        }

        public IGenericRootItem GetChildByPosition(int position)
        {
            return null;
        }

        public IGenericSubcomponent Parent { get; set; }
        public IParsingInfo ParsingInfo { get; set; }
        public IElement ReferenceElement { get; set; }

        public string SeparatorCharacter => null;

        public string Source
        {
            get => null;
            set { } // Do nothing
        }

        public string Value => null;

        public IGenericRepeatedItem GenericRepeatedItem { get; set; }
    }
}