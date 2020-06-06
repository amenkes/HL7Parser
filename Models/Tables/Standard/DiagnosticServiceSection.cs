using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class DiagnosticServiceSection : ITableInfo
    {
        private static ITableInfo InstanceData => new DiagnosticServiceSection();
        public static ITableInfo Instance => InstanceData;
        private DiagnosticServiceSection() { }

        public int Id => 74;
        public string Name => "Diagnostic Service Section ID";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {{"AU", "Audiology"},
            {"BG", "Blood Gases"},
            {"BLB", "Blood Bank"},
            {"CUS", "Cardiac Ultrasound"},
            {"CTH", "Cardiac Catheterization"},
            {"CT", "CAT Scan"},
            {"CH", "Chemistry"},
            {"CP", "Cytopathology"},
            {"EC", "Electrocardiac (e.g., EKG,  EEC, Holter)"},
            {"EN", "Electroneuro (EEG, EMG,EP,PSG)"},
            {"HM", "Hematology"},
            {"ICU", "Bedside ICU Monitoring"},
            {"IMM", "Immunology"},
            {"LAB", "Laboratory"},
            {"MB", "Microbiology"},
            {"MCB", "Mycobacteriology"},
            {"MYC", "Mycology"},
            {"NMS", "Nuclear Medicine Scan"},
            {"NMR", "Nuclear Magnetic Resonance"},
            {"NRS", "Nursing Service Measures"},
            {"OUS", "OB Ultrasound"},
            {"OT", "Occupational Therapy"},
            {"OTH", "Other"},
            {"OSL", "Outside Lab"},
            {"PHR", "Pharmacy"},
            {"PT", "Physical Therapy"},
            {"PHY", "Physician (Hx. Dx, admission note, etc.)"},
            {"PF", "Pulmonary Function"},
            {"RAD", "Radiology"},
            {"RX", "Radiograph"},
            {"RUS", "Radiology Ultrasound"},
            {"RC", "Respiratory Care (therapy)"},
            {"RT", "Radiation Therapy"},
            {"SR", "Serology"},
            {"SP", "Surgical Pathology"},
            {"TX", "Toxicology"},
            {"VUS", "Vascular Ultrasound"},
            {"VR", "Virology"},
            {"XRC", "Cineradiograph"}

        };
    }
}
