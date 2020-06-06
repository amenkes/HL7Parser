using HL7Data.Contracts.Base;
using HL7Data.Models.Types;

namespace HL7Data.Contracts.Fields
{
    public interface IMessageType : IBaseField
    {
        string MessageCode { get; set; }
        string MessageStructure { get; set; }
        string TriggerEvent { get; set; }

        HL7MessageType MessageTypeValue { get; }
        TriggerEventTypes TriggerEventTypeValue { get; }
    }
}