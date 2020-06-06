using HL7Data.Classes.Conversion;
using HL7Data.Classes.ExtensionMethods;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Services.Parsing;
using System.Threading.Tasks;
using static HL7Data.Classes.Attributes.CustomAttributes;

namespace HL7Data.Models.Base
{
    public abstract class BaseElement : IElement
    {
        private IGenericRootItem _genericReferenceElement;
        //protected BaseElement() { }

        //protected BaseElement(IGenericRootItem genericReferenceElement)
        //{
        //    SetElement(genericReferenceElement);
        //}

        protected void SetElement(IGenericRootItem genericReferenceElement)
        {
            GenericReferenceElement = genericReferenceElement;
            genericReferenceElement.ReferenceElement = this;
        }

        public virtual string Prefix => PrefixType?.ToString() ?? string.Empty;
        public virtual object PrefixType { get; set; }

        [IgnoreForPopulate]
        public virtual IGenericRootItem GenericReferenceElement
        {
            get => _genericReferenceElement;
            set
            {
                _genericReferenceElement = value;
                Source = _genericReferenceElement?.Source;
                if (_genericReferenceElement != null && _genericReferenceElement.ReferenceElement == null)
                    _genericReferenceElement.ReferenceElement = this;
                Preprocess(_genericReferenceElement);
                var unused = PopulateData();
                Postprocess(_genericReferenceElement);
            }
        }

        public virtual async Task PopulateData()
        {
            await ParsingService.PopulateDataAsync(this);
        }

        public string Source { get; private set; }

        //Empty for override in subclass without forcing implementation
        protected virtual void Preprocess(IGenericRootItem genericReferenceElement) { }

        //Empty for override in subclass without forcing implementation
        protected virtual void Postprocess(IGenericRootItem genericReferenceElement) { }

        public override string ToString()
        {
            return ConversionMethods.BuildOrderedCollection(this).Result.ToCombinedString();
        }
    }
}