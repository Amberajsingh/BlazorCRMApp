using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Enums
{
    public enum UserRoleType
    {
        Admin = 1,
        User = 2
      //  Agency = 3,
      //  HealthNavigator = 4
    }

    public enum GenderEnum
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }

    public enum RelationShip
    {
        [Description("Self")]
        Self = 1,
        [Description("Spouse")]
        Spause = 2,
        [Description("Child")]
        Children = 3
    }
    public enum MessageType
    {
        Warning,
        Success,
        Danger,
        Info
    }

    public enum ModalSize
    {
        Small,
        Large,
        Medium,
        XLarge
    }
    public enum UserRegistrationSteps
    {
        [Display(Name = "NPN/Profile Info")]
        ProfileInfo = 1,
        [Display(Name = "States")]
        States = 2,
        [Display(Name = "ACA Options")]
        ACAOptions = 3,
        [Display(Name = "Carriers")]
        Carriers = 4,
        [Display(Name = "Product Type")]
        ProductType = 5,
        [Display(Name = "Approved to Sell")]
        ApprovedToSell = 6
    }
  
    public enum SaleStatusType
    {
        [Display(Name = "Sale State")]
        SaleState = 1,
        [Display(Name = "Non Sale State")]
        NonSaleState = 2
    }

    public enum ResidencyStatus
    {
        [Display(Name = "Residency")]
        Residency = 1,
        [Display(Name = "Non-Residency")]
        NonResidency = 2
    }
    public enum StateStatus
    {
        [Description("Active")]
        [Display(Name = "Active")]
        Active = 1,

        [Description("InActive")]
        [Display(Name = "InActive")]
        InActive = 2
    }
    public enum AppointmentStatus
    {
        [Display(Name = "Appointed")]
        Appointed = 1,
        [Display(Name = "Terminated")]
        Terminated = 2,
        [Display(Name = "Other")]
        Other = 3
    }

    public enum EmailTemplateType
    {
        //[Description("Forgot Password")]
        //[Display(Name = "Forgot Password")]
        //ForgotPassword = 1,
        [Description("Reset Password")]
        [Display(Name = "Reset Password")]
        ResetPassword = 1,

        [Description("Inquiry Admin")]
        [Display(Name = "Inquiry Admin")]
        EnquiryAdmin = 2,
        
        [Description("Inquiry User")]
        [Display(Name = "Inquiry User")]
        EnquiryUser = 3,
        
        [Description("Opportunity Email")]
        [Display(Name = "Opportunity Email")]
        OpportunityEmail = 4,
        
        [Description("Client Email")]
        [Display(Name = "Client Email")]
        ClientEmail = 5,
        
        [Description("Leads Order Confirmation")]
        [Display(Name = "Leads Order Confirmation")]
        LeadsOrderConfirmation = 6, 
        
        [Description("Leads Order Confirmation-Admin")]
        [Display(Name = "Leads Order Confirmation-Admin")]
        LeadsOrderConfirmationAdmin = 7, 
        
        [Description("User Sign Up")]
        [Display(Name = "User Sign Up")]
        UserAccountCreation = 8,
        
        [Description("Health Navigator Sign Up")]
        [Display(Name = "Health Navigator Sign Up")]
        HNAccountCreation = 9,
        
        [Description("Health Navigator Account Creation by Admin")]
        [Display(Name = "Health Navigator Account Creation by Admin")]
        HNAccountCreationWithCredentials = 10,

        [Description("Account Verification")]
        [Display(Name = "Account Verification")]
        AccountVerification = 11,
        
        [Description("Admin Event Added")]
        [Display(Name = "Admin Event Added")]
        AdminEvent = 12
    }

   
    public enum CRMType
    {
        [Description("Lead")]
        [Display(Name = "Lead")]
        Lead = 1,
        [Description("Opportunity")]
        [Display(Name = "Opportunity")]
        Opportunity = 2,
        [Description("Client")]
        [Display(Name = "Client")]
        Client = 3
    }


    //1-10 -> Lead Status
    public enum LeadStatus
    {
        [Description("New")]
        [Display(Name = "New")]
        LdNew = 1,
        [Description("In-Progress")]
        [Display(Name = "In-Progress")]
        LdInProgress = 2,
        [Description("Hold")]
        [Display(Name = "Hold")]
        LdHold = 3,
        [Description("Cancel")]
        [Display(Name = "Cancel")]
        LdCancel = 4
    }
    //11-20-> Opportunnities
    public enum OpportunityStatus
    {
        [Description("Pre-Qualified")]
        [Display(Name = "Pre-Qualified")]
        PreQualified = 11,
        [Description("Appointment Set")]
        [Display(Name = "Appointment Set")]
        AppointmentSet = 12,
        [Description("Quote Sent")]
        [Display(Name = "Quote Sent")]
        QuoteSent = 13,
        [Description("Quote Accepted")]
        [Display(Name = "Quote Accepted")]
        QuoteAccepted = 14,
        [Description("Deal Won")]
        [Display(Name = "Deal Won")]
        DealWon = 15
    }

    //21-30 -> Client
    public enum ClientStatus
    {
        [Description("Converted")]
        [Display(Name = "Converted")]
        ClNew = 21,
        [Description("In-Progress")]
        [Display(Name = "In-Progress")]
        ClInProgress = 22,
        [Description("Hold")]
        [Display(Name = "Hold")]
        ClHold = 23,
        [Description("Cancel")]
        [Display(Name = "Cancel")]
        ClCancel = 24,
        [Description("Existing")]
        [Display(Name = "Existing")]
        ClExisting = 25
    }
    //31-40 -> Health Navigator Leads
    public enum HealthNavigatorStatus
    {
        [Description("Intro Call")]
        [Display(Name = "Intro Call")]
        HNIntroCall = 31,
        [Description("Simple Census Completed")]
        [Display(Name = "Simple Census Completed")]
        HNSimpleCensusCompleted = 32,
        [Description("Proposal Sent")]
        [Display(Name = "Proposal Sent")]
        HNProposalSent = 33,
        [Description("RFC Completed")]
        [Display(Name = "RFC Completed")]
        HNRFCCompleted = 34,
        [Description("Final Census Completed")]
        [Display(Name = "Final Census Completed")]
        HNFinalCensusCompleted = 35,
        [Description("Plan Docs Signed")]
        [Display(Name = "Plan Docs Signed")]
        HNPlanDocsSigned = 36,
        [Description("Implementation Call Completed")]
        [Display(Name = "Implementation Call Completed")]
        HNImplementationCallCompleted = 37,
        [Description("Enrollment Closed")]
        [Display(Name = "Enrollment Closed")]
        HNEnrollmentClosed = 38,
        [Description("Client Onboarded")]
        [Display(Name = "Client Onboarded")]
        HNClientOnboarded = 39
    }
    public enum CRMStatusType
    {
        [Description("New")]
        [Display(Name = "New")]
        LdNew = 1,
        [Description("In-Progress")]
        [Display(Name = "In-Progress")]
        LdInProgress = 2,
        [Description("Hold")]
        [Display(Name = "Hold")]
        LdHold = 3,
        [Description("Cancel")]
        [Display(Name = "Cancel")]
        LdCancel = 4,

        [Description("Pre Qualified")]
        [Display(Name = "Pre Qualified")]
        OpPreQualified = 11,
        [Description("Appointment Set")]
        [Display(Name = "Appointment Set")]
        OpAPSet = 12,
        [Description("Quote Sent")]
        [Display(Name = "Quote Sent")]
        OpQTSent = 13,
        [Description("Quote Accepted")]
        [Display(Name = "Quote Accepted")]
        OpQTAccepted = 14,
        [Description("Deal Won")]
        [Display(Name = "Deal Won")]
        OpDWon = 15,

        [Description("Converted")]
        [Display(Name = "Converted")]
        ClNew = 21,
        [Description("In-Progress")]
        [Display(Name = "In-Progress")]
        ClInProgress = 22,
        [Description("Hold")]
        [Display(Name = "Hold")]
        ClHold = 23,
        [Description("Cancel")]
        [Display(Name = "Cancel")]
        ClCancel = 24,
        [Description("Existing")]
        [Display(Name = "Existing")]
        ClExisting = 25,



        [Description("Intro Call")]
        [Display(Name = "Intro Call")]
        HNIntroCall = 31,
        [Description("Simple Census Completed")]
        [Display(Name = "Simple Census Completed")]
        HNSimpleCensusCompleted = 32,
        [Description("Proposal Sent")]
        [Display(Name = "Proposal Sent")]
        HNProposalSent = 33,
        [Description("RFC Completed")]
        [Display(Name = "RFC Completed")]
        HNRFCCompleted = 34,
        [Description("Final Census Completed")]
        [Display(Name = "Final Census Completed")]
        HNFinalCensusCompleted = 35,
        [Description("Plan Docs Signed")]
        [Display(Name = "Plan Docs Signed")]
        HNPlanDocsSigned = 36,
        [Description("Implementation Call Completed")]
        [Display(Name = "Implementation Call Completed")]
        HNImplementationCallCompleted = 37,
        [Description("Enrollment Closed")]
        [Display(Name = "Enrollment Closed")]
        HNEnrollmentClosed = 38,
        [Description("Client Onboarded")]
        [Display(Name = "Client Onboarded")]
        HNClientOnboarded = 39

    }

    public enum LeadHeight
    {
        [Description("4'  6\"")]
        [Display(Name = "4' 6\"")]
        FrSix = 1,
        [Description("4' 7\"")]
        [Display(Name = "4' 7\"")]
        FrSeven = 2,
        [Description("4' 8\"")]
        [Display(Name = "4' 8\"")]
        FrEight = 3,
        [Description("4' 9\"")]
        [Display(Name = "4' 9\"")]
        FrNine = 4,
        [Description("4' 10\"")]
        [Display(Name = "4' 10\"")]
        FrTen = 5,
        [Description("4' 11\"")]
        [Display(Name = "4' 11\"")]
        FrEleven = 6,

        [Description("5'  0\"")]
        [Display(Name = "4' 0\"")]
        FvZero = 7,
        [Description("5' 1\"")]
        [Display(Name = "5' 1\"")]
        FvOne = 8,
        [Description("5' 2\"")]
        [Display(Name = "5' 2\"")]
        FvTwo = 9,
        [Description("5' 3\"")]
        [Display(Name = "5' 3\"")]
        FvThree = 10,
        [Description("5' 4\"")]
        [Display(Name = "5' 4\"")]
        FvFour = 11,
        [Description("5' 5\"")]
        [Display(Name = "5' 5\"")]
        FvFive = 12,
        [Description("5' 6\"")]
        [Display(Name = "5' 6\"")]
        FvSix = 13,
        [Description("5' 7\"")]
        [Display(Name = "5' 7\"")]
        FvSeven = 14,
        [Description("5' 8\"")]
        [Display(Name = "5' 8\"")]
        FvEight = 15,
        [Description("5' 9\"")]
        [Display(Name = "5' 9\"")]
        FvNine = 16,
        [Description("5' 10\"")]
        [Display(Name = "5' 10\"")]
        FvTen = 17,
        [Description("5' 11\"")]
        [Display(Name = "5' 11\"")]
        FvEleven = 18,

        [Description("6'  0\"")]
        [Display(Name = "6' 0\"")]
        SxZero = 19,
        [Description("6' 1\"")]
        [Display(Name = "6' 1\"")]
        SxOne = 20,
        [Description("6' 2\"")]
        [Display(Name = "6' 2\"")]
        SxTwo = 21,
        [Description("6' 3\"")]
        [Display(Name = "6' 3\"")]
        SxThree = 22,
        [Description("6' 4\"")]
        [Display(Name = "6' 4\"")]
        SxFour = 23,
        [Description("6' 5\"")]
        [Display(Name = "6' 5\"")]
        SxFive = 24,
        [Description("6' 6\"")]
        [Display(Name = "6' 6\"")]
        SxSix = 25,
        [Description("6' 7\"")]
        [Display(Name = "6' 7\"")]
        SxSeven = 26,
        [Description("6' 8\"")]
        [Display(Name = "6' 8\"")]
        SxEight = 27,
        [Description("6' 9\"")]
        [Display(Name = "6' 9\"")]
        SxNine = 28,
    }

    public enum LogType
    {

        [Description("Note")]
        [Display(Name = "Note")]
        Note = 1,
        [Description("Conversation")]
        [Display(Name = "Conversation")]
        Conversation = 2,
        [Description("Comment")]
        [Display(Name = "Comment")]
        Comment = 3,
        [Description("Lead To Opportunity")]
        [Display(Name = "Lead To Opportunity")]
        LeadToOpportunity = 4,
        [Description("Opportunity To Client")]
        [Display(Name = "Opportunity To Client")]
        OpportunityToClient = 5,
    }

    public enum CarrierType
    {
        [Description("National General")]
        [Display(Name = "National General")]
        NationalGeneral = 1,
        [Description("United Healthcare")]
        [Display(Name = "UHOne")]
        UHOne = 2,
        [Description("CMS")]
        [Display(Name = "CMS")]
        CMS = 3,
        [Description("VBA")]
        [Display(Name = "VBA")]
        VBA = 4,
        [Description("NEA")]
        [Display(Name = "NEA")]
        NEA = 5
    }

    public enum ApplicantType
    {
        [Description("Primary")]
        [Display(Name = "Primary")]
        Primary = 1,
        [Description("Spouse")]
        [Display(Name = "Spouse")]
        Spause = 2,
        [Description("Child")]
        [Display(Name = "Child")]
        Child = 3
    }

    public enum LeadAge
    {
        [Description("RecentLeads")]
        [Display(Name = "2-19 Day Old Leads")]
        RecentLeads = 1,
        [Description("OlderLeads")]
        [Display(Name = "20-60 Day Old Leads")]
        OlderLeads = 2
    }

    public enum LeadGroup
    {
        [Description("RecentLeads")]
        [Display(Name = "Recent Leads")]
        RecentLeads = 0, 
        [Description("Lead1To249")]
        [Display(Name = "1-249 Leads")]
        Lead1To249 = 1,
        [Description("Lead250To999")]
        [Display(Name = "250-999 Leads")]
        Lead250To999 = 2,
        [Description("Lead1000To4999")]
        [Display(Name = "1,000-4,999 Leads")]
        Lead1000To4999 = 3,
        [Description("Lead5000To9999")]
        [Display(Name = "5,000-9,999 Leads")]
        Lead5000To9999 = 4,
        [Description("Lead10000To24999")]
        [Display(Name = "10,000-24,999 Leads")]
        Lead10000To24999 = 5,
        [Description("Lead25000Plus")]
        [Display(Name = "25,000+ Leads")]
        Lead25000Plus = 6
    }
    public enum PhoneNumberPreference
    {
        [Description("OnlyMobile")]
        [Display(Name = "Only Mobile")]
        OnlyMobile = 1,
        [Description("OnlyPhone")]
        [Display(Name = "Only Phone")]
        OnlyPhone = 2,
        [Description("AlLeastOne")]
        [Display(Name = "At Least Mobile or Phone")]
        AlLeastOne = 3,
        [Description("Both")]
        [Display(Name = "Both Mobile and Phone")]
        Both = 4
    }

    public enum HNSavingsCalculator
    {
        [Description("GuaranteedSavings")]
        [Display(Name = "Guaranteed Yearly Savings")]
        GuaranteedSavings = 1,
        [Description("EstimatedSurplus")]
        [Display(Name = "Estimated Year-end Surplus")]
        EstimatedSurplus = 2,
        [Description("EstimatedSavings")]
        [Display(Name = "Estimated Net Claims Savings")]
        EstimatedSavings = 3
    }

    public enum ObjectState
    {
        Added,
        Modified,
        Deleted,
        Unchanged
    }

    public enum Sorting
    {
        ASCENDING = 1, DESCENDING = 2,
    }
}
