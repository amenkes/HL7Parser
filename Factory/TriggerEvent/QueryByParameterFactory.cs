using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.QueryByParameterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class QueryByParameterFactory : AbstractTriggerEventFactory<QueryByParameterFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            //TODO
            switch (triggerEventType)
            {
                //case TriggerEventTypes.QBP_E03:
                //    return await Task.FromResult(new HealthcareServicesInvoiceStatus());
                //case TriggerEventTypes.QBP_E22:
                //    return await Task.FromResult(new AuthorizationRequestStatus());
                case TriggerEventTypes.QBP_K13:
                    return await Task.FromResult(new QueryByParameter());
                //case TriggerEventTypes.QBP_Q11:
                //    return await Task.FromResult(new QueryByParameterRequestingAnRSPSegmentPatternResponse());
                //case TriggerEventTypes.QBP_Q13:
                //    return await Task.FromResult(new QueryByParameterRequestingAnRTBTabularResponse()); //TODO
                //case TriggerEventTypes.QBP_Q15:
                //    return await Task.FromResult(new QueryByParameterRequestingAnRTBTabularResponse()); //TODO
                //case TriggerEventTypes.QBP_Q21:
                //    return await Task.FromResult(new GetPersonDemographics());
                //case TriggerEventTypes.QBP_Q22:
                //    return await Task.FromResult(new FindCandidates());
                //case TriggerEventTypes.QBP_Q23:
                //    return await Task.FromResult(new GetCorrescpondingIdentifiers());
                //case TriggerEventTypes.QBP_Q24:
                //    return await Task.FromResult(new AllocateIdentifiers());
                //case TriggerEventTypes.QBP_Q25:
                //    return await Task.FromResult(new PersonnelInformationBySegmentQuery());
                //case TriggerEventTypes.QBP_Q31:
                //    return await Task.FromResult(new QBPQueryDispenseHistory());
                //case TriggerEventTypes.QBP_Q32:
                //    return await Task.FromResult(new FindCandidatesIncludingVisitInformation());
                //case TriggerEventTypes.QBP_Z73:
                //    return await Task.FromResult(new InformationAboutPhoneCalls());
                //case TriggerEventTypes.QBP_Z75:
                //    return await Task.FromResult(new TabularPatientList75());//TODO
                //case TriggerEventTypes.QBP_Z77:
                //    return await Task.FromResult(new TabularPatientList77());//TODO
                //case TriggerEventTypes.QBP_Z79:
                //    return await Task.FromResult(new DispenseInformation());
                //case TriggerEventTypes.QBP_Z81:
                //    return await Task.FromResult(new DispenseHistory());//TODO
                //case TriggerEventTypes.QBP_Z85:
                //    return await Task.FromResult(new PharmacyInformationComprehensive());
                //case TriggerEventTypes.QBP_Z87:
                //    return await Task.FromResult(new DispenseInformation()); //TODO
                //case TriggerEventTypes.QBP_Z89:
                //    return await Task.FromResult(new LabResultsHistory());
                //case TriggerEventTypes.QBP_Z91:
                //    return await Task.FromResult(new WhoAmI91()); //TODO
                //case TriggerEventTypes.QBP_Z93:
                //    return await Task.FromResult(new TabularDispenseHistory93()); //TODO
                //case TriggerEventTypes.QBP_Z95:
                //    return await Task.FromResult(new TabularDispenseHistory95()); //TODO
                //case TriggerEventTypes.QBP_Z97:
                //    return await Task.FromResult(new DispenseHistory()); //TODO
                //case TriggerEventTypes.QBP_Z99:
                //    return await Task.FromResult(new WhoAmI99()); //TODO
                default:
                    return null;
            }
        }
    }
}