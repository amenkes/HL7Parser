using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;
using HL7Data.Models.Fields;
using HL7Data.Models.Types;

namespace HL7Data.Models.Base
{
    internal class ParsingInfo : IParsingInfo
    {
        public ParsingInfo()
        {
        }

        public ParsingInfo(string input)
        {
            SetProperties(input);
        }

        public IEncodingCharacters EncodingCharacters { get; set; } = new EncodingCharacters
        {
            ComponentSeparator = Constants.ApplicationConstants.Defaults.ComponentSeparator,
            EscapeCharacter = Constants.ApplicationConstants.Defaults.EscapeCharacter,
            RepetitionSeparator = Constants.ApplicationConstants.Defaults.RepetitionSeparator,
            SubcomponentSeparator = Constants.ApplicationConstants.Defaults.SubcomponentSeparator
        };

        public string FieldSeparator { get; set; } = Constants.ApplicationConstants.Defaults.FieldSeparator;

        private void SetProperties(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return;
            SetPropertiesSubsetData(StringHelpers.IsMessageHeader(data) ? data.Substring(SegmentTypes.MSH.ToString().Length, 5) : data);
        }

        private void SetPropertiesSubsetData(string data)
        {
            if (data.Length < 4 || data.Length > 5) return; // needs to be 4 or 5 characters
            var encoding = data.Right(4); // Take right 4 characters (all if 4, right 4 if 5)
            EncodingCharacters = new EncodingCharacters(encoding);
            if (data.Length == 5)
                FieldSeparator = data.Substring(0, 1);
        }

        public override string ToString()
        {
            return $"{FieldSeparator}{EncodingCharacters}";
        }
    }
}