using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Segments.Application;
using HL7Data.Models.Segments.Application.File;
using HL7Data.Models.Segments.Application.Query;
using HL7Data.Models.Segments.Custom;
using HL7Data.Models.Segments.Header;
using HL7Data.Models.Segments.Misc;
using HL7Data.Models.Segments.Notification;
using HL7Data.Models.Segments.Patient.Appointment;
using HL7Data.Models.Segments.Patient.Blood;
using HL7Data.Models.Segments.Patient.Diagnosis;
using HL7Data.Models.Segments.Patient.Document;
using HL7Data.Models.Segments.Patient.Financial;
using HL7Data.Models.Segments.Patient.Financial.Billing;
using HL7Data.Models.Segments.Patient.Financial.Insurance;
using HL7Data.Models.Segments.Patient.Health;
using HL7Data.Models.Segments.Patient.Hospital;
using HL7Data.Models.Segments.Patient.Interaction;
using HL7Data.Models.Segments.Patient.PersonalInformation;
using HL7Data.Models.Segments.Pharmacy;
using HL7Data.Models.Segments.Procedure;
using HL7Data.Models.Segments.Provider;
using HL7Data.Models.Segments.Provider.Facility;
using HL7Data.Models.Segments.Provider.Facility.Equipment;
using HL7Data.Models.Segments.Provider.Facility.Product;
using HL7Data.Models.Segments.Study;
using System;
using System.Threading.Tasks;
using HL7Data.Services.Parsing;
using HL7Data.Models.Types;

#pragma warning disable 612 // Obsolete elements

namespace HL7Data.Factory.Concrete
{
    public sealed class SegmentFactory : AbstractFactory<SegmentFactory, SegmentTypes, ISegment, IGenericSegment, ISegment>
    {
        public override async Task<SegmentTypes> GetParameterType(IGenericSegment genericSegment)
        {
            Ensure.ArgumentNotNull(nameof(genericSegment), genericSegment);
            var segmentType = genericSegment.Prefix.ToEnum<SegmentTypes>(true, SegmentTypes.UNK);
            return await Task.FromResult(segmentType);
        }

        public override async Task<ISegment> GetElementFromType(SegmentTypes segmentType, IGenericSegment genericSegment /* = null*/)
        {
            switch (segmentType)
            {
                case SegmentTypes.ABS:
                    return await GetElementWithReferencesAsync(new AbstractSegment(), genericSegment);

                case SegmentTypes.ACC:
                    return await GetElementWithReferencesAsync(new AccidentSegment(), genericSegment);

                case SegmentTypes.ADD:
                    return await GetElementWithReferencesAsync(new AddSegment(), genericSegment);

                case SegmentTypes.ADJ:
                    return await GetElementWithReferencesAsync(new AdjustmentSegment(), genericSegment);

                case SegmentTypes.AFF:
                    return await GetElementWithReferencesAsync(new ProfessionalAffiliationSegment(), genericSegment);

                case SegmentTypes.AIG:
                    return await GetElementWithReferencesAsync(new AppointmentInformationGeneralSegment(), genericSegment);

                case SegmentTypes.AIL:
                    return await GetElementWithReferencesAsync(new AppointmentInformationLocationSegment(), genericSegment);

                case SegmentTypes.AIP:
                    return await GetElementWithReferencesAsync(new AppointmentInformationPersonnelSegment(), genericSegment);

                case SegmentTypes.AIS:
                    return await GetElementWithReferencesAsync(new AppointmentInformationSegment(), genericSegment);

                case SegmentTypes.AL1:
                    return await GetElementWithReferencesAsync(new PatientAllergyInformationSegment(), genericSegment);

                case SegmentTypes.APR:
                    return await GetElementWithReferencesAsync(new AppointmentPreferencesSegment(), genericSegment);

                case SegmentTypes.ARQ:
                    return await GetElementWithReferencesAsync(new AppointmentRequestSegment(), genericSegment);

                case SegmentTypes.ARV:
                    return await GetElementWithReferencesAsync(new AccessRestrictionSegment(), genericSegment);

                case SegmentTypes.AUT:
                    return await GetElementWithReferencesAsync(new AuthorizationInformationSegment(), genericSegment);

                case SegmentTypes.BHS:
                    return await GetElementWithReferencesAsync(new BatchHeaderSegment(), genericSegment);

                case SegmentTypes.BLC:
                    return await GetElementWithReferencesAsync(new BloodCodeSegment(), genericSegment);

                case SegmentTypes.BLG:
                    return await GetElementWithReferencesAsync(new BillingSegment(), genericSegment);

                case SegmentTypes.BPO:
                    return await GetElementWithReferencesAsync(new BloodProductOrderSegment(), genericSegment);

                case SegmentTypes.BPX:
                    return await GetElementWithReferencesAsync(new BloodProductDispenseStatusSegment(), genericSegment);

                case SegmentTypes.BTS:
                    return await GetElementWithReferencesAsync(new BatchTrailerSegment(), genericSegment);

                case SegmentTypes.BTX:
                    return await GetElementWithReferencesAsync(new BloodProductTransfusionSegment(), genericSegment);

                case SegmentTypes.CDM:
                    return await GetElementWithReferencesAsync(new ChargeDescriptionMasterSegment(), genericSegment);

                case SegmentTypes.CER:
                    return await GetElementWithReferencesAsync(new CertificateDetailSegment(), genericSegment);

                case SegmentTypes.CM0:
                    return await GetElementWithReferencesAsync(new ClinicalStudyMasterSegment(), genericSegment);

                case SegmentTypes.CM1:
                    return await GetElementWithReferencesAsync(new ClinicalStudyPhaseMasterSegment(), genericSegment);

                case SegmentTypes.CM2:
                    return await GetElementWithReferencesAsync(new ClinicalStudyScheduleMasterSegment(), genericSegment);

                case SegmentTypes.CNS:
                    return await GetElementWithReferencesAsync(new ClearNotificationSegment(), genericSegment);

                case SegmentTypes.CON:
                    return await GetElementWithReferencesAsync(new ConsentSegment(), genericSegment);

                case SegmentTypes.CSP:
                    return await GetElementWithReferencesAsync(new ClinicalStudyPhaseSegment(), genericSegment);

                case SegmentTypes.CSR:
                    return await GetElementWithReferencesAsync(new ClinicalStudyRegistrationSegment(), genericSegment);

                case SegmentTypes.CSS:
                    return await GetElementWithReferencesAsync(new ClinicalStudyDataScheduleSegmentSegment(), genericSegment);

                case SegmentTypes.CTD:
                    return await GetElementWithReferencesAsync(new ContactDataSegment(), genericSegment);

                case SegmentTypes.CTI:
                    return await GetElementWithReferencesAsync(new ClinicalTrialIdentificationSegment(), genericSegment);

                case SegmentTypes.DB1:
                    return await GetElementWithReferencesAsync(new DisabilitySegment(), genericSegment);

                case SegmentTypes.DG1:
                    return await GetElementWithReferencesAsync(new DiagnosisSegment(), genericSegment);

                case SegmentTypes.DMI:
                    return await GetElementWithReferencesAsync(new DrgMasterFileInformationSegment(), genericSegment);

                case SegmentTypes.DRG:
                    return await GetElementWithReferencesAsync(new DiagnosisRelatedGroupSegment(), genericSegment);

                case SegmentTypes.DSC:
                    return await GetElementWithReferencesAsync(new ContinuationPointerSegment(), genericSegment);

                case SegmentTypes.DSP:
                    return await GetElementWithReferencesAsync(new DisplayDataSegment(), genericSegment);

                case SegmentTypes.ECD:
                    return await GetElementWithReferencesAsync(new EquipmentCommandSegment(), genericSegment);

                case SegmentTypes.ECR:
                    return await GetElementWithReferencesAsync(new EquipmentCommandResponseSegment(), genericSegment);

                case SegmentTypes.EDU:
                    return await GetElementWithReferencesAsync(new EducationalDetailSegment(), genericSegment);

                case SegmentTypes.EQP:
                    return await GetElementWithReferencesAsync(new EquipmentLogServiceSegment(), genericSegment);

                case SegmentTypes.EQU:
                    return await GetElementWithReferencesAsync(new EquipmentDetailSegment(), genericSegment);

                case SegmentTypes.ERR:
                    return await GetElementWithReferencesAsync(new ErrorSegment(), genericSegment);

                case SegmentTypes.EVN:
                    return await GetElementWithReferencesAsync(new EventTypeSegment(), genericSegment);

                case SegmentTypes.FAC:
                    return await GetElementWithReferencesAsync(new FacilitySegment(), genericSegment);

                case SegmentTypes.FHS:
                    return await GetElementWithReferencesAsync(new FileHeaderSegment(), genericSegment);

                case SegmentTypes.FT1:
                    return await GetElementWithReferencesAsync(new FinancialTransactionSegment(), genericSegment);

                case SegmentTypes.FTS:
                    return await GetElementWithReferencesAsync(new FileTrailerSegment(), genericSegment);

                case SegmentTypes.GOL:
                    return await GetElementWithReferencesAsync(new GoalDetailSegment(), genericSegment);

                case SegmentTypes.GP1:
                    return await GetElementWithReferencesAsync(new GroupingReimbursementVisitSegment(), genericSegment);

                case SegmentTypes.GP2:
                    return await GetElementWithReferencesAsync(new GroupingReimbursementProcedureLineItemSegment(), genericSegment);

                case SegmentTypes.GT1:
                    return await GetElementWithReferencesAsync(new GuarantorSegment(), genericSegment);

                case SegmentTypes.IAM:
                    return await GetElementWithReferencesAsync(new PatientAdverseReactionInformationSegment(), genericSegment);

                case SegmentTypes.IAR:
                    return await GetElementWithReferencesAsync(new AllergyReactionSegment(), genericSegment);

                case SegmentTypes.IIM:
                    return await GetElementWithReferencesAsync(new InventoryItemMasterSegment(), genericSegment);

                case SegmentTypes.ILT:
                    return await GetElementWithReferencesAsync(new MaterialLotSegment(), genericSegment);

                case SegmentTypes.IN1:
                    return await GetElementWithReferencesAsync(new InsuranceSegment(), genericSegment);

                case SegmentTypes.IN2:
                    return await GetElementWithReferencesAsync(new InsuranceAdditionalInformationSegment(), genericSegment);

                case SegmentTypes.IN3:
                    return await GetElementWithReferencesAsync(new InsuranceAdditionalInformationCertificationSegment(), genericSegment);

                case SegmentTypes.INV:
                    return await GetElementWithReferencesAsync(new InventoryDetailSegment(), genericSegment);

                case SegmentTypes.IPC:
                    return await GetElementWithReferencesAsync(new ImagingProcedureControlSegmentSegment(), genericSegment);

                case SegmentTypes.IPR:
                    return await GetElementWithReferencesAsync(new InvoiceProcessingResultsSegment(), genericSegment);

                case SegmentTypes.ISD:
                    return await GetElementWithReferencesAsync(new InteractionStatusDetailSegment(), genericSegment);

                case SegmentTypes.ITM:
                    return await GetElementWithReferencesAsync(new MaterialItemSegment(), genericSegment);

                case SegmentTypes.IVC:
                    return await GetElementWithReferencesAsync(new InvoiceSegmentSegment(), genericSegment);

                case SegmentTypes.IVT:
                    return await GetElementWithReferencesAsync(new MaterialLocationSegment(), genericSegment);

                case SegmentTypes.LAN:
                    return await GetElementWithReferencesAsync(new LanguageDetailSegment(), genericSegment);

                case SegmentTypes.LCC:
                    return await GetElementWithReferencesAsync(new LocationChargeCodeSegment(), genericSegment);

                case SegmentTypes.LCH:
                    return await GetElementWithReferencesAsync(new LocationCharacteristicSegment(), genericSegment);

                case SegmentTypes.LDP:
                    return await GetElementWithReferencesAsync(new LocationDepartmentSegment(), genericSegment);

                case SegmentTypes.LOC:
                    return await GetElementWithReferencesAsync(new LocationIdentificationSegment(), genericSegment);

                case SegmentTypes.LRL:
                    return await GetElementWithReferencesAsync(new LocationRelationshipSegment(), genericSegment);

                case SegmentTypes.MFA:
                    return await GetElementWithReferencesAsync(new MasterFileAcknowledgmentSegment(), genericSegment);

                case SegmentTypes.MFE:
                    return await GetElementWithReferencesAsync(new MasterFileEntrySegment(), genericSegment);

                case SegmentTypes.MFI:
                    return await GetElementWithReferencesAsync(new MasterFileIdentificationSegment(), genericSegment);

                case SegmentTypes.MRG:
                    return await GetElementWithReferencesAsync(new MergePatientInformationSegment(), genericSegment);

                case SegmentTypes.MSA:
                    return await GetElementWithReferencesAsync(new MessageAcknowledgmentSegment(), genericSegment);

                case SegmentTypes.MSH: //TODO:ALM Need to process 1 or other, but not empty? Or pass generic here to all.
                    return await GetElementWithReferencesAsync(new MessageHeader(), genericSegment);
                case SegmentTypes.NCK:
                    return await GetElementWithReferencesAsync(new SystemClockSegment(), genericSegment);

                case SegmentTypes.NDS:
                    return await GetElementWithReferencesAsync(new NotificationDetailSegment(), genericSegment);

                case SegmentTypes.NK1:
                    return await GetElementWithReferencesAsync(new NextOfKin(), genericSegment);

                case SegmentTypes.NPU:
                    return await GetElementWithReferencesAsync(new BedStatusUpdateSegment(), genericSegment);

                case SegmentTypes.NSC:
                    return await GetElementWithReferencesAsync(new ApplicationStatusChangeSegment(), genericSegment);

                case SegmentTypes.NST:
                    return await GetElementWithReferencesAsync(new ApplicationControlLevelStatisticsSegment(), genericSegment);

                case SegmentTypes.NTE:
                    return await GetElementWithReferencesAsync(new NotesAndCommentsSegment(), genericSegment);

                case SegmentTypes.OBR:
                    return await GetElementWithReferencesAsync(new ObservationRequestSegment(), genericSegment);

                case SegmentTypes.OBX:
                    return await GetElementWithReferencesAsync(new ObservationResultSegment(), genericSegment);

                case SegmentTypes.ODS:
                    return await GetElementWithReferencesAsync(new DietaryOrdersSupplementsPreferencesSegment(), genericSegment);

                case SegmentTypes.ODT:
                    return await GetElementWithReferencesAsync(new DietTrayInstructionsSegment(), genericSegment);

                case SegmentTypes.OM1:
                    return await GetElementWithReferencesAsync(new GeneralSegment(), genericSegment);

                case SegmentTypes.OM2:
                    return await GetElementWithReferencesAsync(new NumericObservationSegment(), genericSegment);

                case SegmentTypes.OM3:
                    return await GetElementWithReferencesAsync(new CategoricalServiceTestObservationSegment(), genericSegment);

                case SegmentTypes.OM4:
                    return await GetElementWithReferencesAsync(new ObservationsThatRequireSpecimensSegment(), genericSegment);

                case SegmentTypes.OM5:
                    return await GetElementWithReferencesAsync(new ObservationBatteriesSegment(), genericSegment);

                case SegmentTypes.OM6:
                    return await GetElementWithReferencesAsync(new ObservationsCalculatedFromOtherObservationsSegment(), genericSegment);

                case SegmentTypes.OM7:
                    return await GetElementWithReferencesAsync(new AdditionalBasicAttributesSegment(), genericSegment);

                case SegmentTypes.ORC:
                    return await GetElementWithReferencesAsync(new CommonOrderSegment(), genericSegment);

                case SegmentTypes.ORG:
                    return await GetElementWithReferencesAsync(new PractitionerOrganizationUnitSegment(), genericSegment);

                case SegmentTypes.OVR:
                    return await GetElementWithReferencesAsync(new OverrideSegment(), genericSegment);

                case SegmentTypes.PAC:
                    return await GetElementWithReferencesAsync(new ShipmentPackageSegment(), genericSegment);

                case SegmentTypes.PCE:
                    return await GetElementWithReferencesAsync(new PatientChargeCostCenterExceptionsSegment(), genericSegment);

                case SegmentTypes.PCR:
                    return await GetElementWithReferencesAsync(new PossibleCausalRelationshipSegment(), genericSegment);

                case SegmentTypes.PD1:
                    return await GetElementWithReferencesAsync(new PatientAdditionalDemographicSegment(), genericSegment);

                case SegmentTypes.PDA:
                    return await GetElementWithReferencesAsync(new PatientDeathAndAutopsySegment(), genericSegment);

                case SegmentTypes.PDC:
                    return await GetElementWithReferencesAsync(new ProductDetailCountrySegment(), genericSegment);

                case SegmentTypes.PEO:
                    return await GetElementWithReferencesAsync(new ProductExperienceObservationSegment(), genericSegment);

                case SegmentTypes.PES:
                    return await GetElementWithReferencesAsync(new ProductExperienceSenderSegment(), genericSegment);

                case SegmentTypes.PID:
                    return await GetElementWithReferencesAsync(new PatientIdentification(), genericSegment);
                case SegmentTypes.PKG:
                    return await GetElementWithReferencesAsync(new ItemPackagingSegment(), genericSegment);

                case SegmentTypes.PMT:
                    return await GetElementWithReferencesAsync(new PaymentInformationSegment(), genericSegment);

                case SegmentTypes.PR1:
                    return await GetElementWithReferencesAsync(new ProceduresSegment(), genericSegment);

                case SegmentTypes.PRA:
                    return await GetElementWithReferencesAsync(new PractitionerDetailSegment(), genericSegment);

                case SegmentTypes.PRB:
                    return await GetElementWithReferencesAsync(new ProblemDetailsSegment(), genericSegment);

                case SegmentTypes.PRC:
                    return await GetElementWithReferencesAsync(new PricingSegment(), genericSegment);

                case SegmentTypes.PRD:
                    return await GetElementWithReferencesAsync(new ProviderDataSegment(), genericSegment);

                case SegmentTypes.PRT:
                    return await GetElementWithReferencesAsync(new ParticipationInformationSegment(), genericSegment);

                case SegmentTypes.PSG:
                    return await GetElementWithReferencesAsync(new ProductServiceGroupSegment(), genericSegment);

                case SegmentTypes.PSH:
                    return await GetElementWithReferencesAsync(new ProductSummaryHeaderSegment(), genericSegment);

                case SegmentTypes.PSL:
                    return await GetElementWithReferencesAsync(new ProductServiceLineItemSegment(), genericSegment);

                case SegmentTypes.PSS:
                    return await GetElementWithReferencesAsync(new ProductServiceSectionSegment(), genericSegment);

                case SegmentTypes.PTH:
                    return await GetElementWithReferencesAsync(new PathwaySegment(), genericSegment);

                case SegmentTypes.PV1:
                    return await GetElementWithReferencesAsync(new PatientVisitSegment(), genericSegment);

                case SegmentTypes.PV2:
                    return await GetElementWithReferencesAsync(new PatientVisitAdditionalInformationSegment(), genericSegment);

                case SegmentTypes.PYE:
                    return await GetElementWithReferencesAsync(new PayeeInformationSegment(), genericSegment);

                case SegmentTypes.QAK:
                    return await GetElementWithReferencesAsync(new QueryAcknowledgmentSegment(), genericSegment);

                case SegmentTypes.QID:
                    return await GetElementWithReferencesAsync(new QueryIdentificationSegment(), genericSegment);

                case SegmentTypes.QPD:
                    return await GetElementWithReferencesAsync(new QueryParameterDefinitionSegment(), genericSegment);

                case SegmentTypes.QRD:
                    return await GetElementWithReferencesAsync(new QueryDefinitionSegment(), genericSegment);

                case SegmentTypes.QRF:
                    return await GetElementWithReferencesAsync(new QueryFilterSegment(), genericSegment);

                case SegmentTypes.QRI:
                    return await GetElementWithReferencesAsync(new QueryResponseInstanceSegment(), genericSegment);

                case SegmentTypes.RCP:
                    return await GetElementWithReferencesAsync(new ResponseControlParameterSegment(), genericSegment);

                case SegmentTypes.RDF:
                    return await GetElementWithReferencesAsync(new TableRowDefinitionSegment(), genericSegment);

                case SegmentTypes.RDT:
                    return await GetElementWithReferencesAsync(new TableRowDataSegment(), genericSegment);

                case SegmentTypes.REL:
                    return await GetElementWithReferencesAsync(new ClinicalRelationshipSegmentSegment(), genericSegment);

                case SegmentTypes.RF1:
                    return await GetElementWithReferencesAsync(new ReferralInformationSegment(), genericSegment);

                case SegmentTypes.RFI:
                    return await GetElementWithReferencesAsync(new RequestForInformationSegment(), genericSegment);

                case SegmentTypes.RGS:
                    return await GetElementWithReferencesAsync(new ResourceGroupSegment(), genericSegment);

                case SegmentTypes.RMI:
                    return await GetElementWithReferencesAsync(new RiskManagementIncidentSegment(), genericSegment);

                case SegmentTypes.ROL:
                    return await GetElementWithReferencesAsync(new RoleSegment(), genericSegment);

                case SegmentTypes.RQ1:
                    return await GetElementWithReferencesAsync(new RequisitionDetail1Segment(), genericSegment);

                case SegmentTypes.RQD:
                    return await GetElementWithReferencesAsync(new RequisitionDetailSegment(), genericSegment);

                case SegmentTypes.RXA:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentAdministrationSegment(), genericSegment);

                case SegmentTypes.RXC:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentComponentOrderSegment(), genericSegment);

                case SegmentTypes.RXD:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentDispenseSegment(), genericSegment);

                case SegmentTypes.RXE:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentEncodedOrderSegment(), genericSegment);

                case SegmentTypes.RXG:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentGiveSegment(), genericSegment);

                case SegmentTypes.RXO:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentOrderSegment(), genericSegment);

                case SegmentTypes.RXR:
                    return await GetElementWithReferencesAsync(new PharmacyTreatmentRouteSegment(), genericSegment);

                case SegmentTypes.SAC:
                    return await GetElementWithReferencesAsync(new SpecimenContainerDetailSegment(), genericSegment);

                case SegmentTypes.SCD:
                    return await GetElementWithReferencesAsync(new AntimicrobialCycleDataSegment(), genericSegment);

                case SegmentTypes.SCH:
                    return await GetElementWithReferencesAsync(new SchedulingActivityInformationSegment(), genericSegment);

                case SegmentTypes.SCP:
                    return await GetElementWithReferencesAsync(new AntimicrobialSterilizerConfigurationSegment(), genericSegment);

                case SegmentTypes.SDD:
                    return await GetElementWithReferencesAsync(new SterilizationDeviceDataSegment(), genericSegment);

                case SegmentTypes.SFT:
                    return await GetElementWithReferencesAsync(new SoftwareSegment(), genericSegment);

                case SegmentTypes.SHP:
                    return await GetElementWithReferencesAsync(new ShipmentSegment(), genericSegment);

                case SegmentTypes.SID:
                    return await GetElementWithReferencesAsync(new SubstanceIdentifierSegment(), genericSegment);

                case SegmentTypes.SLT:
                    return await GetElementWithReferencesAsync(new SterilizationLotSegment(), genericSegment);

                case SegmentTypes.SPM:
                    return await GetElementWithReferencesAsync(new SpecimenSegment(), genericSegment);

                case SegmentTypes.STF:
                    return await GetElementWithReferencesAsync(new StaffIdentificationSegment(), genericSegment);

                case SegmentTypes.STZ:
                    return await GetElementWithReferencesAsync(new SterilizationParameterSegment(), genericSegment);

                case SegmentTypes.TCC:
                    return await GetElementWithReferencesAsync(new TestCodeConfigurationSegment(), genericSegment);

                case SegmentTypes.TCD:
                    return await GetElementWithReferencesAsync(new TestCodeDetailSegment(), genericSegment);

                case SegmentTypes.TQ1:
                    return await GetElementWithReferencesAsync(new TimingQuantitySegment(), genericSegment);

                case SegmentTypes.TQ2:
                    return await GetElementWithReferencesAsync(new TimingQuantityRelationshipSegment(), genericSegment);

                case SegmentTypes.TXA:
                    return await GetElementWithReferencesAsync(new TranscriptionDocumentHeaderSegment(), genericSegment);

                case SegmentTypes.UAC:
                    return await GetElementWithReferencesAsync(new UserAuthenticationCredentialSegment(), genericSegment);

                case SegmentTypes.UB1:
                    return await GetElementWithReferencesAsync(new ClaimFormUb82Segment(), genericSegment);

                case SegmentTypes.UB2:
                    return await GetElementWithReferencesAsync(new UniformBillingDataSegment(), genericSegment);

                case SegmentTypes.URD:
                    return await GetElementWithReferencesAsync(new ResultsUpdateDefinitionSegment(), genericSegment);

                case SegmentTypes.URS:
                    return await GetElementWithReferencesAsync(new UnsolicitedSelectionSegment(), genericSegment);

                case SegmentTypes.VAR:
                    return await GetElementWithReferencesAsync(new VarianceSegment(), genericSegment);

                case SegmentTypes.VND:
                    return await GetElementWithReferencesAsync(new PurchasingVendorSegment(), genericSegment);

                case SegmentTypes.ZL7:
                    return await GetElementWithReferencesAsync(new Zl7ProposedExampleSegment(), genericSegment);

                /*
                    case SegmentTypes.Hxx:
                    case SegmentTypes.UNK:
                    case SegmentTypes.Zxx:
                */
                default:
                    return await Task.FromResult(GetCustomSegment(genericSegment.Prefix));
            }
        }

        private static ISegment GetCustomSegment(string segmentTypeName)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(segmentTypeName), segmentTypeName);

            if (segmentTypeName.Equals("Zl7", StringComparison.CurrentCultureIgnoreCase))
                return new Zl7ProposedExampleSegment();

            if (segmentTypeName.StartsWith("H"))
                return new HxxSegment {ActualPrefix = segmentTypeName};

            if (segmentTypeName.StartsWith("Z"))
                return new ZxxSegment {ActualPrefix = segmentTypeName};

            if (segmentTypeName.Equals(SegmentTypes.UNK.ToString()))
                return new CatchallSegment {ActualPrefix = segmentTypeName};

            return new CatchallSegment {ActualPrefix = segmentTypeName};
        }

        public async Task<ISegment> GetElementWithReferencesAsync(ISegment segment, IGenericSegment genericSegment)
        {
            Ensure.ArgumentNotNull(nameof(segment), segment);
            Ensure.ArgumentNotNull(nameof(genericSegment), genericSegment);

            ParsingService.UpdateReferences(segment, genericSegment);

            return await Task.FromResult(segment);
        }
    }
}