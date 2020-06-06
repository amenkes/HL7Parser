namespace HL7Data.Contracts.Generics
{
    public interface IGenericNoParent : IGenericRootItem, IHasChildren<IGenericPackage>
    {
    }
}