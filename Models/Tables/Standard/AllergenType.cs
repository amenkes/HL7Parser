using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AllergenType : ITableInfo
    {
        private static ITableInfo InstanceData => new AllergenType();
        public static ITableInfo Instance => InstanceData;
        private AllergenType() { }

        public int Id  => 127;
        public string Name  => "Allergen Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"DA", "Drug allergy"},
            {"FA", "Food allergy"},
            {"MA", "Miscellaneous allergy"},
            {"MC", "Miscellaneous contraindication"},
            {"EA", "Environmental Allergy"},
            {"AA", "Animal Allergy"},
            {"PA", "Plant Allergy"},
            {"LA", "Pollen Allergy"}
        };
    }
}

