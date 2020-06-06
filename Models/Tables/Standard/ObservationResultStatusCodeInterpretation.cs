using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ObservationResultStatusCodeInterpretation : ITableInfo
    {
        private static ITableInfo InstanceData => new ObservationResultStatusCodeInterpretation();
        public static ITableInfo Instance => InstanceData;
        private ObservationResultStatusCodeInterpretation() { }

        public int Id => 85;
        public string Name => "Observation Result Status Codes Interpretation";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Amended based on adjustments provided by the Placer (Physician) regarding patient demographics (such as age and/or gender or other patient specific information"},
            {"B", "Appended Report – Final results reviewed and further information provided for clarity without change to the original result values."},
            {"C", "Record coming over is a correction and thus replaces a final result"},
            {"D", "Deletes the OBX record"},
            {"F", "Final results"},
            {"I", "Specimen in lab; results pending"},
            {"N", "Not asked; used to affirmatively document that the observation identified in the OBX was not sought when the universal service ID in OBR-4 implies that it would be sought."},
            {"O", "Order detail description only (no result)"},
            {"P", "Preliminary results"},
            {"R", "Results entered -- not verified"},
            {"S", "Partial results.   Deprecated. Retained only for backward compatibility as of V2.6."},
            {"V", "Verified – Final results reviewed and confirmed to be correct, no change to result value, normal range or abnormal flag"},
            {"X", "Results cannot be obtained for this observation"},
            {"U", "Results status change to final without retransmitting results already sent as ‘preliminary.’  E.g., radiology changes status from preliminary to final"},
            {"W", "Post original as wrong, e.g., transmitted for wrong patient"}

        };
    }
}
