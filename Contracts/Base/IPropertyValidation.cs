using HL7Data.Contracts.Generics;
using System;
using System.Reflection;

namespace HL7Data.Contracts.Base
{
    public interface IPropertyValidation
    {
        IGenericRootItem GenericReferenceElement { get; set; }
        bool IsCollection { get; }
        bool IsIgnored { get; }
        bool IsRequired { get; }
        int? MaxLength { get; }
        int? MinLength { get; }
        string Name { get; }
        int? Order { get; }
        PropertyInfo PropertyInfo { get; }
        IElement ReferenceElement { get; set; }
        Type Type { get; }
        object Value { get; set; }
    }
}