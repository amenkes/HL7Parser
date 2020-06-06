using HL7Data.Contracts.Segments.Provider.Facility;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider.Facility
{
    public class PractitionerOrganizationUnitSegment : BaseSegment, IPractitionerOrganizationUnitSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ORG;
    }
}