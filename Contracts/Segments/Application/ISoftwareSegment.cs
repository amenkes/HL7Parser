using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;

namespace HL7Data.Contracts.Segments.Application
{
    public interface ISoftwareSegment : ISegment
    {
        string SoftwareVendorOrganization { get; } //TODO change to XON
        string SoftwareCertifiedVersionReleaseNumber { get; }
        string SoftwareProductName { get; }
        string SoftwareBinaryId { get; }
        string SoftwareProductInformation { get; }
        IEventDateTime SoftwareInstallDate { get; }
    }
}