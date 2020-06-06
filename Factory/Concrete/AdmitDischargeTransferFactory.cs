using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AdmitDischargeTransferMessages;
using System.Threading.Tasks;
using HL7Data.Models.Types;

namespace HL7Data.Factory.Concrete
{
    public sealed class AdmitDischargeTransferFactory : AbstractTriggerEventFactory<AdmitDischargeTransferFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ADT_A01:
                    return await Task.FromResult(new AdmitVisitNotification());

                case TriggerEventTypes.ADT_A02:
                    return await Task.FromResult(new TransferPatient());

                case TriggerEventTypes.ADT_A03:
                    return await Task.FromResult(new DischargeEndVisit());

                case TriggerEventTypes.ADT_A04:
                    return await Task.FromResult(new RegisterPatient());

                case TriggerEventTypes.ADT_A05:
                    return await Task.FromResult(new PreAdmitPatient());

                case TriggerEventTypes.ADT_A06:
                    return await Task.FromResult(new ChangeOutpatientToInpatient());

                case TriggerEventTypes.ADT_A07:
                    return await Task.FromResult(new ChangeInpatientToOutpatient());

                case TriggerEventTypes.ADT_A08:
                    return await Task.FromResult(new UpdatePatientInformation());

                case TriggerEventTypes.ADT_A09:
                    return await Task.FromResult(new PatientDepartingTracking());

                case TriggerEventTypes.ADT_A10:
                    return await Task.FromResult(new PatientArrivingTracking());

                case TriggerEventTypes.ADT_A11:
                    return await Task.FromResult(new CancelAdmitVisitNotification());

                case TriggerEventTypes.ADT_A12:
                    return await Task.FromResult(new CancelTransfer());

                case TriggerEventTypes.ADT_A13:
                    return await Task.FromResult(new CancelDischargeEndVisit());

                case TriggerEventTypes.ADT_A14:
                    return await Task.FromResult(new PendingAdmit());

                case TriggerEventTypes.ADT_A15:
                    return await Task.FromResult(new PendingTransfer());

                case TriggerEventTypes.ADT_A16:
                    return await Task.FromResult(new PendingDischarge());

                case TriggerEventTypes.ADT_A17:
                    return await Task.FromResult(new SwapPatients());

                case TriggerEventTypes.ADT_A18:
                    return await Task.FromResult(new MergePatientInformation());

                case TriggerEventTypes.ADT_A19:
                    return await Task.FromResult(new PatientQuery());

                case TriggerEventTypes.ADT_A20:
                    return await Task.FromResult(new BedStatusUpdate());

                case TriggerEventTypes.ADT_A21:
                    return await Task.FromResult(new PatientGoesOnLeave());

                case TriggerEventTypes.ADT_A22:
                    return await Task.FromResult(new PatientReturnFromAbsence());

                case TriggerEventTypes.ADT_A23:
                    return await Task.FromResult(new DeleteAPatientRecord());

                case TriggerEventTypes.ADT_A24:
                    return await Task.FromResult(new LinkPatientInformation());

                case TriggerEventTypes.ADT_A25:
                    return await Task.FromResult(new CancelPendingDischarge());

                case TriggerEventTypes.ADT_A26:
                    return await Task.FromResult(new CancelPendingTransfer());

                case TriggerEventTypes.ADT_A27:
                    return await Task.FromResult(new CancelPendingAdmit());

                case TriggerEventTypes.ADT_A28:
                    return await Task.FromResult(new AddPersonInformation());

                case TriggerEventTypes.ADT_A29:
                    return await Task.FromResult(new DeletePersonInformation());

                case TriggerEventTypes.ADT_A30:
                    return await Task.FromResult(new MergePersonInformation());

                case TriggerEventTypes.ADT_A31:
                    return await Task.FromResult(new UpdatePersonInformation());

                case TriggerEventTypes.ADT_A32:
                    return await Task.FromResult(new CancelPatientArrivingTracking());

                case TriggerEventTypes.ADT_A33:
                    return await Task.FromResult(new CancelPatientDepartingTracking());

                case TriggerEventTypes.ADT_A34:
                    return await Task.FromResult(new MergePatientInformationPatientIdOnly());

                case TriggerEventTypes.ADT_A35:
                    return await Task.FromResult(new MergePatientInformationAccountNumberOnly());

                case TriggerEventTypes.ADT_A36:
                    return await Task.FromResult(new MergePatientInformationPatientIdAndAccountNumber());

                case TriggerEventTypes.ADT_A37:
                    return await Task.FromResult(new UnlinkPatientInformation());

                case TriggerEventTypes.ADT_A38:
                    return await Task.FromResult(new CancelPreAdmit());

                case TriggerEventTypes.ADT_A39:
                    return await Task.FromResult(new MergePersonPatientId());

                case TriggerEventTypes.ADT_A40:
                    return await Task.FromResult(new MergePatientPatientIdentifierList());

                case TriggerEventTypes.ADT_A41:
                    return await Task.FromResult(new MergeAccountPatientAccountNumber());

                case TriggerEventTypes.ADT_A42:
                    return await Task.FromResult(new MergeVisitNumber());

                case TriggerEventTypes.ADT_A43:
                    return await Task.FromResult(new MovePatientInformationIdentifierList());

                case TriggerEventTypes.ADT_A44:
                    return await Task.FromResult(new MoveAccountInformationAccountNumber());

                case TriggerEventTypes.ADT_A45:
                    return await Task.FromResult(new MoveVisitInformationNumber());

                case TriggerEventTypes.ADT_A46:
                    return await Task.FromResult(new ChangePatientId());

                case TriggerEventTypes.ADT_A47:
                    return await Task.FromResult(new ChangePatientIdentifierList());

                case TriggerEventTypes.ADT_A48:
                    return await Task.FromResult(new ChangeAlternatePatientId());

                case TriggerEventTypes.ADT_A49:
                    return await Task.FromResult(new ChangePatientAccountNumber());

                case TriggerEventTypes.ADT_A50:
                    return await Task.FromResult(new ChangeVisitNumber());

                case TriggerEventTypes.ADT_A51:
                    return await Task.FromResult(new ChangeAlternateVisitId());

                case TriggerEventTypes.ADT_A52:
                    return await Task.FromResult(new CancelPatientLeave());

                case TriggerEventTypes.ADT_A53:
                    return await Task.FromResult(new CancelPatientReturnsFromLeave());

                case TriggerEventTypes.ADT_A54:
                    return await Task.FromResult(new ChangeAttendingDoctor());

                case TriggerEventTypes.ADT_A55:
                    return await Task.FromResult(new CancelChangeAttendingDoctor());

                case TriggerEventTypes.ADT_A60:
                    return await Task.FromResult(new UpdateAllergyInformation());

                case TriggerEventTypes.ADT_A61:
                    return await Task.FromResult(new ChangeConsultingDoctor());

                case TriggerEventTypes.ADT_A62:
                    return await Task.FromResult(new CancelChangeConsultingDoctor());

                default:
                    return null;
            }
        }
    }
}