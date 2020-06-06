using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.MedicalDocumentManagementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class MedicalDocumentManagementFactory : AbstractTriggerEventFactory<MedicalDocumentManagementFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.MDM_T01:
                    return await Task.FromResult(new OriginalDocumentNotification());

                case TriggerEventTypes.MDM_T02:
                    return await Task.FromResult(new OriginalDocumentNotificationAndContent());

                case TriggerEventTypes.MDM_T03:
                    return await Task.FromResult(new DocumentStatusChangeNotification());

                case TriggerEventTypes.MDM_T04:
                    return await Task.FromResult(new DocumentStatusChangeNotificationAndContent());

                case TriggerEventTypes.MDM_T05:
                    return await Task.FromResult(new DocumentAddendumNotification());

                case TriggerEventTypes.MDM_T06:
                    return await Task.FromResult(new DocumentAddendumNotificationAndContent());

                case TriggerEventTypes.MDM_T07:
                    return await Task.FromResult(new DocumentEditNotification());

                case TriggerEventTypes.MDM_T08:
                    return await Task.FromResult(new DocumentEditNotificationAndContent());

                case TriggerEventTypes.MDM_T09:
                    return await Task.FromResult(new DocumentReplacementNotification());

                case TriggerEventTypes.MDM_T10:
                    return await Task.FromResult(new DocumentReplacementNotificationAndContent());

                case TriggerEventTypes.MDM_T11:
                    return await Task.FromResult(new DocumentCancelNotification());

                default:
                    return null;
            }
        }
    }
}