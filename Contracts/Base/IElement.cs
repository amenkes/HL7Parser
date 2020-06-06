using HL7Data.Contracts.Generics;
using System.Threading.Tasks;

namespace HL7Data.Contracts.Base
{
    public interface IElement
    {
        string Prefix { get; }
        object PrefixType { get; }
        IGenericRootItem GenericReferenceElement { get; set; }
        string Source { get; }

        Task PopulateData();
    }
}