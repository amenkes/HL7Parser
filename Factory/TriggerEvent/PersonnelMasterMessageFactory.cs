using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PersonnelMasterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PersonnelMasterMessageFactory : AbstractTriggerEventFactory<PersonnelMasterMessageFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.PMU_B01:
                    return await Task.FromResult(new AddPersonnelRecord());

                case TriggerEventTypes.PMU_B02:
                    return await Task.FromResult(new UpdatePersonnelRecord());

                case TriggerEventTypes.PMU_B03:
                    return await Task.FromResult(new DeletePersonnelRecord());

                case TriggerEventTypes.PMU_B04:
                    return await Task.FromResult(new ActivatePracticingPerson());

                case TriggerEventTypes.PMU_B05:
                    return await Task.FromResult(new DeactivatePracticingPerson());

                case TriggerEventTypes.PMU_B06:
                    return await Task.FromResult(new TerminatePracticingPerson());

                case TriggerEventTypes.PMU_B07:
                    return await Task.FromResult(new GrantCertificatePermission());

                case TriggerEventTypes.PMU_B08:
                    return await Task.FromResult(new RevokeCertificatePermission());

                default:
                    return null;
            }
        }
    }
}