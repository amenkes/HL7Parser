using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MilitaryService : ITableInfo
    {
        private static ITableInfo InstanceData => new MilitaryService();
        public static ITableInfo Instance => InstanceData;
        private MilitaryService() { }

        public int Id  => 140;
        public string Name  => "Military Service";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"USA", "US Army"},
            {"USN", "US Navy"},
            {"USAF", "US Air Force"},
            {"USMC", "US Marine Corps"},
            {"USCG", "US Coast Guard"},
            {"USPHS", "US Public Health Service"},
            {"NOAA", "National Oceanic and Atmospheric Administration"},
            {"NATO", "North Atlantic Treaty Organization"},
            {"AUSA", "Australian Army"},
            {"AUSN", "Australian Navy"},
            {"AUSAF", "Australian Air Force"}
        };
    }
}

