using HL7Data.Contracts.Segments.Application.Query;
using HL7Data.Models.Base;
using System;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Application.Query
{
    [Obsolete]
    public class QueryFilterSegment : BaseSegment, IQueryFilterSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.QRF;
    }
}