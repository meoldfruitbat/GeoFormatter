using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeFile
    {
        public OperativeFile()
        {
            Audits = new HashSet<Audit>();
            ChangeRequestToHrFileAppliedByNavigations = new HashSet<ChangeRequestToHrFile>();
            ChangeRequestToHrFileEditedByNavigations = new HashSet<ChangeRequestToHrFile>();
            ChangeRequestToHrFileOperatives = new HashSet<ChangeRequestToHrFile>();
            ContractDeliveryTeams = new HashSet<ContractDeliveryTeam>();
            CustomerEnquiryActionNotes = new HashSet<CustomerEnquiryActionNote>();
            CustomerEnquiryActionTasks = new HashSet<CustomerEnquiryActionTask>();
            CustomerEnquiryDetailAgreedByNavigations = new HashSet<CustomerEnquiryDetail>();
            CustomerEnquiryDetailAllocatedToNavigations = new HashSet<CustomerEnquiryDetail>();
            CustomerEnquiryDetailDealWithByNavigations = new HashSet<CustomerEnquiryDetail>();
            DocumentAuditLogs = new HashSet<DocumentAuditLog>();
            EmailTemplateCreatedByNavigations = new HashSet<EmailTemplate>();
            EmailTemplateModifiedByNavigations = new HashSet<EmailTemplate>();
            FaultActivities = new HashSet<FaultActivity>();
            InternalTeamOperatives = new HashSet<InternalTeamOperative>();
            ItemStockTransferHistories = new HashSet<ItemStockTransferHistory>();
            ItemStocks = new HashSet<ItemStock>();
            NonConformanceActionNotes = new HashSet<NonConformanceActionNote>();
            NonConformanceActionTasks = new HashSet<NonConformanceActionTask>();
            NonConformanceCostActions = new HashSet<NonConformanceCostAction>();
            OperativeDeductionBenefits = new HashSet<OperativeDeductionBenefit>();
            OperativeGroups = new HashSet<OperativeGroup>();
            OperativeManagers = new HashSet<OperativeManager>();
            OperativeStatusChangeHistories = new HashSet<OperativeStatusChangeHistory>();
            OperativeTasks = new HashSet<OperativeTask>();
            PublicUtilityDamageGangResponsibles = new HashSet<PublicUtilityDamageGangResponsible>();
            PublicUtilityDamageInvestigations = new HashSet<PublicUtilityDamageInvestigation>();
            SubContractorOperatives = new HashSet<SubContractorOperative>();
            SubContractorTeamOperatives = new HashSet<SubContractorTeamOperative>();
            TeamOperatives = new HashSet<TeamOperative>();
            TrainingRequests = new HashSet<TrainingRequest>();
            UserFavoriteProjects = new HashSet<UserFavoriteProject>();
            UtilityStrikeActionNotes = new HashSet<UtilityStrikeActionNote>();
            UtilityStrikeActionTasks = new HashSet<UtilityStrikeActionTask>();
            UtilityStrikeFinalReports = new HashSet<UtilityStrikeFinalReport>();
        }

        public long OperativeId { get; set; }
        public string Initials { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string GroupId { get; set; }
        public string Department { get; set; }
        public string OperativeType { get; set; }
        public string OperativeCompany { get; set; }
        public string Active { get; set; }
        public string MarkDeleted { get; set; }
        public string MobileAllocated { get; set; }
        public string OperativeValue { get; set; }
        public string OperativeHours { get; set; }
        public decimal? NormalCosts { get; set; }
        public decimal? MidweekCosts { get; set; }
        public decimal? SaturdayCosts { get; set; }
        public decimal? DoubleTimeCosts { get; set; }
        public DateTime? EmploymentStarted { get; set; }
        public DateTime? EmploymentEnded { get; set; }
        public string EntitlementThisYear { get; set; }
        public string EntThisYearRemain { get; set; }
        public string EntitlementNextYear { get; set; }
        public string EntNextYearremain { get; set; }
        public string HolidayCategory { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public string LogonAlias { get; set; }
        public DateTime? Dob { get; set; }
        public string Ninumber { get; set; }
        public string Address { get; set; }
        public string OperativePictureName { get; set; }
        public string Pin { get; set; }
        public string VolatileSsid { get; set; }
        public string MobileNumber { get; set; }
        public string BusinessTitle { get; set; }
        public string CompanyCarAllocated { get; set; }
        public string IPadAllocated { get; set; }
        public string IPadVersion { get; set; }
        public string MobileType { get; set; }
        public string MobileVersion { get; set; }
        public string ContactNumber { get; set; }
        public bool CanRaisePublicUtilitiesDamage { get; set; }
        public string CanDoPreSiteCheck { get; set; }
        public string SalariedOrSubContract { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinAddress { get; set; }
        public string Gender { get; set; }
        public decimal? BasicAnnualSalary { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string EmploymentType { get; set; }
        public DateTime? FixedTermEndDate { get; set; }
        public string SalaryType { get; set; }
        public string PaymentFrequency { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountSortCode { get; set; }
        public string AccountBranchAddress { get; set; }
        public bool? AccruePerYearService { get; set; }
        public decimal? SundayRate { get; set; }
        public decimal? NightRate { get; set; }
        public string MaritalStatus { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficeNumber { get; set; }
        public string CompanyMobileNumber { get; set; }
        public string PersonalEmail { get; set; }
        public string NoticePeriod { get; set; }
        public string NextOfkinContactNumber { get; set; }
        public string Relationship { get; set; }
        public int? Nationality { get; set; }
        public string MethodOfRecruitment { get; set; }
        public string RecruitmentCost { get; set; }
        public long? Office { get; set; }
        public string LieuDaysAccrued { get; set; }
        public string LieuDaysRmaining { get; set; }
        public decimal? ApprovedHoliday { get; set; }
        public decimal? ApprovedLieu { get; set; }
        public decimal? SickDay { get; set; }
        public string Utrnumber { get; set; }
        public string MeritId { get; set; }
        public long? ContractorCompanyId { get; set; }
        public DateTime? ProbationEnded { get; set; }
        public string OtherName { get; set; }
        public bool AddToAd { get; set; }
        public int EmailType { get; set; }
        public int PersonalEmailType { get; set; }
        public string EndReason { get; set; }
        public string EndComment { get; set; }
        public string NewEmployerDetails { get; set; }
        public string RedundancySeverancePay { get; set; }
        public string TrainingSumRecovered { get; set; }
        public int? MailBoxType { get; set; }
        public string RelationshipName { get; set; }
        public bool? IsDeductionInPercentage { get; set; }
        public bool? IsBenefitInPercentage { get; set; }

        public virtual NationalityLookup NationalityNavigation { get; set; }
        public virtual ClientCompanyFile OfficeNavigation { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<ChangeRequestToHrFile> ChangeRequestToHrFileAppliedByNavigations { get; set; }
        public virtual ICollection<ChangeRequestToHrFile> ChangeRequestToHrFileEditedByNavigations { get; set; }
        public virtual ICollection<ChangeRequestToHrFile> ChangeRequestToHrFileOperatives { get; set; }
        public virtual ICollection<ContractDeliveryTeam> ContractDeliveryTeams { get; set; }
        public virtual ICollection<CustomerEnquiryActionNote> CustomerEnquiryActionNotes { get; set; }
        public virtual ICollection<CustomerEnquiryActionTask> CustomerEnquiryActionTasks { get; set; }
        public virtual ICollection<CustomerEnquiryDetail> CustomerEnquiryDetailAgreedByNavigations { get; set; }
        public virtual ICollection<CustomerEnquiryDetail> CustomerEnquiryDetailAllocatedToNavigations { get; set; }
        public virtual ICollection<CustomerEnquiryDetail> CustomerEnquiryDetailDealWithByNavigations { get; set; }
        public virtual ICollection<DocumentAuditLog> DocumentAuditLogs { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplateModifiedByNavigations { get; set; }
        public virtual ICollection<FaultActivity> FaultActivities { get; set; }
        public virtual ICollection<InternalTeamOperative> InternalTeamOperatives { get; set; }
        public virtual ICollection<ItemStockTransferHistory> ItemStockTransferHistories { get; set; }
        public virtual ICollection<ItemStock> ItemStocks { get; set; }
        public virtual ICollection<NonConformanceActionNote> NonConformanceActionNotes { get; set; }
        public virtual ICollection<NonConformanceActionTask> NonConformanceActionTasks { get; set; }
        public virtual ICollection<NonConformanceCostAction> NonConformanceCostActions { get; set; }
        public virtual ICollection<OperativeDeductionBenefit> OperativeDeductionBenefits { get; set; }
        public virtual ICollection<OperativeGroup> OperativeGroups { get; set; }
        public virtual ICollection<OperativeManager> OperativeManagers { get; set; }
        public virtual ICollection<OperativeStatusChangeHistory> OperativeStatusChangeHistories { get; set; }
        public virtual ICollection<OperativeTask> OperativeTasks { get; set; }
        public virtual ICollection<PublicUtilityDamageGangResponsible> PublicUtilityDamageGangResponsibles { get; set; }
        public virtual ICollection<PublicUtilityDamageInvestigation> PublicUtilityDamageInvestigations { get; set; }
        public virtual ICollection<SubContractorOperative> SubContractorOperatives { get; set; }
        public virtual ICollection<SubContractorTeamOperative> SubContractorTeamOperatives { get; set; }
        public virtual ICollection<TeamOperative> TeamOperatives { get; set; }
        public virtual ICollection<TrainingRequest> TrainingRequests { get; set; }
        public virtual ICollection<UserFavoriteProject> UserFavoriteProjects { get; set; }
        public virtual ICollection<UtilityStrikeActionNote> UtilityStrikeActionNotes { get; set; }
        public virtual ICollection<UtilityStrikeActionTask> UtilityStrikeActionTasks { get; set; }
        public virtual ICollection<UtilityStrikeFinalReport> UtilityStrikeFinalReports { get; set; }
    }
}
