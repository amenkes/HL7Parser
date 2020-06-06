using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.QueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class QueryFactory : AbstractTriggerEventFactory<QueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.QRY:
                    return await Task.FromResult(new Query());

                case TriggerEventTypes.QRY_A19:
                    return await Task.FromResult(new PatientQuery());

                case TriggerEventTypes.QRY_PC4:
                    return await Task.FromResult(new ProblemQuery());

                case TriggerEventTypes.QRY_PC9:
                    return await Task.FromResult(new PcGoalQuery());

                case TriggerEventTypes.QRY_PCE:
                    return await Task.FromResult(new PcPathwayProblemOrientedQuery());

                case TriggerEventTypes.QRY_PCK:
                    return await Task.FromResult(new PcPathwayGoalOrientedQuery());

                case TriggerEventTypes.QRY_Q01:
                    return await Task.FromResult(new QuerySentForImmediateResponse());

                case TriggerEventTypes.QRY_Q02:
                    return await Task.FromResult(new QuerySentForDeferredResponse());

                case TriggerEventTypes.QRY_R02:
                    return await Task.FromResult(new QueryForResultsOfObservation());

                default:
                    return null;
            }
        }
    }
}