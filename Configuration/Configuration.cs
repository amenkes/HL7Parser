using System;
using HL7Data.Contracts.Base;
using HL7Data.Models.Base;
using HL7Data.Models.Fields;
using HL7Data.Models.Types;
using static HL7Data.Constants.ApplicationConstants;

namespace HL7Data.Configuration
{
    public class Configuration
    {
        public sealed class ConfigurationData : IConfigurationData
        {
            private static readonly Lazy<ConfigurationData> ConfigData =
                new Lazy<ConfigurationData>(() => new ConfigurationData());

            private ConfigurationData()
            {
            }

            public static ConfigurationData Instance => ConfigData.Value;

            public DateTimePrecision DefaultDateTimePrecision => DateTimePrecision.S;

            public IParsingInfo ParsingData => new ParsingInfo
            {
                EncodingCharacters = new EncodingCharacters
                {
                    ComponentSeparator = Defaults.ComponentSeparator,
                    EscapeCharacter = Defaults.EscapeCharacter,
                    RepetitionSeparator = Defaults.RepetitionSeparator,
                    SubcomponentSeparator = Defaults.SubcomponentSeparator
                },
                FieldSeparator = Defaults.FieldSeparator
            };

            public string ApplicationNamespace => Defaults.ApplicationNamespace;
            public string DateTimeFormatString => Defaults.DateTimeFormatString;
        }
    }
}