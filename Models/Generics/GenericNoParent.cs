using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using System.Collections.Generic;

namespace HL7Data.Models.Generics
{
    public class GenericNoParent<TAnySelf> : IGenericNoParent, IGenericElement<TAnySelf, IGenericPackage, IGenericNoParent>
    {
        public IGenericRepeatedItem GenericRepeatedItem
        {
            get => null;
            set { } // Do nothing
        }

        public IGenericNoParent Parent
        {
            get => null;
            set { } // Do nothing
        }

        public TAnySelf Self { get; set; }

        public virtual void SetSourceDirect(string data)
        {
        }

        public IGenericPackage GetChildByPosition(int position)
        {
            return Children == null || Children.Count < position ? default(IGenericPackage) : Children[position];
        }

        public IList<IGenericPackage> Children { get; set; }
        public IParsingInfo ParsingInfo { get; set; }
        public IElement ReferenceElement { get; set; }
        public string SeparatorCharacter => null;

        public string Source
        {
            get => null;
            set { } // Do nothing
        }

        public string Value => null;
    }
}