#if false
using HL7Data.Contracts.Segments.Misc;
using HL7Data.Contracts.Segments.Patient.Appointment;
using HL7Data.Contracts.Segments.Patient.PersonalInformation;
using HL7Data.Contracts.Segments.TOVERIFY;
#endif

using HL7Data.Contracts.Messages.ScheduleInformationUnsolicitedMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleInformationUnsolicitedMessages
{
    public class BaseScheduleInformationUnsolicitedMessage : BaseMessage, IBaseScheduleInformationUnsolicitedMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SIU;
#if false
        public IAppointmentInformationGeneralSegment AppointmentInformationGeneral { get; set; }
        public IAppointmentInformationLocationSegment AppointmentInformationLocation { get; set; }
        public IAppointmentInformationPersonnelSegment AppointmentInformationPersonnel { get; set; }
        public IPatientDemographicSegment PatientDemographic { get; set; }
        public IPatientIdentificationSegment PatientIdentification { get; set; }
        public IPatientVisitSegment PatientVisit { get; set; }
        public IResourceGroupSegment ResourceGroup { get; set; }
        public IScheduleActivitySegment ScheduleActivity { get; set; }
#endif
    }
}