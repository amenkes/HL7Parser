#if todo
using HL7Data.Contracts.Segments.Application;
using HL7Data.Contracts.Segments.Patient.Appointment;
using HL7Data.Contracts.Segments.Patient.Financial.Billing;
using HL7Data.Contracts.Segments.Patient.PersonalInformation;
#endif

using HL7Data.Contracts.Messages.DetailFinancialTransactionsMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DetailFinancialTransactionMessages
{
    public class BaseDetailFinancialTransactions : BaseMessage, IBaseDetailFinancialTransactionsMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DFT;
#if todo
        public IEventTypeEvnSegment EventType { get; set; }
        public IPatientIdentificationSegment PatientIdentification { get; set; }

        public IPatientVisitSegment PatientVisit { get; set; }

        public IFinancialTransactionSegment FinancialTransaction { get; set; }
#endif
    }
}