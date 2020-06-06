using System.Collections.Generic;

namespace HL7Data.Contracts.Generics
{
    public interface IHasChildren<T>
    {
        IList<T> Children { get; set; }
    }
}