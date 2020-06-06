using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ScheduleInformationUnsolicitedMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ScheduleInformationUnsolicitedFactory : AbstractTriggerEventFactory<ScheduleInformationUnsolicitedFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SIU_S12:
                    return await Task.FromResult(new NotificationNewAppointmentBooking());

                case TriggerEventTypes.SIU_S13:
                    return await Task.FromResult(new NotificationAppointmentRescheduling());

                case TriggerEventTypes.SIU_S14:
                    return await Task.FromResult(new NotificationAppointmentModification());

                case TriggerEventTypes.SIU_S15:
                    return await Task.FromResult(new NotificationAppointmentCancellation());

                case TriggerEventTypes.SIU_S16:
                    return await Task.FromResult(new NotificationAppointmentDiscontinuation());

                case TriggerEventTypes.SIU_S17:
                    return await Task.FromResult(new NotificationAppointmentDeletion());

                case TriggerEventTypes.SIU_S18:
                    return await Task.FromResult(new NotificationAdditionOfServiceResourceOnAppointment());

                case TriggerEventTypes.SIU_S19:
                    return await Task.FromResult(new NotificationModificationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SIU_S20:
                    return await Task.FromResult(new NotificationCancellationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SIU_S21:
                    return await Task.FromResult(new NotificationDiscontinuationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SIU_S22:
                    return await Task.FromResult(new NotificationDeletionOfServiceResourceOnAppointment());

                case TriggerEventTypes.SIU_S23:
                    return await Task.FromResult(new NotificationBlockedScheduleTimeslot());

                case TriggerEventTypes.SIU_S24:
                    return await Task.FromResult(new NotificationOpenedUnblockedScheduleTimeslot());

                case TriggerEventTypes.SIU_S26:
                    return await Task.FromResult(new NotificationPatientDidNotShowUpForScheduledAppointment());

                case TriggerEventTypes.SIU_S27:
                    return await Task.FromResult(new BroadcastNotificationScheduledAppointments());

                default:
                    return null;
            }
        }
    }
}