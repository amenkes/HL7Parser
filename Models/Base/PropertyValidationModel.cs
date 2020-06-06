using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using System;
using System.Reflection;

namespace HL7Data.Models.Base
{
    public class PropertyValidationModel : IPropertyValidation
    {
        public IGenericRootItem GenericReferenceElement { get; set; }
        public bool IsCollection { get; set; }
        public bool IsIgnored { get; set; }
        public bool IsRequired { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public IElement ReferenceElement { get; set; }
        public Type Type { get; set; }
        public object Value { get; set; }
    }
}