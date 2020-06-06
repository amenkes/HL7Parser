using HL7Data.Contracts.Segments.Provider.Facility.Product;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Provider.Facility.Product
{
    public class RequisitionDetail1Segment : BaseSegment, IRequisitionDetail1Segment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RQ1;
    }
}