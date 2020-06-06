using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class SpecimenActionCode : ITableInfo
    {
        private static ITableInfo InstanceData => new SpecimenActionCode();
        public static ITableInfo Instance => InstanceData;
        private SpecimenActionCode() { }

        public int Id => 65;
        public string Name => "Specimen Action Code";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Add ordered tests to the existing specimen"},
            {"G", "Generated order; reflex order"},
            {"L", "Lab to obtain specimen from patient"},
            {"O", "Specimen obtained by service other than Lab"},
            {"P", "Pending specimen; Order sent prior to delivery"},
            {"R", "Revised order"},
            {"S", "Schedule the tests specified below"}
        };
    }
}
