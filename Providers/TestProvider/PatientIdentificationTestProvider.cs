using HL7Data.Contracts.Providers;
using HL7Data.Models.Segments.Patient.PersonalInformation;

namespace HL7Data.Providers.TestProvider
{
    public class PatientIdentificationTestProvider : PatientIdentification, IProviderData
    {
        public override string Sex => "A";
    }
}
