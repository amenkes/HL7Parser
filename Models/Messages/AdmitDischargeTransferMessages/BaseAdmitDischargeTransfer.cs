using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

#if false
using HL7Data.Contracts.Segments.Application;
using HL7Data.Contracts.Segments.Patient.Appointment;
using HL7Data.Contracts.Segments.Patient.Financial;
using HL7Data.Contracts.Segments.Patient.Financial.Insurance;
using HL7Data.Contracts.Segments.Patient.PersonalInformation;
using HL7Data.Contracts.Segments.TOVERIFY;
using HL7Data.Services.Parsing;
using System.Collections.Generic;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;
#endif

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public abstract class BaseAdmitDischargeTransfer : BaseMessage, IBaseAdmitDischargeTransferMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ADT;
        public override SegmentTypes SegmentType => SegmentTypes.MSH;
        public override object PrefixType => MessageType;

#if false
        [CombineOrder(Order = 2)]
        public IEventTypeEvnSegment EventType { get; set; }

        [CombineOrder(Order = 3)]
        public IPatientIdentificationSegment PatientIdentification { get; set; }

        [CombineOrder(Order = 4)]
        public IPatientDemographicSegment PatientDemographic { get; set; }

        [CombineOrder(Order = 5)]
        public IPatientVisitSegment PatientVisit { get; set; }

        [CombineOrder(Order = 6)]
        public IGuarantorSegment Guarantor { get; set; }

        [CombineOrder(Order = 7)]
        public ICollection<IInsuranceSegment> Insurance { get; set; }

        public override async Task PopulateData()
        {
            await base.PopulateData();
            await ParsingService.PopulateDataAsync(this);
        }
#endif
    }
}