using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.BillingMessages;
using HL7Data.Models.Messages.ErrorMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class BillingAccountFactory : AbstractTriggerEventFactory<BillingAccountFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.BAR_P01:
                    return await Task.FromResult(new AddPatientAccounts());

                case TriggerEventTypes.BAR_P02:
                    return await Task.FromResult(new PurgePatientAccount());

                case TriggerEventTypes.BAR_P05:
                    return await Task.FromResult(new UpdateAccount());

                case TriggerEventTypes.BAR_P06:
                    return await Task.FromResult(new EndAccount());

                case TriggerEventTypes.BAR_P10:
                    return await Task.FromResult(new TransmitAmbulatoryPaymentClassification());

                case TriggerEventTypes.BAR_P12:
                    return await Task.FromResult(new UpdateDiagnoseProcedure());

                default:
                    return await Task.FromResult(new ErrorMessage()); //TODO
            }
        }
    }
}