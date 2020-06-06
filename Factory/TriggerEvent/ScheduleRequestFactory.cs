using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ScheduleRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ScheduleRequestFactory : AbstractTriggerEventFactory<ScheduleRequestFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SRM_S01:
                    return await Task.FromResult(new RequestNewAppointmentBooking());

                case TriggerEventTypes.SRM_S02:
                    return await Task.FromResult(new RequestAppointmentRescheduling());

                case TriggerEventTypes.SRM_S03:
                    return await Task.FromResult(new RequestAppointmentModification());

                case TriggerEventTypes.SRM_S04:
                    return await Task.FromResult(new RequestAppointmentCancellation());

                case TriggerEventTypes.SRM_S05:
                    return await Task.FromResult(new RequestAppointmentDiscontinuation());

                case TriggerEventTypes.SRM_S06:
                    return await Task.FromResult(new RequestAppointmentDeletion());

                case TriggerEventTypes.SRM_S07:
                    return await Task.FromResult(new RequestAdditionOfServiceResourceOnAppointment());

                case TriggerEventTypes.SRM_S08:
                    return await Task.FromResult(new RequestModificationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SRM_S09:
                    return await Task.FromResult(new RequestCancellationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SRM_S10:
                    return await Task.FromResult(new RequestDiscontinuationOfServiceResourceOnAppointment());

                case TriggerEventTypes.SRM_S11:
                    return await Task.FromResult(new RequestDeletionOfServiceResourceOnAppointment());

                default:
                    return null;
            }
        }
    }
}