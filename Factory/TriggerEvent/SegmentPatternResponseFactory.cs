using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Types;

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously - Factory incomplete. Will by async when implemented

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class SegmentPatternResponseFactory : AbstractTriggerEventFactory<SegmentPatternResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            //TODO
            switch (triggerEventType)
            {
                //case TriggerEventTypes.RSP_K11:
                //    return await Task.FromResult(new SegmentPatternResponseInResponseToQBPQ11()); //TODO
                //case TriggerEventTypes.RSP_K21:
                //    return await Task.FromResult(new GetPersonDemographicsResponse());
                //case TriggerEventTypes.RSP_K22:
                //    return await Task.FromResult(new FindCandidatesResponse());
                //case TriggerEventTypes.RSP_K23:
                //    return await Task.FromResult(new GetCorrespondingIdentifiersResponse());
                //case TriggerEventTypes.RSP_K24:
                //    return await Task.FromResult(new AllocateIdentifiersResponse());
                //case TriggerEventTypes.RSP_K25:
                //    return await Task.FromResult(new PersonnelInformationBySegmentResponse());
                //case TriggerEventTypes.RSP_K31:
                //    return await Task.FromResult(new DispenseHistoryResponse()); //TODO same name as below
                //case TriggerEventTypes.RSP_K32:
                //    return await Task.FromResult(new FindCandidatesIncludingVisitInformationResponse());
                //case TriggerEventTypes.RSP_Q11:
                //    return await Task.FromResult(new SegmentPatternResponse());
                //case TriggerEventTypes.RSP_Z82:
                //    return await Task.FromResult(new DispenseHistoryResponse());  //TODO same name as above
                //case TriggerEventTypes.RSP_Z84:
                //    return await Task.FromResult(new WhoAmIResponse());
                //case TriggerEventTypes.RSP_Z86:
                //    return await Task.FromResult(new PharmacyInformationComprehensiveResponse());
                //case TriggerEventTypes.RSP_Z88:
                //    return await Task.FromResult(new DispenseInformationResponse());
                //case TriggerEventTypes.RSP_Z90:
                //    return await Task.FromResult(new LabResultsHistoryResponse());
                default:
                    return null;
            }
        }
    }
}