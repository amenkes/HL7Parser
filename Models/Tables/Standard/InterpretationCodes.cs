using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class InterpretationCodes : ITableInfo
    {
        private static ITableInfo InstanceData => new InterpretationCodes();
        public static ITableInfo Instance => InstanceData;
        private InterpretationCodes() { }

        public int Id => 78;
        public string Name => "Interpretation Codes";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"L", "Below low normal"},
            {"H", "Above high normal"},
            {"LL", "Below lower panic limits"},
            {"HH", "Above upper panic limits"},
            {"<", "Below absolute low-off instrument scale"},
            {">", "Above absolute high-off instrument scale"},
            {"N", "Normal (applies to non-numeric results)"},
            {"A", "Abnormal (applies to non-numeric results)"},
            {"AA", "Very abnormal (applies to non-numeric units, analogous to panic limits for numeric units)"},
            {"null", "No range defined, or normal ranges don't apply"},
            {"U", "Significant change up"},
            {"D", "Significant change down"},
            {"B", "Better-use when direction not relevant"},
            {"W", "Worse-use when direction not relevant"},
            {"S", "Susceptible. Indicates for microbiology susceptibilities only."},
            {"R", "Resistant. Indicates for microbiology susceptibilities only."},
            {"I", "Intermediate. Indicates for microbiology susceptibilities only."},
            {"MS", "Moderately susceptible. Indicates for microbiology susceptibilities only."},
            {"VS", "Very susceptible. Indicates for microbiology susceptibilities only."},
            {"POS", "Positive"},
            {"NEG", "Negative"},
            {"IND", "Indeterminate"},
            {"DET", "Detected"},
            {"ND", "Not Detected"},
            {"AC", "Anti-complementary substances present"},
            {"TOX", "Cytotoxic substance present"},
            {"QCF", "Quality Control Failure"},
            {"RR", "Reactive"},
            {"WR", "Weakly reactive"},
            {"NR", "Non-reactive"},
            {"OBX", "Interpretation qualifiers in separate OBX segments"},
            {"HM", "Hold for Medical Review"}
        };
    }
}
