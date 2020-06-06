using HL7Data.Contracts.Generics;
using System;
using System.Linq;

namespace HL7Data.Models.Generics
{
    public class GenericMessage : BaseGenericElement<IGenericMessage, GenericSegment, IGenericSegment, IGenericPackage>, IGenericMessage
    {
        public IGenericMessageHeader GenericMessageHeader => (IGenericMessageHeader) Children?.First();
        public override string SeparatorCharacter => Environment.NewLine;

        protected override void SetSelf<T>()
        {
            Self = this;
        }
    }
}