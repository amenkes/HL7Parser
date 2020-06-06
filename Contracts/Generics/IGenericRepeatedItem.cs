using System.Collections.Generic;

namespace HL7Data.Contracts.Generics
{
    public interface IGenericRepeatedItem : IGenericRootItem, IHasChildren<IGenericRootItem>
    {
        void SetChildren(IList<IGenericRootItem> children);
        bool HasChildren { get; }
    }
}