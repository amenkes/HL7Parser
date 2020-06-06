using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class TransportationMode : ITableInfo
    {
        private static ITableInfo InstanceData => new TransportationMode();
        public static ITableInfo Instance => InstanceData;
        private TransportationMode() { }

        public int Id  => 124;
        public string Name  => "Transportation Mode";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"CART", "Cart - patient travels on cart or gurney"},
            {"PORT", "The examining device goes to patient's location"},
            {"WALK", "Patient walks to diagnostic service"},
            {"WHLC", "Wheelchair"}
        };
    }
}

