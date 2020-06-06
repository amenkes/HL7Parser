namespace HL7Data.Models.Types
{
    public enum ElementDataType
    {
        None = 0, // None, Unknown, Generic, etc.
        AD, // Address
        AUI, // Authorization information
        CCD, // Charge code and date
        CCP, // Channel calibration parameters
        CD, // Channel definition
        CE, // Coded element
        CF, // Coded element with formatted values
        CK, // Composite ID with check digit
        CM, // Composite
        CN, // Composite ID number and name
        CNE, // Coded with no exceptions
        CNN, // Composite ID number and name simplified
        CP, // Composite price
        CQ, // Composite quantity with units
        CSU, // Channel sensitivity and units
        CWE, // Coded with exceptions
        CX, // Extended composite ID with check digit
        DDI, // Daily deductible information
        DIN, // Date and institution name
        DLD, // Discharge to location and date
        DLN, // Driver's license number
        DLT, // Delta
        DR, // Date/time range
        DT, // Date
        DTM, // Date/time
        DTN, // Day type and number
        ED, // Encapsulated data
        EI, // Entity identifier
        EIP, // Entity identifier pair
        ELD, // Error location and description
        ERL, // Error location
        FC, // Financial class
        FN, // Family name
        FT, // Formatted text
        GTS, // General timing specification
        HD, // Hierarchic designator
        ICD, // Insurance certification definition
        ID, // Coded values for HL7 tables
        IS, // Coded value for user-defined tables
        JCC, // Job code/class
        LA1, // Location with address variation 1
        LA2, // Location with address variation 2
        MA, // Multiplexed array
        MO, // Money
        MOC, // Money and charge code
        MOP, // Money or percentage
        MSG, // Message type
        NA, // Numeric array
        NDL, // Name with date and location
        NM, // Numeric
        NR, // Numeric range
        OCD, // Occurrence code and date
        OSD, // Order sequence definition
        OSP, // Occurrence span code and date
        PIP, // Practitioner institutional privileges
        PL, // Person location
        PLN, // Practitioner license or other ID number
        PN, // Person name
        PPN, // Performing person time stamp
        PRL, // Parent result link
        PT, // Processing type
        PTA, // Policy type and amount
        QIP, // Query input parameter list
        QSC, // Query selection criteria
        RCD, // Row column definition
        RFR, // Reference range
        RI, // Repeat interval
        RMC, // Room coverage
        RP, // Reference pointer
        RPT, // Repeat pattern
        SAD, // Street Address
        SCV, // Scheduling class value pair
        SI, // Sequence ID
        SN, // Structured numeric
        SNM, // String of telephone number digits
        SPD, // Specialty description
        SPS, // Specimen source
        SRT, // Sort order
        ST, // String data
        TM, // Time
        TN, // Telephone number
        TQ, // Timing/quantity
        TS, // Time stamp
        TX, // Text data
        UVC, // UB value code and amount
        VH, // Visiting hours
        VID, // Version identifier
        VR, // Value range
        WVI, // Channel Identifier
        WVS, // Waveform source
        XAD, // Extended address
        XCN, // Extended composite ID number and name for persons
        XON, // Extended composite name and ID number for organizations
        XPN, // Extended person name
        XTN // Extended telecommunications number
    }
}
