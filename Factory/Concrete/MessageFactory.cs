using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Contracts.Segments.Header;
using HL7Data.Factory.Base;
using HL7Data.Models.Types;
using System.Threading.Tasks;
using HL7Data.Factory.TriggerEvent;

namespace HL7Data.Factory.Concrete
{
    public class MessageFactory : AbstractFactory<MessageFactory, HL7MessageType, IMessage, IGenericMessage, IMessage>
    {
        private IMessageHeader _messageHeader;

        //Override base to assign header to reference elements
        public override async Task<IMessage> CreateAsync(IGenericMessage genericMessage)
        {
            Ensure.ArgumentNotNull(nameof(genericMessage), genericMessage);
            //TODO:watch 34 ms
            var message = await base.CreateAsync(genericMessage);
            if (message == null) return null;

            message.MessageHeader = _messageHeader;
            return await Task.FromResult(message);
        }

        public override async Task<HL7MessageType> GetParameterType(IGenericMessage genericMessage)
        {
            Ensure.ArgumentNotNull(nameof(genericMessage), genericMessage);

            _messageHeader = genericMessage.GenericMessageHeader.ReferenceElement as IMessageHeader;
            var messageType = _messageHeader?.MessageType?.MessageCode?.ToEnum<HL7MessageType>(true, HL7MessageType.Unknown) ?? HL7MessageType.Unknown;

            return await Task.FromResult(messageType);
        }

        public override async Task<IMessage> GetElementFromType(HL7MessageType messageType, IGenericMessage genericMessage)
        {
            Ensure.ArgumentNotNull(nameof(genericMessage), genericMessage);

            switch (messageType)
            {
                case HL7MessageType.ACK: //TODO
                    return await AbstractTriggerEventFactory<GeneralAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ADT:
                    return await AbstractTriggerEventFactory<AdmitDischargeTransferFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.BAR:
                    return await AbstractTriggerEventFactory<BillingAccountFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.BPS:
                    return await AbstractTriggerEventFactory<BloodProductDispenseStatusFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.BRP:
                    return await AbstractTriggerEventFactory<BloodProductDispenseStatusAcknowledgementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.BRT:
                    return await AbstractTriggerEventFactory<BloodProductTransfusionDispositionAcknowledgementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.BTS:
                    return await AbstractTriggerEventFactory<BloodProductTransfusionDispositionFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCF:
                    return await AbstractTriggerEventFactory<CollaborativeCareFetchFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCI: //TODO
                    return await AbstractTriggerEventFactory<CollaborativeCareInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCM:
                    return await AbstractTriggerEventFactory<CollaborativeCareFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCQ:
                    return await AbstractTriggerEventFactory<CollaborativeCareQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCR:
                    return await AbstractTriggerEventFactory<ContinuityOfCareRecordFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CCU:
                    return await AbstractTriggerEventFactory<CollaborativeCareUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CQU: //TODO
                    return await AbstractTriggerEventFactory<CollaborativeCareReferralUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CRM:
                    return await AbstractTriggerEventFactory<ClinicalStudyRegistrationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.CSU:
                    return await AbstractTriggerEventFactory<UnsolicitedStudyDataFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DBC: //TODO
                    return await AbstractTriggerEventFactory<CreateDonorRecordFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DBU: //TODO
                    return await AbstractTriggerEventFactory<UpdateDonorRecordFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DEL: //TODO
                    return await AbstractTriggerEventFactory<DonorEligibilityFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DEO: //TODO
                    return await AbstractTriggerEventFactory<DonorEligibilityObservationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DER: //TODO
                    return await AbstractTriggerEventFactory<DonorEligibilityRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DFT:
                    return await AbstractTriggerEventFactory<DetailFinancialTransactionFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DOC:
                    return await AbstractTriggerEventFactory<DocumentQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DPR:
                    return await AbstractTriggerEventFactory<DonationProcedureFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DRC: //TODO
                    return await AbstractTriggerEventFactory<DonorRequestToCollectFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DRG: //TODO
                    return await AbstractTriggerEventFactory<DiagnosisRelatedGroupFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.DSR:
                    return await AbstractTriggerEventFactory<DeferredQueryResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EAC:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentCommandFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EAN:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentNotificationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EAR:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EDR:
                    return await AbstractTriggerEventFactory<EnhancedDisplayResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EHC:
                    return await AbstractTriggerEventFactory<HealthcareInvoiceFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ERP:
                    return await AbstractTriggerEventFactory<EventeplayResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ESR:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentStatusUpdateAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ESU:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentStatusUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.EQQ:
                    return await AbstractTriggerEventFactory<EmbeddedQueryLanguageFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.INR:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentInventoryRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.INU:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentInventoryUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.LSR:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentLogServiceRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.LSU:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentLogServiceUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.MDM:
                    return await AbstractTriggerEventFactory<MedicalDocumentManagementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.MFK:
                    return await AbstractTriggerEventFactory<MasterFilesApplicationAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.MFN:
                    return await AbstractTriggerEventFactory<MasterFilesNotificationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.MFQ:
                    return await AbstractTriggerEventFactory<QueryForMasterFileRecordFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.MFR:
                    return await AbstractTriggerEventFactory<MasterFileResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.NMD:
                    return await AbstractTriggerEventFactory<ApplicationManagementDataFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.NMQ:
                    return await AbstractTriggerEventFactory<ApplicationManagementQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.NMR:
                    return await AbstractTriggerEventFactory<ApplicationManagementResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMB:
                    return await AbstractTriggerEventFactory<BloodProductOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMD:
                    return await AbstractTriggerEventFactory<DietaryOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMG:
                    return await AbstractTriggerEventFactory<GeneralClinicalOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMI:
                    return await AbstractTriggerEventFactory<ImagingOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OML:
                    return await AbstractTriggerEventFactory<LaboratoryOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMN:
                    return await AbstractTriggerEventFactory<NonStockRequisitionOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMP:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMQ: //TODO
                    return await AbstractTriggerEventFactory<GeneralOrderMessageWithDocumentPayloadFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OMS:
                    return await AbstractTriggerEventFactory<StockRequisitionOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OPL:
                    return await AbstractTriggerEventFactory<PopulatioLocationBasedLaboratoryOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OPR:
                    return await AbstractTriggerEventFactory<PopulationLocationBasedLaboratoryOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OPU:
                    return await AbstractTriggerEventFactory<UnsolicitedPopulationLocationBasedLaboratoryObservationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORA:
                    return await AbstractTriggerEventFactory<ObservationReportAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORB:
                    return await AbstractTriggerEventFactory<BloodProductOrderAcknowledgementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORD:
                    return await AbstractTriggerEventFactory<DietaryOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORF:
                    return await AbstractTriggerEventFactory<ResponseToQueryTransmissionOfRequestedObservationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORG:
                    return await AbstractTriggerEventFactory<GeneralClinicalOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORI:
                    return await AbstractTriggerEventFactory<ImagingOrderAcknowledgementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORL:
                    return await AbstractTriggerEventFactory<LaboratoryAcknowledgmentMessageUnsolicitedFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORM:
                    return await AbstractTriggerEventFactory<OrderMessageFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORN:
                    return await AbstractTriggerEventFactory<NonStockRequisitionGeneralOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORP:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORR:
                    return await AbstractTriggerEventFactory<OrderResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORS:
                    return await AbstractTriggerEventFactory<StockRequisitionOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORU:
                    return await AbstractTriggerEventFactory<UnsolicitedTransmissionOfObservationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ORX: //TODO
                    return await AbstractTriggerEventFactory<GeneralOrderMessageWithDocumentPayloadAcknowledgementFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OSM:
                    return await AbstractTriggerEventFactory<SpecimenShipmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OSQ:
                    return await AbstractTriggerEventFactory<QueryForOrderStatusFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OSR:
                    return await AbstractTriggerEventFactory<QueryResponseForOrderStatusFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OSU: //TODO
                    return await AbstractTriggerEventFactory<OrderStatusUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.OUL:
                    return await AbstractTriggerEventFactory<UnsolicitedLaboratoryObservationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PEX:
                    return await AbstractTriggerEventFactory<ProductExperienceFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PGL:
                    return await AbstractTriggerEventFactory<PatientGoalFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PIN: //TODO
                    return await AbstractTriggerEventFactory<PatientInsuranceInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PMU:
                    return await AbstractTriggerEventFactory<PersonnelMasterMessageFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PPG: //TODO
                    return await AbstractTriggerEventFactory<PatientPathwayMessageGoalOrientedFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PPP: //TODO
                    return await AbstractTriggerEventFactory<PatientPathwayMessageProblemOrientedFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.PPR: //TODO
                    return await AbstractTriggerEventFactory<PatientProblemFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QBP:
                    return await AbstractTriggerEventFactory<QueryByParameterFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QCN:
                    return await AbstractTriggerEventFactory<CancelQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QCK:
                    return await AbstractTriggerEventFactory<DeferredResponseQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QRY:
                    return await AbstractTriggerEventFactory<QueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QSB:
                    return await AbstractTriggerEventFactory<CreateSubscriptionFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QSX: //TODO
                    return await AbstractTriggerEventFactory<CancelSubscriptionAcknowledgeFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.QVR: //TODO
                    return await AbstractTriggerEventFactory<QueryForPreviousEventsFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RAR:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentAdministrationInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RAS:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentAdministrationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RCL:
                    return await AbstractTriggerEventFactory<ReturnClinicalInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RDE:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RDR: //TODO
                    return await AbstractTriggerEventFactory<PharmacyTreatmentDispenseInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RDS:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentDispenseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RDY:
                    return await AbstractTriggerEventFactory<DisplayBasedResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.REF: //TODO
                    return await AbstractTriggerEventFactory<PatientReferralFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RER:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RGR:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentDoseInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RGV:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentGiveFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RPA:
                    return await AbstractTriggerEventFactory<ReturnPatientAuthorizationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RPI: //TODO
                    return await AbstractTriggerEventFactory<ReturnPatientInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RPL:
                    return await AbstractTriggerEventFactory<ReturnPatientDisplayListFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RPR:
                    return await AbstractTriggerEventFactory<ReturnPatientListFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RQA:
                    return await AbstractTriggerEventFactory<RequestPatientAuthorizationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ROR:
                    return await AbstractTriggerEventFactory<PharmacyPrescriptionOrderQueryResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RQC:
                    return await AbstractTriggerEventFactory<RequestForPatientClinicalInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RQI:
                    return await AbstractTriggerEventFactory<RequestPatientInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RQP:
                    return await AbstractTriggerEventFactory<RequestPatientDemographicsFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RQQ:
                    return await AbstractTriggerEventFactory<EventReplayQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RRA:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentAdministrationAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RRD: //TODO
                    return await AbstractTriggerEventFactory<PharmacyTreatmentDispenseAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RRE:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RRG:
                    return await AbstractTriggerEventFactory<PharmacyTreatmentGiveAcknowledgmentFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RRI:
                    return await AbstractTriggerEventFactory<ReturnReferralInformationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RSP:
                    return await AbstractTriggerEventFactory<SegmentPatternResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.RTB: //TODO
                    return await AbstractTriggerEventFactory<TabularResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SCN: //TODO
                    return await AbstractTriggerEventFactory<NotificationOfAntimicrobialDeviceCycleDataFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SDN: //TODO
                    return await AbstractTriggerEventFactory<NotificationOfAntimicrobialDeviceDataFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SDR: //TODO
                    return await AbstractTriggerEventFactory<SterilizationAntimicrobialDeviceDataRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SIU:
                    return await AbstractTriggerEventFactory<ScheduleInformationUnsolicitedFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SLN: //TODO
                    return await AbstractTriggerEventFactory<NotificationOfNewSterilizationLotFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SLR: //TODO
                    return await AbstractTriggerEventFactory<SterilizationLotRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SMD: //TODO
                    return await AbstractTriggerEventFactory<SterilizationAntimicrobialDeviceCycleDataRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SPQ:
                    return await AbstractTriggerEventFactory<StoredProcedureRequestFactory>.Instance.CreateAsync(genericMessage);
                //case HL7MessageType.SQM: //TODO  - SQM_S25 - Same name and similar format to SQR_S25
                //    return await AbstractTriggerEventFactory<>.Instance.CreateAsync(genericMessage);
                case HL7MessageType.SQR:
                    return await AbstractTriggerEventFactory<ScheduleQueryMessageAndResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SRM:
                    return await AbstractTriggerEventFactory<ScheduleRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SRR:
                    return await AbstractTriggerEventFactory<ScheduledRequestResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SSR:
                    return await AbstractTriggerEventFactory<SpecimenStatusRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.SSU:
                    return await AbstractTriggerEventFactory<SpecimenStatusUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.STC:
                    return await AbstractTriggerEventFactory<NotificationOfSterilizationConfigurationFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.STI:
                    return await AbstractTriggerEventFactory<SterilizationItemRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.TBR:
                    return await AbstractTriggerEventFactory<TabularDataResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.TCR:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentTestCodeSettingsRequestFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.TCU:
                    return await AbstractTriggerEventFactory<AutomatedEquipmentTestCodeSettingsUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.UDM:
                    return await AbstractTriggerEventFactory<UnsolicitedDisplayUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.VQQ:
                    return await AbstractTriggerEventFactory<VirtualTableQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.VXQ:
                    return await AbstractTriggerEventFactory<QueryForVaccinationRecordFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.VXR:
                    return await AbstractTriggerEventFactory<VaccinationRecordResponseFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.VXU:
                    return await AbstractTriggerEventFactory<UnsolicitedVaccinationRecordUpdateFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.VXX:
                    return await AbstractTriggerEventFactory<ResponseToVaccinationQueryFactory>.Instance.CreateAsync(genericMessage);

                case HL7MessageType.ZZZ: //TODO
                    return await AbstractTriggerEventFactory<CustomMessageFactory>.Instance.CreateAsync(genericMessage);

                default: //TODO - Custom? Error?
                    return await AbstractTriggerEventFactory<CustomMessageFactory>.Instance.CreateAsync(genericMessage);
            }
        }
    }
}