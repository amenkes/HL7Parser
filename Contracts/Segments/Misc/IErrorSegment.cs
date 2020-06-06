using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using System.Collections.Generic;

namespace HL7Data.Contracts.Segments.Misc
{
    public interface IErrorSegment : ISegment
    {
        ICollection<IErrorLocationDescription> ErrorLocationAndDescriptions { get; }
        ICollection<string> ErrorLocations { get; } //TODO string -> ERL
        string HL7ErrorCode { get; } //TODO string -> CWE
        string Severity { get; }
        string ApplicationErrorCode { get; } //TODO string -> CWE
        ICollection<string> ApplicationErrorParameters { get; }
        string DiagnosticInformation { get; }
        string UserMessage { get; }
        ICollection<string> InformPersonIndicators { get; }
        string OverrideType { get; } //TODO string -> CWE
        ICollection<string> OverrideReasonCodes { get; } //TODO string -> CWE
        ICollection<IExtendedTelecommunicationNumber> HelpdeskContactPoints { get; }
    }
}