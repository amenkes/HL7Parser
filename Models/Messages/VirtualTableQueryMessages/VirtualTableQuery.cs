using HL7Data.Contracts.Messages.VirtualTableQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.VirtualTableQueryMessages
{
    public class VirtualTableQuery : BaseVirtualTableQueryMessage, IVirtualTableQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.VQQ_Q07;
    }
}