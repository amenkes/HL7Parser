using HL7Data.Contracts.Base;
using System;

namespace HL7Data.Contracts.Fields
{
    public interface IDateTime : IBaseField
    {
        DateTime SystemDateTime { get; set; }
    }
}