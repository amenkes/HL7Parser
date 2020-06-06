using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Base;
using HL7Data.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace HL7Data.Models.Packages
{
    public partial class Package : BaseElement, IPackage
    {
        public Package(IGenericPackage genericPackage)
        {
            Ensure.ArgumentNotNull(nameof(genericPackage), genericPackage);

            SetElement(genericPackage);
        }

        public IGroup FirstGroup => Groups?.FirstOrDefault();
        public IGenericPackage GenericPackage => (IGenericPackage) GenericReferenceElement;
        public IList<IGroup> Groups { get; set; } = new List<IGroup>();
        public IList<IMessage> Messages => GetMessages();
        public InterfaceType ProviderType { get; set; } = InterfaceType.HL7Standard;
    }
}