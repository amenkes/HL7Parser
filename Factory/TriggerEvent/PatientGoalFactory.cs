using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PatientGoalMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PatientGoalFactory : AbstractTriggerEventFactory<PatientGoalFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.PGL_PC6:
                    return await Task.FromResult(new PcGoalAdd());

                case TriggerEventTypes.PGL_PC7:
                    return await Task.FromResult(new PcGoalUpdate());

                case TriggerEventTypes.PGL_PC8:
                    return await Task.FromResult(new PcGoalDelete());

                default:
                    return null;
            }
        }
    }
}