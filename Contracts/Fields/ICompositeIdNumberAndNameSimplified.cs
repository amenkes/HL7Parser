using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface ICompositeIdNumberAndNameSimplified : IBaseField
    {
        string Degree { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string NamePrefix { get; set; }
        string NamespaceId { get; set; } // Assigning Authority- Namespace Id
        string NameSuffix { get; set; }
        string SecondName { get; set; } //Second And Further Given Names Or Initials Thereof
        string SourceTable { get; set; }
        string UniversalId { get; set; } // Assigning Authority- Universal Id
        string UniversalIdType { get; set; } // Assigning Authority- Universal Id Type
    }
}