using System.Collections.Generic;
using HL7Data.Models.Types;

// ReSharper disable InconsistentNaming

namespace HL7Data
{
    public static class Constants
    {
        public static class ApplicationConstants
        {
            internal static class Defaults
            {
                internal const string ComponentSeparator = @"^";
                internal const string EscapeCharacter = @"\";
                internal const string FieldSeparator = @"|";
                internal const string RepetitionSeparator = @"~";
                internal const string SubcomponentSeparator = @"&";

                internal const string ApplicationNamespace = "EyeMDEMR";
                internal const string DateTimeFormatString = "yyyyMMddHHmmss";
            }
        }

        internal static class PropertyNames
        {
            internal static class EncodingCharactersProperties
            {
                internal const string ComponentSeparator = "ComponentSeparator";
                internal const string EscapeCharacter = "EscapeCharacter";
                internal const string RepetitionSeparator = "RepetitionSeparator";
                internal const string SubcomponentSeparator = "SubcomponentSeparator";
            }

            internal static class MessageHeaderProperties
            {
                internal const string EncodingCharacters = "EncodingCharacters";
                internal const string FieldSeparator = "FieldSeparator";
            }
        }

        internal static class FillerStatusCodes
        {
            internal const string Arrived = "Arrived";
            internal const string Booked = "Booked";
            internal const string Cancelled = "Cancelled";
            internal const string CheckedIn = "Checked In";
            internal const string Scheduled = "Scheduled";

            internal static Dictionary<StatusCodeIdentifier, string> StatusCodes =
                new Dictionary<StatusCodeIdentifier, string>
                {
                    {StatusCodeIdentifier.None, null},
                    {StatusCodeIdentifier.Arrived, Arrived},
                    {StatusCodeIdentifier.Booked, Booked},
                    {StatusCodeIdentifier.Cancelled, Cancelled},
                    {StatusCodeIdentifier.CheckedIn, CheckedIn},
                    {StatusCodeIdentifier.Scheduled, Scheduled}
                };
        }

        internal static class DateTimeCodes
        {
            internal const string Day = "Day";
            internal const string Hour = "Hour";
            internal const string Minute = "Minute";
            internal const string Month = "Month";
            internal const string Second = "Second";
            internal const string Year = "Year";

            internal static Dictionary<DateTimePrecision, string> DateTimePrecisionList =
                new Dictionary<DateTimePrecision, string>
                {
                    {DateTimePrecision.None, null},
                    {DateTimePrecision.Y, Year},
                    {DateTimePrecision.L, Month},
                    {DateTimePrecision.D, Day},
                    {DateTimePrecision.H, Hour},
                    {DateTimePrecision.M, Minute},
                    {DateTimePrecision.S, Second}
                };
        }

        internal static class MessageKeys
        {
            internal const string EmptyParameter = "Parameter cannot be empty";
            internal const string StandardKeyValueFormat = @"{0}:{1}";
            internal const string TimespanZero = "Timespan must be greater than zero";
        }

        internal static class Protocols
        {
            internal static class MlpConstants
            {
                internal const int Acknowledgement = 0x06;
                internal const int CarriageReturn = 0x0D;
                internal const int EndBlock = 0x1C; // FileSeparator
                internal const int NegativeAcknowledgement = 0x15;
                internal const int StartBlock = 0x0B; // Vertical Tab

                internal static string MessagePrefix = $"{(char) StartBlock}";
                internal static string MessageSuffix = $"{(char) EndBlock}{(char) CarriageReturn}";

                internal static string AcknowledgementMessage =
                    $"{MessagePrefix}{(char) Acknowledgement}{MessageSuffix}";

                internal static string NegativeAcknowledgementMessage =
                    $"{MessagePrefix}{(char) NegativeAcknowledgement}{MessageSuffix}";
            }
        }
    }
}