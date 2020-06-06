using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ClinicalStudyRegistrationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ClinicalStudyRegistrationFactory : AbstractTriggerEventFactory<ClinicalStudyRegistrationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CRM_C01:
                    return await Task.FromResult(new RegisterPatientOnClinicalTrial());

                case TriggerEventTypes.CRM_C02:
                    return await Task.FromResult(new CancelPatientRegistrationOnClinicalTrial());

                case TriggerEventTypes.CRM_C03:
                    return await Task.FromResult(new CorrectUpdateRegistrationInformation());

                case TriggerEventTypes.CRM_C04:
                    return await Task.FromResult(new PatientHasGoneOffClinicalTrial());

                case TriggerEventTypes.CRM_C05:
                    return await Task.FromResult(new PatientEntersPhaseOfClinicalTrial());

                case TriggerEventTypes.CRM_C06:
                    return await Task.FromResult(new CancelPatientEnteringPhase());

                case TriggerEventTypes.CRM_C07:
                    return await Task.FromResult(new CorrectUpdatePhaseInformation());

                case TriggerEventTypes.CRM_C08:
                    return await Task.FromResult(new PatientHasGoneOffPhaseOfClinicalTrial());

                default:
                    return null;
            }
        }
    }
}