using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.MasterFilesNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class MasterFilesNotificationFactory : AbstractTriggerEventFactory<MasterFilesNotificationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.MFN_M02:
                    return await Task.FromResult(new MasterFileStaffPractitioner());

                case TriggerEventTypes.MFN_M04:
                    return await Task.FromResult(new MasterFilesChargeDescription());

                case TriggerEventTypes.MFN_M05:
                    return await Task.FromResult(new PatientLocationMasterFile());

                case TriggerEventTypes.MFN_M06:
                    return await Task.FromResult(new ClinicalStudyWithPhasesAndSchedulesMasterFile());

                case TriggerEventTypes.MFN_M07:
                    return await Task.FromResult(new ClinicalStudyWithoutPhasesButWithSchedulesMasterFile());

                case TriggerEventTypes.MFN_M08:
                    return await Task.FromResult(new TestObservationNumericMasterFile());

                case TriggerEventTypes.MFN_M09:
                    return await Task.FromResult(new TestObservationCategoricalMasterFile());

                case TriggerEventTypes.MFN_M10:
                    return await Task.FromResult(new TestObservationBatteriesMasterFile());

                case TriggerEventTypes.MFN_M11:
                    return await Task.FromResult(new TestCalculatedObservationsMasterFile());

                case TriggerEventTypes.MFN_M12:
                    return await Task.FromResult(new MasterFilesNotificationMessage());

                case TriggerEventTypes.MFN_M13:
                    return await Task.FromResult(new MasterFilesNotificationGeneral());

                case TriggerEventTypes.MFN_M14:
                    return await Task.FromResult(new MasterFilesNotificationSiteDefined());

                case TriggerEventTypes.MFN_M15:
                    return await Task.FromResult(new InventoryItemMasterFileNotification());

                case TriggerEventTypes.MFN_M16:
                    return await Task.FromResult(new MasterFilseNotificationInventoryItemEnhanced());

                case TriggerEventTypes.MFN_M17:
                    return await Task.FromResult(new DrgMasterFilesMessage());

                default:
                    return null;
            }
        }
    }
}