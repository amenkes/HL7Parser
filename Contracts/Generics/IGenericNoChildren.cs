namespace HL7Data.Contracts.Generics
{
    public interface IGenericNoChildren : IGenericRootItem, IHasParent<IGenericSubcomponent>, IHasGenericRepeatedItems
    {
    }
}