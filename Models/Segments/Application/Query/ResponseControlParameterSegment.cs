using HL7Data.Contracts.Segments.Application.Query;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.Query
{
    public class ResponseControlParameterSegment : BaseSegment, IResponseControlParameterSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.RCP;
    }
}