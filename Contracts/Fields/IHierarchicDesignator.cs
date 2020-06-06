using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IHierarchicDesignator : IBaseField
    {
        string NamespaceId { get; }
        string UniversalId { get; }
        string UniversalIdType { get; }
    }
}