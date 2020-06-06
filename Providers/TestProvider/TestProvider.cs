using System;
using System.Collections.Generic;
using HL7Data.Models.Segments.Patient.PersonalInformation;
using HL7Data.Providers.Base;

namespace HL7Data.Providers.TestProvider
{
    public class TestProvider : BaseProvider
    {
        public override IDictionary<Type, Type> ProviderOverrides => new Dictionary<Type, Type>
        {
            {typeof(PatientIdentification), typeof(PatientIdentificationTestProvider)}
        };
    }
}
