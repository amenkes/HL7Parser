using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedStudyDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class UnsolicitedStudyDataFactory : AbstractTriggerEventFactory<UnsolicitedStudyDataFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CSU_C09:
                    return await Task.FromResult(new AutomatedReportingTimeIntervals());

                case TriggerEventTypes.CSU_C10:
                    return await Task.FromResult(new PatientCompletesClinicalTrial());

                case TriggerEventTypes.CSU_C11:
                    return await Task.FromResult(new PatientCompletesClinicalTrialPhase());

                case TriggerEventTypes.CSU_C12:
                    return await Task.FromResult(new UpdatePatientOrderResultInformation());

                default:
                    return null;
            }
        }
    }
}