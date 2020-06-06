// ReSharper disable InconsistentNaming
namespace HL7Data.Models.Types
{
    public enum HL7MessageType
    {
        Unknown,
        ACK, // General acknowledgment message
        ADR, // Patient query
        ADT, // ADT message
        BAR, // Add/change billing account
        BPS, // Blood product dispense status message
        BRP, // Blood product dispense status acknowledgement message
        BRT, // Blood product transfusion/disposition acknowledgement message
        BTS, // Blood product transfusion/disposition message
        CCF, // Collaborative Care Fetch
        CCI, // Collaborative Care Information
        CCM, // Collaborative Care Message
        CCQ, // Collaborative Care Referral
        CCR, // Continuity of Care Record
        CCU, // Collaborative Care Referral
        CQU, // Collaborative Care Referral Update
        CRM, // Clinical study registration message
        CSU, // Unsolicited study data message
        DBC, // Create Donor Record Message
        DBU, // Update Donor Record Message
        DEL, // Donor Eligibility
        DEO, // Donor Eligibility Observation
        DER, // Donor Eligibility Request
        DFT, // Detail financial transactions
        DOC, // Document Query
        DPR, // Donation Procedure (v 2.8)
        DRC, // Donor Request to Collect
        DRG, // Diagnosis Related Group
        DSR, // Deferred response to a query
        EAC, // Automated equipment command message
        EAN, // Automated equipment notification message
        EAR, // Automated equipment response message
        EDR, // Enhanced Display Response
        EHC, // Health Care Invoice
        ERP, // Evem Replay response
        ESR, // Automated equipment status update acknowledgment message
        ESU, // Automated equipment status update message
        EQQ, // Embedded Query Language
        INR, // Automated equipment inventory request message
        INU, // Automated equipment inventory update message
        LSR, // Automated equipment log/service request message
        LSU, // Automated equipment log/service update message
        MDM, // Medical document management
        MFK, // Master files application acknowledgment
        MFN, // Master files notification
        MFQ, // Query For MasterFile Record
        MFR, // Master file response
        NMD, // Application management data message
        NMQ, // Application management query message
        NMR, // Application management response message
        OMB, // Blood product order message
        OMD, // Dietary order
        OMG, // General clinical order message
        OMI, // Imaging order
        OML, // Laboratory order message
        OMN, // Non-stock requisition order message
        OMP, // Pharmacy/treatment order message
        OMQ, // General order message with document payload
        OMS, // Stock requisition order message
        OPL, // Population/Location-Based Laboratory Order Message
        OPR, // Population/Location-Based Laboratory Order Acknowledgment Message
        OPU, // Unsolicited Population/Location-Based Laboratory Observation Message
        ORA, // Observation Report Acknowledgment
        ORB, // Blood product order acknowledgement message
        ORD, // Dietary order acknowledgment message
        ORF, // Response To Query Transmission Of Requested Observation
        ORG, // General clinical order acknowledgment message
        ORI, // Imaging order acknowledgement message
        ORL, // Laboratory acknowledgment message (unsolicited)
        ORM, // Order Message
        ORN, // Non-stock requisition - General order acknowledgment message
        ORP, // Pharmacy/treatment order acknowledgment message
        ORR, // Order Response
        ORS, // Stock requisition - Order acknowledgment message
        ORU, // Unsolicited transmission of an observation message
        ORX, // General Order Message with Document Payload Acknowledgement
        OSM, // Specimen Shipment Message
        OSQ, // Query For Order Status
        OSR, // Query Response For Order Status
        OSU, // Order status update
        OUL, // Unsolicited laboratory observation message
        PEX, // Product experience message
        PGL, // Patient goal message
        PIN, // Patient insurance information
        PMU, // Add personnel record
        PPG, // Patient pathway message (goal-oriented)
        PPP, // Patient pathway message (problem-oriented)
        PPR, // Patient problem message
        QBP, // Query by parameter
        QCN, // Cancel query
        QCK, // Query (For deferred response)
        QRY, // Query
        QSB, // Create subscription
        QSX, // Cancel subscription/acknowledge message
        QVR, // Query for previous events
        RAR, // Pharmacy/treatment Administration Information
        RAS, // Pharmacy/treatment administration message
        RCL, // Return Clinical Information
        RDE, // Pharmacy/treatment encoded order message
        RDR, // Pharmacy/treatment dispense information
        RDS, // Pharmacy/treatment dispense message
        RDY, // Display based response
        REF, // Patient referral
        RER, // Pharmacy/Treatment Encoded Order Information
        RGV, // Pharmacy/treatment give message
        RGR, // Pharmacy/Treatment Dose Information
        RPA, // Return patient authorization
        RPI, // Return patient information
        RPL, // Return patient display list
        RPR, // Return patient list
        RQA, // Request patient authorization
        ROR, // Pharmacy Prescription Order Query Response
        RQC, // Request For Patient Clinical Information
        RQI, // Request patient information
        RQP, // Request patient demographics
        RQQ, // Event Replay Query
        RRA, // Pharmacy/treatment administration acknowledgment message
        RRD, // Pharmacy/treatment dispense acknowledgment message
        RRE, // Pharmacy/treatment encoded order acknowledgment message
        RRG, // Pharmacy/treatment give acknowledgment message
        RRI, // Return referral information
        RSP, // Segment pattern response
        RTB, // Tabular response
        SCN, // Notification of Anti-Microbial Device Cycle Data
        SDN, // Notification of Anti-Microbial Device Data
        SDR, // Sterilization anti-microbial device data request
        SIU, // Schedule information unsolicited
        SLN, // Notification of New Sterilization Lot
        SLR, // Sterilization lot request
        SMD, // Sterilization anti-microbial device cycle data request
        SPQ, // Stored Procedure Request
        SQR, // Schedule Query Message And Response
        SRM, // Schedule request message
        SRR, // Scheduled request response
        SSR, // Specimen status request message
        SSU, // Specimen status update message
        STC, // Notification of Sterilization Configuration
        STI, // Sterilization item request
        TBR, // Tabular Data Response
        TCR, // Automated equipment test code settings request message
        TCU, // Automated equipment test code settings update message
        UDM, // Unsolicited display update message
        VQQ, // Virtual Table Query
        VXQ, // Query For Vaccination Record
        VXR, // Vaccination Record Response
        VXU, // Unsolicited vaccination record update
        VXX, // Response To Vaccination Query
        ZZZ // Used for Custom
    }
}
