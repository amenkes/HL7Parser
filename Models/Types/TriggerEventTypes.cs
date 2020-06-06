namespace HL7Data.Models.Types
{
    public enum TriggerEventTypes
    {
        Unknown = 0,
        ACK, // General acknowledgment message
        ADR_A19, // Patient query
        ADT_A01, // Admit/visit notification
        ADT_A02, // Transfer a patient
        ADT_A03, // Discharge/end visit
        ADT_A04, // Register a patient
        ADT_A05, // Pre-admit a patient
        ADT_A06, // Change an outpatient to an inpatient
        ADT_A07, // Change an inpatient to an outpatient
        ADT_A08, // Update patient information
        ADT_A09, // Patient departing - tracking
        ADT_A10, // Patient arriving - tracking
        ADT_A11, // Cancel admit/visit notification
        ADT_A12, // Cancel transfer
        ADT_A13, // Cancel discharge/end visit
        ADT_A14, // Pending admit
        ADT_A15, // Pending transfer
        ADT_A16, // Pending discharge
        ADT_A17, // Swap patients
        ADT_A18, // Merge patient information
        ADT_A19, // QRY/ADR - Patient query
        ADT_A20, // Bed status update
        ADT_A21, // Patient goes on a "leave of absence"
        ADT_A22, // Patient returns from a "leave of absence"
        ADT_A23, // Delete a patient record
        ADT_A24, // Link patient information
        ADT_A25, // Cancel pending discharge
        ADT_A26, // Cancel pending transfer
        ADT_A27, // Cancel pending admit
        ADT_A28, // Add person information
        ADT_A29, // Delete person information
        ADT_A30, // Merge person information
        ADT_A31, // Update person information
        ADT_A32, // Cancel patient arriving - tracking
        ADT_A33, // Cancel patient departing - tracking
        ADT_A34, // Merge patient information - patient id only
        ADT_A35, // Merge patient information - account number only
        ADT_A36, // Merge patient information - patient id and account number
        ADT_A37, // Unlink patient information
        ADT_A38, // Cancel pre-admit
        ADT_A39, // Merge person - patient id
        ADT_A40, // Merge patient - patient identifier list
        ADT_A41, // Merge account - patient account number
        ADT_A42, // Merge visit - visit number
        ADT_A43, // Move patient information - patient identifier list
        ADT_A44, // Move account information - patient account number
        ADT_A45, // Move visit information - visit number
        ADT_A46, // Change patient id (for backward compatibility only)
        ADT_A47, // Change patient identifier list
        ADT_A48, // Change alternate patient id
        ADT_A49, // Change patient account number
        ADT_A50, // Change visit number
        ADT_A51, // Change alternate visit ID
        ADT_A52, // Cancel leave of absence for a patient
        ADT_A53, // Cancel patient returns from a leave of absence
        ADT_A54, // Change attending doctor
        ADT_A55, // Cancel change attending doctor
        ADT_A60, // Update allergy information
        ADT_A61, // Change consulting doctor
        ADT_A62, // Cancel change consulting doctor
        BAR_P01, // Add patient accounts
        BAR_P02, // Purge patient accounts

        //
        BAR_P05, // Update account

        BAR_P06, // End account

        //
        BAR_P10, // Transmit Ambulatory Payment Classification(APC)

        //
        BAR_P12, // Update Diagnosis/Procedure

        BPS_O29, // Blood product dispense status
        BRP_O30, // Blood product dispense status acknowledgment
        BRT_O32, // Blood product transfusion/disposition acknowledgment
        BTS_O31, // Blood product transfusion/disposition
        CCF_I22, // Collaborative Care Fetch / Collaborative Care Information
        CCM_I21, // Collaborative Care Message
        CCQ_I19, // Collaborative Care Query/Collaborative Care Query Update
        CCR_I16, // Collaborative Care Referral
        CCR_I17, // Modify Collaborative Care Referral
        CCR_I18, // Cancel Collaborative Care Referral
        CCU_I20, // Asynchronous Collaborative Care Update
        CRM_C01, // Register a patient on a clinical trial
        CRM_C02, // Cancel a patient registration on clinical trial (for clerical mistakes only)
        CRM_C03, // Correct/update registration information
        CRM_C04, // Patient has gone off a clinical trial
        CRM_C05, // Patient enters phase of clinical trial
        CRM_C06, // Cancel patient entering a phase (clerical mistake)
        CRM_C07, // Correct/update phase information
        CRM_C08, // Patient has gone off phase of clinical trial
        CSU_C09, // Automated time intervals for reporting, like monthly
        CSU_C10, // Patient completes the clinical trial
        CSU_C11, // Patient completes a phase of the clinical trial
        CSU_C12, // Update/correction of patient order/result information
        DFT_P03, // Post detail financial transaction
        DFT_P11, // Post detail financial transactions - New
        DOC_T12, // Document response
        DPR_048, // Donation Procedure (2.8)
        DSR_Q01, // Display response message
        DSR_Q03, // Deferred response to a query
        EAC_U07, // Automated equipment command
        EAN_U09, // Automated equipment notification
        EAR_U08, // Automated equipment response
        EDR_R07, // Enhanced display response
        EHC_E01, // Submit Healthcare Services Invoice
        EHC_E02, // Cancel Healthcare Services Invoice
        EHC_E04, // Assess Healthcare Services Invoice Request
        EHC_E10, // Edit/Adjudication Results
        EHC_E12, // Request Additional Information
        EHC_E13, // Additional Information Response
        EHC_E15, // Payment/Remittance Advice
        EHC_E20, // Submit Authorization Request
        EHC_E21, // Cancel Authorization Request
        EHC_E24, // Authorization Response
        EQQ_Q04, // Embedded query language query
        ERP_R09, // Event replay response
        ESR_U02, // Automated equipment status request
        ESU_U01, // Automated equipment status update
        INR_U06, // Automated equipment inventory request
        INU_U05, // Automated equipment inventory update
        LSR_U13, // Automated equipment log/service request
        LSU_U12, // Automated equipment log/service update
        MDM_T01, // Original document notification
        MDM_T02, // Original document notification and content
        MDM_T03, // Document status change notification
        MDM_T04, // Document status change notification and content
        MDM_T05, // Document addendum notification
        MDM_T06, // Document addendum notification and content
        MDM_T07, // Document edit notification
        MDM_T08, // Document edit notification and content
        MDM_T09, // Document replacement notification
        MDM_T10, // Document replacement notification and content
        MDM_T11, // Document cancel notification
        MFK_M01, // Master file application acknowledgment
        MFN_M02, // Master file - staff practitioner
        MFN_M04, // Master files charge description
        MFN_M05, // Patient location master file
        MFN_M06, // Clinical study with phases and schedules master file
        MFN_M07, // Clinical study without phases but with schedules master file
        MFN_M08, // Test/observation (numeric) master file
        MFN_M09, // Test/observation (categorical) master file
        MFN_M10, // Test /observation batteries master file
        MFN_M11, // Test/calculated observations master file
        MFN_M12, // Master file notification message
        MFN_M13, // Master file notification - general
        MFN_M14, // Master file notification - site defined
        MFN_M15, // Inventory item master file notification
        MFN_M16, // Master File Notification Inventory Item Enhanced
        MFN_M17, // DRG Master File Message
        MFQ_M01, // Query for master file record
        MFR_M04, // Master files response
        MFR_M05, // Master files response
        MFR_M06, // Master files response
        MFR_M07, // Master files response
        NMD_N02, // Application management data message (unsolicited)
        NMQ_N01, // Application management query message
        NMR_N01, // Application management response
        OMB_O27, // Blood product order
        OMD_O03, // Diet order
        OMG_O19, // General clinical order
        OMI_O23, // Imaging order
        OML_O21, // Laboratory order
        OML_O33, // Laboratory order for multiple orders related to a single specimen
        OML_O35, // Laboratory order for multiple orders related to a single container of a sp
        OML_O39, // Specimen shipment centric laboratory order
        OMN_O07, // Non-stock requisition order
        OMP_O09, // Pharmacy/treatment order
        OMS_O05, // Stock requisition order
        OPL_O37, // Population/Location-Based Laboratory Order Message
        OPR_O38, // Population/Location-Based Laboratory Order Acknowledgment Message
        OPU_R25, // Unsolicited Population/Location-Based Laboratory Observation Message
        ORA_R33, // Observation Report Acknowledgement
        ORB_O28, // Blood product order acknowledgment
        ORD_O04, // Diet order acknowledgment
        ORF_R04, // Response to query; transmission of requested observation
        ORG_O20, // General clinical order response
        ORI_O24, // Imaging order response message to any OMI
        ORL_O22, // General laboratory order response message to any OML
        ORL_O34, // Laboratory order response message to a multiple order related to single sp
        ORL_O36, // Laboratory order response message to a single container of a specimen OML
        ORL_O40, // Specimen Shipment Centric Laboratory Order Acknowledgment Message
        ORM_O01, // Order message
        ORN_O08, // Non-stock requisition acknowledgment
        ORP_O10, // Pharmacy/treatment order acknowledgment
        ORR_O02, // Order response
        ORS_O06, // Stock requisition acknowledgment
        ORU, // Unsolicited transmission of an observation message
        ORU_R01, // Unsolicited transmission of an observation message
        ORU_R03, // Display oriented results, queyr/unsol. update
        ORU_R30, // Unsolicited Point-Of-Care Observation Message Without Existing Order - Pla
        ORU_R31, // Unsolicited New Point-Of-Care Observation Message - Search For An Order
        ORU_R32, // Unsolicited Pre-Ordered Point-Of-Care Observation
        OSM_R26, // Unsolicited Specimen Shipment Manifest Message
        OSQ_Q06, // Query for order status
        OSR_Q06, // Query response for order status
        OUL_R21, // Unsolicited laboratory observation
        OUL_R22, // Unsolicited Specimen Oriented Observation Message
        OUL_R23, // Unsolicited Specimen Container Oriented Observation Message
        OUL_R24, // Unsolicited Order Oriented Observation Message
        PEX_P07, // Unsolicited initial individual product experience report
        PEX_P08, // Unsolicited update individual product experience report
        PGL_PC6, // PC/ goal add
        PGL_PC7, // PC/ goal update
        PGL_PC8, // PC/ goal delete
        PIN_I07, // Unsolicited insurance information
        PMU_B01, // Add personnel record
        PMU_B02, // Update personnel record
        PMU_B03, // Delete personnel record
        PMU_B04, // Active practicing person
        PMU_B05, // Deactivate practicing person
        PMU_B06, // Terminate practicing person
        PMU_B07, // Grant Certificate/Permission
        PMU_B08, // Revoke Certificate/Permission
        PPG_PCG, // PC/ pathway (goal-oriented) add
        PPG_PCH, // PC/ pathway (goal-oriented) update
        PPG_PCJ, // PC/ pathway (goal-oriented) delete
        PPP_PCB, // PC/ pathway (problem-oriented) add
        PPP_PCC, // PC/ pathway (problem-oriented) update
        PPP_PCD, // PC/ pathway (problem-oriented) delete
        PPR_PC1, // PC/ problem add
        PPR_PC2, // PC/ problem update
        PPR_PC3, // PC/ problem delete
        PPT_PCL, // PC/ pathway (goal-oriented) query response
        PPV_PCA, // PC/ goal response
        PRR_PC5, // PC/ problem response
        PTR_PCF, // PC/ pathway (problem-oriented) query response
        QBP_E03, // Healthcare Services Invoice Status
        QBP_E22, // Authorization Request Status
        QBP_K13, // Query by parameter
        QBP_Q11, // Query by parameter requesting an RSP segment pattern response
        QBP_Q13, // Query by parameter requesting an RTB - tabular response
        QBP_Q15, // Query by parameter requesting an RDY display response
        QBP_Q21, // Get person demographics
        QBP_Q22, // Find candidates
        QBP_Q23, // Get corresponding identifiers
        QBP_Q24, // Allocate identifiers
        QBP_Q25, // Personnel Information by Segment Query
        QBP_Q31, // QBP Query Dispense history
        QBP_Q32, // Find Candidates including Visit Information
        QBP_Z73, // Information about Phone Calls
        QBP_Z75, // Tabular Patient List
        QBP_Z77, // Tabular Patient List
        QBP_Z79, // Dispense Information
        QBP_Z81, // Dispense History
        QBP_Z85, // Pharmacy Information Comprehensive
        QBP_Z87, // Dispense Information
        QBP_Z89, // Lab Results History
        QBP_Z91, // Who Am I
        QBP_Z93, // Tabular Dispense History
        QBP_Z95, // Tabular Dispense History
        QBP_Z97, // Dispense History
        QBP_Z99, // Who Am I
        QCK_Q02, // Deferred query
        QCN_J01, // Cancel query/acknowledge message
        QRY, // Query
        QRY_A19, // Patient query
        QRY_PC4, // PC/ problem query
        QRY_PC9, // PC/ goal query
        QRY_PCE, // PC/ pathway (problem-oriented) query
        QRY_PCK, // PC/ pathway (goal-oriented) query
        QRY_Q01, // Query sent for immediate response
        QRY_Q02, // Query sent for deferred response
        QRY_R02, // Query for results of observation
        QSB_Q16, // Create subscription
        QSB_Z83, // ORU Subscription
        QSX_J02, // Cancel subscription/acknowledge message
        QVR_Q17, // Query for previous events
        RAR_RAR, // Pharmacy/treatment administration information
        RAS_O17, // Pharmacy/treatment administration
        RCI_I05, // Return clinical information
        RCL_I06, // Return clinical information
        RDE_O11, // Pharmacy/treatment encoded order
        RDE_O25, // Pharmacy/treatment refill authorization request
        RDR_RDR, // Pharmacy/treatment Dispense Information
        RDS_O13, // Pharmacy/treatment dispense
        RDY_K15, // Display response in response to QBP^Q15
        RDY_Z80, // Dispense Information (Response)
        RDY_Z98, // Dispense History (Response)
        REF_I12, // Patient referral
        REF_I13, // Modify patient referral
        REF_I14, // Cancel patient referral
        REF_I15, // Request patient referral status
        RER_RER, // Pharmacy/treatment encoded order information
        RGR_RGR, // Pharmacy/treatment dose information
        RGV_O15, // Pharmacy/treatment give
        ROR_ROR, // Pharmacy prescription order query response
        RPA_I08, // Return patient authorization
        RPI_I01, // Return patient information
        RPI_I04, // Return patient information
        RPL_I02, // Return patient display list
        RPR_I03, // Return patient list
        RQA_I08, // Request for treatment authorization information
        RQA_I09, // Request for modification to an authorization
        RQA_I10, // Request for resubmission of an authorization
        RQA_I11, // Request for cancellation of an authorization
        RQC_I05, // Request for patient clinical information
        RQC_I06, // Request/receipt of clinical data listing
        RQI_I01, // Request for insurance information
        RQI_I02, // Request/receipt of patient selection display list
        RQI_I03, // Request/receipt of patient selection list
        RQP_I04, // Request for patient demographic data
        RQQ_Q09, // Event replay query
        RRA_O18, // Pharmacy/treatment administration acknowledgment
        RRD_O14, // Pharmacy/treatment dispense acknowledgment
        RRE_O12, // Pharmacy/treatment encoded order acknowledgment
        RRE_O26, // Pharmacy/Treatment Refill Authorization Acknowledgement
        RRG_O16, // Pharmacy/treatment give acknowledgment
        RRI_I12, // Return referral information
        RSP_K11, // Segment pattern response in response to QBP^Q11
        RSP_K21, // Get person demographics response
        RSP_K22, // Find candidates response
        RSP_K23, // Get corresponding identifiers response
        RSP_K24, // Allocate identifiers response
        RSP_K25, // Personnel Information by Segment Response
        RSP_K31, // Dispense History Response
        RSP_K32, // Find Candidates including Visit Information Response
        RSP_Q11, // Segment pattern response
        RSP_Z82, // Dispense History (Response)
        RSP_Z84, // Who Am I (Response)
        RSP_Z86, // Pharmacy Information Comprehensive (Response)
        RSP_Z88, // Dispense Information (Response)
        RSP_Z90, // Lab Results History (Response)
        RTB_K13, // Tabular response in response to QBP^Q13
        RTB_Z74, // Information about Phone Calls (Response)
        RTB_Z76, // Tabular Patient List (Response)
        RTB_Z78, // Tabular Patient List (Response)
        RTB_Z92, // Who Am I (Response)
        RTB_Z94, // Tabular Dispense History (Response)
        RTB_Z96, // Tabular Dispense History (Response)
        SCN_S37, // Notification of anti-microbial device cycle data
        SDN_S36, // Notification of anti-microbial device data
        SDR_S31, // Request anti-microbial device data
        SIU_S12, // Notification of new appointment booking
        SIU_S13, // Notification of appointment rescheduling
        SIU_S14, // Notification of appointment modification
        SIU_S15, // Notification of appointment cancellation
        SIU_S16, // Notification of appointment discontinuation
        SIU_S17, // Notification of appointment deletion
        SIU_S18, // Notification of addition of service/resource on appointment
        SIU_S19, // Notification of modification of service/resource on appointment
        SIU_S20, // Notification of cancellation of service/resource on appointment
        SIU_S21, // Notification of discontinuation of service/resource on appointment
        SIU_S22, // Notification of deletion of service/resource on appointment
        SIU_S23, // Notification of blocked schedule time slot(s)
        SIU_S24, // Notification of opened ("unblocked") schedule time slot(s)
        SIU_S26, // SIU/ACK Notification that patient did not show up for schedule appointment
        SIU_S27, // Broadcast Notification of Scheduled Appointments
        SLN_S34, // Notification of sterilization lot
        SLN_S35, // Notification of sterilization lot deletion
        SLR_S28, // Request new sterilization lot
        SLR_S29, // Request Sterilization lot deletion
        SMD_S32, // Request anti-microbial device cycle data
        SPQ_Q08, // Stored procedure request
        SQM_S25, // Schedule query message and response
        SQR_S25, // Schedule query message and response
        SRM_S01, // Request new appointment booking
        SRM_S02, // Request appointment rescheduling
        SRM_S03, // Request appointment modification
        SRM_S04, // Request appointment cancellation
        SRM_S05, // Request appointment discontinuation
        SRM_S06, // Request appointment deletion
        SRM_S07, // Request addition of service/resource on appointment
        SRM_S08, // Request modification of service/resource on appointment
        SRM_S09, // Request cancellation of service/resource on appointment
        SRM_S10, // Request discontinuation of service/resource on appointment
        SRM_S11, // Request deletion of service/resource on appointment
        SRR_S01, // Scheduled request response
        SSR_U04, // specimen status request
        SSU_U03, // Specimen status update
        STC_S33, // Notification of sterilization configuration
        STI_S30, // Request item
        TBR_R08, // Tabular data response
        TCR_U11, // Automated equipment test code settings request
        TCU_U10, // Automated equipment test code settings update
        UDM_Q05, // Unsolicited display update message
        VQQ_Q07, // Virtual table query
        VXQ_V01, // Query for vaccination record
        VXR_V03, // Vaccination record response
        VXU_V04, // Unsolicited vaccination record update
        VXX_V02 // Response to vaccination query
    }
}
