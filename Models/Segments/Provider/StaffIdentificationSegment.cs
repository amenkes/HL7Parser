using HL7Data.Contracts.Fields;
using HL7Data.Contracts.Segments.Provider;
using HL7Data.Models.Base;
using System.Collections.Generic;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider
{
    public class StaffIdentificationSegment : BaseSegment, IStaffIdentificationSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.STF;
        public string PrimaryKeyValue { get; set; }
        public ICollection<IExtendedCompositeId> StaffIdentifierList { get; set; }
        public string StaffName { get; set; }
        public string StaffType { get; set; }
        public bool Active { get; set; }

        public string Phone { get; set; }
        //TODO: rest
    }
}