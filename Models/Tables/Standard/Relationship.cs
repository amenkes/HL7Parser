using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class Relationship : ITableInfo
    {
        private static ITableInfo InstanceData => new Relationship();
        public static ITableInfo Instance => InstanceData;
        private Relationship() { }

        public int Id => 63;
        public string Name => "Relationship";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"SEL", "Self"},
            {"SPO", "Spouse"},
            {"DOM", "Life partner"},
            {"CHD", "Child"},
            {"GCH", "Grandchild"},
            {"NCH", "Natural child"},
            {"SCH", "Stepchild"},
            {"FCH", "Foster child"},
            {"DEP", "Handicapped dependent"},
            {"WRD", "Ward of court"},
            {"PAR", "Parent"},
            {"MTH", "Mother"},
            {"FTH", "Father"},
            {"CGV", "Care giver"},
            {"GRD", "Guardian"},
            {"GRP", "Grandparent"},
            {"EXF", "Extended family"},
            {"SIB", "Sibling"},
            {"BRO", "Brother"},
            {"SIS", "Sister"},
            {"FND", "Friend"},
            {"OAD", "Other adult"},
            {"EME", "Employee"},
            {"EMR", "Employer"},
            {"ASC", "Associate"},
            {"EMC", "Emergency contact"},
            {"OWN", "Owner"},
            {"TRA", "Trainer"},
            {"MGR", "Manager"},
            {"NON", "None"},
            {"UNK", "Unknown"},
            {"OTH", "Other"}
        };
    }
}
