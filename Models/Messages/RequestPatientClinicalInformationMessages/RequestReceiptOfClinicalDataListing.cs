using HL7Data.Contracts.Messages.RequestPatientClinicalInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientClinicalInformationMessages
{
    public class RequestReceiptOfClinicalDataListing : BaseRequestPatientClinicalInformationMessage, IRequestReceiptOfClinicalDataListing
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQC_I06;
    }
}