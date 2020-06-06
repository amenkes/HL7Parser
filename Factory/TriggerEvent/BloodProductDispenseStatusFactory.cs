using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.BloodProductDispenseStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class BloodProductDispenseStatusFactory : AbstractTriggerEventFactory<BloodProductDispenseStatusFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.BPS_O29:
                    return await Task.FromResult(new BloodProductDispenseStatus());

                default:
                    return null;
            }
        }
    }
}