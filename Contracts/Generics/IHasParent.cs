namespace HL7Data.Contracts.Generics
{
    public interface IHasParent<TParentGeneric>
    {
        TParentGeneric Parent { get; set; }
    }
}