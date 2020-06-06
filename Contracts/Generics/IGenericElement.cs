namespace HL7Data.Contracts.Generics
{
    public interface IGenericElement<TGenericCurrent, TGenericChildInterface, TGenericParent> :
        IGenericRootItem, IHasChildren<TGenericChildInterface>, IHasParent<TGenericParent>,
        IHasGenericRepeatedItems
    {
        TGenericCurrent Self { get; set; }

        void SetSourceDirect(string data);

        TGenericChildInterface GetChildByPosition(int position);
    }
}