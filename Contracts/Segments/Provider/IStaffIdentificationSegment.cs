using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using System.Collections.Generic;

namespace HL7Data.Contracts.Segments.Provider
{
    public interface IStaffIdentificationSegment : ISegment
    {
        string PrimaryKeyValue { get; }
        ICollection<IExtendedCompositeId> StaffIdentifierList { get; }
        string StaffName { get; } //TODO XPN
        string StaffType { get; }
        bool Active { get; }
        string Phone { get; }
    }
}