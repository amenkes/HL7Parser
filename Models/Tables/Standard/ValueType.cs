using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ValueType : ITableInfo
    {
        private static ITableInfo InstanceData => new ValueType();
        public static ITableInfo Instance => InstanceData;
        private ValueType() { }

        public int Id  => 125;
        public string Name  => "Value Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"AD", "Address"},
            {"CNE", "Coded with No Exceptions"},
            {"CWE", "Coded Entry"},
            {"CF", "Coded Element With Formatted Values"},
            {"CK", "Composite ID With Check Digit"},
            {"CN", "Composite ID And Name"},
            {"CP", "Composite Price"},
            {"CX", "Extended Composite ID With Check Digit"},
            {"DR", "Date/Time Range"},
            {"DT", "Date"},
            {"DTM", "Time Stamp (Date & Time)"},
            {"ED", "Encapsulated Data"},
            {"FT", "Formatted Text (Display)"},
            {"ID", "Coded Value for HL7 Defined Tables"},
            {"IS", "Coded Value for User-Defined Tables"},
            {"MA", "Multiplexed Array"},
            {"MO", "Money"},
            {"NA", "Numeric Array"},
            {"NM", "Numeric"},
            {"PN", "Person Name"},
            {"RP", "Reference Pointer"},
            {"SN", "Structured Numeric"},
            {"ST", "String Data."},
            {"TM", "Time"},
            {"TN", "Telephone Number"},
            {"TX", "Text Data (Display)"},
            {"XAD", "Extended Address"},
            {"XCN", "Extended Composite Name And Number For Persons"},
            {"XON", "Extended Composite Name And Number For Organizations"},
            {"XPN", "Extended Person Name"},
            {"XTN", "Extended Telecommunications Number"}
        };
    }
}

