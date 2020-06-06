using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IAuthorizationInformation : IBaseField
    {
        string AuthorizationNumber { get; set; }
        IDate Date { get; set; }
        string AuthorizationSource { get; set; }
    }
}