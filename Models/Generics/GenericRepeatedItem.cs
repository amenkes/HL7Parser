using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using System.Collections.Generic;
using System.Linq;

namespace HL7Data.Models.Generics
{
    public partial class GenericRepeatedItem : IGenericRepeatedItem
    {
        public IList<IGenericRootItem> Children { get; set; }
        public IParsingInfo ParsingInfo { get; set; }
        public IElement ReferenceElement { get; set; }
        public string SeparatorCharacter => ParsingInfo.EncodingCharacters.RepetitionSeparator;
        public string Source { get; set; }
        public string Value => string.Join(SeparatorCharacter, Children.Select(λ => λ.Value));

        public void SetChildren(IList<IGenericRootItem> children)
        {
            Children = children;
        }

        public bool HasChildren => Children != null && Children.Any();
    }
}
