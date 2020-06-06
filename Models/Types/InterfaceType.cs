namespace HL7Data.Models.Types
{
    public enum InterfaceType
    {
        Unknown,
        HL7Standard = 1,
        Misys = 2, // Misys HL7 v2.3
        MediNotes = 3, // MediNotes HL7 v2.3
        AllScripts = 4, // Allscripts Professional/OLD CollaborateMD (Uses PID 3-1 as PM ID)
        MedAccessHealthSuite = 5, // MedAccess HealthSuite  (Uses PID 3-1 as PM ID and PID2 as SSN)
        SageIntergy = 6, //Sage Intergy & Medware (Uses PID 3-1 as PM ID and PID18 As Chart Number)
        STiComputerServices = 7, // STI Computer Services (Uses PID 3-1 as PM ID & handles the word NEW to the front of the patient ID until the patient appointment is confirmed)
        Xlink = 8, //X-link (Skips Demographics for non ADT Messages)
        AdscMedicsPremier = 9, //ADSC Medics Premier (Imports PCP & Eye Care Provider from Last 2 Custom Fields in ADSC)
        MdSuite = 10, //MDSuite (Uses PID 3-1 as PM ID, Uses AIL3.4.2 for Location ID, Looks in STF 10.9 for Telephone Use Code
        MedComp = 11, // MedComp (Only Changes Charge Messages DFT
        MedEvolve = 12, // MedEvolve (Uses PID 3-1 2nd Repetition as PM ID, Sends "ID^^^^PI" in PID 3-1 for charges)
        Medisys = 13, // Medisys
        MdSuiteAdvancedIntegration = 14, //MDSuite with Advanced Integration
        Mpic = 15, //MPIC - Mckesson Practice Interface Center (Lytec/Medisoft) (Insurance Plan ID in IN1-2)
        Avisena = 16, // Custom Language, Race, Ethnicity, Marital Status, & Filler Status Codes
        IheCEyecareCompliant = 17, //IHE C-EYECARE Compliant (Uses PID 3-1 as PM ID with support for Assigning Authority Namespaces)
        CollaborateMd = 18, //CollaborateMD (Uses PID 3-1 as PM ID and Location Specified in AIG 3-1)
        InternalTesting = 9999
    }
}
