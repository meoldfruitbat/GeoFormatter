using System;
using Microsoft.EntityFrameworkCore;
using GeoJsonFormatter.Models;

namespace GeoJsonFormatter.Entities
{
    public partial class GGContext : DbContext
    {
        public GGContext()
        {
        }

        public GGContext(DbContextOptions<GGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abbriviation> Abbriviations { get; set; }
        public virtual DbSet<Abmeasure> Abmeasures { get; set; }
        public virtual DbSet<AcceptTransferDatum> AcceptTransferData { get; set; }
        public virtual DbSet<AccessControlTabElement> AccessControlTabElements { get; set; }
        public virtual DbSet<AccessLog> AccessLogs { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<AliasType> AliasTypes { get; set; }
        public virtual DbSet<ApplointmentMeeting> ApplointmentMeetings { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuditExpectedPhoto> AuditExpectedPhotos { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AuditLogForRecruitment> AuditLogForRecruitments { get; set; }
        public virtual DbSet<AuditLogForWorksRate> AuditLogForWorksRates { get; set; }
        public virtual DbSet<BackgroundCheckDocumentType> BackgroundCheckDocumentTypes { get; set; }
        public virtual DbSet<Bdmmanager> Bdmmanagers { get; set; }
        public virtual DbSet<BkpDocumentLibrary> BkpDocumentLibraries { get; set; }
        public virtual DbSet<BkpFileHistory> BkpFileHistories { get; set; }
        public virtual DbSet<Blockage> Blockages { get; set; }
        public virtual DbSet<CableRun> CableRuns { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateDoc> CandidateDocs { get; set; }
        public virtual DbSet<CandidateEmail> CandidateEmails { get; set; }
        public virtual DbSet<CandidateExperience> CandidateExperiences { get; set; }
        public virtual DbSet<CandidatePhoneCall> CandidatePhoneCalls { get; set; }
        public virtual DbSet<CandidateProfile> CandidateProfiles { get; set; }
        public virtual DbSet<CandidateSearch> CandidateSearches { get; set; }
        public virtual DbSet<CandidateSearchDetail> CandidateSearchDetails { get; set; }
        public virtual DbSet<CandidateTraining> CandidateTrainings { get; set; }
        public virtual DbSet<CandidateTrainingLookup> CandidateTrainingLookups { get; set; }
        public virtual DbSet<CertificateLookup> CertificateLookups { get; set; }
        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<ChangeLogProcurement> ChangeLogProcurements { get; set; }
        public virtual DbSet<ChangeRequestToHrFile> ChangeRequestToHrFiles { get; set; }
        public virtual DbSet<CheckAssignment> CheckAssignments { get; set; }
        public virtual DbSet<CityFibreConfiguration> CityFibreConfigurations { get; set; }
        public virtual DbSet<ClaimedFile> ClaimedFiles { get; set; }
        public virtual DbSet<ClaimedNotesFile> ClaimedNotesFiles { get; set; }
        public virtual DbSet<ClientCompanyFile> ClientCompanyFiles { get; set; }
        public virtual DbSet<ClientContractorFile> ClientContractorFiles { get; set; }
        public virtual DbSet<ClientProjectTeam> ClientProjectTeams { get; set; }
        public virtual DbSet<ClientSector> ClientSectors { get; set; }
        public virtual DbSet<ClientsFile> ClientsFiles { get; set; }
        public virtual DbSet<CommercialDetail> CommercialDetails { get; set; }
        public virtual DbSet<CompanyDocsDocumentsList> CompanyDocsDocumentsLists { get; set; }
        public virtual DbSet<CompanyDomain> CompanyDomains { get; set; }
        public virtual DbSet<CompanySetup> CompanySetups { get; set; }
        public virtual DbSet<CompanySetupDefaultHour> CompanySetupDefaultHours { get; set; }
        public virtual DbSet<CompanySetupExpectedPhoto> CompanySetupExpectedPhotos { get; set; }
        public virtual DbSet<CompanySetupWorkingHour> CompanySetupWorkingHours { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<ConfigurationType> ConfigurationTypes { get; set; }
        public virtual DbSet<ContractDeliveryTeam> ContractDeliveryTeams { get; set; }
        public virtual DbSet<ContractFile> ContractFiles { get; set; }
        public virtual DbSet<ContractTimescaleDetail> ContractTimescaleDetails { get; set; }
        public virtual DbSet<ContractorDetail> ContractorDetails { get; set; }
        public virtual DbSet<ContractorDetailReference> ContractorDetailReferences { get; set; }
        public virtual DbSet<ContractorPartnerDetail> ContractorPartnerDetails { get; set; }
        public virtual DbSet<ContractorProjectPlantCost> ContractorProjectPlantCosts { get; set; }
        public virtual DbSet<ContractsDayBook> ContractsDayBooks { get; set; }
        public virtual DbSet<ContractsDayBookComment> ContractsDayBookComments { get; set; }
        public virtual DbSet<CordovaSsid> CordovaSsids { get; set; }
        public virtual DbSet<CountryLookup> CountryLookups { get; set; }
        public virtual DbSet<CountyLookup> CountyLookups { get; set; }
        public virtual DbSet<CpuserAuthProvidersDetail> CpuserAuthProvidersDetails { get; set; }
        public virtual DbSet<CpuserDetail> CpuserDetails { get; set; }
        public virtual DbSet<CpuserMainContractAccess> CpuserMainContractAccesses { get; set; }
        public virtual DbSet<CustomerEnquiryActionNote> CustomerEnquiryActionNotes { get; set; }
        public virtual DbSet<CustomerEnquiryActionTask> CustomerEnquiryActionTasks { get; set; }
        public virtual DbSet<CustomerEnquiryAllocatedHistory> CustomerEnquiryAllocatedHistories { get; set; }
        public virtual DbSet<CustomerEnquiryComment> CustomerEnquiryComments { get; set; }
        public virtual DbSet<CustomerEnquiryDetail> CustomerEnquiryDetails { get; set; }
        public virtual DbSet<CustomerEnquiryPicture> CustomerEnquiryPictures { get; set; }
        public virtual DbSet<CustomerEnquiryReference> CustomerEnquiryReferences { get; set; }
        public virtual DbSet<Cvi> Cvis { get; set; }
        public virtual DbSet<CvichangeHistory> CvichangeHistories { get; set; }
        public virtual DbSet<CvidetailsHistoryLog> CvidetailsHistoryLogs { get; set; }
        public virtual DbSet<Cvipicture> Cvipictures { get; set; }
        public virtual DbSet<CvischedulerNotificationEmail> CvischedulerNotificationEmails { get; set; }
        public virtual DbSet<CvistatusUpdateLog> CvistatusUpdateLogs { get; set; }
        public virtual DbSet<CvivariationResponsibility> CvivariationResponsibilities { get; set; }
        public virtual DbSet<DailyMeasureTimestamp> DailyMeasureTimestamps { get; set; }
        public virtual DbSet<DailyPlantChecksDetail> DailyPlantChecksDetails { get; set; }
        public virtual DbSet<DailyPlantChecksDetailArchive> DailyPlantChecksDetailArchives { get; set; }
        public virtual DbSet<DailyProjectNote> DailyProjectNotes { get; set; }
        public virtual DbSet<DatabaseFirewallRule> DatabaseFirewallRules { get; set; }
        public virtual DbSet<DefaultFolderStructure> DefaultFolderStructures { get; set; }
        public virtual DbSet<DeliveryCost> DeliveryCosts { get; set; }
        public virtual DbSet<DepartmentFile> DepartmentFiles { get; set; }
        public virtual DbSet<Dfe> Dves { get; set; }
        public virtual DbSet<DigPermit> DigPermits { get; set; }
        public virtual DbSet<DocumentAuditLog> DocumentAuditLogs { get; set; }
        public virtual DbSet<DocumentCountView> DocumentCountViews { get; set; }
        public virtual DbSet<DocumentFile> DocumentFiles { get; set; }
        public virtual DbSet<DocumentLibrary> DocumentLibraries { get; set; }
        public virtual DbSet<EditProjectRate> EditProjectRates { get; set; }
        public virtual DbSet<EditProjectRatesTeam> EditProjectRatesTeams { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailAttachment> EmailAttachments { get; set; }
        public virtual DbSet<EmailControl> EmailControls { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<EnquiryAuditLog> EnquiryAuditLogs { get; set; }
        public virtual DbSet<EnquiryBidTeam> EnquiryBidTeams { get; set; }
        public virtual DbSet<EnquiryOtherContact> EnquiryOtherContacts { get; set; }
        public virtual DbSet<EnquiryTaskStatus> EnquiryTaskStatuses { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<EventSeverity> EventSeverities { get; set; }
        public virtual DbSet<EventsManagement> EventsManagements { get; set; }
        public virtual DbSet<EventsManagementType> EventsManagementTypes { get; set; }
        public virtual DbSet<ExtranetClientAccessList> ExtranetClientAccessLists { get; set; }
        public virtual DbSet<ExtranetFilesToDownload> ExtranetFilesToDownloads { get; set; }
        public virtual DbSet<FaultActivity> FaultActivities { get; set; }
        public virtual DbSet<FaultEscalation> FaultEscalations { get; set; }
        public virtual DbSet<FaultMapLocation> FaultMapLocations { get; set; }
        public virtual DbSet<FaultMaster> FaultMasters { get; set; }
        public virtual DbSet<FaultPortalStatusEnum> FaultPortalStatusEnums { get; set; }
        public virtual DbSet<FaultPortalUserAuthProvidersDetail> FaultPortalUserAuthProvidersDetails { get; set; }
        public virtual DbSet<FaultPortalUserDetail> FaultPortalUserDetails { get; set; }
        public virtual DbSet<FaultPremise> FaultPremises { get; set; }
        public virtual DbSet<FibreTestResult> FibreTestResults { get; set; }
        public virtual DbSet<FileDownloadControl> FileDownloadControls { get; set; }
        public virtual DbSet<FileHistory> FileHistories { get; set; }
        public virtual DbSet<Fitter> Fitters { get; set; }
        public virtual DbSet<FittersWorkingOnRepair> FittersWorkingOnRepairs { get; set; }
        public virtual DbSet<FuelCardDatum> FuelCardData { get; set; }
        public virtual DbSet<FuelConsumption> FuelConsumptions { get; set; }
        public virtual DbSet<Gang> Gangs { get; set; }
        public virtual DbSet<GangOperative> GangOperatives { get; set; }
        public virtual DbSet<GenericValue> GenericValues { get; set; }
        public virtual DbSet<GetCertificateList> GetCertificateLists { get; set; }
        public virtual DbSet<GiftsAndGratuity> GiftsAndGratuities { get; set; }
        public virtual DbSet<GiftsAndGratuityClient> GiftsAndGratuityClients { get; set; }
        public virtual DbSet<GpsDatum> GpsData { get; set; }
        public virtual DbSet<GroupPiveledge> GroupPiveledges { get; set; }
        public virtual DbSet<HealthAndSafetyDocControl> HealthAndSafetyDocControls { get; set; }
        public virtual DbSet<HealthNsafety> HealthNsafeties { get; set; }
        public virtual DbSet<HolidayPlannerDatum> HolidayPlannerData { get; set; }
        public virtual DbSet<HolidayPlannerLog> HolidayPlannerLogs { get; set; }
        public virtual DbSet<HolidayPlannerView> HolidayPlannerViews { get; set; }
        public virtual DbSet<IPadSsid> IPadSsids { get; set; }
        public virtual DbSet<InHouseFailure> InHouseFailures { get; set; }
        public virtual DbSet<InHouseFailureImage> InHouseFailureImages { get; set; }
        public virtual DbSet<IndustryLookup> IndustryLookups { get; set; }
        public virtual DbSet<InternalTeam> InternalTeams { get; set; }
        public virtual DbSet<InternalTeamOperative> InternalTeamOperatives { get; set; }
        public virtual DbSet<InterviewCandidateList> InterviewCandidateLists { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceCreditNote> InvoiceCreditNotes { get; set; }
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemGroup> ItemGroups { get; set; }
        public virtual DbSet<ItemPriceBreak> ItemPriceBreaks { get; set; }
        public virtual DbSet<ItemStock> ItemStocks { get; set; }
        public virtual DbSet<ItemStockTransferHistory> ItemStockTransferHistories { get; set; }
        public virtual DbSet<ItemSupplier> ItemSuppliers { get; set; }
        public virtual DbSet<ItemThreshold> ItemThresholds { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobCard> JobCards { get; set; }
        public virtual DbSet<JobCardCheck> JobCardChecks { get; set; }
        public virtual DbSet<JobCardChecksResponse> JobCardChecksResponses { get; set; }
        public virtual DbSet<JobCardPartialUpdate> JobCardPartialUpdates { get; set; }
        public virtual DbSet<JobCardPic> JobCardPics { get; set; }
        public virtual DbSet<JobCentre> JobCentres { get; set; }
        public virtual DbSet<JobCentreCalendar> JobCentreCalendars { get; set; }
        public virtual DbSet<JobCentreTask> JobCentreTasks { get; set; }
        public virtual DbSet<JobCostingBillHeader> JobCostingBillHeaders { get; set; }
        public virtual DbSet<JobCostingBillLine> JobCostingBillLines { get; set; }
        public virtual DbSet<JobCostingCustomer> JobCostingCustomers { get; set; }
        public virtual DbSet<JobCostingJob> JobCostingJobs { get; set; }
        public virtual DbSet<JobCostingSupplier> JobCostingSuppliers { get; set; }
        public virtual DbSet<JobCostingTransaction> JobCostingTransactions { get; set; }
        public virtual DbSet<JobPackInfo> JobPackInfos { get; set; }
        public virtual DbSet<JobPicture> JobPictures { get; set; }
        public virtual DbSet<LabourFile> LabourFiles { get; set; }
        public virtual DbSet<LabourRequirement> LabourRequirements { get; set; }
        public virtual DbSet<LabourSheetPlantListing> LabourSheetPlantListings { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MaintenenceContractsAction> MaintenenceContractsActions { get; set; }
        public virtual DbSet<MaintenenceContractsLookup> MaintenenceContractsLookups { get; set; }
        public virtual DbSet<ManageEmail> ManageEmails { get; set; }
        public virtual DbSet<MaterialRequisition> MaterialRequisitions { get; set; }
        public virtual DbSet<MeasuresExceeded> MeasuresExceededs { get; set; }
        public virtual DbSet<MethodStatement> MethodStatements { get; set; }
        public virtual DbSet<MobilesAndTablet> MobilesAndTablets { get; set; }
        public virtual DbSet<MobilesAndTabletsLog> MobilesAndTabletsLogs { get; set; }
        public virtual DbSet<ModifyWage> ModifyWages { get; set; }
        public virtual DbSet<NationalMinimumWage> NationalMinimumWages { get; set; }
        public virtual DbSet<NationalityLookup> NationalityLookups { get; set; }
        public virtual DbSet<NcnatureMaster> NcnatureMasters { get; set; }
        public virtual DbSet<NewPlantLookup> NewPlantLookups { get; set; }
        public virtual DbSet<NextYearHoliday> NextYearHolidays { get; set; }
        public virtual DbSet<NominalCode> NominalCodes { get; set; }
        public virtual DbSet<NonConformanceActionNote> NonConformanceActionNotes { get; set; }
        public virtual DbSet<NonConformanceActionTask> NonConformanceActionTasks { get; set; }
        public virtual DbSet<NonConformanceAllocatedHistory> NonConformanceAllocatedHistories { get; set; }
        public virtual DbSet<NonConformanceComment> NonConformanceComments { get; set; }
        public virtual DbSet<NonConformanceCostAction> NonConformanceCostActions { get; set; }
        public virtual DbSet<NonConformanceDetail> NonConformanceDetails { get; set; }
        public virtual DbSet<NonConformanceNature> NonConformanceNatures { get; set; }
        public virtual DbSet<NonConformancePicture> NonConformancePictures { get; set; }
        public virtual DbSet<NonConformanceReference> NonConformanceReferences { get; set; }
        public virtual DbSet<NonConformanceReport> NonConformanceReports { get; set; }
        public virtual DbSet<NonConformanceResponsible> NonConformanceResponsibles { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NotificationProcurement> NotificationProcurements { get; set; }
        public virtual DbSet<OperationDetail> OperationDetails { get; set; }
        public virtual DbSet<OperativeDeductionBenefit> OperativeDeductionBenefits { get; set; }
        public virtual DbSet<OperativeDoc> OperativeDocs { get; set; }
        public virtual DbSet<OperativeDocLog> OperativeDocLogs { get; set; }
        public virtual DbSet<OperativeFile> OperativeFiles { get; set; }
        public virtual DbSet<OperativeFileLiveCopy> OperativeFileLiveCopies { get; set; }
        public virtual DbSet<OperativeGroup> OperativeGroups { get; set; }
        public virtual DbSet<OperativeGroup1> OperativeGroups1 { get; set; }
        public virtual DbSet<OperativeManager> OperativeManagers { get; set; }
        public virtual DbSet<OperativeStatusChangeHistory> OperativeStatusChangeHistories { get; set; }
        public virtual DbSet<OperativeTask> OperativeTasks { get; set; }
        public virtual DbSet<OperativeTaskStatus> OperativeTaskStatuses { get; set; }
        public virtual DbSet<OperativeType> OperativeTypes { get; set; }
        public virtual DbSet<OperativesCosting> OperativesCostings { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderBookItem> OrderBookItems { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PhoneCall> PhoneCalls { get; set; }
        public virtual DbSet<PictureReason> PictureReasons { get; set; }
        public virtual DbSet<PlannerViewOperative> PlannerViewOperatives { get; set; }
        public virtual DbSet<PlanningGeneralAnswer> PlanningGeneralAnswers { get; set; }
        public virtual DbSet<PlanningGeneralQuestion> PlanningGeneralQuestions { get; set; }
        public virtual DbSet<PlanningInfo> PlanningInfos { get; set; }
        public virtual DbSet<PlanningLocationComment> PlanningLocationComments { get; set; }
        public virtual DbSet<PlantAcceptance> PlantAcceptances { get; set; }
        public virtual DbSet<PlantCheckControl> PlantCheckControls { get; set; }
        public virtual DbSet<PlantCheckControlComment> PlantCheckControlComments { get; set; }
        public virtual DbSet<PlantCheckListing> PlantCheckListings { get; set; }
        public virtual DbSet<PlantCheckScdstore> PlantCheckScdstores { get; set; }
        public virtual DbSet<PlantChecksForScdstore> PlantChecksForScdstores { get; set; }
        public virtual DbSet<PlantComponentCategory> PlantComponentCategories { get; set; }
        public virtual DbSet<PlantDefault> PlantDefaults { get; set; }
        public virtual DbSet<PlantDoc> PlantDocs { get; set; }
        public virtual DbSet<PlantFile> PlantFiles { get; set; }
        public virtual DbSet<PlantFileUploadInfo> PlantFileUploadInfos { get; set; }
        public virtual DbSet<PlantGroup> PlantGroups { get; set; }
        public virtual DbSet<PlantInExstraInfo> PlantInExstraInfos { get; set; }
        public virtual DbSet<PlantIssue> PlantIssues { get; set; }
        public virtual DbSet<PlantIssueComment> PlantIssueComments { get; set; }
        public virtual DbSet<PlantLookup> PlantLookups { get; set; }
        public virtual DbSet<PlantMaintAttribute> PlantMaintAttributes { get; set; }
        public virtual DbSet<PlantMaintScheduledServiceType> PlantMaintScheduledServiceTypes { get; set; }
        public virtual DbSet<PlantMaintenanceCertificationType> PlantMaintenanceCertificationTypes { get; set; }
        public virtual DbSet<PlantMaintenanceComment> PlantMaintenanceComments { get; set; }
        public virtual DbSet<PlantMaintenanceDamage> PlantMaintenanceDamages { get; set; }
        public virtual DbSet<PlantMaintenanceDamagesPic> PlantMaintenanceDamagesPics { get; set; }
        public virtual DbSet<PlantMaintenenceLog> PlantMaintenenceLogs { get; set; }
        public virtual DbSet<PlantRequestDetail> PlantRequestDetails { get; set; }
        public virtual DbSet<PlantRequisition> PlantRequisitions { get; set; }
        public virtual DbSet<PlantRequisitionDetail> PlantRequisitionDetails { get; set; }
        public virtual DbSet<PlantTransferControl> PlantTransferControls { get; set; }
        public virtual DbSet<PlantType> PlantTypes { get; set; }
        public virtual DbSet<PlantWhereabout> PlantWhereabouts { get; set; }
        public virtual DbSet<PpeRequisition> PpeRequisitions { get; set; }
        public virtual DbSet<Ppeworkwear> Ppeworkwears { get; set; }
        public virtual DbSet<PriceEnquiry> PriceEnquiries { get; set; }
        public virtual DbSet<PriceEnquiryItemType> PriceEnquiryItemTypes { get; set; }
        public virtual DbSet<PriceEnquirySupplier> PriceEnquirySuppliers { get; set; }
        public virtual DbSet<ProductEnquiry> ProductEnquiries { get; set; }
        public virtual DbSet<ProjectCheckIndicator> ProjectCheckIndicators { get; set; }
        public virtual DbSet<ProjectExpectedPhoto> ProjectExpectedPhotos { get; set; }
        public virtual DbSet<ProjectLabourRequirement> ProjectLabourRequirements { get; set; }
        public virtual DbSet<ProjectSheq> ProjectSheqs { get; set; }
        public virtual DbSet<ProjectWork> ProjectWorks { get; set; }
        public virtual DbSet<ProjectWorkingHour> ProjectWorkingHours { get; set; }
        public virtual DbSet<PublicHoliday> PublicHolidays { get; set; }
        public virtual DbSet<PublicUtilityDamage> PublicUtilityDamages { get; set; }
        public virtual DbSet<PublicUtilityDamageChangeSet> PublicUtilityDamageChangeSets { get; set; }
        public virtual DbSet<PublicUtilityDamageGangResponsible> PublicUtilityDamageGangResponsibles { get; set; }
        public virtual DbSet<PublicUtilityDamageInformation> PublicUtilityDamageInformations { get; set; }
        public virtual DbSet<PublicUtilityDamageInvestigation> PublicUtilityDamageInvestigations { get; set; }
        public virtual DbSet<PublicUtilityDamageInvestigationTypeAnswer> PublicUtilityDamageInvestigationTypeAnswers { get; set; }
        public virtual DbSet<PublicUtilityDamagePicture> PublicUtilityDamagePictures { get; set; }
        public virtual DbSet<PublicUtilityDamageReport> PublicUtilityDamageReports { get; set; }
        public virtual DbSet<PublicUtilityDamageSignature> PublicUtilityDamageSignatures { get; set; }
        public virtual DbSet<PublicUtilityDamageType> PublicUtilityDamageTypes { get; set; }
        public virtual DbSet<PublicUtilityDamageWitness> PublicUtilityDamageWitnesses { get; set; }
        public virtual DbSet<PublicUtilityDescriptionOfIncidentChangeSet> PublicUtilityDescriptionOfIncidentChangeSets { get; set; }
        public virtual DbSet<PublicUtilityIndirectCause> PublicUtilityIndirectCauses { get; set; }
        public virtual DbSet<PublicUtilityInjuredPersonnel> PublicUtilityInjuredPersonnel { get; set; }
        public virtual DbSet<PublicUtilityInvestigationAnswer> PublicUtilityInvestigationAnswers { get; set; }
        public virtual DbSet<PublicUtilityInvestigationQuestion> PublicUtilityInvestigationQuestions { get; set; }
        public virtual DbSet<PublicUtilityOtherPersonInvolved> PublicUtilityOtherPersonInvolveds { get; set; }
        public virtual DbSet<QualityAuditDetail> QualityAuditDetails { get; set; }
        public virtual DbSet<QuoteAssociatedClient> QuoteAssociatedClients { get; set; }
        public virtual DbSet<QuoteFile> QuoteFiles { get; set; }
        public virtual DbSet<QuoteWork> QuoteWorks { get; set; }
        public virtual DbSet<QuotedBy> QuotedBies { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<ReInstatementMeasure> ReInstatementMeasures { get; set; }
        public virtual DbSet<RecruitmentSearchHistory> RecruitmentSearchHistories { get; set; }
        public virtual DbSet<RefCategory> RefCategories { get; set; }
        public virtual DbSet<ReferenceDatum> ReferenceData { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RejectPlantDatum> RejectPlantData { get; set; }
        public virtual DbSet<Repair> Repairs { get; set; }
        public virtual DbSet<ResourceDatum> ResourceData { get; set; }
        public virtual DbSet<ResourceProjConcurrency> ResourceProjConcurrencies { get; set; }
        public virtual DbSet<ResourceWorkDate> ResourceWorkDates { get; set; }
        public virtual DbSet<RightToWorkDocumentType> RightToWorkDocumentTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScdCableStockAudit> ScdCableStockAudits { get; set; }
        public virtual DbSet<ScdCableStockUse> ScdCableStockUses { get; set; }
        public virtual DbSet<ScheduledServicing> ScheduledServicings { get; set; }
        public virtual DbSet<SdhMusReconciliationDefect> SdhMusReconciliationDefects { get; set; }
        public virtual DbSet<SdhMusReconciliationJobMovement> SdhMusReconciliationJobMovements { get; set; }
        public virtual DbSet<SdhMusReconciliationMaterial> SdhMusReconciliationMaterials { get; set; }
        public virtual DbSet<SdhMusReconciliationNonStd> SdhMusReconciliationNonStds { get; set; }
        public virtual DbSet<SdhMusReconciliationS74andFpn> SdhMusReconciliationS74andFpns { get; set; }
        public virtual DbSet<SdhMusReconciliationSummary> SdhMusReconciliationSummaries { get; set; }
        public virtual DbSet<SdhMusReconciliationWorksDatum> SdhMusReconciliationWorksData { get; set; }
        public virtual DbSet<ServicesCrossedDatum> ServicesCrossedData { get; set; }
        public virtual DbSet<SharepointIssue> SharepointIssues { get; set; }
        public virtual DbSet<SmallToolRequisition> SmallToolRequisitions { get; set; }
        public virtual DbSet<StatusChangeHistory> StatusChangeHistories { get; set; }
        public virtual DbSet<StatusLookup> StatusLookups { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockControl> StockControls { get; set; }
        public virtual DbSet<StockFuel> StockFuels { get; set; }
        public virtual DbSet<StrikeClassificationChangeSet> StrikeClassificationChangeSets { get; set; }
        public virtual DbSet<SubContractorOperative> SubContractorOperatives { get; set; }
        public virtual DbSet<SubContractorTeam> SubContractorTeams { get; set; }
        public virtual DbSet<SubContractorTeamOperative> SubContractorTeamOperatives { get; set; }
        public virtual DbSet<SubcontractorProject> SubcontractorProjects { get; set; }
        public virtual DbSet<SupSiteSafetyInspItem> SupSiteSafetyInspItems { get; set; }
        public virtual DbSet<SupSiteSafetyInspLog> SupSiteSafetyInspLogs { get; set; }
        public virtual DbSet<SupSiteSafetyInspLookup> SupSiteSafetyInspLookups { get; set; }
        public virtual DbSet<SupplierDetail> SupplierDetails { get; set; }
        public virtual DbSet<SupplierDetailReference> SupplierDetailReferences { get; set; }
        public virtual DbSet<SupplierLookup> SupplierLookups { get; set; }
        public virtual DbSet<SupplierPrice> SupplierPrices { get; set; }
        public virtual DbSet<SupplierType> SupplierTypes { get; set; }
        public virtual DbSet<SurfaceType> SurfaceTypes { get; set; }
        public virtual DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public virtual DbSet<SurveyComment> SurveyComments { get; set; }
        public virtual DbSet<SurveyCommentLog> SurveyCommentLogs { get; set; }
        public virtual DbSet<SurveyPicture> SurveyPictures { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<SystemTimeLog> SystemTimeLogs { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskDetail> TaskDetails { get; set; }
        public virtual DbSet<TaskWeekendDetail> TaskWeekendDetails { get; set; }
        public virtual DbSet<TeamDetail> TeamDetails { get; set; }
        public virtual DbSet<TeamOperative> TeamOperatives { get; set; }
        public virtual DbSet<TeamProject> TeamProjects { get; set; }
        public virtual DbSet<TeamProjectPlantCost> TeamProjectPlantCosts { get; set; }
        public virtual DbSet<TeamRegion> TeamRegions { get; set; }
        public virtual DbSet<TeamRole> TeamRoles { get; set; }
        public virtual DbSet<TeamTrade> TeamTrades { get; set; }
        public virtual DbSet<TeamWorkStream> TeamWorkStreams { get; set; }
        public virtual DbSet<TermContract> TermContracts { get; set; }
        public virtual DbSet<TermContractWork> TermContractWorks { get; set; }
        public virtual DbSet<TestTableForCordova> TestTableForCordovas { get; set; }
        public virtual DbSet<ThirdPartyRepair> ThirdPartyRepairs { get; set; }
        public virtual DbSet<ThirdPartyRepairCalendar> ThirdPartyRepairCalendars { get; set; }
        public virtual DbSet<ThirdPartyRepairCompany> ThirdPartyRepairCompanies { get; set; }
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }
        public virtual DbSet<Timing> Timings { get; set; }
        public virtual DbSet<ToolBoxTalk> ToolBoxTalks { get; set; }
        public virtual DbSet<Trade> Trades { get; set; }
        public virtual DbSet<TrainingCategory> TrainingCategories { get; set; }
        public virtual DbSet<TrainingDetail> TrainingDetails { get; set; }
        public virtual DbSet<TrainingRequest> TrainingRequests { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
        public virtual DbSet<UserDailyProjectTime> UserDailyProjectTimes { get; set; }
        public virtual DbSet<UserDailyTime> UserDailyTimes { get; set; }
        public virtual DbSet<UserDailyTimeNote> UserDailyTimeNotes { get; set; }
        public virtual DbSet<UserFavoriteProject> UserFavoriteProjects { get; set; }
        public virtual DbSet<UserFriendlyName> UserFriendlyNames { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserToolBoxTalk> UserToolBoxTalks { get; set; }
        public virtual DbSet<UtilityStrikeActionNote> UtilityStrikeActionNotes { get; set; }
        public virtual DbSet<UtilityStrikeActionTask> UtilityStrikeActionTasks { get; set; }
        public virtual DbSet<UtilityStrikeFinalReport> UtilityStrikeFinalReports { get; set; }
        public virtual DbSet<UtilityStrikeResponsible> UtilityStrikeResponsibles { get; set; }
        public virtual DbSet<VOperativeGroup> VOperativeGroups { get; set; }
        public virtual DbSet<VOperativeGroupsId> VOperativeGroupsIds { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<VacancyAdvertising> VacancyAdvertisings { get; set; }
        public virtual DbSet<VacancyAdvertisingMethod> VacancyAdvertisingMethods { get; set; }
        public virtual DbSet<VacancyShortList> VacancyShortLists { get; set; }
        public virtual DbSet<Valuation> Valuations { get; set; }
        public virtual DbSet<ValuationDetail> ValuationDetails { get; set; }
        public virtual DbSet<Variation> Variations { get; set; }
        public virtual DbSet<VersionDetail> VersionDetails { get; set; }
        public virtual DbSet<VersionErrorLog> VersionErrorLogs { get; set; }
        public virtual DbSet<VirginExtraInfo> VirginExtraInfos { get; set; }
        public virtual DbSet<VisitorsLog> VisitorsLogs { get; set; }
        public virtual DbSet<VmL3cabDetail> VmL3cabDetails { get; set; }
        public virtual DbSet<VmL4cabDetail> VmL4cabDetails { get; set; }
        public virtual DbSet<VmL5cabDetail> VmL5cabDetails { get; set; }
        public virtual DbSet<VmnetworkExpansionReleaseDatum> VmnetworkExpansionReleaseDatum { get; set; }
        public virtual DbSet<VmspecialReportCheck> VmspecialReportChecks { get; set; }
        public virtual DbSet<WagesHistory> WagesHistories { get; set; }
        public virtual DbSet<WagesModification> WagesModifications { get; set; }
        public virtual DbSet<WeatherDatum> WeatherData { get; set; }
        public virtual DbSet<WhoHasAccess> WhoHasAccesses { get; set; }
        public virtual DbSet<WorkCategory> WorkCategories { get; set; }
        public virtual DbSet<WorkFile> WorkFiles { get; set; }
        public virtual DbSet<WorkFileDev> WorkFileDevs { get; set; }
        public virtual DbSet<WorkTypeLookup> WorkTypeLookups { get; set; }
        public virtual DbSet<WorkingDay> WorkingDays { get; set; }
        public virtual DbSet<Workstream> Workstreams { get; set; }
        public virtual DbSet<XmlLogging> XmlLoggings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=harmonixsqldb.database.windows.net;Database=HarmonixFocusStaging_LC_Local_010921;user id=FocusSQLadmin;password=%R3VIS3D*9xx;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Abmeasure>(entity =>
            {
                entity.HasKey(e => e.MeasureId)
                    .HasName("PK_ABTrack_Measures");

                entity.ToTable("ABMeasures");

                entity.Property(e => e.MeasureId).ValueGeneratedNever();

                entity.Property(e => e.CompletedById).IsRequired();

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.EndPrefix).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemCode).IsRequired();

                entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.StartPrefix).HasMaxLength(50);

                entity.Property(e => e.TobyId).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.WalkPoint).IsRequired();

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.Abmeasures)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABMeasures_Assignment");
            });

            modelBuilder.Entity<AcceptTransferDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AcceptTransferData");

                entity.Property(e => e.Pic1FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic2FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic3FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic4FilenameIn).HasMaxLength(50);

                entity.Property(e => e.PtcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ptcID");
            });

            modelBuilder.Entity<AccessControlTabElement>(entity =>
            {
                entity.HasKey(e => e.ContentId);

                entity.Property(e => e.ContentId).ValueGeneratedNever();

                entity.Property(e => e.ElementId).HasMaxLength(50);

                entity.Property(e => e.ElementTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<AccessLog>(entity =>
            {
                entity.ToTable("AccessLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElementTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.PhoneCallId).HasColumnName("PhoneCallID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Open')")
                    .HasComment("Values can be \"Open\" or \"Closed\"");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<AliasType>(entity =>
            {
                entity.ToTable("AliasType");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.FirstNameElement)
                    .HasMaxLength(50)
                    .HasColumnName("First_Name_Element");

                entity.Property(e => e.SecondNameElement)
                    .HasMaxLength(50)
                    .HasColumnName("Second_Name_Element");

                entity.Property(e => e.Seperator).HasMaxLength(10);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AliasTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AliasType__Compa__4C413C06");
            });

            modelBuilder.Entity<ApplointmentMeeting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Attachment).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Duration).HasMaxLength(20);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExAppId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ExAppID");

                entity.Property(e => e.Location).HasMaxLength(300);

                entity.Property(e => e.Optional).HasMaxLength(200);

                entity.Property(e => e.OrganiserId).HasColumnName("OrganiserID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RegardingId).HasColumnName("RegardingID");

                entity.Property(e => e.Required)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShowTimeAs)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Open')")
                    .HasComment("Values can be \"Open\" or \"Closed\"");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasKey(e => e.AssignmentId)
                    .HasName("PK__Assignme__3214EC07469B9053");

                entity.ToTable("Assignment");

                entity.Property(e => e.AssignmentId).ValueGeneratedNever();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.ClientName).IsRequired();

                entity.Property(e => e.Complete).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationId).IsRequired();

                entity.Property(e => e.LocationName).IsRequired();

                entity.Property(e => e.ProjectName).IsRequired();

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.SubmittedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("Audit");

                entity.Property(e => e.AuditId).ValueGeneratedNever();

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Score).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.Audits)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Audit_Assignment");

                entity.HasOne(d => d.GangLeader)
                    .WithMany(p => p.Audits)
                    .HasForeignKey(d => d.GangLeaderId)
                    .HasConstraintName("FK_Audit_operative_file");
            });

            modelBuilder.Entity<AuditExpectedPhoto>(entity =>
            {
                entity.Property(e => e.PerUnitValue).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhotoTypeNavigation)
                    .WithMany(p => p.AuditExpectedPhotos)
                    .HasForeignKey(d => d.PhotoType)
                    .HasConstraintName("FK_AuditExpectedPhotos_PictureReasons");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.AuditExpectedPhotos)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditExpectedPhotos_WorkTypeLookup");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Field_Name");

                entity.Property(e => e.FileId).HasColumnName("File_Id");

                entity.Property(e => e.Modified)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_Value");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_Value");

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditLogForRecruitment>(entity =>
            {
                entity.ToTable("AuditLogForRecruitment");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditLogForWorksRate>(entity =>
            {
                entity.Property(e => e.ViewedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ViewedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.AuditLogForWorksRates)
                    .HasForeignKey(d => d.QuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditLogForWorksRates_quote_file");
            });

            modelBuilder.Entity<BackgroundCheckDocumentType>(entity =>
            {
                entity.ToTable("BackgroundCheckDocumentType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Bdmmanager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BDMManager");
            });

            modelBuilder.Entity<BkpDocumentLibrary>(entity =>
            {
                entity.ToTable("BkpDocumentLibrary");

                entity.Property(e => e.Archived).HasColumnType("datetime");

                entity.Property(e => e.ArchivedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedOut).HasColumnType("datetime");

                entity.Property(e => e.CheckedOutBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.FileId).HasColumnName("File_Id");

                entity.Property(e => e.FileName)
                    .IsUnicode(false)
                    .HasColumnName("File_Name");

                entity.Property(e => e.FileTitle)
                    .IsUnicode(false)
                    .HasColumnName("File_Title");

                entity.Property(e => e.FolderPath)
                    .IsUnicode(false)
                    .HasColumnName("Folder_Path");

                entity.Property(e => e.IPadtransferOk).HasColumnName("iPADTransferOK");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BkpFileHistory>(entity =>
            {
                entity.ToTable("BkpFileHistory");

                entity.Property(e => e.CommentsAddedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Comments_Added_By");

                entity.Property(e => e.CommentsAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Comments_Added_Date");

                entity.Property(e => e.FileId).HasColumnName("File_Id");

                entity.Property(e => e.FileName)
                    .IsUnicode(false)
                    .HasColumnName("File_Name");

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.Version).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.VersionComments)
                    .IsUnicode(false)
                    .HasColumnName("Version_Comments");
            });

            modelBuilder.Entity<Blockage>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LengthFromCab).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LengthFromToby).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PointAgps).HasColumnName("PointAGps");

                entity.Property(e => e.PointAref).HasColumnName("PointARef");

                entity.Property(e => e.PointBgps).HasColumnName("PointBGps");

                entity.Property(e => e.PointBref).HasColumnName("PointBRef");

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CableRun>(entity =>
            {
                entity.Property(e => e.ApproxDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CableRunIdentifier).IsRequired();

                entity.Property(e => e.ProjectName).IsRequired();

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.Address1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableFrom).HasColumnType("datetime");

                entity.Property(e => e.CandidateReference)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cvfilepath)
                    .IsUnicode(false)
                    .HasColumnName("CVFilepath");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Education).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Forename)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords).IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinContactNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinRelationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ninumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NINumber");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContactNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryRangeFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalaryRangeTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondaryContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryVocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK_Candidates_Candidates");
            });

            modelBuilder.Entity<CandidateDoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardRegNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Card_Reg_Number");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IPadtransferOk).HasColumnName("iPADtransferOK");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OpenText).IsUnicode(false);

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.SupercededDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingCost).HasColumnType("money");

                entity.Property(e => e.TrainingProvider).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateDocs)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidateDocs_Candidates");
            });

            modelBuilder.Entity<CandidateEmail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachmentFile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bcc)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DelayedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EmailStatus).HasComment("Values can be: 'Draft', 'Saved', 'Closed', 'Open'");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpDateTime).HasColumnType("datetime");

                entity.Property(e => e.Priority)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentTo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateEmails)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidateEmails_Candidates");
            });

            modelBuilder.Entity<CandidateExperience>(entity =>
            {
                entity.ToTable("CandidateExperience");

                entity.Property(e => e.Desciption).IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ReferenceContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateExperiences)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidateExperience_Candidates");
            });

            modelBuilder.Entity<CandidatePhoneCall>(entity =>
            {
                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.Number)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("These values can be \"Open\" or \"Closed\"");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidatePhoneCalls)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatePhoneCalls_Candidates");
            });

            modelBuilder.Entity<CandidateProfile>(entity =>
            {
                entity.ToTable("CandidateProfile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.DateTimeLogged).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Forename).HasMaxLength(25);

                entity.Property(e => e.GangOrPerson).HasMaxLength(10);

                entity.Property(e => e.LoggedBy).HasMaxLength(25);

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Scdnotes).HasColumnName("SCDnotes");

                entity.Property(e => e.Surname).HasMaxLength(25);

                entity.Property(e => e.Tickets).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(4);
            });

            modelBuilder.Entity<CandidateSearch>(entity =>
            {
                entity.ToTable("CandidateSearch");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.SearchDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Search)
                    .WithMany(p => p.CandidateSearches)
                    .HasForeignKey(d => d.SearchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidateSearch_CandidateSearchDetails");
            });

            modelBuilder.Entity<CandidateSearchDetail>(entity =>
            {
                entity.Property(e => e.SearchOperator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchText).IsUnicode(false);

                entity.Property(e => e.SearchType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_CandidateSearchDetails_CandidateSearchDetails1");
            });

            modelBuilder.Entity<CandidateTraining>(entity =>
            {
                entity.ToTable("CandidateTraining");
            });

            modelBuilder.Entity<CandidateTrainingLookup>(entity =>
            {
                entity.ToTable("CandidateTrainingLookup");

                entity.Property(e => e.TrainingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertificateLookup>(entity =>
            {
                entity.ToTable("CertificateLookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateProfile).HasMaxLength(3);

                entity.Property(e => e.CertNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateName).HasMaxLength(200);

                entity.Property(e => e.IsExclueExpired).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.ToTable("ChangeLog");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.SectionName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.WhenChanged).HasColumnType("datetime");

                entity.Property(e => e.WhoChanged).HasMaxLength(100);
            });

            modelBuilder.Entity<ChangeLogProcurement>(entity =>
            {
                entity.ToTable("ChangeLogProcurement");

                entity.Property(e => e.SectionName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.WhenChanged).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChangeRequestToHrFile>(entity =>
            {
                entity.ToTable("ChangeRequestToHrFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.EditedDate).HasColumnType("datetime");

                entity.Property(e => e.LogedDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AppliedByNavigation)
                    .WithMany(p => p.ChangeRequestToHrFileAppliedByNavigations)
                    .HasForeignKey(d => d.AppliedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChangeReq__Appli__5B837F96");

                entity.HasOne(d => d.EditedByNavigation)
                    .WithMany(p => p.ChangeRequestToHrFileEditedByNavigations)
                    .HasForeignKey(d => d.EditedBy)
                    .HasConstraintName("FK__ChangeReq__Edite__5A8F5B5D");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.ChangeRequestToHrFileOperatives)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChangeReq__Opera__599B3724");
            });

            modelBuilder.Entity<CheckAssignment>(entity =>
            {
                entity.ToTable("CheckAssignment");

                entity.Property(e => e.Action).IsRequired();

                entity.Property(e => e.Status).IsRequired();

                entity.Property(e => e.Vmnbunumber).HasColumnName("VMNBUnumber");
            });

            modelBuilder.Entity<CityFibreConfiguration>(entity =>
            {
                entity.ToTable("CityFibreConfiguration");

                entity.Property(e => e.ClientPurchaseOrderNumber)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContractType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FormofContract)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentContactName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimedFile>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.ToTable("claimed_file");

                entity.HasIndex(e => new { e.ContractReference, e.ClaimDate }, "MickiesTestIndex2")
                    .HasFillFactor((byte)75);

                entity.HasIndex(e => new { e.ContractReference, e.ClaimHeader }, "nci_wi_claimed_file_D076C6824F7EF05B4FA18BB6061A6E10");

                entity.HasIndex(e => new { e.QuoteId, e.ClaimDate, e.PostedByGangerName }, "nci_wi_claimed_file_E5F99DAC85CB52CE4E5BAC86948822E4");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.ApprovedBySupervisor).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBySupervisorName).HasMaxLength(50);

                entity.Property(e => e.BaseUnit)
                    .HasMaxLength(20)
                    .HasColumnName("base_unit");

                entity.Property(e => e.BoxBuilderLabour).HasColumnType("money");

                entity.Property(e => e.BoxBuilderMaterials).HasColumnType("money");

                entity.Property(e => e.BoxBuilderPlant).HasColumnType("money");

                entity.Property(e => e.CableGangLabour).HasColumnType("money");

                entity.Property(e => e.CableGangMaterials).HasColumnType("money");

                entity.Property(e => e.CableGangPlant).HasColumnType("money");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasColumnName("claim_date");

                entity.Property(e => e.ClaimDepth)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("claim_depth");

                entity.Property(e => e.ClaimDesc).HasColumnName("claim_desc");

                entity.Property(e => e.ClaimGang)
                    .HasMaxLength(6)
                    .HasColumnName("claim_gang");

                entity.Property(e => e.ClaimHeader)
                    .HasMaxLength(20)
                    .HasColumnName("claim_header");

                entity.Property(e => e.ClaimId1).HasColumnName("ClaimID");

                entity.Property(e => e.ClaimPrefix)
                    .HasMaxLength(3)
                    .HasColumnName("claim_prefix");

                entity.Property(e => e.ClaimQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("claim_qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimRate01)
                    .HasColumnType("money")
                    .HasColumnName("claim_rate_01")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimRate02)
                    .HasColumnType("money")
                    .HasColumnName("claim_rate_02")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimSupervisor)
                    .HasMaxLength(6)
                    .HasColumnName("claim_supervisor");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(2)
                    .HasColumnName("claim_type");

                entity.Property(e => e.ClaimWidth)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("claim_width");

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.FibreGangLabour).HasColumnType("money");

                entity.Property(e => e.FibreGangMaterials).HasColumnType("money");

                entity.Property(e => e.FibreGangPlant).HasColumnType("money");

                entity.Property(e => e.GangLabour).HasColumnType("money");

                entity.Property(e => e.GangMaterials).HasColumnType("money");

                entity.Property(e => e.GangPlant).HasColumnType("money");

                entity.Property(e => e.GrabLabour).HasColumnType("money");

                entity.Property(e => e.GrabMaterials).HasColumnType("money");

                entity.Property(e => e.GrabPlant).HasColumnType("money");

                entity.Property(e => e.IsVariation).HasMaxLength(1);

                entity.Property(e => e.Labour).HasColumnType("money");

                entity.Property(e => e.Materials).HasColumnType("money");

                entity.Property(e => e.OriginalClaimQtyByGang).HasMaxLength(10);

                entity.Property(e => e.Plant).HasColumnType("money");

                entity.Property(e => e.PostedByAdmin).HasColumnType("datetime");

                entity.Property(e => e.PostedByGanger).HasColumnType("datetime");

                entity.Property(e => e.PostedByGangerName).HasMaxLength(50);

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_id");

                entity.Property(e => e.ReinstatingLabour).HasColumnType("money");

                entity.Property(e => e.ReinstatingMaterials).HasColumnType("money");

                entity.Property(e => e.ReinstatingPlant).HasColumnType("money");

                entity.Property(e => e.RiskAndBalancingItem).HasColumnType("money");

                entity.Property(e => e.SubContract).HasColumnType("money");

                entity.Property(e => e.SubbyLabourAndPlant).HasColumnType("money");

                entity.Property(e => e.SubbyLabourOnly).HasColumnType("money");

                entity.Property(e => e.SynCode)
                    .HasMaxLength(6)
                    .HasColumnName("syn_code");

                entity.Property(e => e.Tmchapter8)
                    .HasColumnType("money")
                    .HasColumnName("TMchapter8");

                entity.Property(e => e.ToDoBeforeClaim).HasMaxLength(50);

                entity.Property(e => e.TobyPicture).HasColumnName("toby_picture");

                entity.Property(e => e.TrackPicture).HasColumnName("track_picture");
            });

            modelBuilder.Entity<ClaimedNotesFile>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.ToTable("claimed_notes_file");

                entity.Property(e => e.NotesId).HasColumnName("notes_id");

                entity.Property(e => e.AdminText).HasColumnName("admin_text");

                entity.Property(e => e.ApprovedBySupervisor).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBySupervisorName).HasMaxLength(50);

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.NotesDate)
                    .HasColumnType("datetime")
                    .HasColumnName("notes_date");

                entity.Property(e => e.NotesGang)
                    .HasMaxLength(6)
                    .HasColumnName("notes_gang");

                entity.Property(e => e.NotesText).HasColumnName("notes_text");

                entity.Property(e => e.PostedByAdmin).HasColumnType("datetime");

                entity.Property(e => e.PostedByGanger).HasColumnType("datetime");

                entity.Property(e => e.PostedByGangerName).HasMaxLength(50);

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_id");

                entity.Property(e => e.VmhomesPassed).HasColumnName("VMhomesPassed");
            });

            modelBuilder.Entity<ClientCompanyFile>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("client_company_file");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.BillingOfficeId).HasColumnName("billing_office_id");

                entity.Property(e => e.Cisno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CISNo");

                entity.Property(e => e.ClientAccount)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyAddress01)
                    .HasMaxLength(50)
                    .HasColumnName("company_address01");

                entity.Property(e => e.CompanyAddress02)
                    .HasMaxLength(50)
                    .HasColumnName("company_address02");

                entity.Property(e => e.CompanyAddress03)
                    .HasMaxLength(50)
                    .HasColumnName("company_address03");

                entity.Property(e => e.CompanyAddress04)
                    .HasMaxLength(50)
                    .HasColumnName("company_address04");

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(50)
                    .HasColumnName("company_city");

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(50)
                    .HasColumnName("company_country");

                entity.Property(e => e.CompanyCounty)
                    .HasMaxLength(50)
                    .HasColumnName("company_county");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(100)
                    .HasColumnName("company_email");

                entity.Property(e => e.CompanyEmailDisplayName)
                    .HasMaxLength(150)
                    .HasColumnName("company_EmailDisplayName");

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(50)
                    .HasColumnName("company_fax");

                entity.Property(e => e.CompanyGuid)
                    .HasMaxLength(50)
                    .HasColumnName("CompanyGUID");

                entity.Property(e => e.CompanyIndustry)
                    .HasMaxLength(50)
                    .HasColumnName("company_industry");

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(20)
                    .HasColumnName("company_logo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(60)
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyNotes).HasColumnName("company_notes");

                entity.Property(e => e.CompanyOffice)
                    .HasMaxLength(50)
                    .HasColumnName("company_office");

                entity.Property(e => e.CompanyPostcode)
                    .HasMaxLength(50)
                    .HasColumnName("company_postcode");

                entity.Property(e => e.CompanyRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company_reg_no");

                entity.Property(e => e.CompanyTypeId).HasColumnName("company_type_id");

                entity.Property(e => e.CompanyWww)
                    .HasMaxLength(120)
                    .HasColumnName("company_www");

                entity.Property(e => e.ContractorsLiabilityIncExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ContractorsLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisableAccount).HasMaxLength(3);

                entity.Property(e => e.EmployerLiabilityIncExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.EmployerLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAccountSuspended).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSubContractorAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUtilityCompany).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVatregistered)
                    .HasColumnName("IsVATRegistered")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OfficeTitle)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("office_title");

                entity.Property(e => e.ParentCompanyId).HasColumnName("parent_company_id");

                entity.Property(e => e.ProfIndemnityIncExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ProfIndemnityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PubLiabilityIncExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.PubLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierFlag).HasMaxLength(3);

                entity.Property(e => e.SupplierIndustry).HasMaxLength(100);

                entity.Property(e => e.TrainingProvider)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.UtilityCompanyType).HasMaxLength(50);

                entity.Property(e => e.Utrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UTRNo");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATNo");
            });

            modelBuilder.Entity<ClientContractorFile>(entity =>
            {
                entity.ToTable("ClientContractorFile");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its Primary key.");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Refers to Account number of contractor.");

                entity.Property(e => e.ContractorAddress01)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to address1 of contractor.");

                entity.Property(e => e.ContractorAddress02)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to address2 of contractor.");

                entity.Property(e => e.ContractorAddress03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to address3 of contractor.");

                entity.Property(e => e.ContractorAddress04)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to address4 of contractor.");

                entity.Property(e => e.ContractorCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to city of contractor.");

                entity.Property(e => e.ContractorCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to country of contractor.");

                entity.Property(e => e.ContractorCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to county of contractor.");

                entity.Property(e => e.ContractorEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to email of contractor.");

                entity.Property(e => e.ContractorFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to fax number of the contractor.");

                entity.Property(e => e.ContractorName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("Refers to name of contractor.");

                entity.Property(e => e.ContractorOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to office number of the contractor.");

                entity.Property(e => e.ContractorPostcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to postalcode of contractor.");

                entity.Property(e => e.ContractorRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to registration number of the contractor.");

                entity.Property(e => e.ContractorWww)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("ContractorWWW")
                    .HasComment("Refers to website of contractor.");

                entity.Property(e => e.DisableAccount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Refers to Awaiting Approval.");

                entity.Property(e => e.Dunsno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DUNSNo")
                    .HasComment("Refers to DUNS number of the contractor.");

                entity.Property(e => e.IsAccountSuspended)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Refers to Suspended.");

                entity.Property(e => e.IsVatregistered)
                    .HasColumnName("IsVATRegistered")
                    .HasComment("Refers to registered in VAT or not?");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to last modified.");

                entity.Property(e => e.LastModifiedOn)
                    .HasColumnType("datetime")
                    .HasComment("Refers to the date and time on which modified last.");

                entity.Property(e => e.LegalForm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Refers to legal form of contractor.");

                entity.Property(e => e.OfficeTitle)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("Refers to office title of the contractor.");

                entity.Property(e => e.ParentCoRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to parent company registration number of the contractor.");

                entity.Property(e => e.ParentCompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to parent company name of the contractor.");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeStampForOperatives)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TimeStampRates)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Utrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UTRNo")
                    .HasComment("Refers to UTR number of the contractor.");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VATNo")
                    .HasComment("Refers to VAT Number of the contractor.");
            });

            modelBuilder.Entity<ClientProjectTeam>(entity =>
            {
                entity.ToTable("ClientProjectTeam");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProjectTeams)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_SCDDeliveryTeam_clients_file");
            });

            modelBuilder.Entity<ClientSector>(entity =>
            {
                entity.ToTable("ClientSector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ClientsFile>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("clients_file");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ChildrensName).HasMaxLength(200);

                entity.Property(e => e.ClientActmgr)
                    .HasMaxLength(300)
                    .HasColumnName("client_actmgr");

                entity.Property(e => e.ClientAddress01)
                    .HasMaxLength(50)
                    .HasColumnName("client_address01");

                entity.Property(e => e.ClientAddress02)
                    .HasMaxLength(50)
                    .HasColumnName("client_address02");

                entity.Property(e => e.ClientAddress03)
                    .HasMaxLength(50)
                    .HasColumnName("client_address03");

                entity.Property(e => e.ClientCategories)
                    .HasMaxLength(50)
                    .HasColumnName("client_Categories");

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(60)
                    .HasColumnName("client_CompanyName");

                entity.Property(e => e.ClientCountry)
                    .HasMaxLength(50)
                    .HasColumnName("client_country");

                entity.Property(e => e.ClientDept)
                    .HasMaxLength(50)
                    .HasColumnName("client_dept");

                entity.Property(e => e.ClientEmail)
                    .HasMaxLength(100)
                    .HasColumnName("client_email");

                entity.Property(e => e.ClientEmail2)
                    .HasMaxLength(100)
                    .HasColumnName("client_Email2");

                entity.Property(e => e.ClientEmail2DisplayName)
                    .HasMaxLength(150)
                    .HasColumnName("client_Email2DisplayName");

                entity.Property(e => e.ClientEmailDisplayName)
                    .HasMaxLength(150)
                    .HasColumnName("client_EmailDisplayName");

                entity.Property(e => e.ClientFax)
                    .HasMaxLength(50)
                    .HasColumnName("client_fax");

                entity.Property(e => e.ClientFname)
                    .HasMaxLength(50)
                    .HasColumnName("client_fname");

                entity.Property(e => e.ClientHomePhone)
                    .HasMaxLength(50)
                    .HasColumnName("client_HomePhone");

                entity.Property(e => e.ClientInvoiceAddress01)
                    .HasMaxLength(50)
                    .HasColumnName("client_invoice_address01");

                entity.Property(e => e.ClientInvoiceAddress02)
                    .HasMaxLength(50)
                    .HasColumnName("client_invoice_address02");

                entity.Property(e => e.ClientInvoiceAddress03)
                    .HasMaxLength(50)
                    .HasColumnName("client_invoice_address03");

                entity.Property(e => e.ClientInvoiceHeader)
                    .HasMaxLength(50)
                    .HasColumnName("client_invoice_header");

                entity.Property(e => e.ClientInvoicePostcode)
                    .HasMaxLength(50)
                    .HasColumnName("client_invoice_postcode");

                entity.Property(e => e.ClientJobTitle)
                    .HasMaxLength(100)
                    .HasColumnName("client_JobTitle");

                entity.Property(e => e.ClientMob)
                    .HasMaxLength(50)
                    .HasColumnName("client_mob");

                entity.Property(e => e.ClientNotes).HasColumnName("client_notes");

                entity.Property(e => e.ClientPostcode)
                    .HasMaxLength(50)
                    .HasColumnName("client_postcode");

                entity.Property(e => e.ClientSname)
                    .HasMaxLength(50)
                    .HasColumnName("client_sname");

                entity.Property(e => e.ClientSuffix)
                    .HasMaxLength(50)
                    .HasColumnName("client_suffix");

                entity.Property(e => e.ClientTel)
                    .HasMaxLength(50)
                    .HasColumnName("client_tel");

                entity.Property(e => e.ClientTitle)
                    .HasMaxLength(50)
                    .HasColumnName("client_title");

                entity.Property(e => e.ClientWebPage)
                    .HasMaxLength(120)
                    .HasColumnName("client_WebPage");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DisableAccount).HasMaxLength(3);

                entity.Property(e => e.Intrests).HasMaxLength(200);

                entity.Property(e => e.PartnerName).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ClientsFiles)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__clients_f__compa__5D6BC808");
            });

            modelBuilder.Entity<CommercialDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommercialSummary).IsUnicode(false);

                entity.Property(e => e.MonToFriEndTime).HasColumnType("time(2)");

                entity.Property(e => e.MonToFriNa).HasColumnName("MonToFriNA");

                entity.Property(e => e.MonToFriStartTime).HasColumnType("time(2)");

                entity.Property(e => e.SaturdayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SaturdayNa).HasColumnName("SaturdayNA");

                entity.Property(e => e.SaturdayStartTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayNa).HasColumnName("SundayNA");

                entity.Property(e => e.SundayStartTime).HasColumnType("time(2)");
            });

            modelBuilder.Entity<CompanyDocsDocumentsList>(entity =>
            {
                entity.ToTable("CompanyDocsDocumentsList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filename).HasMaxLength(250);

                entity.Property(e => e.IsItAfolder)
                    .HasMaxLength(3)
                    .HasColumnName("IsItAFolder");

                entity.Property(e => e.Path).HasMaxLength(500);

                entity.Property(e => e.WhoIsItFor).HasMaxLength(20);
            });

            modelBuilder.Entity<CompanyDomain>(entity =>
            {
                entity.ToTable("CompanyDomain");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyDomains)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompanyDo__Compa__5E5FEC41");
            });

            modelBuilder.Entity<CompanySetup>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__CompanyS__2D971CACC46F7E74");

                entity.ToTable("CompanySetup");

                entity.Property(e => e.CompanyAddress).HasMaxLength(500);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Pim).HasColumnName("PIM");
            });

            modelBuilder.Entity<CompanySetupDefaultHour>(entity =>
            {
                entity.ToTable("CompanySetupDefaultHour");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MonToFriEndTime).HasColumnType("time(2)");

                entity.Property(e => e.MonToFriNa).HasColumnName("MonToFriNA");

                entity.Property(e => e.MonToFriStartTime).HasColumnType("time(2)");

                entity.Property(e => e.SaturdayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SaturdayNa).HasColumnName("SaturdayNA");

                entity.Property(e => e.SaturdayStartTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayNa).HasColumnName("SundayNA");

                entity.Property(e => e.SundayStartTime).HasColumnType("time(2)");
            });

            modelBuilder.Entity<CompanySetupExpectedPhoto>(entity =>
            {
                entity.Property(e => e.PerUnitValue).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhotoTypeNavigation)
                    .WithMany(p => p.CompanySetupExpectedPhotos)
                    .HasForeignKey(d => d.PhotoType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanySetupExpectedPhotos_PictureReasons");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.CompanySetupExpectedPhotos)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanySetupExpectedPhotos_WorkTypeLookup");
            });

            modelBuilder.Entity<CompanySetupWorkingHour>(entity =>
            {
                entity.ToTable("CompanySetupWorkingHour");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndHours).HasColumnType("datetime");

                entity.Property(e => e.HoursFactor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartHours).HasColumnType("datetime");

                entity.Property(e => e.TravelFactor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TravelTimeHours).HasColumnType("datetime");

                entity.Property(e => e.WorkingDays)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.ToTable("CompanyType");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.ConfigKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Config_Key");

                entity.Property(e => e.ConfigValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Config_Value");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStatusEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConfigurationTypeNavigation)
                    .WithMany(p => p.Configurations)
                    .HasForeignKey(d => d.ConfigurationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Configuration__ConfigurationType_ConfigurationType");
            });

            modelBuilder.Entity<ConfigurationType>(entity =>
            {
                entity.ToTable("ConfigurationType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractDeliveryTeam>(entity =>
            {
                entity.ToTable("ContractDeliveryTeam");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.ContractDeliveryTeams)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK_ContractDeliveryTeam_operative_file");
            });

            modelBuilder.Entity<ContractFile>(entity =>
            {
                entity.HasKey(e => e.MainContractId);

                entity.ToTable("contract_file");

                entity.HasIndex(e => e.ConStatus, "MichaelsTestIndex");

                entity.HasIndex(e => new { e.MainContractId, e.ConStatus }, "NonClusteredIndex-20141027-111146")
                    .HasFillFactor((byte)76);

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.AccountContactId).HasColumnName("AccountContactID");

                entity.Property(e => e.AccountsCleared).HasMaxLength(3);

                entity.Property(e => e.AccountsEmail).HasMaxLength(100);

                entity.Property(e => e.AsBuiltDrawings).HasMaxLength(50);

                entity.Property(e => e.BillingType).HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(6)
                    .HasColumnName("client_id");

                entity.Property(e => e.CompletionDocs).HasMaxLength(45);

                entity.Property(e => e.ConClientName)
                    .HasMaxLength(60)
                    .HasColumnName("con_ClientName");

                entity.Property(e => e.ConContactName)
                    .HasMaxLength(60)
                    .HasColumnName("con_ContactName")
                    .IsFixedLength(true);

                entity.Property(e => e.ConCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("con_created");

                entity.Property(e => e.ConDoclocation)
                    .HasMaxLength(255)
                    .HasColumnName("con_doclocation");

                entity.Property(e => e.ConEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("con_end");

                entity.Property(e => e.ConExported).HasColumnName("con_exported");

                entity.Property(e => e.ConIssuedby)
                    .HasMaxLength(50)
                    .HasColumnName("con_issuedby");

                entity.Property(e => e.ConLocation01).HasColumnName("con_location01");

                entity.Property(e => e.ConLocation02).HasColumnName("con_location02");

                entity.Property(e => e.ConLocation03)
                    .HasMaxLength(100)
                    .HasColumnName("con_location03");

                entity.Property(e => e.ConLocation04)
                    .HasMaxLength(100)
                    .HasColumnName("con_location04");

                entity.Property(e => e.ConManager)
                    .HasMaxLength(60)
                    .HasColumnName("con_manager");

                entity.Property(e => e.ConNotes).HasColumnName("con_notes");

                entity.Property(e => e.ConObservations).HasColumnName("con_observations");

                entity.Property(e => e.ConPorder)
                    .HasMaxLength(50)
                    .HasColumnName("con_porder");

                entity.Property(e => e.ConProjectManager)
                    .HasMaxLength(60)
                    .HasColumnName("con_ProjectManager");

                entity.Property(e => e.ConScopeofworks).HasColumnName("con_scopeofworks");

                entity.Property(e => e.ConStart)
                    .HasColumnType("datetime")
                    .HasColumnName("con_start");

                entity.Property(e => e.ConStatus)
                    .HasMaxLength(10)
                    .HasColumnName("con_status");

                entity.Property(e => e.ConTheirref)
                    .HasMaxLength(50)
                    .HasColumnName("con_theirref");

                entity.Property(e => e.ConType)
                    .HasMaxLength(2)
                    .HasColumnName("con_type");

                entity.Property(e => e.ConValue)
                    .HasMaxLength(20)
                    .HasColumnName("con_value");

                entity.Property(e => e.ConWorkgrp)
                    .HasMaxLength(6)
                    .HasColumnName("con_workgrp");

                entity.Property(e => e.ContactId)
                    .HasMaxLength(6)
                    .HasColumnName("Contact_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.ContractCompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ContractPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("contract_prefix");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.ConvertQuoteDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalEndDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalStartDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraCustRef).HasMaxLength(30);

                entity.Property(e => e.FormOfContract).HasMaxLength(50);

                entity.Property(e => e.InvoiceAddress).HasMaxLength(500);

                entity.Property(e => e.Omsmanual)
                    .HasMaxLength(50)
                    .HasColumnName("OMSManual");

                entity.Property(e => e.OpticalFibre).HasMaxLength(50);

                entity.Property(e => e.OtherCompletionDoc).HasMaxLength(50);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(60)
                    .HasColumnName("project_name");

                entity.Property(e => e.ProjectSynopsis).IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.QuotePrefix)
                    .HasMaxLength(1)
                    .HasColumnName("quote_prefix");

                entity.Property(e => e.QuoteYear)
                    .HasMaxLength(2)
                    .HasColumnName("quote_year");

                entity.Property(e => e.ReasonToReOpen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeHistory).HasMaxLength(500);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VariationId)
                    .HasMaxLength(6)
                    .HasColumnName("variation_id");

                entity.Property(e => e.VariationPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("variation_prefix");

                entity.Property(e => e.WorkId)
                    .HasMaxLength(6)
                    .HasColumnName("work_id");

                entity.Property(e => e.WorkPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("work_prefix");
            });

            modelBuilder.Entity<ContractTimescaleDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("It’s a primary key of table.");

                entity.Property(e => e.Addedby).HasColumnName("addedby");

                entity.Property(e => e.Addedon)
                    .HasColumnType("datetime")
                    .HasColumnName("addedon");

                entity.Property(e => e.CeresponseUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEResponseUnit");

                entity.Property(e => e.Cewarning)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CEWarning")
                    .HasComment("Refers to CEWarning.");

                entity.Property(e => e.ClientWarning)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to ClientWarning.");

                entity.Property(e => e.DferesponseTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DFEResponseTime")
                    .HasComment("Refers to DFEResponseTime.");

                entity.Property(e => e.DferesponseUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DFEResponseUnit");

                entity.Property(e => e.EventSubmissionTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to eventSubmissionTime.");

                entity.Property(e => e.InternalWarning)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to internalWarning.");

                entity.Property(e => e.PmiresponseTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PMIResponseTime")
                    .HasComment("Refers to PMIResponseTime.");

                entity.Property(e => e.PmiresponseUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PMIResponseUnit");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Its foreign key of quote_file.Refers to ID");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updatedon)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedon");
            });

            modelBuilder.Entity<ContractorDetail>(entity =>
            {
                entity.ToTable("ContractorDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its Primary key.");

                entity.Property(e => e.AcceptCreditCardPayment).HasComment("Refers to do you accept credit card?. (Add contractor Screen 2).");

                entity.Property(e => e.Approval).HasComment("Its Foreign key of ReferenceData Table. Refers to the Approval radio button.(Add Contractor Screen 3).");

                entity.Property(e => e.BankAccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to account name.(Add contractor Screen 2).");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to account number.(Add contractor Screen 2).");

                entity.Property(e => e.BankAccountSortCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to sort code.(Add contractor Screen 2).");

                entity.Property(e => e.BankBranchAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment(" Refers to branch address.(Add contractor Screen 2).");

                entity.Property(e => e.BankBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to branch name.(Add contractor Screen 2).");

                entity.Property(e => e.ContractorId)
                    .HasColumnName("ContractorID")
                    .HasComment("Its Foreign key of ClientContractorFile Table. Refers to ID.");

                entity.Property(e => e.ContractorsLiabilityIncExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to contractor Liability Expiry Date.(Add contractor Screen 2).");

                entity.Property(e => e.ContractorsLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to contractor Liability number.(Add contractor Screen 2).");

                entity.Property(e => e.EmployerLiabilityIncExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to employer Liability Expiry Date.(Add contractor Screen 2).");

                entity.Property(e => e.EmployerLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to employer Liability number.(Add contractor Screen 2).");

                entity.Property(e => e.IsRetentionApplied).HasComment(" Refers retention is applied or not?. (Add contractor Screen 2).");

                entity.Property(e => e.PercentageCharge)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment(" Refers to %age charge.(Add contractor Screen 2).");

                entity.Property(e => e.ProfIndemnityIncExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to prof Indemnity Expiry Date.(Add contractor Screen 2).");

                entity.Property(e => e.ProfIndemnityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to prof Indemnity number.(Add contractor Screen 2).");

                entity.Property(e => e.PubLiabilityIncExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to Pub Liability Expiry Date.(Add contractor Screen 2).");

                entity.Property(e => e.PubLiabilityIncNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to Pub Liability number.(Add contractor Screen 2).");

                entity.Property(e => e.PurchaseOrderEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to purchase order email. (Add contractor Screen 2).");

                entity.Property(e => e.PurchaseOrderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to purchase order name. (Add contractor Screen 2).");

                entity.Property(e => e.PurchaseOrderTelephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment(" Refers to purchase order telephone. (Add contractor Screen 2).");

                entity.Property(e => e.QuestionarieReceived).HasComment("Refers to Questionarie is received or not?(Add Contractor Screen 3).");

                entity.Property(e => e.RegionApplicable).HasComment("Refers to checkbox of region is checked or not.(Add Contractor Screen 3).");

                entity.Property(e => e.RemittanceEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment(" Refers to the remittance email.");

                entity.Property(e => e.RemittanceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment(" Refers to the remittance name.");

                entity.Property(e => e.RemittanceTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the remittance telephone.");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimestampTrade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradeDetailsApplicable).HasComment("Refers to checkbox of trade is checked or not.(Add Contractor Screen 3).");

                entity.HasOne(d => d.ApprovalNavigation)
                    .WithMany(p => p.ContractorDetails)
                    .HasForeignKey(d => d.Approval)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorDetails)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorDetail_ClientContractorFile_ContractorID_New");
            });

            modelBuilder.Entity<ContractorDetailReference>(entity =>
            {
                entity.ToTable("ContractorDetailReference");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its Primary key.");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasComment("Its Foreign key of ClientContractorFile Table.Refers to ID.");

                entity.Property(e => e.ContractorDetailId)
                    .HasColumnName("ContractorDetailID")
                    .HasComment("Its Foreign key of ContractorDetail Table.Refers to ID.");

                entity.Property(e => e.ContractorDetailReferenceType).HasComment("Its Foreign key of ReferenceData Table. Refers to contractor detail reference type i.e Trade or Region.");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasComment("Its Foreign key of region Table.Refers to id.");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TradeId)
                    .HasColumnName("TradeID")
                    .HasComment("Its Foreign key of Trade Table.Refers to ID.");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ContractorDetailReferences)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ContractorDetailReferences_ClientContractorFile_ClientID");

                entity.HasOne(d => d.ContractorDetail)
                    .WithMany(p => p.ContractorDetailReferences)
                    .HasForeignKey(d => d.ContractorDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorDetailReferences_ContractorDetail_ContractorDetailID");

                entity.HasOne(d => d.ContractorDetailReferenceTypeNavigation)
                    .WithMany(p => p.ContractorDetailReferences)
                    .HasForeignKey(d => d.ContractorDetailReferenceType)
                    .HasConstraintName("FK_ContractorDetailReference_ReferenceData");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.ContractorDetailReferences)
                    .HasForeignKey(d => d.TradeId);
            });

            modelBuilder.Entity<ContractorPartnerDetail>(entity =>
            {
                entity.ToTable("ContractorPartnerDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("It’s a primary key of table.");

                entity.Property(e => e.ContractorId)
                    .HasColumnName("ContractorID")
                    .HasComment("Refers to foreign of client_contractor_file.");

                entity.Property(e => e.PartnerFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to firstname of Contractor partner.");

                entity.Property(e => e.PartnerSurName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to surname of Contractor partner.");

                entity.Property(e => e.PartnerTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to title of Contractor partner.");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorPartnerDetails)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorPartnerDetail_ClientContractorFile_ID");
            });

            modelBuilder.Entity<ContractorProjectPlantCost>(entity =>
            {
                entity.ToTable("ContractorProjectPlantCost");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.WeeklyPlantCost).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ContractsDayBook>(entity =>
            {
                entity.ToTable("ContractsDayBook");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.EmailFrom).HasMaxLength(100);

                entity.Property(e => e.EmailSentWhen).HasColumnType("datetime");

                entity.Property(e => e.EmailTo).HasMaxLength(500);

                entity.Property(e => e.Locked).HasMaxLength(3);

                entity.Property(e => e.Month).HasMaxLength(10);

                entity.Property(e => e.Retention).HasColumnType("money");

                entity.Property(e => e.RetentionDate).HasColumnType("datetime");

                entity.Property(e => e.SalesProvisionValue).HasColumnType("money");

                entity.Property(e => e.Year).HasMaxLength(4);
            });

            modelBuilder.Entity<ContractsDayBookComment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.CommentsAddedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractReference)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");
            });

            modelBuilder.Entity<CordovaSsid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CordovaSSIDs");

                entity.Property(e => e.GangLeaderName).HasMaxLength(60);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ssid).HasColumnName("SSID");

                entity.Property(e => e.Ssiddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SSIDDate");

                entity.Property(e => e.SupervisorName).HasMaxLength(60);
            });

            modelBuilder.Entity<CountryLookup>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("country_lookup");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(6)
                    .HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(60)
                    .HasColumnName("country_name");
            });

            modelBuilder.Entity<CountyLookup>(entity =>
            {
                entity.ToTable("CountyLookup");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<CpuserAuthProvidersDetail>(entity =>
            {
                entity.ToTable("CPUserAuthProvidersDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CploginId).HasColumnName("CPLoginID");

                entity.HasOne(d => d.Cplogin)
                    .WithMany(p => p.CpuserAuthProvidersDetails)
                    .HasForeignKey(d => d.CploginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPUserDetail_CPUserAuthProvidersDetail_CPLoginID");
            });

            modelBuilder.Entity<CpuserDetail>(entity =>
            {
                entity.ToTable("CPUserDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAccessDfes).HasColumnName("IsAccessDFEs");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");
            });

            modelBuilder.Entity<CpuserMainContractAccess>(entity =>
            {
                entity.ToTable("CPUserMainContractAccess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ContractID");

                entity.Property(e => e.CploginId).HasColumnName("CPLoginID");

                entity.HasOne(d => d.Cplogin)
                    .WithMany(p => p.CpuserMainContractAccesses)
                    .HasForeignKey(d => d.CploginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPUSerdetail_CPUserMainContractAccess_CPLoginID");
            });

            modelBuilder.Entity<CustomerEnquiryActionNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerEnquiryActionNotes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_CustomerEnquiryActionNotes_operative_file");

                entity.HasOne(d => d.CustomerEnquiry)
                    .WithMany(p => p.CustomerEnquiryActionNotes)
                    .HasForeignKey(d => d.CustomerEnquiryId)
                    .HasConstraintName("FK_CustomerEnquiryActionNotes_CustomerEnquiryDetails");
            });

            modelBuilder.Entity<CustomerEnquiryActionTask>(entity =>
            {
                entity.ToTable("CustomerEnquiryActionTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(6)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.EventId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EventID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredByDate).HasColumnType("datetime");

                entity.Property(e => e.Requirements)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignToNavigation)
                    .WithMany(p => p.CustomerEnquiryActionTasks)
                    .HasForeignKey(d => d.AssignTo)
                    .HasConstraintName("FK_CustomerEnquiryActionTask_operative_file");

                entity.HasOne(d => d.CustomerEnquiry)
                    .WithMany(p => p.CustomerEnquiryActionTasks)
                    .HasForeignKey(d => d.CustomerEnquiryId)
                    .HasConstraintName("FK_CustomerEnquiryActionTask_CustomerEnquiryDetails");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.CustomerEnquiryActionTasks)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_CustomerEnquiryActionTask_department_file");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CustomerEnquiryActionTasks)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_CustomerEnquiryActionTask_OperativeGroups");
            });

            modelBuilder.Entity<CustomerEnquiryAllocatedHistory>(entity =>
            {
                entity.ToTable("CustomerEnquiryAllocatedHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.HasOne(d => d.CustomerEnquiry)
                    .WithMany(p => p.CustomerEnquiryAllocatedHistories)
                    .HasForeignKey(d => d.CustomerEnquiryId)
                    .HasConstraintName("FK_CustomerEnquiryAllocatedHistory_CustomerEnquiryAllocatedHistory");
            });

            modelBuilder.Entity<CustomerEnquiryComment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.CustomerEnquiryComments)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_CustomerEnquiryComments_CustomerEnquiryDetails");
            });

            modelBuilder.Entity<CustomerEnquiryDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComplainantAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantPostalcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantTownCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IncidentDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Nctype).HasColumnName("NCType");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.RecordedDate).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AgreedByNavigation)
                    .WithMany(p => p.CustomerEnquiryDetailAgreedByNavigations)
                    .HasForeignKey(d => d.AgreedBy)
                    .HasConstraintName("FK_CustomerEnquiryDetails_operative_file1");

                entity.HasOne(d => d.AllocatedToNavigation)
                    .WithMany(p => p.CustomerEnquiryDetailAllocatedToNavigations)
                    .HasForeignKey(d => d.AllocatedTo)
                    .HasConstraintName("FK_CustomerEnquiryDetails_operative_file");

                entity.HasOne(d => d.DealWithByNavigation)
                    .WithMany(p => p.CustomerEnquiryDetailDealWithByNavigations)
                    .HasForeignKey(d => d.DealWithBy)
                    .HasConstraintName("FK_CustomerEnquiryDetails_operative_file2");
            });

            modelBuilder.Entity<CustomerEnquiryPicture>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CustomerEnquiryDetailsId).HasColumnName("CustomerEnquiryDetailsID");

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PictureCompressedFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerEnquiryDetails)
                    .WithMany(p => p.CustomerEnquiryPictures)
                    .HasForeignKey(d => d.CustomerEnquiryDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerEnquiryPictures_CustomerEnquiryDetails");
            });

            modelBuilder.Entity<CustomerEnquiryReference>(entity =>
            {
                entity.ToTable("CustomerEnquiryReference");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.CustomerEnquiryReferences)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_CustomerEnquiryReference_CustomerEnquiryDetails");
            });

            modelBuilder.Entity<Cvi>(entity =>
            {
                entity.HasKey(e => e.Cvino);

                entity.ToTable("CVI");

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.ActualDfevalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ActualDFEValue");

                entity.Property(e => e.AgreedbyEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDfe).HasColumnName("ApprovedDFE");

                entity.Property(e => e.AttentionOf)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BeingChargedAt)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationReason).IsUnicode(false);

                entity.Property(e => e.ClientEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientSignature).HasColumnName("clientSignature");

                entity.Property(e => e.ConfirmationDate).HasMaxLength(20);

                entity.Property(e => e.ConfirmationOnBehalfOf).HasMaxLength(50);

                entity.Property(e => e.ConfirmationPrintName).HasMaxLength(50);

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("ContractID");

                entity.Property(e => e.ContractIdverified).HasColumnName("ContractIDVerified");

                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.CostPreparedBy).HasMaxLength(100);

                entity.Property(e => e.CostSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.CostingsFile).HasMaxLength(200);

                entity.Property(e => e.CvifromIpad).HasColumnName("CVIFromIPAD");

                entity.Property(e => e.CvirelatedTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CVIRelatedTo");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GangLeaderId).HasColumnName("GangLeaderID");

                entity.Property(e => e.HomesAffected)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Instruction).IsRequired();

                entity.Property(e => e.InstructionDetails).IsUnicode(false);

                entity.Property(e => e.InstructionTo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IssueDate)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IssuedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IssuedByDate)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.OtherSpecified).HasMaxLength(100);

                entity.Property(e => e.PathToPdf)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("PathToPDF");

                entity.Property(e => e.Picture1).HasMaxLength(50);

                entity.Property(e => e.Picture2).HasMaxLength(50);

                entity.Property(e => e.PmrdateTimeReceived)
                    .HasColumnType("datetime")
                    .HasColumnName("PMRDateTimeReceived");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.PoprovidedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("POProvidedBy");

                entity.Property(e => e.PosubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POSubmittedDate");

                entity.Property(e => e.ProjectManagerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.ScdcontractId)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("SCDContractID");

                entity.Property(e => e.Scdsignature).HasColumnName("SCDsignature");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Accepted values are: 1 = submitted good; 2 = issues; 3 = cost submitted; 4 = completed; 5 = paid; 6 = cancelled;");

                entity.Property(e => e.StatusChangedBy).HasMaxLength(50);

                entity.Property(e => e.StatusChangedReason).HasMaxLength(200);

                entity.Property(e => e.SubStatus).HasDefaultValueSql("((9))");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimestampForValuation).IsUnicode(false);

                entity.Property(e => e.WhoGavePmi)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WhoGavePMI");

                entity.Property(e => e.WorkId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("WorkID")
                    .HasDefaultValueSql("(N'000000')");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.Cvis)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK_CVI_Assignment");
            });

            modelBuilder.Entity<CvichangeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CVIChangeHistory");

                entity.Property(e => e.ChangeMadeBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<CvidetailsHistoryLog>(entity =>
            {
                entity.ToTable("CVIDetailsHistoryLog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Primary key of table");

                entity.Property(e => e.Cvino)
                    .HasColumnName("CVINo")
                    .HasComment("Foreign key - reference to CVI table");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Column is used to store name of field which is updated.");

                entity.Property(e => e.LastModifiedBy).HasComment("Column is used to store value who has lastly modified by whom.");

                entity.Property(e => e.LastModifiedOn)
                    .HasColumnType("datetime")
                    .HasComment("Column is used to store value when last time modified value.");

                entity.Property(e => e.NewValue).HasComment("Column is used to store new value of field which is updated.");

                entity.Property(e => e.OldValue).HasComment("Column is used to store old value of field which is updated.");

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.CvidetailsHistoryLogs)
                    .HasForeignKey(d => d.Cvino)
                    .HasConstraintName("FK_CVIDetailsHistoryLog_CVI");
            });

            modelBuilder.Entity<Cvipicture>(entity =>
            {
                entity.ToTable("CVIPictures");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Cviid).HasColumnName("CVIID");

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PictureCompressedFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.Cvipictures)
                    .HasForeignKey(d => d.Cvino)
                    .HasConstraintName("FK_CVIPictures_CVIPictures");
            });

            modelBuilder.Entity<CvischedulerNotificationEmail>(entity =>
            {
                entity.ToTable("CVISchedulerNotificationEmails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.NotificationElementId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.CvischedulerNotificationEmails)
                    .HasForeignKey(d => d.Cvino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CVISchedulerNotificationEmails_CVI");
            });

            modelBuilder.Entity<CvistatusUpdateLog>(entity =>
            {
                entity.ToTable("CVIStatusUpdateLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.CvistatusUpdateLogs)
                    .HasForeignKey(d => d.Cvino)
                    .HasConstraintName("FK_CVIStatusUpdateLog_CVI");
            });

            modelBuilder.Entity<CvivariationResponsibility>(entity =>
            {
                entity.ToTable("CVIVariationResponsibility");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Primary key of table");

                entity.Property(e => e.ContactType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Type of contact primary,secondary or further.");

                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasComment("Column is refer to contractid");

                entity.Property(e => e.OperativeId)
                    .HasColumnName("OperativeID")
                    .HasComment("Column is refer to Operative  Id.");

                entity.Property(e => e.WorkId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("WorkID")
                    .HasComment("Column is refer to workid");
            });

            modelBuilder.Entity<DailyMeasureTimestamp>(entity =>
            {
                entity.ToTable("DailyMeasureTimestamp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.GangId).HasColumnName("GangID");

                entity.Property(e => e.LabourDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DailyPlantChecksDetail>(entity =>
            {
                entity.ToTable("DailyPlantChecksDetail");

                entity.HasIndex(e => e.PlantId, "IX_DailyPlantChecksDetail");

                entity.HasIndex(e => new { e.ContractReference, e.GangLeaderName, e.RelevantDate, e.PlantId }, "nci_wi_DailyPlantChecksDetail_2CB5A98548F2D301A20B682307D61474");

                entity.HasIndex(e => new { e.PlantAssignedToName, e.RelevantDate, e.PlantId }, "nci_wi_DailyPlantChecksDetail_4497D68E76407E8FD0F990C2FCC406D0");

                entity.HasIndex(e => new { e.GangLeaderName, e.PlantId, e.RelevantDate }, "nci_wi_DailyPlantChecksDetail_C27ED1F123C34AEF357985A897B269B7");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSubmittedBy).HasMaxLength(50);

                entity.Property(e => e.ContractReference)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.DateTimeOfCheck).HasColumnType("datetime");

                entity.Property(e => e.GangLeaderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileName).HasMaxLength(60);

                entity.Property(e => e.PlantAssignedToName).HasMaxLength(50);

                entity.Property(e => e.PlantCheckedByName).HasMaxLength(50);

                entity.Property(e => e.PlantId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("PlantID");

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("QuestionID");

                entity.Property(e => e.QuestionResponse)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RelevantDate).HasColumnType("date");
            });

            modelBuilder.Entity<DailyPlantChecksDetailArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DailyPlantChecksDetail_Archive");

                entity.Property(e => e.CheckSubmittedBy).HasMaxLength(50);

                entity.Property(e => e.ContractReference)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.DateTimeOfCheck).HasColumnType("datetime");

                entity.Property(e => e.GangLeaderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PictureFileName).HasMaxLength(60);

                entity.Property(e => e.PlantAssignedToName).HasMaxLength(50);

                entity.Property(e => e.PlantCheckedByName).HasMaxLength(50);

                entity.Property(e => e.PlantId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("PlantID");

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("QuestionID");

                entity.Property(e => e.QuestionResponse)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RelevantDate).HasColumnType("date");
            });

            modelBuilder.Entity<DailyProjectNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.ProjectTimeId).HasColumnName("ProjectTimeID");

                entity.HasOne(d => d.ProjectTime)
                    .WithMany(p => p.DailyProjectNotes)
                    .HasForeignKey(d => d.ProjectTimeId)
                    .HasConstraintName("FK_DailyProjectNotes_UserDailyProjectTimes");
            });

            modelBuilder.Entity<DatabaseFirewallRule>(entity =>
            {
                entity.ToTable("database_firewall_rules");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.EndIpAddress)
                    .IsUnicode(false)
                    .HasColumnName("end_ip_address");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StartIpAddress)
                    .IsUnicode(false)
                    .HasColumnName("start_ip_address");
            });

            modelBuilder.Entity<DefaultFolderStructure>(entity =>
            {
                entity.Property(e => e.ConfigType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Container)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryCost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnyNotes).HasMaxLength(50);

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(6)
                    .HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.DeliveryCharge).HasColumnType("money");
            });

            modelBuilder.Entity<DepartmentFile>(entity =>
            {
                entity.HasKey(e => e.IdCode);

                entity.ToTable("department_file");

                entity.Property(e => e.IdCode)
                    .HasMaxLength(6)
                    .HasColumnName("id_code");

                entity.Property(e => e.Department)
                    .HasMaxLength(2)
                    .HasColumnName("department");

                entity.Property(e => e.Description)
                    .HasMaxLength(240)
                    .HasColumnName("description");

                entity.Property(e => e.MarkActive).HasColumnName("mark_active");

                entity.Property(e => e.MarkDeleted).HasColumnName("mark_deleted");
            });

            modelBuilder.Entity<Dfe>(entity =>
            {
                entity.HasKey(e => e.DfeId);

                entity.ToTable("Dfe");

                entity.Property(e => e.DfeId).ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.Dves)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dfe_Assignment");
            });

            modelBuilder.Entity<DigPermit>(entity =>
            {
                entity.HasKey(e => e.PermitId);

                entity.Property(e => e.PermitId).ValueGeneratedNever();

                entity.Property(e => e.Distance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.DigPermits)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK_DigPermits_Assignment");
            });

            modelBuilder.Entity<DocumentAuditLog>(entity =>
            {
                entity.ToTable("DocumentAuditLog");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocumentAuditLogs)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAuditLog_operative_file");
            });

            modelBuilder.Entity<DocumentCountView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DocumentCountView");

                entity.Property(e => e.FolderPath)
                    .IsUnicode(false)
                    .HasColumnName("Folder_Path");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DocumentFile>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("document_file");

                entity.Property(e => e.DocId)
                    .HasMaxLength(6)
                    .HasColumnName("doc_id");

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(2)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.DocBlob).HasColumnName("doc_blob");

                entity.Property(e => e.DocName)
                    .HasMaxLength(254)
                    .HasColumnName("doc_name");

                entity.Property(e => e.DocPath)
                    .HasMaxLength(254)
                    .HasColumnName("doc_path");

                entity.Property(e => e.DocType)
                    .HasMaxLength(20)
                    .HasColumnName("doc_type");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");
            });

            modelBuilder.Entity<DocumentLibrary>(entity =>
            {
                entity.ToTable("DocumentLibrary");

                entity.Property(e => e.Archived).HasColumnType("datetime");

                entity.Property(e => e.ArchivedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedOut).HasColumnType("datetime");

                entity.Property(e => e.CheckedOutBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.FileId).HasColumnName("File_Id");

                entity.Property(e => e.FileName)
                    .IsUnicode(false)
                    .HasColumnName("File_Name");

                entity.Property(e => e.FileTitle)
                    .IsUnicode(false)
                    .HasColumnName("File_Title");

                entity.Property(e => e.FolderPath)
                    .IsUnicode(false)
                    .HasColumnName("Folder_Path");

                entity.Property(e => e.IPadtransferOk).HasColumnName("iPADTransferOK");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EditProjectRate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Header)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<EditProjectRatesTeam>(entity =>
            {
                entity.ToTable("EditProjectRatesTeam");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Header)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttachmentFile).HasMaxLength(200);

                entity.Property(e => e.Bcc).HasMaxLength(2000);

                entity.Property(e => e.Cc).HasMaxLength(2000);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DelayedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasMaxLength(10);

                entity.Property(e => e.EmailBody).IsRequired();

                entity.Property(e => e.EmailStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Draft')")
                    .HasComment("Values can be: 'Draft', 'Saved', 'Closed', 'Open'");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDateTime).HasColumnType("datetime");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Priority).HasMaxLength(20);

                entity.Property(e => e.RegardingId).HasColumnName("RegardingID");

                entity.Property(e => e.SentTo).HasMaxLength(2000);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Not Sent')")
                    .HasComment("Values can be: 'Sent', 'Not Sent'");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            });

            modelBuilder.Entity<EmailAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attachment).IsRequired();

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<EmailControl>(entity =>
            {
                entity.ToTable("EmailControl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direction).HasMaxLength(3);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime");

                entity.Property(e => e.MessageFrom).HasMaxLength(100);

                entity.Property(e => e.MessageSubject).HasMaxLength(250);

                entity.Property(e => e.MessageTo).HasMaxLength(100);

                entity.Property(e => e.PrivateSelection).HasMaxLength(7);

                entity.Property(e => e.QuoteNumber).HasMaxLength(6);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Htmlbody)
                    .IsRequired()
                    .HasColumnName("HTMLBody");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmailTemplateCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmailTemplateModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<EnquiryAuditLog>(entity =>
            {
                entity.ToTable("EnquiryAuditLog");

                entity.Property(e => e.Action).HasMaxLength(10);

                entity.Property(e => e.ActionedOn).HasColumnType("datetime");

                entity.Property(e => e.LoggedInUser)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<EnquiryBidTeam>(entity =>
            {
                entity.ToTable("EnquiryBidTeam");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.OperativeId).HasColumnName("operative_id");
            });

            modelBuilder.Entity<EnquiryOtherContact>(entity =>
            {
                entity.ToTable("EnquiryOtherContact");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EnquiryOtherContacts)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__EnquiryOt__Clien__01A9287E");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.EnquiryOtherContacts)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK__EnquiryOt__LeadI__00B50445");
            });

            modelBuilder.Entity<EnquiryTaskStatus>(entity =>
            {
                entity.ToTable("EnquiryTaskStatus");

                entity.Property(e => e.TaskStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnquiryTask)
                    .WithMany(p => p.EnquiryTaskStatuses)
                    .HasForeignKey(d => d.EnquiryTaskId)
                    .HasConstraintName("FK__EnquiryTa__Enqui__039170F0");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.EnquiryTaskStatuses)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK__EnquiryTa__LeadI__029D4CB7");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FullErrorDescription).IsUnicode(false);

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InputData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutputData)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventSeverity>(entity =>
            {
                entity.ToTable("EventSeverity");

                entity.Property(e => e.Severity).IsRequired();
            });

            modelBuilder.Entity<EventsManagement>(entity =>
            {
                entity.ToTable("EventsManagement");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InjuredPerson).HasColumnName("InjuredPerson ");

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");
            });

            modelBuilder.Entity<EventsManagementType>(entity =>
            {
                entity.ToTable("EventsManagementType");
            });

            modelBuilder.Entity<ExtranetClientAccessList>(entity =>
            {
                entity.ToTable("ExtranetClientAccessList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(8)
                    .HasColumnName("ClientID");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(8)
                    .HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CrossRefId).HasColumnName("CrossRefID");

                entity.Property(e => e.ForeName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(8);

                entity.Property(e => e.SydrfilterGoups)
                    .HasMaxLength(200)
                    .HasColumnName("SYDRfilterGoups");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ExtranetFilesToDownload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExtranetFilesToDownload");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.DownloadFileId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DownloadFileID");

                entity.Property(e => e.DownloadRequestId)
                    .HasMaxLength(6)
                    .HasColumnName("DownloadRequestID");

                entity.Property(e => e.FileDescription).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaultActivity>(entity =>
            {
                entity.ToTable("FaultActivity");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Fault)
                    .WithMany(p => p.FaultActivities)
                    .HasForeignKey(d => d.FaultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaultActivity_FaultMaster");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.FaultActivities)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK__FaultActi__Opera__5B196B42");
            });

            modelBuilder.Entity<FaultEscalation>(entity =>
            {
                entity.ToTable("FaultEscalation");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaultMapLocation>(entity =>
            {
                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaultMaster>(entity =>
            {
                entity.HasKey(e => e.FaultId);

                entity.ToTable("FaultMaster");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.Area)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("Client_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FaultSequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncidentDate).HasColumnType("datetime");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaultPortalStatusEnum>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("FaultPortalStatusEnum");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaultPortalUserAuthProvidersDetail>(entity =>
            {
                entity.ToTable("FaultPortalUserAuthProvidersDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FaultPortalLoginId).HasColumnName("FaultPortalLoginID");

                entity.HasOne(d => d.FaultPortalLogin)
                    .WithMany(p => p.FaultPortalUserAuthProvidersDetails)
                    .HasForeignKey(d => d.FaultPortalLoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaultPortalUserAuthProvidersDetail_FaultPortalUserDetail");
            });

            modelBuilder.Entity<FaultPortalUserDetail>(entity =>
            {
                entity.ToTable("FaultPortalUserDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaultPremise>(entity =>
            {
                entity.Property(e => e.FaultPremiseId).HasColumnName("FaultPremiseID");

                entity.Property(e => e.FaultId).HasColumnName("FaultID");

                entity.Property(e => e.PremiseName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FibreTestResult>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aposition).HasColumnName("APosition");

                entity.Property(e => e.Arack).HasColumnName("ARack");

                entity.Property(e => e.Asuite).HasColumnName("ASuite");

                entity.Property(e => e.AttenuationAb1310nm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AttenuationAB1310nm");

                entity.Property(e => e.AttenuationAb1550nm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AttenuationAB1550nm");

                entity.Property(e => e.AttenuationBa1310nm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AttenuationBA1310nm");

                entity.Property(e => e.AttenuationBa1550nm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AttenuationBA1550nm");

                entity.Property(e => e.AverageAttenuation1310nm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageAttenuation1550nm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageIlmaab1310)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AverageILMAAB1310");

                entity.Property(e => e.AverageIlmaab1550)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AverageILMAAB1550");

                entity.Property(e => e.Bposition).HasColumnName("BPosition");

                entity.Property(e => e.Brack).HasColumnName("BRack");

                entity.Property(e => e.Bsuite).HasColumnName("BSuite");

                entity.Property(e => e.CustomerName).HasColumnName("Customer Name");

                entity.Property(e => e.DistanceAb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DistanceAB");

                entity.Property(e => e.ExchangeCode).HasColumnName("Exchange Code");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Identifier).IsRequired();

                entity.Property(e => e.Ilmaab1310)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ILMAAB1310");

                entity.Property(e => e.Ilmaab1550)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ILMAAB1550");

                entity.Property(e => e.Ilmaba1310)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ILMABA1310");

                entity.Property(e => e.Ilmaba1550)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ILMABA1550");

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.TotalSplicesAb).HasColumnName("TotalSplicesAB");
            });

            modelBuilder.Entity<FileDownloadControl>(entity =>
            {
                entity.HasKey(e => e.FileDownLoadId);

                entity.ToTable("FileDownloadControl");

                entity.Property(e => e.FileDownLoadId).HasColumnName("FileDownLoadID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.CompanySelected).HasMaxLength(200);

                entity.Property(e => e.ExtranetLogonReason).HasMaxLength(150);

                entity.Property(e => e.LogonDays).HasMaxLength(50);

                entity.Property(e => e.LogonHours).HasMaxLength(50);

                entity.Property(e => e.WhenEnabled).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileHistory>(entity =>
            {
                entity.ToTable("FileHistory");

                entity.Property(e => e.CommentsAddedBy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Comments_Added_By");

                entity.Property(e => e.CommentsAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Comments_Added_Date");

                entity.Property(e => e.FileId).HasColumnName("File_Id");

                entity.Property(e => e.FileName)
                    .IsUnicode(false)
                    .HasColumnName("File_Name");

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.Version).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.VersionComments)
                    .IsUnicode(false)
                    .HasColumnName("Version_Comments");
            });

            modelBuilder.Entity<Fitter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColourCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.TagTextColour).HasMaxLength(20);
            });

            modelBuilder.Entity<FittersWorkingOnRepair>(entity =>
            {
                entity.ToTable("FittersWorkingOnRepair");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.FitterId).HasColumnName("FitterID");

                entity.Property(e => e.FitterScdId).HasColumnName("Fitter_SCD_ID");

                entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FuelCardDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NetPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegistrationGiven)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SitePostcode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.VehicleRegistration)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FuelConsumption>(entity =>
            {
                entity.ToTable("FuelConsumption");

                entity.Property(e => e.DateOfEntry).HasColumnType("datetime");

                entity.Property(e => e.EndReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HoursOrMilage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartReading).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Gang>(entity =>
            {
                entity.ToTable("Gang");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GangLeaderId).HasColumnName("GangLeaderID");

                entity.Property(e => e.SubcontractorLabourTeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GangOperative>(entity =>
            {
                entity.HasIndex(e => e.GangId, "IX_GangOperatives");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GangId).HasColumnName("GangID");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.HasOne(d => d.Gang)
                    .WithMany(p => p.GangOperatives)
                    .HasForeignKey(d => d.GangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GangOperatives_Gang");
            });

            modelBuilder.Entity<GenericValue>(entity =>
            {
                entity.ToTable("GenericValue");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetCertificateList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("getCertificateList");

                entity.Property(e => e.CertNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateName).HasMaxLength(200);
            });

            modelBuilder.Entity<GiftsAndGratuity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorisationInfo)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'Gift/Gratuity Not Authorised')");

                entity.Property(e => e.AuthorisedBy).HasMaxLength(6);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EventEndDate).HasColumnType("datetime");

                entity.Property(e => e.EventStartDate).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastAmendedOn).HasColumnType("datetime");

                entity.Property(e => e.Originator)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<GiftsAndGratuityClient>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorisationInfo)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'Not Set')");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("ClientID");

                entity.Property(e => e.Gagid)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("GAGID");
            });

            modelBuilder.Entity<GpsDatum>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id, "ClusteredIndex-20161217-171542")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.Imei, e.TimeUtc }, "GpsDataImeiIndex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "GpsData_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventType).HasMaxLength(128);

                entity.Property(e => e.GpsHeading).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.GpsLatitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.GpsLongitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.GpsSpeed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IMEI")
                    .IsFixedLength(true);

                entity.Property(e => e.InsertedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Parameter1).HasMaxLength(128);

                entity.Property(e => e.Parameter2).HasMaxLength(128);

                entity.Property(e => e.PoiName).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.SpeedLimit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeLocal).HasColumnType("datetime");

                entity.Property(e => e.TimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeUTC");

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VehicleRegistration).HasMaxLength(32);

                entity.Property(e => e.VehicleTemperature).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<GroupPiveledge>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GroupName).IsRequired();

                entity.Property(e => e.Priveledge).IsRequired();
            });

            modelBuilder.Entity<HealthAndSafetyDocControl>(entity =>
            {
                entity.ToTable("HealthAndSafetyDocControl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.Categories).HasMaxLength(500);

                entity.Property(e => e.Filename).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(6);

                entity.Property(e => e.Version).HasColumnType("money");
            });

            modelBuilder.Entity<HealthNsafety>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HealthNSafety");

                entity.Property(e => e.GangLeaderName).HasMaxLength(60);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ssid).HasColumnName("SSID");

                entity.Property(e => e.Ssiddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SSIDDate");

                entity.Property(e => e.SupervisorName).HasMaxLength(60);
            });

            modelBuilder.Entity<HolidayPlannerDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Authorised).HasMaxLength(3);

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Comments).HasMaxLength(150);

                entity.Property(e => e.Confirmed).HasMaxLength(3);

                entity.Property(e => e.DateTimeHolidayRequested).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ForeName).HasMaxLength(50);

                entity.Property(e => e.LeaveComment).IsUnicode(false);

                entity.Property(e => e.LeaveFor).HasMaxLength(20);

                entity.Property(e => e.LeaveType).HasMaxLength(20);

                entity.Property(e => e.Month).HasMaxLength(9);

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.Year).HasMaxLength(4);
            });

            modelBuilder.Entity<HolidayPlannerLog>(entity =>
            {
                entity.ToTable("HolidayPlannerLog");

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.NewValue).IsUnicode(false);

                entity.Property(e => e.OldValue).IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HolidayPlannerView>(entity =>
            {
                entity.ToTable("HolidayPlannerView");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlannerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IPadSsid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("iPadSSIDs");

                entity.Property(e => e.GangLeaderName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Ssid).HasColumnName("SSID");

                entity.Property(e => e.Ssiddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SSIDDate");

                entity.Property(e => e.SupervisorName).HasMaxLength(50);
            });

            modelBuilder.Entity<InHouseFailure>(entity =>
            {
                entity.ToTable("InHouseFailure");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.IssueReportedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantMaintenanceCommentsId).HasColumnName("PlantMaintenanceCommentsID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Issue Reported From iPad')");
            });

            modelBuilder.Entity<InHouseFailureImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateTaken)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.InHouseFailureId).HasColumnName("InHouseFailureID");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IndustryLookup>(entity =>
            {
                entity.HasKey(e => e.IndustryId)
                    .HasName("PK__industry__A9676AC8DE828DEC");

                entity.ToTable("industry_lookup");

                entity.Property(e => e.IndustryId).HasColumnName("industry_id");

                entity.Property(e => e.IndustryCategory)
                    .HasColumnName("industry_category")
                    .HasComment("0 = Old Industry Categories; 1 = New Industry Categories");

                entity.Property(e => e.IndustryLong)
                    .HasMaxLength(60)
                    .HasColumnName("industry_long");

                entity.Property(e => e.IndustryShort)
                    .HasMaxLength(30)
                    .HasColumnName("industry_short");
            });

            modelBuilder.Entity<InternalTeam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<InternalTeamOperative>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InternalTeamId).HasColumnName("InternalTeamID");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.HasOne(d => d.InternalTeam)
                    .WithMany(p => p.InternalTeamOperatives)
                    .HasForeignKey(d => d.InternalTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalTeamOperatives_InternalTeamOperatives");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.InternalTeamOperatives)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalTeamOperatives_operative_file");
            });

            modelBuilder.Entity<InterviewCandidateList>(entity =>
            {
                entity.ToTable("InterviewCandidateList");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewEndDateTime).HasColumnType("datetime");

                entity.Property(e => e.InterviewerOne)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewerThree)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewerTwo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.InterviewCandidateLists)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_InterviewCandidateList_Candidate");

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.InterviewCandidateLists)
                    .HasForeignKey(d => d.VacancyId)
                    .HasConstraintName("FK_InterviewCandidateList_Vacancy");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountCredited).HasColumnType("money");

                entity.Property(e => e.AmountDue).HasColumnType("money");

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.ContactGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ContactGUID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("date");

                entity.Property(e => e.FullyPaidOnDate).HasColumnType("date");

                entity.Property(e => e.InvoiceGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceGUID");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.PlannedPaymentDate).HasColumnType("date");

                entity.Property(e => e.Reference).HasMaxLength(250);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalDiscount).HasColumnType("money");

                entity.Property(e => e.TotalTax).HasColumnType("money");

                entity.Property(e => e.UpdatedDateUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("UpdatedDateUTC");
            });

            modelBuilder.Entity<InvoiceCreditNote>(entity =>
            {
                entity.ToTable("InvoiceCreditNote");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppliedAmount).HasColumnType("money");

                entity.Property(e => e.CreditNoteGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreditNoteGUID");

                entity.Property(e => e.CreditNoteNumber).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FullyPaidOnDate).HasColumnType("date");

                entity.Property(e => e.InvoiceGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceGUID");

                entity.Property(e => e.Reference).HasMaxLength(250);

                entity.Property(e => e.RemainingCredit).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalTax).HasColumnType("money");

                entity.Property(e => e.UpdatedDateUtc).HasColumnName("UpdatedDateUTC");
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.ToTable("InvoiceLineItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCode).HasMaxLength(20);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.InvoiceGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceGUID");

                entity.Property(e => e.LineItemGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LineItemGUID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxType).HasMaxLength(50);

                entity.Property(e => e.TrackingCategoryGuid)
                    .HasMaxLength(50)
                    .HasColumnName("TrackingCategoryGUID");

                entity.Property(e => e.TrackingName).HasMaxLength(200);

                entity.Property(e => e.TrackingOption).HasMaxLength(200);

                entity.Property(e => e.UnitAmount).HasColumnType("money");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.ToTable("InvoicePayment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InvoiceGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceGUID");

                entity.Property(e => e.PaymentGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PaymentGUID");

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(150);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedDateUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("UpdatedDateUTC");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table");

                entity.Property(e => e.Aisle)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("AISLE")
                    .HasComment("Refers to the Aisle.");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the Code.");

                entity.Property(e => e.CompanyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsStockItem).HasComment("Refers to stock item whether it is available or not.");

                entity.Property(e => e.ItemTypeId)
                    .HasColumnName("ItemTypeID")
                    .HasComment("Refers to group & type information");

                entity.Property(e => e.MaxOrderQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the maximum order quantity.");

                entity.Property(e => e.MinOrderQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the minimum order quantity.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to item Name/Description");

                entity.Property(e => e.NominalCode).HasMaxLength(10);

                entity.Property(e => e.PickLocation)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasComment("Refers to the Pick Location.");

                entity.Property(e => e.UnitTypeId)
                    .HasColumnName("UnitTypeID")
                    .HasComment("Refers to UnitType Reference data");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UnitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.ToTable("ItemGroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("group information.");
            });

            modelBuilder.Entity<ItemPriceBreak>(entity =>
            {
                entity.ToTable("ItemPriceBreak");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ThresholdId).HasColumnName("ThresholdID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ItemStock>(entity =>
            {
                entity.ToTable("ItemStock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemSupplierId).HasColumnName("ItemSupplierID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemStocks)
                    .HasForeignKey(d => d.ItemId);

                entity.HasOne(d => d.ItemSupplier)
                    .WithMany(p => p.ItemStocks)
                    .HasForeignKey(d => d.ItemSupplierId)
                    .HasConstraintName("FK_ItemStock_ItemSupplier_ID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ItemStocks)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ItemStocks)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<ItemStockTransferHistory>(entity =>
            {
                entity.ToTable("ItemStockTransferHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.NoOfUnits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransferCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrasnsferedDate).HasColumnType("datetime");

                entity.Property(e => e.ValueOfTransfer).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemStockTransferHistories)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MethodOfTransferNavigation)
                    .WithMany(p => p.ItemStockTransferHistories)
                    .HasForeignKey(d => d.MethodOfTransfer)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransferByNavigation)
                    .WithMany(p => p.ItemStockTransferHistories)
                    .HasForeignKey(d => d.TransferBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransferFromNavigation)
                    .WithMany(p => p.ItemStockTransferHistoryTransferFromNavigations)
                    .HasForeignKey(d => d.TransferFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransferToNavigation)
                    .WithMany(p => p.ItemStockTransferHistoryTransferToNavigations)
                    .HasForeignKey(d => d.TransferTo)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemSupplier>(entity =>
            {
                entity.ToTable("ItemSupplier");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasComment("Refers to item.");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to item Price.");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasComment("Refers to CompanyID.");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemSuppliers)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Supplier_Item_ItemID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ItemSuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Supplier_ClientCompanyFile_SupplierID");
            });

            modelBuilder.Entity<ItemThreshold>(entity =>
            {
                entity.ToTable("ItemThreshold");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemGroupId).HasColumnName("ItemGroupID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.HasOne(d => d.ItemGroup)
                    .WithMany(p => p.ItemThresholds)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_Thresholds_Thresholds_ItemGroupID");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemThresholds)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_Thresholds_ItemType_ItemTypeID");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.ToTable("ItemType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasComment("Refers to group.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Referes to name.");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ItemTypes)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasIndex(e => e.GangId, "IX_Jobs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractFileId).HasColumnName("ContractFileID");

                entity.Property(e => e.GangId).HasColumnName("GangID");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            });

            modelBuilder.Entity<JobCard>(entity =>
            {
                entity.ToTable("JobCard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.FitterId).HasColumnName("FitterID");

                entity.Property(e => e.JobEnd).HasColumnType("datetime");

                entity.Property(e => e.JobStart).HasColumnType("datetime");

                entity.Property(e => e.LastPartialSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OriginOfWork)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Normal')")
                    .HasComment("These values can be either: High; Normal; Low");

                entity.Property(e => e.ReasonForWork)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TravelTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobCardCheck>(entity =>
            {
                entity.HasIndex(e => e.Type, "IX_JobCardChecks");

                entity.HasIndex(e => e.ListIndex, "IX_JobCardChecks_1");

                entity.HasIndex(e => new { e.Type, e.ListIndex }, "IX_JobCardChecks_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ButtonType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CheckText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Disabled)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'No')");

                entity.Property(e => e.NotifiableResponse).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeSubCategory).HasMaxLength(50);
            });

            modelBuilder.Entity<JobCardChecksResponse>(entity =>
            {
                entity.ToTable("JobCardChecksResponse");

                entity.HasIndex(e => e.ListIndex, "IX_JobCardChecksResponse");

                entity.HasIndex(e => e.Response, "IX_JobCardChecksResponse_1");

                entity.HasIndex(e => new { e.ListIndex, e.Response }, "IX_JobCardChecksResponse_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RelatedChecksId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RelatedChecksID");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JobCardPartialUpdate>(entity =>
            {
                entity.ToTable("JobCardPartialUpdate");

                entity.HasIndex(e => new { e.Ticket, e.ItemNo }, "IX_JobCardPartialUpdate");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.ReIssueDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdatedById)
                    .HasColumnName("UpdatedByID")
                    .HasComment("This is the ID of the fitter (NOT the operative ID) in the Fitters tables");
            });

            modelBuilder.Entity<JobCardPic>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<JobCentre>(entity =>
            {
                entity.ToTable("JobCentre");

                entity.HasIndex(e => new { e.Ticket, e.Item }, "IX_JobCentre");

                entity.HasIndex(e => e.RelatedId, "IX_JobCentre_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("This is the unique identifier that identifies the record");

                entity.Property(e => e.DateTimeCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .HasDefaultValueSql("((1))")
                    .HasComment("This is the item number if applicable. Most jobs will have a single item, but some jobs may have multiple items to deal with");

                entity.Property(e => e.JobAllocatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("This identifies which categagory the job came from. i.e. Plant Issues, Plant Checks etc ...");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("RelatedID")
                    .HasComment("This is the \"ID\" field of the appropriate table i.e. PlantIssues, PlantCheck|sControl etc ...");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("This number represents the current status of a job and can be one of the following: 1 = \"Open\"; 2 = \"Allocated\"; 3 = \"In Progress\"; 4 = \"On Hold\"; 5 = \"Completed\"");

                entity.Property(e => e.Ticket).HasComment("This is a dynamically generated number that represents a ticket number regardless of which table the job came from");
            });

            modelBuilder.Entity<JobCentreCalendar>(entity =>
            {
                entity.ToTable("JobCentreCalendar");

                entity.HasIndex(e => new { e.Ticket, e.Item }, "IX_JobCentreCalendar");

                entity.HasIndex(e => new { e.StartDateTime, e.EndDateTime }, "IX_JobCentreCalendar_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Closed)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfWork)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.FitterId).HasColumnName("FitterID");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobCentreTask>(entity =>
            {
                entity.ToTable("JobCentreTask");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.JobCentreCalendarId).HasColumnName("JobCentreCalendarID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("This number represents the current status of a job and can be one of the following: 1 = \"Open\"; 2 = \"Allocated\"; 3 = \"In Progress\"; 4 = \"On Hold\"; 5 = \"Completed\"");

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");
            });

            modelBuilder.Entity<JobCostingBillHeader>(entity =>
            {
                entity.ToTable("JobCostingBillHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress1).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress2).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress3).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress4).HasMaxLength(200);

                entity.Property(e => e.CustomerAddress5).HasMaxLength(200);

                entity.Property(e => e.CustomerEmail).HasMaxLength(200);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerOrderNo).HasMaxLength(200);

                entity.Property(e => e.CustomerRef).HasMaxLength(200);

                entity.Property(e => e.DateTimeLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.FullyInvoicedFlag).HasMaxLength(3);

                entity.Property(e => e.GlobalTaxRate).HasColumnType("money");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceGross).HasColumnType("money");

                entity.Property(e => e.InvoiceNet)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.InvoiceTax).HasColumnType("money");

                entity.Property(e => e.ItemsNet).HasColumnType("money");

                entity.Property(e => e.ItemsTax).HasColumnType("money");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LastUser).HasMaxLength(200);

                entity.Property(e => e.OnHoldEmailSentCheck).HasMaxLength(3);

                entity.Property(e => e.OrderNumber).HasMaxLength(200);

                entity.Property(e => e.OrderTakenBy).HasMaxLength(200);

                entity.Property(e => e.Telephone).HasMaxLength(200);
            });

            modelBuilder.Entity<JobCostingBillLine>(entity =>
            {
                entity.ToTable("JobCostingBillLine");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillHeaderId).HasColumnName("BillHeaderID");

                entity.Property(e => e.BillLineId).HasColumnName("BillLineID");

                entity.Property(e => e.DateTimeLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasColumnType("money");

                entity.Property(e => e.ItemGridPosition).HasMaxLength(5);

                entity.Property(e => e.LastUser).HasMaxLength(200);

                entity.Property(e => e.LineValue).HasColumnType("money");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.PostingDetails).HasMaxLength(200);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");
            });

            modelBuilder.Entity<JobCostingCustomer>(entity =>
            {
                entity.ToTable("JobCostingCustomer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Address3).HasMaxLength(200);

                entity.Property(e => e.Address4).HasMaxLength(200);

                entity.Property(e => e.Address5).HasMaxLength(200);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRef).HasMaxLength(50);

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUser).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<JobCostingJob>(entity =>
            {
                entity.ToTable("JobCostingJob");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerOrderNo).HasMaxLength(50);

                entity.Property(e => e.CustomerReference).HasMaxLength(50);

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.JobStatus).HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUser).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<JobCostingSupplier>(entity =>
            {
                entity.ToTable("JobCostingSupplier");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Address3).HasMaxLength(200);

                entity.Property(e => e.Address4).HasMaxLength(200);

                entity.Property(e => e.Address5).HasMaxLength(200);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUser).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierRef).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<JobCostingTransaction>(entity =>
            {
                entity.ToTable("JobCostingTransaction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChargeAmount).HasColumnType("money");

                entity.Property(e => e.ChargeQuantity).HasColumnType("money");

                entity.Property(e => e.ChargeRate).HasColumnType("money");

                entity.Property(e => e.Chid).HasColumnName("CHID");

                entity.Property(e => e.CostQuantity).HasColumnType("money");

                entity.Property(e => e.CostRate).HasColumnType("money");

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Details).HasMaxLength(200);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUser).HasMaxLength(50);

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.PostingStatus).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderHeaderId).HasColumnName("PurchaseOrderHeaderID");

                entity.Property(e => e.PurchaseOrderItemId).HasColumnName("PurchaseOrderItemID");

                entity.Property(e => e.PurchaseOrderJobItemId).HasColumnName("PurchaseOrderJobItemID");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Ref1).HasMaxLength(15);

                entity.Property(e => e.Ref2).HasMaxLength(15);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.TaxCode).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            });

            modelBuilder.Entity<JobPackInfo>(entity =>
            {
                entity.ToTable("JobPackInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.ContractNumber).HasMaxLength(24);

                entity.Property(e => e.DocumentTitle).HasMaxLength(250);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.FolderPath).HasMaxLength(500);

                entity.Property(e => e.IsItAfolder).HasMaxLength(3);

                entity.Property(e => e.OperativeInformed)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'NO')");

                entity.Property(e => e.Qnumber)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.SharePointFileId)
                    .HasMaxLength(24)
                    .HasColumnName("SharePointFileID");

                entity.Property(e => e.UploadDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<JobPicture>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractReference)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.GangLeaderId).HasColumnName("GangLeaderID");

                entity.Property(e => e.IsVisibleToCp)
                    .IsRequired()
                    .HasColumnName("IsVisibleToCP")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LateralMeasure).HasMaxLength(15);

                entity.Property(e => e.Latitude).HasMaxLength(20);

                entity.Property(e => e.Longitude).HasMaxLength(20);

                entity.Property(e => e.PictureCompressedFileName).HasMaxLength(300);

                entity.Property(e => e.PictureFileName).HasMaxLength(300);

                entity.Property(e => e.PicturePath).HasColumnName("picturePath");

                entity.Property(e => e.PictureReason).HasMaxLength(20);

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            modelBuilder.Entity<LabourFile>(entity =>
            {
                entity.HasKey(e => e.LabourId)
                    .HasName("PK_labour_file_1");

                entity.ToTable("labour_file");

                entity.HasIndex(e => new { e.ContractReference, e.LabourDate }, "MickieTestIndex")
                    .HasFillFactor((byte)75);

                entity.HasIndex(e => new { e.ContractReference, e.LabourDate }, "NonClusteredIndex-20141024-162733")
                    .HasFillFactor((byte)75);

                entity.HasIndex(e => new { e.PostedByAdmin, e.ApprovedBySupervisorName, e.PostedByGangerName }, "nci_wi_labour_file_EAB653F29BD667483C41621B1AAB82D7");

                entity.Property(e => e.LabourId).HasColumnName("labour_id");

                entity.Property(e => e.ActualDoubleHours).HasColumnType("datetime");

                entity.Property(e => e.ActualNormalHours).HasColumnType("datetime");

                entity.Property(e => e.ActualTimeAndHalfHours).HasColumnType("datetime");

                entity.Property(e => e.ActualTravelHours).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBySupervisor).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBySupervisorName).HasMaxLength(50);

                entity.Property(e => e.ClaimedYardEnd).HasColumnType("datetime");

                entity.Property(e => e.ClaimedYardStart).HasColumnType("datetime");

                entity.Property(e => e.ClaimedorTracked).HasMaxLength(1);

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(2)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.DoubleTimeHours).HasColumnType("datetime");

                entity.Property(e => e.DoubleTimeTrueCost).HasColumnType("money");

                entity.Property(e => e.HoursDeductionNotes).HasMaxLength(1000);

                entity.Property(e => e.HoursDeductions).HasColumnType("money");

                entity.Property(e => e.HoursTravel).HasColumnType("datetime");

                entity.Property(e => e.HoursWorked).HasColumnType("datetime");

                entity.Property(e => e.LabourAddress)
                    .HasMaxLength(180)
                    .HasColumnName("labour_address");

                entity.Property(e => e.LabourDate)
                    .HasColumnType("datetime")
                    .HasColumnName("labour_date");

                entity.Property(e => e.LabourGang)
                    .HasMaxLength(6)
                    .HasColumnName("labour_gang");

                entity.Property(e => e.LabourOperative)
                    .HasMaxLength(6)
                    .HasColumnName("labour_operative");

                entity.Property(e => e.LabourSupervisor)
                    .HasMaxLength(6)
                    .HasColumnName("labour_supervisor");

                entity.Property(e => e.LabourTravel)
                    .HasColumnType("datetime")
                    .HasColumnName("labour_travel");

                entity.Property(e => e.LabourTravelRate)
                    .HasMaxLength(6)
                    .HasColumnName("labour_travel_rate");

                entity.Property(e => e.LabourType)
                    .HasMaxLength(1)
                    .HasColumnName("labour_type");

                entity.Property(e => e.LabourWorkRate)
                    .HasMaxLength(6)
                    .HasColumnName("labour_work_rate");

                entity.Property(e => e.LabourWorked)
                    .HasColumnType("datetime")
                    .HasColumnName("labour_worked");

                entity.Property(e => e.MidweekTrueCost).HasColumnType("money");

                entity.Property(e => e.ModifyWages).HasMaxLength(20);

                entity.Property(e => e.NormalHours).HasColumnType("datetime");

                entity.Property(e => e.NormalTrueCost).HasColumnType("money");

                entity.Property(e => e.PayType).HasMaxLength(8);

                entity.Property(e => e.PlantDeduction).HasColumnType("money");

                entity.Property(e => e.PostedByAdmin).HasColumnType("datetime");

                entity.Property(e => e.PostedByGanger).HasColumnType("datetime");

                entity.Property(e => e.PostedByGangerName).HasMaxLength(50);

                entity.Property(e => e.PriceworkDeductionNotes).HasMaxLength(1000);

                entity.Property(e => e.PriceworkDeductions).HasColumnType("money");

                entity.Property(e => e.PriceworkModifyWages).HasColumnType("money");

                entity.Property(e => e.PriceworkValue).HasColumnType("money");

                entity.Property(e => e.PriceworkWages).HasColumnType("money");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_id");

                entity.Property(e => e.SaturdayTrueCost).HasColumnType("money");

                entity.Property(e => e.SupervisorFinish).HasColumnType("datetime");

                entity.Property(e => e.SupervisorLabourType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'W')");

                entity.Property(e => e.SupervisorOffSite).HasColumnType("datetime");

                entity.Property(e => e.SupervisorOnSite).HasColumnType("datetime");

                entity.Property(e => e.SupervisorStart).HasColumnType("datetime");

                entity.Property(e => e.SupervisorTravel).HasColumnType("datetime");

                entity.Property(e => e.SupervisorWorked).HasColumnType("datetime");

                entity.Property(e => e.SupervisorYardEnd).HasColumnType("datetime");

                entity.Property(e => e.SupervisorYardStart).HasColumnType("datetime");

                entity.Property(e => e.TeamMemberDeduction).HasColumnType("money");

                entity.Property(e => e.TimeAndHalfHours).HasColumnType("datetime");

                entity.Property(e => e.TimeLeftSite)
                    .HasColumnType("datetime")
                    .HasColumnName("time_left_site");

                entity.Property(e => e.TimeOnSite)
                    .HasColumnType("datetime")
                    .HasColumnName("time_on_site");

                entity.Property(e => e.TrackerFinish)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_finish");

                entity.Property(e => e.TrackerOffsite)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_offsite");

                entity.Property(e => e.TrackerOnsite)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_onsite");

                entity.Property(e => e.TrackerStart)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_start");

                entity.Property(e => e.TrackerTravel)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_travel");

                entity.Property(e => e.TrackerWorked)
                    .HasColumnType("datetime")
                    .HasColumnName("tracker_worked");

                entity.Property(e => e.TrackerYardEnd).HasColumnType("datetime");

                entity.Property(e => e.TrackerYardStart).HasColumnType("datetime");

                entity.Property(e => e.TravelFromSite)
                    .HasColumnType("datetime")
                    .HasColumnName("travel_from_site");

                entity.Property(e => e.TravelToSite)
                    .HasColumnType("datetime")
                    .HasColumnName("travel_to_site");

                entity.Property(e => e.Wages).HasColumnType("money");

                entity.Property(e => e.WagesTrueCost).HasColumnType("money");
            });

            modelBuilder.Entity<LabourRequirement>(entity =>
            {
                entity.ToTable("LabourRequirement");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabourSheetPlantListing>(entity =>
            {
                entity.ToTable("LabourSheetPlantListing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(10);

                entity.Property(e => e.PlantName).HasMaxLength(50);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientSector)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EstStartDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsProspectingLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'New')")
                    .HasComment("These types can be either \"New\" or \"Contacted\"");

                entity.Property(e => e.OverallLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.PreferredContactMethod)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteRequiredBy).HasColumnType("datetime");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonToClose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonToCloseOther)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Source).HasMaxLength(100);

                entity.Property(e => e.SpecificLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Open')")
                    .HasComment("The status of the Lead can be \"Open\" or \"Closed\"");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WorkStreamSector)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.QuestionId).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MaintenenceContractsAction>(entity =>
            {
                entity.ToTable("MaintenenceContractsAction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedProjectManager).HasMaxLength(50);

                entity.Property(e => e.AssignedProjectManagerDateTime).HasColumnType("datetime");

                entity.Property(e => e.MaintContractId)
                    .HasMaxLength(6)
                    .HasColumnName("MaintContractID");

                entity.Property(e => e.ReportedBy).HasMaxLength(200);

                entity.Property(e => e.ReportedOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<MaintenenceContractsLookup>(entity =>
            {
                entity.ToTable("MaintenenceContractsLookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientIds)
                    .HasMaxLength(300)
                    .HasColumnName("ClientIDs");

                entity.Property(e => e.ClientNames).HasMaxLength(500);

                entity.Property(e => e.ContractClosed).HasMaxLength(3);

                entity.Property(e => e.ContractStart).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(6)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.OriginalContractId)
                    .HasMaxLength(24)
                    .HasColumnName("OriginalContractID");

                entity.Property(e => e.OriginalContractName).HasMaxLength(200);

                entity.Property(e => e.ResponsePeriod).HasMaxLength(20);

                entity.Property(e => e.ThisContractName).HasMaxLength(100);
            });

            modelBuilder.Entity<ManageEmail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MailBcc).IsUnicode(false);

                entity.Property(e => e.MailCc).IsUnicode(false);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OtherAttachments).IsUnicode(false);

                entity.Property(e => e.ProductAttachment).HasMaxLength(250);

                entity.Property(e => e.ReferenceTablePkid).HasColumnName("ReferenceTablePKID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ReferenceTableNavigation)
                    .WithMany(p => p.ManageEmailReferenceTableNavigations)
                    .HasForeignKey(d => d.ReferenceTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ManageEmails__ReferenceData__ReferanceTable");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ManageEmailStatusNavigations)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ManageEma__ReferenceData__Status");
            });

            modelBuilder.Entity<MaterialRequisition>(entity =>
            {
                entity.ToTable("MaterialRequisition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CNumber");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.MaterialType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OpRequiringMaterial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherDetails).HasMaxLength(100);

                entity.Property(e => e.ProjectAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisorLogOn)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<MeasuresExceeded>(entity =>
            {
                entity.ToTable("MeasuresExceeded");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseUnit).HasMaxLength(10);

                entity.Property(e => e.ClientName).HasMaxLength(50);

                entity.Property(e => e.CompletedThisDay).HasMaxLength(20);

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.EmailCheck).HasColumnType("datetime");

                entity.Property(e => e.GangLeader).HasMaxLength(50);

                entity.Property(e => e.LeftToDo).HasMaxLength(10);

                entity.Property(e => e.Measure).HasMaxLength(256);

                entity.Property(e => e.MeasuresExceededDate).HasColumnType("datetime");

                entity.Property(e => e.Planned).HasMaxLength(10);

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.Property(e => e.SalesPerson).HasMaxLength(50);

                entity.Property(e => e.SalesPersonEmail).HasMaxLength(50);
            });

            modelBuilder.Entity<MethodStatement>(entity =>
            {
                entity.ToTable("MethodStatement");

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.Reference)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Statement).IsRequired();
            });

            modelBuilder.Entity<MobilesAndTablet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateReturned).HasColumnType("datetime");

                entity.Property(e => e.DeviceMake).HasMaxLength(30);

                entity.Property(e => e.DeviceModel).HasMaxLength(30);

                entity.Property(e => e.DeviceType).HasMaxLength(30);

                entity.Property(e => e.Imei)
                    .HasMaxLength(15)
                    .HasColumnName("IMEI")
                    .IsFixedLength(true);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.Passcode).HasMaxLength(15);

                entity.Property(e => e.Simnumber)
                    .HasMaxLength(30)
                    .HasColumnName("SIMnumber");

                entity.Property(e => e.UserId)
                    .HasMaxLength(6)
                    .HasColumnName("UserID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MobilesAndTabletsLog>(entity =>
            {
                entity.ToTable("MobilesAndTabletsLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasMaxLength(300);

                entity.Property(e => e.DateOfAction).HasColumnType("datetime");

                entity.Property(e => e.MobilesAndTabletsId).HasColumnName("MobilesAndTabletsID");
            });

            modelBuilder.Entity<ModifyWage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyWages).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NationalMinimumWage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Current18To20).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Current21To24).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Current25Above).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentApprentice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentU18).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Future18To20).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Future21To24).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Future25Above).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FutureApprentice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FutureChangeDate).HasColumnType("datetime");

                entity.Property(e => e.FutureU18).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NationalityLookup>(entity =>
            {
                entity.ToTable("NationalityLookup");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(100);
            });

            modelBuilder.Entity<NcnatureMaster>(entity =>
            {
                entity.ToTable("NCNatureMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewPlantLookup>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.ToTable("New Plant Lookup");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.CalibrationDate)
                    .HasMaxLength(255)
                    .HasColumnName("calibration_date");

                entity.Property(e => e.CalibrationDue)
                    .HasMaxLength(255)
                    .HasColumnName("calibration_due");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.DayRate)
                    .HasColumnType("money")
                    .HasColumnName("day_rate");

                entity.Property(e => e.HireReference)
                    .HasMaxLength(255)
                    .HasColumnName("hire_reference");

                entity.Property(e => e.HireReturnDueDate).HasMaxLength(255);

                entity.Property(e => e.HourRate)
                    .HasColumnType("money")
                    .HasColumnName("hour_rate");

                entity.Property(e => e.IsHireVehicle).HasColumnName("is_hire_vehicle");

                entity.Property(e => e.MaintAttributeStyle).HasMaxLength(255);

                entity.Property(e => e.MaintLogBrief)
                    .HasMaxLength(255)
                    .HasColumnName("MaintLog_Brief");

                entity.Property(e => e.OffHireDate)
                    .HasMaxLength(255)
                    .HasColumnName("off_hire_date");

                entity.Property(e => e.OffHireReference)
                    .HasMaxLength(255)
                    .HasColumnName("off_hire_reference");

                entity.Property(e => e.OnHireDate)
                    .HasMaxLength(255)
                    .HasColumnName("on_hire_date");

                entity.Property(e => e.PlantAddress01)
                    .HasMaxLength(255)
                    .HasColumnName("plant_address01");

                entity.Property(e => e.PlantAddress02)
                    .HasMaxLength(255)
                    .HasColumnName("plant_address02");

                entity.Property(e => e.PlantAddress03)
                    .HasMaxLength(255)
                    .HasColumnName("plant_address03");

                entity.Property(e => e.PlantAddress04)
                    .HasMaxLength(255)
                    .HasColumnName("plant_address04");

                entity.Property(e => e.PlantDepot)
                    .HasMaxLength(255)
                    .HasColumnName("plant_depot");

                entity.Property(e => e.PlantEmail)
                    .HasMaxLength(255)
                    .HasColumnName("plant_email");

                entity.Property(e => e.PlantEngine)
                    .HasMaxLength(255)
                    .HasColumnName("plant_engine");

                entity.Property(e => e.PlantFax)
                    .HasMaxLength(255)
                    .HasColumnName("plant_fax");

                entity.Property(e => e.PlantGroup)
                    .HasMaxLength(255)
                    .HasColumnName("plant_group");

                entity.Property(e => e.PlantLocation)
                    .HasMaxLength(255)
                    .HasColumnName("plant_location");

                entity.Property(e => e.PlantMake)
                    .HasMaxLength(255)
                    .HasColumnName("plant_make");

                entity.Property(e => e.PlantMark)
                    .HasMaxLength(255)
                    .HasColumnName("plant_mark");

                entity.Property(e => e.PlantModel)
                    .HasMaxLength(255)
                    .HasColumnName("plant_model");

                entity.Property(e => e.PlantRate)
                    .HasMaxLength(255)
                    .HasColumnName("plant_rate");

                entity.Property(e => e.PlantRef)
                    .HasMaxLength(255)
                    .HasColumnName("plant_ref");

                entity.Property(e => e.PlantSerial)
                    .HasMaxLength(255)
                    .HasColumnName("plant_serial");

                entity.Property(e => e.PlantSize)
                    .HasMaxLength(255)
                    .HasColumnName("plant_size");

                entity.Property(e => e.PlantSupplier)
                    .HasMaxLength(255)
                    .HasColumnName("plant_supplier");

                entity.Property(e => e.PlantTel)
                    .HasMaxLength(255)
                    .HasColumnName("plant_tel");

                entity.Property(e => e.PlantType)
                    .HasMaxLength(255)
                    .HasColumnName("plant_type");

                entity.Property(e => e.PlantTyreSize)
                    .HasMaxLength(255)
                    .HasColumnName("plant_tyre_size");

                entity.Property(e => e.PlantWebsite)
                    .HasMaxLength(255)
                    .HasColumnName("plant_website");

                entity.Property(e => e.PlantWeight)
                    .HasMaxLength(255)
                    .HasColumnName("plant_weight");

                entity.Property(e => e.RequiresCalibration).HasColumnName("requires_calibration");

                entity.Property(e => e.ScheduledServicingLog).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.WeightMeasurment)
                    .HasMaxLength(255)
                    .HasColumnName("weight_measurment");
            });

            modelBuilder.Entity<NextYearHoliday>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NoOfYearsServiceRequiredForLeavesToBeIncremented).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaturdayBirthdayUse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SundayBirthdayUse)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NominalCode>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.NominalCode1)
                    .HasMaxLength(4)
                    .HasColumnName("NominalCode");
            });

            modelBuilder.Entity<NonConformanceActionNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.NonConformanceActionNotes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_NonConformanceActionNotes_operative_file");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceActionNotes)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceActionNotes_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceActionTask>(entity =>
            {
                entity.ToTable("NonConformanceActionTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(6)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.EventId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EventID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.RequiredByDate).HasColumnType("datetime");

                entity.Property(e => e.Requirements)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignToNavigation)
                    .WithMany(p => p.NonConformanceActionTasks)
                    .HasForeignKey(d => d.AssignTo)
                    .HasConstraintName("FK_NonConformanceActionTask_operative_file");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.NonConformanceActionTasks)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_NonConformanceActionTask_department_file");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.NonConformanceActionTasks)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_NonConformanceActionTask_OperativeGroups");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceActionTasks)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceActionTask_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceAllocatedHistory>(entity =>
            {
                entity.ToTable("NonConformanceAllocatedHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceAllocatedHistories)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceAllocatedHistory_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceComment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceComments)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceComments_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceCostAction>(entity =>
            {
                entity.ToTable("NonConformanceCostAction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.RequiredByDate).HasColumnType("datetime");

                entity.Property(e => e.Requirements)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignToNavigation)
                    .WithMany(p => p.NonConformanceCostActions)
                    .HasForeignKey(d => d.AssignTo)
                    .HasConstraintName("FK_NonConformanceCostAction_operative_file");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.NonConformanceCostActions)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_NonConformanceCostAction_OperativeGroups");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceCostActions)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceCostAction_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualCostOfNcr)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ActualCostOfNCR");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantPostalcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComplainantTownCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectiveAction)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectiveActionComments).IsUnicode(false);

                entity.Property(e => e.CorrectiveActionLessons).IsUnicode(false);

                entity.Property(e => e.CostofNcr)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CostofNCR");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnquiryId).HasColumnName("CustomerEnquiryID");

                entity.Property(e => e.ImmediateAction)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IncidentDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Nctype).HasColumnName("NCType");

                entity.Property(e => e.PreventiveAction)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecordedDate).HasColumnType("datetime");

                entity.Property(e => e.RootCause).IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Audit)
                    .WithMany(p => p.NonConformanceDetails)
                    .HasForeignKey(d => d.AuditId)
                    .HasConstraintName("FK_NonConformanceDetails_Audit");
            });

            modelBuilder.Entity<NonConformanceNature>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NatureId).HasColumnName("NatureID");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NonConformanceNatures)
                    .HasForeignKey(d => d.NatureId)
                    .HasConstraintName("FK_NonConformanceNatures_NCNatureMaster");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceNatures)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceNatures_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformancePicture>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NonConformanceDetailsId).HasColumnName("NonConformanceDetailsID");

                entity.Property(e => e.PictureCompressedFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.NonConformanceDetails)
                    .WithMany(p => p.NonConformancePictures)
                    .HasForeignKey(d => d.NonConformanceDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonConformancePictures_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceReference>(entity =>
            {
                entity.ToTable("NonConformanceReference");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NonConformanceId).HasColumnName("NonConformanceID");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.HasOne(d => d.NonConformance)
                    .WithMany(p => p.NonConformanceReferences)
                    .HasForeignKey(d => d.NonConformanceId)
                    .HasConstraintName("FK_NonConformanceReference_NonConformanceDetails");
            });

            modelBuilder.Entity<NonConformanceReport>(entity =>
            {
                entity.HasKey(e => e.CodeId);

                entity.ToTable("NonConformanceReport");

                entity.Property(e => e.CodeId).HasColumnName("CodeID");

                entity.Property(e => e.AgreedBy)
                    .HasMaxLength(30)
                    .HasColumnName("agreed_by");

                entity.Property(e => e.CauseAssessedBy)
                    .HasMaxLength(30)
                    .HasColumnName("cause_assessed_by");

                entity.Property(e => e.ClaimGang).HasMaxLength(60);

                entity.Property(e => e.ClaimOperatives).HasMaxLength(600);

                entity.Property(e => e.ClaimSupervisor).HasMaxLength(60);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(6)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientName).HasMaxLength(60);

                entity.Property(e => e.ClosedBy)
                    .HasMaxLength(30)
                    .HasColumnName("closed_by");

                entity.Property(e => e.ClosedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closed_date");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ContactId)
                    .HasMaxLength(6)
                    .HasColumnName("ContactID");

                entity.Property(e => e.ContactName).HasMaxLength(60);

                entity.Property(e => e.ContractReference).HasMaxLength(50);

                entity.Property(e => e.CorrectiveActionBy)
                    .HasMaxLength(30)
                    .HasColumnName("corrective_action_by");

                entity.Property(e => e.IssueNumber)
                    .HasMaxLength(1)
                    .HasColumnName("issue_number");

                entity.Property(e => e.PreventativeActionBy)
                    .HasMaxLength(30)
                    .HasColumnName("preventative_action_by");

                entity.Property(e => e.ProblemPo)
                    .HasMaxLength(10)
                    .HasColumnName("problem_po");

                entity.Property(e => e.ProblemType)
                    .HasMaxLength(1)
                    .HasColumnName("problem_type");

                entity.Property(e => e.RecordedBy).HasMaxLength(60);

                entity.Property(e => e.RecordedDate).HasColumnType("datetime");

                entity.Property(e => e.Responsibility).HasMaxLength(60);

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("review_date");

                entity.Property(e => e.Source).HasMaxLength(30);

                entity.Property(e => e.Status).HasMaxLength(80);
            });

            modelBuilder.Entity<NonConformanceResponsible>(entity =>
            {
                entity.ToTable("NonConformanceResponsible");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DebitorCredit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NonconformanceId).HasColumnName("NonconformanceID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.ResponsibleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Nonconformance)
                    .WithMany(p => p.NonConformanceResponsibles)
                    .HasForeignKey(d => d.NonconformanceId)
                    .HasConstraintName("FK_NonConformanceResponsible_NonConformanceDetails");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "CompanyID");

                entity.HasIndex(e => e.LeadId, "LeadID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.CandidatePhoneCallId).HasColumnName("CandidatePhoneCallID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.Note1)
                    .IsRequired()
                    .HasColumnName("Note");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.PhoneCallId).HasColumnName("PhoneCallID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<NotificationProcurement>(entity =>
            {
                entity.ToTable("NotificationProcurement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnName("isRead");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OperationDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientDefectLiabilityPeriod).HasColumnType("datetime");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LadefectLiabilityPeriod)
                    .HasColumnType("datetime")
                    .HasColumnName("LADefectLiabilityPeriod");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.MonToFriEndTime).HasColumnType("time(2)");

                entity.Property(e => e.MonToFriNa).HasColumnName("MonToFriNA");

                entity.Property(e => e.MonToFriStartTime).HasColumnType("time(2)");

                entity.Property(e => e.OperationalSummary)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SaturdayNa).HasColumnName("SaturdayNA");

                entity.Property(e => e.SaturdayStartTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayEndTime).HasColumnType("time(2)");

                entity.Property(e => e.SundayNa).HasColumnName("SundayNA");

                entity.Property(e => e.SundayStartTime).HasColumnType("time(2)");

                entity.Property(e => e.YardInfoNa).HasColumnName("YardInfoNA");

                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.OperationDetails)
                    .HasForeignKey(d => d.MainContractId)
                    .HasConstraintName("FK_OperationsDetails_contract_file");
            });

            modelBuilder.Entity<OperativeDeductionBenefit>(entity =>
            {
                entity.ToTable("OperativeDeductionBenefit");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DeductionOrBenefit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionOrBenefitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsCustomized).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.DeductionBenefit)
                    .WithMany(p => p.OperativeDeductionBenefits)
                    .HasForeignKey(d => d.DeductionBenefitId)
                    .HasConstraintName("FK__Operative__Deduc__361CF0BD");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.OperativeDeductionBenefits)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK__Operative__Opera__3528CC84");
            });

            modelBuilder.Entity<OperativeDoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.CardName).HasMaxLength(200);

                entity.Property(e => e.CardRegNumber)
                    .HasMaxLength(250)
                    .HasColumnName("Card_Reg_Number");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.IPadtransferOk)
                    .HasMaxLength(3)
                    .HasColumnName("iPADtransferOK")
                    .IsFixedLength(true);

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OperativeId)
                    .HasMaxLength(6)
                    .HasColumnName("OperativeID");

                entity.Property(e => e.Section).HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SupercededDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingCertificate).IsUnicode(false);

                entity.Property(e => e.TrainingCost).HasColumnType("money");

                entity.Property(e => e.TrainingHour).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrainingProvider).HasMaxLength(100);

                entity.Property(e => e.TrainingSubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.OperativeDocs)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("fk_OperativeDocs_TrainingDetail");
            });

            modelBuilder.Entity<OperativeDocLog>(entity =>
            {
                entity.ToTable("OperativeDocLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UploadEnd).HasColumnType("datetime");

                entity.Property(e => e.UploadStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<OperativeFile>(entity =>
            {
                entity.HasKey(e => e.OperativeId);

                entity.ToTable("operative_file");

                entity.Property(e => e.OperativeId).HasColumnName("operative_id");

                entity.Property(e => e.AccountBranchAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSortCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccruePerYearService).HasDefaultValueSql("((0))");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddToAd).HasColumnName("AddToAD");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.ApprovedHoliday).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApprovedLieu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BasicAnnualSalary)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessTitle).HasMaxLength(100);

                entity.Property(e => e.CanDoPreSiteCheck)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'No')")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyCarAllocated).HasMaxLength(3);

                entity.Property(e => e.CompanyMobileNumber).HasMaxLength(40);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(6);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DoubleTimeCosts)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.EmploymentEnded).HasColumnType("datetime");

                entity.Property(e => e.EmploymentStarted).HasColumnType("datetime");

                entity.Property(e => e.EmploymentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndComment).IsUnicode(false);

                entity.Property(e => e.EndReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntNextYearremain)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true);

                entity.Property(e => e.EntThisYearRemain)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true);

                entity.Property(e => e.EntitlementNextYear)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true);

                entity.Property(e => e.EntitlementThisYear)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedTermEndDate).HasColumnType("datetime");

                entity.Property(e => e.Forename)
                    .HasMaxLength(30)
                    .HasColumnName("forename");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(2)
                    .HasColumnName("group_id");

                entity.Property(e => e.HolidayCategory).HasMaxLength(50);

                entity.Property(e => e.IPadAllocated)
                    .HasMaxLength(3)
                    .HasColumnName("iPAD_Allocated");

                entity.Property(e => e.IPadVersion)
                    .HasMaxLength(15)
                    .HasColumnName("iPAD_Version");

                entity.Property(e => e.Industry).HasMaxLength(20);

                entity.Property(e => e.Initials)
                    .HasMaxLength(2)
                    .HasColumnName("initials");

                entity.Property(e => e.IsBenefitInPercentage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeductionInPercentage)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LieuDaysAccrued)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDaysRmaining)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LogonAlias).HasMaxLength(40);

                entity.Property(e => e.MailBoxType).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaritalStatus).HasMaxLength(50);

                entity.Property(e => e.MarkDeleted)
                    .HasMaxLength(1)
                    .HasColumnName("mark_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeritId)
                    .HasMaxLength(30)
                    .HasColumnName("MeritID");

                entity.Property(e => e.MethodOfRecruitment).HasMaxLength(40);

                entity.Property(e => e.MidweekCosts)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileAllocated)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.MobileType).HasMaxLength(15);

                entity.Property(e => e.MobileVersion).HasMaxLength(15);

                entity.Property(e => e.NewEmployerDetails).IsUnicode(false);

                entity.Property(e => e.NextOfKinAddress).HasMaxLength(250);

                entity.Property(e => e.NextOfKinName).HasMaxLength(50);

                entity.Property(e => e.NextOfkinContactNumber).HasMaxLength(40);

                entity.Property(e => e.NightRate).HasColumnType("money");

                entity.Property(e => e.Ninumber)
                    .HasMaxLength(20)
                    .HasColumnName("NInumber");

                entity.Property(e => e.NormalCosts)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoticePeriod).HasMaxLength(40);

                entity.Property(e => e.OfficeAddress).HasMaxLength(600);

                entity.Property(e => e.OfficeNumber).HasMaxLength(40);

                entity.Property(e => e.OperativeCompany)
                    .HasMaxLength(6)
                    .HasColumnName("operative_company");

                entity.Property(e => e.OperativeHours)
                    .HasMaxLength(5)
                    .HasColumnName("operative_hours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OperativePictureName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'User-icon.png')");

                entity.Property(e => e.OperativeType)
                    .HasMaxLength(50)
                    .HasColumnName("operative_type");

                entity.Property(e => e.OperativeValue)
                    .HasMaxLength(8)
                    .HasColumnName("operative_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherName).HasMaxLength(30);

                entity.Property(e => e.PaymentFrequency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasMaxLength(4)
                    .HasColumnName("PIN")
                    .HasDefaultValueSql("(N'1234')");

                entity.Property(e => e.ProbationEnded).HasColumnType("datetime");

                entity.Property(e => e.RecruitmentCost).HasMaxLength(100);

                entity.Property(e => e.RedundancySeverancePay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalariedOrSubContract)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.SalaryType)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdayCosts)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SickDay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SundayRate).HasColumnType("money");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .HasColumnName("surname");

                entity.Property(e => e.TrainingSumRecovered)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Utrnumber)
                    .HasMaxLength(30)
                    .HasColumnName("UTRNumber");

                entity.Property(e => e.VolatileSsid)
                    .HasMaxLength(50)
                    .HasColumnName("VolatileSSID");

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.OperativeFiles)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK__operative__Natio__2F6FF32E");

                entity.HasOne(d => d.OfficeNavigation)
                    .WithMany(p => p.OperativeFiles)
                    .HasForeignKey(d => d.Office)
                    .HasConstraintName("FK_client_company_file_Office");
            });

            modelBuilder.Entity<OperativeFileLiveCopy>(entity =>
            {
                entity.HasKey(e => e.OperativeId);

                entity.ToTable("operative_file_LiveCopy");

                entity.Property(e => e.OperativeId).HasColumnName("operative_id");

                entity.Property(e => e.AccountBranchAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSortCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccruePerYearService).HasDefaultValueSql("((0))");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .HasColumnName("active");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.ApprovedHoliday).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApprovedLieu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BasicAnnualSalary).HasColumnType("money");

                entity.Property(e => e.BusinessTitle).HasMaxLength(100);

                entity.Property(e => e.CanDoPreSiteCheck)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'No')")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyCarAllocated).HasMaxLength(3);

                entity.Property(e => e.CompanyEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyMobileNumber).HasMaxLength(40);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(6);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DoubleTimeCosts).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EmploymentEnded).HasColumnType("datetime");

                entity.Property(e => e.EmploymentStarted).HasColumnType("datetime");

                entity.Property(e => e.EmploymentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntNextYearremain)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.EntThisYearRemain)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.EntitlementNextYear)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.EntitlementThisYear).HasMaxLength(6);

                entity.Property(e => e.FixedTermEndDate).HasColumnType("datetime");

                entity.Property(e => e.Forename)
                    .HasMaxLength(30)
                    .HasColumnName("forename");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(2)
                    .HasColumnName("group_id");

                entity.Property(e => e.HolidayCategory).HasMaxLength(50);

                entity.Property(e => e.HolidayPlanner)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.IPadAllocated)
                    .HasMaxLength(3)
                    .HasColumnName("iPAD_Allocated");

                entity.Property(e => e.IPadVersion)
                    .HasMaxLength(15)
                    .HasColumnName("iPAD_Version");

                entity.Property(e => e.Industry).HasMaxLength(20);

                entity.Property(e => e.Initials)
                    .HasMaxLength(2)
                    .HasColumnName("initials");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LieuDaysAccrued)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LieuDaysRmaining)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LogonAlias).HasMaxLength(20);

                entity.Property(e => e.MaritalStatus).HasMaxLength(50);

                entity.Property(e => e.MarkDeleted)
                    .HasMaxLength(1)
                    .HasColumnName("mark_deleted");

                entity.Property(e => e.MethodOfRecruitment).HasMaxLength(40);

                entity.Property(e => e.MidweekCosts).HasColumnType("money");

                entity.Property(e => e.MobileAllocated).HasMaxLength(1);

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.MobileType).HasMaxLength(15);

                entity.Property(e => e.MobileVersion).HasMaxLength(15);

                entity.Property(e => e.NextOfKinAddress).HasMaxLength(250);

                entity.Property(e => e.NextOfKinName).HasMaxLength(50);

                entity.Property(e => e.NextOfkinContactNumber).HasMaxLength(40);

                entity.Property(e => e.NextYear)
                    .HasMaxLength(4)
                    .IsFixedLength(true);

                entity.Property(e => e.NightRate).HasColumnType("money");

                entity.Property(e => e.Ninumber)
                    .HasMaxLength(20)
                    .HasColumnName("NInumber");

                entity.Property(e => e.NormalCosts).HasColumnType("money");

                entity.Property(e => e.NoticePeriod).HasMaxLength(40);

                entity.Property(e => e.OfficeAddress).HasMaxLength(600);

                entity.Property(e => e.OfficeNumber).HasMaxLength(40);

                entity.Property(e => e.OperativeCompany)
                    .HasMaxLength(6)
                    .HasColumnName("operative_company");

                entity.Property(e => e.OperativeHours)
                    .HasMaxLength(8)
                    .HasColumnName("operative_hours");

                entity.Property(e => e.OperativePictureName).HasMaxLength(50);

                entity.Property(e => e.OperativeType)
                    .HasMaxLength(20)
                    .HasColumnName("operative_type");

                entity.Property(e => e.OperativeValue)
                    .HasMaxLength(8)
                    .HasColumnName("operative_value");

                entity.Property(e => e.ParentGroup)
                    .HasMaxLength(6)
                    .HasColumnName("parent_group");

                entity.Property(e => e.PaymentFrequency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Payroll)
                    .HasMaxLength(30)
                    .HasColumnName("payroll");

                entity.Property(e => e.Pin)
                    .HasMaxLength(4)
                    .HasColumnName("PIN")
                    .HasDefaultValueSql("(N'1234')");

                entity.Property(e => e.PublicHolidaysNextYear).HasMaxLength(50);

                entity.Property(e => e.PublicHolidaysThisYear).HasMaxLength(50);

                entity.Property(e => e.RecruitmentCost).HasMaxLength(100);

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.Property(e => e.SalariedOrSubContract)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.SalaryType)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdayCosts).HasColumnType("money");

                entity.Property(e => e.SickDay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SundayRate).HasColumnType("money");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .HasColumnName("surname");

                entity.Property(e => e.ThisYear)
                    .HasMaxLength(4)
                    .IsFixedLength(true);

                entity.Property(e => e.VolatileSsid)
                    .HasMaxLength(50)
                    .HasColumnName("VolatileSSID");

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.OperativeFileLiveCopies)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK__operative__Natio__13C7D8B9");
            });

            modelBuilder.Entity<OperativeGroup>(entity =>
            {
                entity.ToTable("Operative_Groups");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.OperativeGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.OperativeGroups)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_operative");
            });

            modelBuilder.Entity<OperativeGroup1>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__Operativ__149AF36A66F70245");

                entity.ToTable("OperativeGroups");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OperativeManager>(entity =>
            {
                entity.ToTable("Operative_Manager");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.OperativeManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Operative__Manag__3434A84B");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.OperativeManagers)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Operative__Opera__33408412");
            });

            modelBuilder.Entity<OperativeStatusChangeHistory>(entity =>
            {
                entity.ToTable("OperativeStatusChangeHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.OperativeStatusChangeHistories)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK_OperativeStatusChangeHistory_operative_file");
            });

            modelBuilder.Entity<OperativeTask>(entity =>
            {
                entity.ToTable("OperativeTask");

                entity.Property(e => e.DateLogged).HasColumnType("datetime");

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TaskDescription).HasMaxLength(100);

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.OperativeTasks)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_operatives_task");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OperativeTasks)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_task_status");
            });

            modelBuilder.Entity<OperativeTaskStatus>(entity =>
            {
                entity.ToTable("OperativeTaskStatus");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StatusColour)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OperativeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operative_type");

                entity.Property(e => e.IdCode)
                    .HasMaxLength(6)
                    .HasColumnName("id_code");

                entity.Property(e => e.MarkDeleted).HasColumnName("mark_deleted");

                entity.Property(e => e.OpDesc)
                    .HasMaxLength(120)
                    .HasColumnName("op_desc");

                entity.Property(e => e.OpGroup)
                    .HasMaxLength(2)
                    .HasColumnName("op_group");

                entity.Property(e => e.OpType)
                    .HasMaxLength(30)
                    .HasColumnName("op_type");
            });

            modelBuilder.Entity<OperativesCosting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperativesCosting");

                entity.Property(e => e.BasicHourlyRate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CostingGroup)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.HolidayAndSickPay)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insurances)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MobileCallsPerMonth)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MobilePhonePerMonth)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Nhipercent)
                    .HasMaxLength(10)
                    .HasColumnName("NHIpercent")
                    .IsFixedLength(true);

                entity.Property(e => e.Nhiweek)
                    .HasMaxLength(10)
                    .HasColumnName("NHIweek")
                    .IsFixedLength(true);

                entity.Property(e => e.NhiworkingDays)
                    .HasMaxLength(10)
                    .HasColumnName("NHIworkingDays")
                    .IsFixedLength(true);

                entity.Property(e => e.Overtime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Rate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SmallTools)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StatDaysPerYear)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TotalHourlyRate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingAmount)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingDays)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkingDays)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkingHoursInDay)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkingHoursInWeek)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkingWeeks)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Workwear)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its Primary Key.");

                entity.Property(e => e.ApproverId)
                    .HasColumnName("ApproverID")
                    .HasComment("Refers to the Approver ID.");

                entity.Property(e => e.ContactTelNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to the Contact number.");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Refers to the Delivery Address.");

                entity.Property(e => e.DeliveryDriver)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Refers to the delivery notes.");

                entity.Property(e => e.DispatchDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeliveryTypeOrder).HasComment("Default is 0, 1=Its for Delivery type Order, 0= Not for Delivery type Order.");

                entity.Property(e => e.IsOrderedByCompany).HasComment("Default is 0, 1=Its for Ordered By Company, 0= Not for Ordered By Company.");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the Order Number.");

                entity.Property(e => e.OrderNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("Refers to the order notes.");

                entity.Property(e => e.OrderValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Order value.");

                entity.Property(e => e.OrderedBy).HasComment("Refers to the Order by.");

                entity.Property(e => e.OrderedDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to the Order date.");

                entity.Property(e => e.OrphanSupplierId).HasMaxLength(50);

                entity.Property(e => e.OrphanSupplierName).HasMaxLength(100);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasComment("Its Foreign key of quote_file Table. Refers to the project.");

                entity.Property(e => e.PurchaseOrderGuid)
                    .HasMaxLength(50)
                    .HasColumnName("PurchaseOrderGUID");

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the Purchase Order Number.");

                entity.Property(e => e.ReasonForRejection)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredByDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to the the required by date.");

                entity.Property(e => e.Status).HasComment("Refers to the status from ReferenceData table where Type = OrderStatus.");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasComment("Its Foreign key of Supplier Table. Refers to the Supplier.");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("Refers to the Time Stamp.");

                entity.Property(e => e.UpdatedDateUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("UpdatedDateUTC");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProjectId);

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Status);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<OrderBookItem>(entity =>
            {
                entity.ToTable("OrderBookItem");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.PriceExcludingVat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PriceExcludingVAT");

                entity.Property(e => e.PricePerUnit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its Primary Key.");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Discount");

                entity.Property(e => e.IsStockItem).HasComment("Default is 0, 1=Its for Stock Item, 0= Not for Stock Item.");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasComment("Its Foreign key of Item Table. Refers to the Item.");

                entity.Property(e => e.LineItemId).HasMaxLength(50);

                entity.Property(e => e.NetTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Net Total.");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("Its Foreign key of Order Table. Refers to the Order.");

                entity.Property(e => e.OrderValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Order value.");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Quantity.");

                entity.Property(e => e.QuantityReceived)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Quantity received.");

                entity.Property(e => e.QuantityRejected)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Quantity Rejected.");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Rate.");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the Size.");

                entity.Property(e => e.Specification)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to the Specification.");

                entity.Property(e => e.UnitType).HasComment("Refers to the Unit type.");

                entity.Property(e => e.UnitValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to the Unit value.");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasIndex(e => new { e.Ticket, e.ItemNo }, "IX_Parts");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateSelected).HasColumnType("datetime");

                entity.Property(e => e.ItemNo).HasComment("If the Ticket has more than 1 issue attached to it then the item number informs you which item is being maintained");

                entity.Property(e => e.SupplierPricesId).HasColumnName("SupplierPricesID");

                entity.Property(e => e.SupplierPricesSid)
                    .HasMaxLength(50)
                    .HasColumnName("SupplierPricesSID");
            });

            modelBuilder.Entity<PhoneCall>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.Number).HasMaxLength(250);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.RecipientPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regarding)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegardingId).HasColumnName("RegardingID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Open')")
                    .HasComment("These values can be \"Open\" or \"Closed\"");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PictureReason>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlannerViewOperative>(entity =>
            {
                entity.ToTable("PlannerViewOperative");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ElementId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Planner)
                    .WithMany(p => p.PlannerViewOperatives)
                    .HasForeignKey(d => d.PlannerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlannerViewOperative_HolidayPlannerView");
            });

            modelBuilder.Entity<PlanningGeneralAnswer>(entity =>
            {
                entity.Property(e => e.DateTimePosted).HasColumnType("datetime");

                entity.Property(e => e.PostedBy).HasMaxLength(80);

                entity.Property(e => e.YesOrNo)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PlanningGeneralQuestion)
                    .WithMany(p => p.PlanningGeneralAnswers)
                    .HasForeignKey(d => d.PlanningGeneralQuestionId)
                    .HasConstraintName("FK__PlanningG__Plann__041B80D5");
            });

            modelBuilder.Entity<PlanningGeneralQuestion>(entity =>
            {
                entity.Property(e => e.Active)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.QuestionText).HasMaxLength(100);
            });

            modelBuilder.Entity<PlanningInfo>(entity =>
            {
                entity.HasKey(e => e.PlanningId)
                    .HasName("PK_VMplanningInfo");

                entity.ToTable("PlanningInfo");

                entity.Property(e => e.PlanningId).HasColumnName("PlanningID");

                entity.Property(e => e.Activity).HasMaxLength(500);

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.AsBuiltComplete).HasColumnType("datetime");

                entity.Property(e => e.Backfilled).HasColumnType("datetime");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(24)
                    .HasColumnName("ContractID")
                    .IsFixedLength(true);

                entity.Property(e => e.Coordinates).HasMaxLength(500);

                entity.Property(e => e.DurationDays).HasColumnType("money");

                entity.Property(e => e.EngDifficulties).HasMaxLength(500);

                entity.Property(e => e.HighwaysAgency).HasMaxLength(500);

                entity.Property(e => e.JobpackCompleted)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.LatitudeLongitude).HasMaxLength(100);

                entity.Property(e => e.NoticeNumber).HasMaxLength(60);

                entity.Property(e => e.NoticeOrPermit).HasMaxLength(500);

                entity.Property(e => e.OtherParty).HasMaxLength(500);

                entity.Property(e => e.PlannedEnd).HasColumnType("datetime");

                entity.Property(e => e.PlannedStart).HasColumnType("datetime");

                entity.Property(e => e.PreSiteCheckComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.PreSitedById)
                    .HasMaxLength(6)
                    .HasColumnName("PreSitedByID")
                    .IsFixedLength(true);

                entity.Property(e => e.PreSitedByName).HasMaxLength(60);

                entity.Property(e => e.PrintsValidUntil).HasColumnType("datetime");

                entity.Property(e => e.ProgrammeDays).HasColumnType("money");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("QuoteID")
                    .IsFixedLength(true);

                entity.Property(e => e.RegisterRequired).HasColumnType("datetime");

                entity.Property(e => e.Registered).HasColumnType("datetime");

                entity.Property(e => e.Reinstated).HasColumnType("datetime");

                entity.Property(e => e.RoadName).HasMaxLength(500);

                entity.Property(e => e.SiteClear).HasColumnType("datetime");

                entity.Property(e => e.StreetUsrn)
                    .HasMaxLength(500)
                    .HasColumnName("StreetUSRN");

                entity.Property(e => e.Surface).HasMaxLength(50);

                entity.Property(e => e.TrafficManagement).HasMaxLength(500);

                entity.Property(e => e.TrafficSens).HasMaxLength(500);

                entity.Property(e => e.Vmmeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("VMmeasure");

                entity.Property(e => e.Works2Do).HasMaxLength(500);
            });

            modelBuilder.Entity<PlanningLocationComment>(entity =>
            {
                entity.Property(e => e.CivilsCablingcomments).HasMaxLength(100);

                entity.Property(e => e.CoOrdscomments).HasMaxLength(100);

                entity.Property(e => e.DateTimePosted).HasColumnType("datetime");

                entity.Property(e => e.Highwayscomments).HasMaxLength(100);

                entity.Property(e => e.JobPackGoodOrRejected).HasMaxLength(8);

                entity.Property(e => e.NoticePermitcomments).HasMaxLength(100);

                entity.Property(e => e.OtherPartycomments).HasMaxLength(100);

                entity.Property(e => e.PostedBy).HasMaxLength(80);

                entity.Property(e => e.TrafficMgmntcomments).HasMaxLength(100);

                entity.Property(e => e.Usrncomments)
                    .HasMaxLength(100)
                    .HasColumnName("USRNcomments");
            });

            modelBuilder.Entity<PlantAcceptance>(entity =>
            {
                entity.ToTable("PlantAcceptance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateConformityCorrect)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DoorsLocksHingesGoodCondition)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.GangLeader)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LightsBeaconsOperational)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineClean)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineFreeFromCracksBoom)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineFreeFromLeaks)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineSafe)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineThoroughlyGreased)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MountingsAttachedSecurely)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.PathToPdf)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("PathToPDF");

                entity.Property(e => e.PlantFreeFromDamageToBody)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.QuickHitchFunctionalSecure)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RearHitchMechanismOperate)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RegPlateVisible)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RoadTaxDisplayed)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.RollOverPreventionFunctional)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SafeWorkingLoadDisplayed)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SafetyLabelsInPlace)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StepsHandrailsGoodCondition)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SubmittedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TowingSocketSecure)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.TyresFreeFromDamage)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Weight)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WindowsFreeFromChipsCracks)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.WipersOperational)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<PlantCheckControl>(entity =>
            {
                entity.ToTable("PlantCheckControl");

                entity.HasIndex(e => e.DailyPlantChecksDetailId, "IX_PlantCheckControl");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("The unique ID of the record in the table");

                entity.Property(e => e.CompletionDate)
                    .HasColumnType("datetime")
                    .HasComment("The date the check has completed it's lifecycle and has gone back to site, hirer, or is no longer the property of SCD");

                entity.Property(e => e.DailyPlantChecksDetailId)
                    .HasColumnName("DailyPlantChecksDetailID")
                    .HasComment("The ID of the check in the DailyPlantCheckDetails table");

                entity.Property(e => e.LoggedDate)
                    .HasColumnType("datetime")
                    .HasComment("The date that this check was logged into this table");

                entity.Property(e => e.PlantMaintenanceCommentsId).HasColumnName("PlantMaintenanceCommentsID");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(400)
                    .HasComment("This is the location ID of the plant, found in the plant_lookup table");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("The date when the status was last changed");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Open')")
                    .HasComment("The actual status given to this check (to be a list - not yet determined)");
            });

            modelBuilder.Entity<PlantCheckControlComment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentMadeBy).HasMaxLength(50);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.PlantCheckControlId).HasColumnName("PlantCheckControlID");
            });

            modelBuilder.Entity<PlantCheckListing>(entity =>
            {
                entity.ToTable("PlantCheckListing");

                entity.HasIndex(e => new { e.Type, e.Disabled }, "IX_PlantCheckListing");

                entity.HasIndex(e => e.ListIndex, "IX_PlantCheckListing_1");

                entity.HasIndex(e => new { e.ListIndex, e.Type }, "IX_PlantCheckListing_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ButtonType).HasMaxLength(20);

                entity.Property(e => e.Category)
                    .HasMaxLength(7)
                    .IsFixedLength(true);

                entity.Property(e => e.CheckText).HasMaxLength(500);

                entity.Property(e => e.Disabled).HasMaxLength(3);

                entity.Property(e => e.NotifiableResponse).HasMaxLength(10);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PlantCheckScdstore>(entity =>
            {
                entity.ToTable("PlantCheckSCDStore");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ButtonType).HasMaxLength(20);

                entity.Property(e => e.CheckText).HasMaxLength(500);

                entity.Property(e => e.Disabled).HasMaxLength(3);

                entity.Property(e => e.Type).HasMaxLength(60);
            });

            modelBuilder.Entity<PlantChecksForScdstore>(entity =>
            {
                entity.ToTable("PlantChecksForSCDStore");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CheckedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("This is the windows logon name");

                entity.Property(e => e.DateTimeOfCheck).HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantTransferControlId).HasColumnName("PlantTransferControlID");
            });

            modelBuilder.Entity<PlantComponentCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubCat1).HasMaxLength(50);

                entity.Property(e => e.SubCat2).HasMaxLength(50);

                entity.Property(e => e.SubCat3).HasMaxLength(50);

                entity.Property(e => e.SubCat4).HasMaxLength(50);

                entity.Property(e => e.SubCat5).HasMaxLength(50);
            });

            modelBuilder.Entity<PlantDefault>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("plant_default");

                entity.Property(e => e.PlantType)
                    .HasMaxLength(60)
                    .HasColumnName("plant_type");
            });

            modelBuilder.Entity<PlantDoc>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PlantFile>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.ToTable("plant_file");

                entity.HasIndex(e => new { e.ContractReference, e.PlantDate, e.PlantIdfromPlantLookup }, "MickiesPlantIndexTest")
                    .HasFillFactor((byte)75);

                entity.HasIndex(e => new { e.PlantGang, e.PlantDate }, "nci_wi_plant_file_A2C2B63CA5137C38FB4D0253E78BA887");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(2)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(10)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PlantCost)
                    .HasMaxLength(10)
                    .HasColumnName("plant_cost");

                entity.Property(e => e.PlantDate)
                    .HasColumnType("datetime")
                    .HasColumnName("plant_date");

                entity.Property(e => e.PlantDepot)
                    .HasMaxLength(50)
                    .HasColumnName("plant_depot");

                entity.Property(e => e.PlantEngine)
                    .HasMaxLength(30)
                    .HasColumnName("plant_engine");

                entity.Property(e => e.PlantGang)
                    .HasMaxLength(6)
                    .HasColumnName("plant_gang");

                entity.Property(e => e.PlantIdfromPlantLookup)
                    .HasMaxLength(6)
                    .HasColumnName("PlantIDfromPlantLookup");

                entity.Property(e => e.PlantMake)
                    .HasMaxLength(30)
                    .HasColumnName("plant_make");

                entity.Property(e => e.PlantModel)
                    .HasMaxLength(30)
                    .HasColumnName("plant_model");

                entity.Property(e => e.PlantQty)
                    .HasColumnType("datetime")
                    .HasColumnName("plant_qty");

                entity.Property(e => e.PlantRef)
                    .HasMaxLength(20)
                    .HasColumnName("plant_ref");

                entity.Property(e => e.PlantSerial)
                    .HasMaxLength(30)
                    .HasColumnName("plant_serial");

                entity.Property(e => e.PlantSize)
                    .HasMaxLength(30)
                    .HasColumnName("plant_size");

                entity.Property(e => e.PlantSupAdd01)
                    .HasMaxLength(50)
                    .HasColumnName("plant_sup_add01");

                entity.Property(e => e.PlantSupAdd02)
                    .HasMaxLength(50)
                    .HasColumnName("plant_sup_add02");

                entity.Property(e => e.PlantSupAdd03)
                    .HasMaxLength(50)
                    .HasColumnName("plant_sup_add03");

                entity.Property(e => e.PlantSupAdd04)
                    .HasMaxLength(50)
                    .HasColumnName("plant_sup_add04");

                entity.Property(e => e.PlantSupDepot)
                    .HasMaxLength(50)
                    .HasColumnName("plant_sup_depot");

                entity.Property(e => e.PlantSupEmail)
                    .HasMaxLength(120)
                    .HasColumnName("plant_sup_email");

                entity.Property(e => e.PlantSupFax)
                    .HasMaxLength(17)
                    .HasColumnName("plant_sup_fax");

                entity.Property(e => e.PlantSupTel)
                    .HasMaxLength(17)
                    .HasColumnName("plant_sup_tel");

                entity.Property(e => e.PlantSupplier)
                    .HasMaxLength(50)
                    .HasColumnName("plant_supplier");

                entity.Property(e => e.PlantType)
                    .HasMaxLength(60)
                    .HasColumnName("plant_type");

                entity.Property(e => e.PlantTyreSize)
                    .HasMaxLength(20)
                    .HasColumnName("plant_tyre_size");

                entity.Property(e => e.PlantWeight)
                    .HasMaxLength(10)
                    .HasColumnName("plant_weight");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(10)
                    .HasColumnName("quote_id");
            });

            modelBuilder.Entity<PlantFileUploadInfo>(entity =>
            {
                entity.ToTable("PlantFileUploadInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.DocumentTitle).HasMaxLength(100);

                entity.Property(e => e.IsItAfolder).HasMaxLength(3);

                entity.Property(e => e.PlantId)
                    .HasMaxLength(6)
                    .HasColumnName("PlantID");

                entity.Property(e => e.UploadDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlantGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("plant_group");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .HasColumnName("group_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InUse).HasMaxLength(30);
            });

            modelBuilder.Entity<PlantInExstraInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlantInExstraInfo");

                entity.Property(e => e.Pic1FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic2FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic3FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic4FilenameIn).HasMaxLength(50);
            });

            modelBuilder.Entity<PlantIssue>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.PlantId }, "IX_PlantIssues");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Confirmation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Awaiting Confirmation')");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.FirstQuestion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IssueReportedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Picture1).HasMaxLength(100);

                entity.Property(e => e.Picture2).HasMaxLength(100);

                entity.Property(e => e.Picture3).HasMaxLength(100);

                entity.Property(e => e.Picture4).HasMaxLength(100);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantLocation).IsRequired();

                entity.Property(e => e.PlantMaintenanceCommentsId).HasColumnName("PlantMaintenanceCommentsID");

                entity.Property(e => e.PlantOwner)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SecondQuestion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Issue Reported From iPad')");
            });

            modelBuilder.Entity<PlantIssueComment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentMadeBy).HasMaxLength(50);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.PlantIssueId).HasColumnName("PlantIssueID");
            });

            modelBuilder.Entity<PlantLookup>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PK_Sdg");

                entity.ToTable("plant_lookup");

                entity.HasIndex(e => e.PlantType, "IX_Plant_lookup_plant_type");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.CalibrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("calibration_date");

                entity.Property(e => e.CalibrationDateDelete)
                    .HasMaxLength(20)
                    .HasColumnName("calibration_date_DELETE");

                entity.Property(e => e.CalibrationDue)
                    .HasColumnType("datetime")
                    .HasColumnName("calibration_due");

                entity.Property(e => e.CalibrationDueDelete)
                    .HasMaxLength(20)
                    .HasColumnName("calibration_due_DELETE");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.DatePurchased).HasColumnType("datetime");

                entity.Property(e => e.DayRate)
                    .HasColumnType("money")
                    .HasColumnName("day_rate");

                entity.Property(e => e.DeliveryCost).HasColumnType("money");

                entity.Property(e => e.DirectOrAgency).HasMaxLength(10);

                entity.Property(e => e.EstAssetValue).HasColumnType("money");

                entity.Property(e => e.HireReference)
                    .HasMaxLength(30)
                    .HasColumnName("hire_reference");

                entity.Property(e => e.HireReturnDueDate).HasColumnType("datetime");

                entity.Property(e => e.HireReturnDueDateDelete)
                    .HasMaxLength(20)
                    .HasColumnName("HireReturnDueDate_DELETE");

                entity.Property(e => e.HourRate)
                    .HasColumnType("money")
                    .HasColumnName("hour_rate");

                entity.Property(e => e.IsHireVehicle).HasColumnName("is_hire_vehicle");

                entity.Property(e => e.MaintAttributeStyle).HasMaxLength(100);

                entity.Property(e => e.MaintLogBrief).HasColumnName("MaintLog_Brief");

                entity.Property(e => e.Manager).HasMaxLength(100);

                entity.Property(e => e.MaxTowingCapacity).HasMaxLength(20);

                entity.Property(e => e.OffHireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("off_hire_date");

                entity.Property(e => e.OffHireDateDelete)
                    .HasMaxLength(20)
                    .HasColumnName("off_hire_date_DELETE");

                entity.Property(e => e.OffHireReference)
                    .HasMaxLength(20)
                    .HasColumnName("off_hire_reference");

                entity.Property(e => e.OnHireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("on_hire_date");

                entity.Property(e => e.OnHireDateDelete)
                    .HasMaxLength(20)
                    .HasColumnName("on_hire_date_DELETE");

                entity.Property(e => e.PayrollCodes).HasMaxLength(10);

                entity.Property(e => e.PlantAddress01)
                    .HasMaxLength(60)
                    .HasColumnName("plant_address01");

                entity.Property(e => e.PlantAddress02)
                    .HasMaxLength(60)
                    .HasColumnName("plant_address02");

                entity.Property(e => e.PlantAddress03)
                    .HasMaxLength(60)
                    .HasColumnName("plant_address03");

                entity.Property(e => e.PlantAddress04)
                    .HasMaxLength(60)
                    .HasColumnName("plant_address04");

                entity.Property(e => e.PlantDepot)
                    .HasMaxLength(60)
                    .HasColumnName("plant_depot");

                entity.Property(e => e.PlantEmail)
                    .HasMaxLength(120)
                    .HasColumnName("plant_email");

                entity.Property(e => e.PlantEngine)
                    .HasMaxLength(30)
                    .HasColumnName("plant_engine");

                entity.Property(e => e.PlantFax)
                    .HasMaxLength(17)
                    .HasColumnName("plant_fax");

                entity.Property(e => e.PlantGroup)
                    .HasMaxLength(60)
                    .HasColumnName("plant_group");

                entity.Property(e => e.PlantLocation)
                    .HasMaxLength(160)
                    .HasColumnName("plant_location");

                entity.Property(e => e.PlantMake)
                    .HasMaxLength(30)
                    .HasColumnName("plant_make");

                entity.Property(e => e.PlantMark)
                    .HasMaxLength(10)
                    .HasColumnName("plant_mark");

                entity.Property(e => e.PlantModel)
                    .HasMaxLength(30)
                    .HasColumnName("plant_model");

                entity.Property(e => e.PlantRate)
                    .HasMaxLength(8)
                    .HasColumnName("plant_rate");

                entity.Property(e => e.PlantRef)
                    .HasMaxLength(20)
                    .HasColumnName("plant_ref");

                entity.Property(e => e.PlantSerial)
                    .HasMaxLength(30)
                    .HasColumnName("plant_serial");

                entity.Property(e => e.PlantSize)
                    .HasMaxLength(30)
                    .HasColumnName("plant_size");

                entity.Property(e => e.PlantSupplier)
                    .HasMaxLength(60)
                    .HasColumnName("plant_supplier");

                entity.Property(e => e.PlantTel)
                    .HasMaxLength(17)
                    .HasColumnName("plant_tel");

                entity.Property(e => e.PlantType)
                    .HasMaxLength(60)
                    .HasColumnName("plant_type");

                entity.Property(e => e.PlantTyreSize)
                    .HasMaxLength(20)
                    .HasColumnName("plant_tyre_size");

                entity.Property(e => e.PlantWebsite)
                    .HasMaxLength(120)
                    .HasColumnName("plant_website");

                entity.Property(e => e.PlantWeight)
                    .HasMaxLength(10)
                    .HasColumnName("plant_weight");

                entity.Property(e => e.PurchasePrice).HasColumnType("money");

                entity.Property(e => e.RequiresCalibration).HasColumnName("requires_calibration");

                entity.Property(e => e.SafeWorkingLoad1).HasMaxLength(20);

                entity.Property(e => e.SafeWorkingLoad2).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.WeeklyCost).HasColumnType("money");

                entity.Property(e => e.WeightMeasurment)
                    .HasMaxLength(3)
                    .HasColumnName("weight_measurment");
            });

            modelBuilder.Entity<PlantMaintAttribute>(entity =>
            {
                entity.HasKey(e => e.MaintAttributesId);

                entity.Property(e => e.MaintAttributesId).HasColumnName("MaintAttributesID");

                entity.Property(e => e.GroupAttrName).HasMaxLength(100);

                entity.Property(e => e.TestName).HasMaxLength(100);

                entity.Property(e => e.TestType).HasMaxLength(20);
            });

            modelBuilder.Entity<PlantMaintScheduledServiceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbbreviatedDescription).HasMaxLength(50);

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.DevelopmentDescription).HasMaxLength(50);

                entity.Property(e => e.FullDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<PlantMaintenanceCertificationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CertificationRequired).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PlantGroup).HasMaxLength(60);

                entity.Property(e => e.PlantType).HasMaxLength(60);

                entity.Property(e => e.ServiceType1).HasMaxLength(100);

                entity.Property(e => e.ServiceType2).HasMaxLength(100);

                entity.Property(e => e.ServiceType3).HasMaxLength(100);
            });

            modelBuilder.Entity<PlantMaintenanceComment>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentMadeBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlantMaintenanceDamage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DamageReportDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<PlantMaintenanceDamagesPic>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateTaken).HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PlantMaintenenceLog>(entity =>
            {
                entity.HasKey(e => e.MaintLogId);

                entity.ToTable("PlantMaintenenceLog");

                entity.HasIndex(e => e.MaintLogId, "IX_PlantMaintenenceLog");

                entity.Property(e => e.MaintLogId).HasColumnName("MaintLogID");

                entity.Property(e => e.AttributeGroupName).HasMaxLength(100);

                entity.Property(e => e.CostOfAnySpares).HasColumnType("money");

                entity.Property(e => e.DamageIndicator).HasMaxLength(25);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PlantId)
                    .HasMaxLength(6)
                    .HasColumnName("PlantID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.Property(e => e.TestType).HasMaxLength(50);
            });

            modelBuilder.Entity<PlantRequestDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.PlantRequestDetails)
                    .HasForeignKey(d => d.MainContractId)
                    .HasConstraintName("FK_PlantRequestDetails_contract_file");
            });

            modelBuilder.Entity<PlantRequisition>(entity =>
            {
                entity.ToTable("PlantRequisition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CNumber");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.DurationOfUse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpRequiringPlant)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlantType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectDuration)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.Specifications).HasMaxLength(100);

                entity.Property(e => e.SupervisorLogOn)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PlantRequisitionDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantRequestId).HasColumnName("PlantRequestID");

                entity.Property(e => e.RequiredByDate).HasColumnType("datetime");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.PlantRequisitionDetails)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK_PlantRequisitionDetails_plant_lookup");

                entity.HasOne(d => d.PlantRequest)
                    .WithMany(p => p.PlantRequisitionDetails)
                    .HasForeignKey(d => d.PlantRequestId)
                    .HasConstraintName("FK_PlantRequisitionDetails_PlantRequestDetails");
            });

            modelBuilder.Entity<PlantTransferControl>(entity =>
            {
                entity.ToTable("PlantTransferControl");

                entity.HasIndex(e => e.PlantId, "IX_PlantTransferControl");

                entity.HasIndex(e => new { e.TransferCancelledDate, e.TransferAcceptedDate }, "IX_PlantTransferControl_1");

                entity.HasIndex(e => new { e.TransferToId, e.TransferAcceptedDate }, "IX_PlantTransferControl_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptanceCheck).HasMaxLength(30);

                entity.Property(e => e.Pic1FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic1FilenameOut).HasMaxLength(60);

                entity.Property(e => e.Pic2FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic2FilenameOut).HasMaxLength(60);

                entity.Property(e => e.Pic3FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic3FilenameOut).HasMaxLength(60);

                entity.Property(e => e.Pic4FilenameIn).HasMaxLength(50);

                entity.Property(e => e.Pic4FilenameOut).HasMaxLength(60);

                entity.Property(e => e.PlantGroup).HasMaxLength(60);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantRef).HasMaxLength(60);

                entity.Property(e => e.PlantType).HasMaxLength(60);

                entity.Property(e => e.ScdreceiptIninitials)
                    .HasMaxLength(2)
                    .HasColumnName("SCDreceiptIninitials");

                entity.Property(e => e.TransferAcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.TransferCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.TransferFromId)
                    .HasMaxLength(6)
                    .HasColumnName("TransferFromID");

                entity.Property(e => e.TransferFromName).HasMaxLength(60);

                entity.Property(e => e.TransferOutById)
                    .HasMaxLength(30)
                    .HasColumnName("TransferOutByID");

                entity.Property(e => e.TransferOutByName).HasMaxLength(60);

                entity.Property(e => e.TransferRequestDate).HasColumnType("datetime");

                entity.Property(e => e.TransferToId)
                    .HasMaxLength(6)
                    .HasColumnName("TransferToID");

                entity.Property(e => e.TransferToName).HasMaxLength(60);

                entity.Property(e => e.WhereaboutsId)
                    .HasMaxLength(6)
                    .HasColumnName("WhereaboutsID");
            });

            modelBuilder.Entity<PlantType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("plant_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(60)
                    .HasColumnName("type_name");
            });

            modelBuilder.Entity<PlantWhereabout>(entity =>
            {
                entity.HasIndex(e => new { e.IssuedToId, e.IssuedDate, e.ReturnedDate }, "IX_PlantWhereabouts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentView).HasMaxLength(1);

                entity.Property(e => e.GangTransfer).HasMaxLength(3);

                entity.Property(e => e.IssuedById)
                    .HasMaxLength(6)
                    .HasColumnName("IssuedByID")
                    .IsFixedLength(true);

                entity.Property(e => e.IssuedByName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedToId)
                    .HasMaxLength(6)
                    .HasColumnName("IssuedToID")
                    .IsFixedLength(true);

                entity.Property(e => e.IssuedToName).HasMaxLength(60);

                entity.Property(e => e.PlantGroup).HasMaxLength(60);

                entity.Property(e => e.PlantId)
                    .HasMaxLength(6)
                    .HasColumnName("PlantID")
                    .IsFixedLength(true);

                entity.Property(e => e.PlantRef)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.PlantType).HasMaxLength(60);

                entity.Property(e => e.ReturnListCheck).HasMaxLength(1);

                entity.Property(e => e.ReturnedById)
                    .HasMaxLength(6)
                    .HasColumnName("ReturnedByID")
                    .IsFixedLength(true);

                entity.Property(e => e.ReturnedByName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedToId)
                    .HasMaxLength(6)
                    .HasColumnName("ReturnedToID")
                    .IsFixedLength(true);

                entity.Property(e => e.ReturnedToName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PpeRequisition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PpeRequisition");

                entity.Property(e => e.AdditionalInformation).HasMaxLength(400);

                entity.Property(e => e.Cnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CNumber");

                entity.Property(e => e.CompletedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateRequired)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ProjectAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Ppeworkwear>(entity =>
            {
                entity.ToTable("PPEWorkwear");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.TopSize).HasMaxLength(5);

                entity.Property(e => e.TrouserSize).HasMaxLength(5);
            });

            modelBuilder.Entity<PriceEnquiry>(entity =>
            {
                entity.ToTable("PriceEnquiry");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.DelieveryAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Refers to the Delievery Address.");

                entity.Property(e => e.EmailAttachments)
                    .IsUnicode(false)
                    .HasComment("Refers to the Email Attachments.");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasComment("Refers to the Email Body.");

                entity.Property(e => e.EnquiryName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasComment("Refers to the Enquiry Name.");

                entity.Property(e => e.IsForQuoteOrContract).HasComment("Default is 1, 1=Its for Quote or Contract, 0= Not for Quote or Contract.");

                entity.Property(e => e.OtherEmails)
                    .IsUnicode(false)
                    .HasComment("Comma separated if multiple.");

                entity.Property(e => e.PriceFor).HasComment("Refers to PriceFor Reference data.");

                entity.Property(e => e.ProductAttachments).IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasComment("Refers to quote_id for fetch C/Q Number.");

                entity.Property(e => e.RequiredByDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to the Required By Date.");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PriceEnquiries)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<PriceEnquiryItemType>(entity =>
            {
                entity.ToTable("PriceEnquiryItemType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.PriceEnquiryId).HasColumnName("PriceEnquiryID");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.PriceEnquiryItemTypes)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceEnquiryItemType_ItemType");

                entity.HasOne(d => d.PriceEnquiry)
                    .WithMany(p => p.PriceEnquiryItemTypes)
                    .HasForeignKey(d => d.PriceEnquiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceEnquiryItemType_PriceEnquiry");
            });

            modelBuilder.Entity<PriceEnquirySupplier>(entity =>
            {
                entity.ToTable("PriceEnquirySupplier");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.CheapPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.LeadTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PriceEnquiryId)
                    .HasColumnName("PriceEnquiryID")
                    .HasComment("Refers to price enquiry information.");

                entity.Property(e => e.ProductAttachment).IsUnicode(false);

                entity.Property(e => e.RespondedDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasComment("Refers to CompanyID.");

                entity.HasOne(d => d.PriceEnquiry)
                    .WithMany(p => p.PriceEnquirySuppliers)
                    .HasForeignKey(d => d.PriceEnquiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceInquiry_Supplier_PriceInquiry_ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PriceEnquirySuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceInquiry_Supplier_PriceInquiry_SupplierID");
            });

            modelBuilder.Entity<ProductEnquiry>(entity =>
            {
                entity.ToTable("ProductEnquiry");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to the description.");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasComment("Referes to Item.");

                entity.Property(e => e.MinOrderQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Net).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceEnquirySupplierId).HasColumnName("PriceEnquirySupplierID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to quantity of available product.");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Size)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Refers to the size of product.");

                entity.Property(e => e.Specification)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to the specification of product.");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProductEnquiries)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductEnquiery_Item_ItemID");

                entity.HasOne(d => d.PriceEnquirySupplier)
                    .WithMany(p => p.ProductEnquiries)
                    .HasForeignKey(d => d.PriceEnquirySupplierId)
                    .HasConstraintName("FK_ProductEnquiry_PriceEnquirySupplier_ID");
            });

            modelBuilder.Entity<ProjectCheckIndicator>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.UploadRamsonTablets).HasColumnName("UploadRAMSonTablets");

                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.ProjectCheckIndicators)
                    .HasForeignKey(d => d.MainContractId)
                    .HasConstraintName("FK_ProjectCheckIndicators_contract_file");
            });

            modelBuilder.Entity<ProjectExpectedPhoto>(entity =>
            {
                entity.Property(e => e.PerUnitValue).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhotoTypeNavigation)
                    .WithMany(p => p.ProjectExpectedPhotos)
                    .HasForeignKey(d => d.PhotoType)
                    .HasConstraintName("FK_ProjectExpectedPhotos_PictureReasons");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.ProjectExpectedPhotos)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectExpectedPhotos_WorkTypeLookup");
            });

            modelBuilder.Entity<ProjectLabourRequirement>(entity =>
            {
                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.ProjectLabourRequirements)
                    .HasForeignKey(d => d.MainContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contractLabourRequirement_contract_file");
            });

            modelBuilder.Entity<ProjectSheq>(entity =>
            {
                entity.ToTable("ProjectSHEQ");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsNotifiableUnderCmd).HasColumnName("IsNotifiableUnderCMD");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequireRams).HasColumnName("RequireRAMS");

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.ProjectSheqs)
                    .HasForeignKey(d => d.MainContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSHEQ_contract_file");
            });

            modelBuilder.Entity<ProjectWork>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Cvino).HasColumnName("CVINo");

                entity.Property(e => e.DesignatorType).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Shiftpattern).HasMaxLength(50);

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.ProjectWorks)
                    .HasForeignKey(d => d.Cvino)
                    .HasConstraintName("FK_ProjectWorks_CVI");

                entity.HasOne(d => d.Revision)
                    .WithMany(p => p.ProjectWorks)
                    .HasForeignKey(d => d.RevisionId)
                    .HasConstraintName("FK_ProjectWorks_Valuation");
            });

            modelBuilder.Entity<ProjectWorkingHour>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndHours).HasColumnType("datetime");

                entity.Property(e => e.HoursFactor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartHours).HasColumnType("datetime");

                entity.Property(e => e.TravelFactor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TravelTimeHours).HasColumnType("datetime");

                entity.Property(e => e.WorkingDays)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublicHoliday>(entity =>
            {
                entity.ToTable("PublicHoliday");

                entity.Property(e => e.CalendarYear)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PublicUtilityDamage>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PK_PublicUtilityDamages");

                entity.ToTable("PublicUtilityDamage");

                entity.Property(e => e.CodeId).HasColumnName("CodeID");

                entity.Property(e => e.AnswerFour).HasMaxLength(100);

                entity.Property(e => e.AnswerOne).HasMaxLength(100);

                entity.Property(e => e.AnswerThree).HasMaxLength(100);

                entity.Property(e => e.AnswerTwo).HasMaxLength(100);

                entity.Property(e => e.ClientContactedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.ContractType).HasMaxLength(20);

                entity.Property(e => e.ContractorResponsibleContactName).HasMaxLength(50);

                entity.Property(e => e.ContractorResponsibleContactNumber).HasMaxLength(20);

                entity.Property(e => e.ContractorResponsibleId).HasColumnName("ContractorResponsibleID");

                entity.Property(e => e.DamageLocation).HasMaxLength(20);

                entity.Property(e => e.DamageTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("DamageTypeID");

                entity.Property(e => e.FinalReportSelectedDocIds)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FinalReportSelectedDocIDs");

                entity.Property(e => e.FinalReportVisitorLogIds)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("FinalReportVisitorLogIDs");

                entity.Property(e => e.IncidentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.ReasonForReOpenInvestigation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecordedBy).HasMaxLength(50);

                entity.Property(e => e.RecordedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReportedBy).HasMaxLength(50);

                entity.Property(e => e.ReportedByCompany).HasMaxLength(100);

                entity.Property(e => e.Responsibility).HasMaxLength(50);

                entity.Property(e => e.Severity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UtilityContactName).HasMaxLength(50);

                entity.Property(e => e.UtilityContactNumber).HasMaxLength(20);

                entity.Property(e => e.UtilityContactedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UtilityId).HasColumnName("UtilityID");

                entity.Property(e => e.UtilityReference).HasMaxLength(50);

                entity.Property(e => e.WorksType).HasMaxLength(30);
            });

            modelBuilder.Entity<PublicUtilityDamageChangeSet>(entity =>
            {
                entity.ToTable("PublicUtilityDamageChangeSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientContactedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.IncidentDateTime).HasColumnType("datetime");

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.UtilityContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtilityContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UtilityContactedDateTime).HasColumnType("datetime");

                entity.Property(e => e.UtilityReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Investigation)
                    .WithMany(p => p.PublicUtilityDamageChangeSets)
                    .HasForeignKey(d => d.InvestigationId)
                    .HasConstraintName("FK_PublicUtilityDamageChangeSet_PublicUtilityDamageInvestigation");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamageChangeSets)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_PublicUtilityDamageChangeSet_PublicUtilityDamage");
            });

            modelBuilder.Entity<PublicUtilityDamageGangResponsible>(entity =>
            {
                entity.ToTable("PublicUtilityDamageGangResponsible");

                entity.Property(e => e.GangLeaderId).HasColumnName("GangLeaderID");

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.PublicUtilityDamagesId).HasColumnName("PublicUtilityDamagesID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.PublicUtilityDamageGangResponsibles)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLID");
            });

            modelBuilder.Entity<PublicUtilityDamageInformation>(entity =>
            {
                entity.HasKey(e => e.Infold);

                entity.ToTable("PublicUtilityDamageInformation");

                entity.Property(e => e.BtprintsProvided).HasColumnName("BTPrintsProvided");

                entity.Property(e => e.CctvprintsProvided).HasColumnName("CCTVPrintsProvided");

                entity.Property(e => e.InputOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<PublicUtilityDamageInvestigation>(entity =>
            {
                entity.ToTable("PublicUtilityDamageInvestigation");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.BtprintsProvided).HasColumnName("BTPrintsProvided");

                entity.Property(e => e.CctvprintsProvided).HasColumnName("CCTVPrintsProvided");

                entity.Property(e => e.CurrentInvestigationStatus).HasMaxLength(50);

                entity.Property(e => e.EventLeadingToIncident).IsUnicode(false);

                entity.Property(e => e.ImmediateActionTaken).IsUnicode(false);

                entity.Property(e => e.ImmediateDirectCause).IsUnicode(false);

                entity.Property(e => e.InvestigationDate).HasColumnType("datetime");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.RiddornotificationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RIDDORNotificationDate");

                entity.Property(e => e.StrikeClassification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SurfaceMaterial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.PublicUtilityDamageInvestigations)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_PUDInvestigation_Agent");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamageInvestigations)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DamageID");

                entity.HasOne(d => d.Signature)
                    .WithMany(p => p.PublicUtilityDamageInvestigations)
                    .HasForeignKey(d => d.SignatureId)
                    .HasConstraintName("Fk_Investigation_Signature");
            });

            modelBuilder.Entity<PublicUtilityDamageInvestigationTypeAnswer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer1).HasMaxLength(100);

                entity.Property(e => e.Answer2).HasMaxLength(100);

                entity.Property(e => e.Answer3).HasMaxLength(100);

                entity.Property(e => e.Answer4).HasMaxLength(100);

                entity.Property(e => e.DamageLocation).HasMaxLength(100);

                entity.Property(e => e.DamageTypeId)
                    .HasMaxLength(100)
                    .HasColumnName("DamageTypeID");

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.SurfaceMaterial)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublicUtilityDamagePicture>(entity =>
            {
                entity.ToTable("PublicUtilityDamagePicture");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PictureCompressedFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamagePictures)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_UtilityDamageImage_UtilityDamage");
            });

            modelBuilder.Entity<PublicUtilityDamageReport>(entity =>
            {
                entity.ToTable("PublicUtilityDamageReport");

                entity.Property(e => e.AgreedCostOfRepair).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApproxCostOfRepair).HasMaxLength(12);

                entity.Property(e => e.DirectCause)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EnteredOn).HasColumnType("datetime");

                entity.Property(e => e.InsuranceCompanyContacted).HasMaxLength(100);

                entity.Property(e => e.Liability)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LiablePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LongTermRecommendation).HasMaxLength(500);

                entity.Property(e => e.LongTermTimescale).HasMaxLength(100);

                entity.Property(e => e.QuotedCostOfRepair).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShortTermRecommendation).HasMaxLength(500);

                entity.Property(e => e.ShortTermTimescale).HasMaxLength(100);

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamageReports)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_PublicUtilityDamagesId_Report");
            });

            modelBuilder.Entity<PublicUtilityDamageSignature>(entity =>
            {
                entity.ToTable("PublicUtilityDamageSignature");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.SignatureDate).HasColumnType("datetime");

                entity.Property(e => e.SignatureType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamageSignatures)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_DamagesID_Signature");
            });

            modelBuilder.Entity<PublicUtilityDamageType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PublicUtilityDamageType");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.DamageColour)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DamageGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DamageType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.QuestionFour).HasMaxLength(100);

                entity.Property(e => e.QuestionOne)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QuestionThree)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QuestionTwo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PublicUtilityDamageWitness>(entity =>
            {
                entity.ToTable("PublicUtilityDamageWitness");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.SignatureFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatementDate).HasColumnType("datetime");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDamageWitnesses)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PublicUtilityDamageWitness_PublicUtilityDamage");
            });

            modelBuilder.Entity<PublicUtilityDescriptionOfIncidentChangeSet>(entity =>
            {
                entity.ToTable("PublicUtilityDescriptionOfIncidentChangeSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DescriptionType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.HasOne(d => d.Investigation)
                    .WithMany(p => p.PublicUtilityDescriptionOfIncidentChangeSets)
                    .HasForeignKey(d => d.InvestigationId)
                    .HasConstraintName("FK_PublicUtilityDamageInformation_PublicUtilityDamageInvestigation");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityDescriptionOfIncidentChangeSets)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_PublicUtilityDamageInformation_PublicUtilityDamage");
            });

            modelBuilder.Entity<PublicUtilityIndirectCause>(entity =>
            {
                entity.ToTable("PublicUtilityIndirectCause");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ElementID");

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.Rcno).HasColumnName("RCNo");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Weighting)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityIndirectCauses)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_PublicUtilityIndirectCause_PublicUtilityDamage");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.PublicUtilityIndirectCauses)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_PublicUtilityDamageReport_IndirectCause");
            });

            modelBuilder.Entity<PublicUtilityInjuredPersonnel>(entity =>
            {
                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Injuries)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NextOfKinName).HasMaxLength(200);

                entity.Property(e => e.NextOfKinNumber).HasMaxLength(40);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityInjuredPersonnel)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UtilityDamage_Injuries");
            });

            modelBuilder.Entity<PublicUtilityInvestigationAnswer>(entity =>
            {
                entity.ToTable("PublicUtilityInvestigationAnswer");

                entity.Property(e => e.Answer).HasMaxLength(100);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityInvestigationAnswers)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PublicUtilityDamageID_DamageID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PublicUtilityInvestigationAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionID_QuestionsID");
            });

            modelBuilder.Entity<PublicUtilityInvestigationQuestion>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublicUtilityOtherPersonInvolved>(entity =>
            {
                entity.ToTable("PublicUtilityOtherPersonInvolved");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateLogged).HasColumnType("datetime");

                entity.Property(e => e.Forename).HasMaxLength(50);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.OffSiteTime).HasColumnType("datetime");

                entity.Property(e => e.OnSiteTime).HasColumnType("datetime");

                entity.Property(e => e.Organisation).HasMaxLength(150);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.VehicleReg).HasMaxLength(10);

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.PublicUtilityOtherPersonInvolveds)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_OtherPersonInvolved_PublicUtilityDamage");
            });

            modelBuilder.Entity<QualityAuditDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.QualityAuditDetails)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QualityAuditDetails_WorkType");
            });

            modelBuilder.Entity<QuoteAssociatedClient>(entity =>
            {
                entity.HasOne(d => d.ClientCompany)
                    .WithMany(p => p.QuoteAssociatedClients)
                    .HasForeignKey(d => d.ClientCompanyId)
                    .HasConstraintName("FK_QuoteAssociatedClients_client_company_file");

                entity.HasOne(d => d.ClientdNavigation)
                    .WithMany(p => p.QuoteAssociatedClients)
                    .HasForeignKey(d => d.Clientd)
                    .HasConstraintName("FK_QuoteAssociatedClients_clients_file");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.QuoteAssociatedClients)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("FK_QuoteAssociatedClients_quote_file");
            });

            modelBuilder.Entity<QuoteFile>(entity =>
            {
                entity.HasKey(e => e.QuoteId);

                entity.ToTable("quote_file");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.ClientSector).HasMaxLength(40);

                entity.Property(e => e.Committed).HasMaxLength(3);

                entity.Property(e => e.EnquiryEstimatedValue).HasMaxLength(20);

                entity.Property(e => e.EnquiryStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstStartDate).HasColumnType("datetime");

                entity.Property(e => e.IsSurveyRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUtilityPrintsRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadSource).HasMaxLength(40);

                entity.Property(e => e.LostDate).HasColumnType("datetime");

                entity.Property(e => e.OrderExpectedDate).HasColumnType("datetime");

                entity.Property(e => e.PercentagePossibility).HasMaxLength(30);

                entity.Property(e => e.ProjectedStartDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteAssociate)
                    .HasMaxLength(6)
                    .HasColumnName("quote_associate");

                entity.Property(e => e.QuoteCallback).HasColumnName("quote_callback");

                entity.Property(e => e.QuoteCallbackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("quote_callback_date");

                entity.Property(e => e.QuoteClientId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_client_id");

                entity.Property(e => e.QuoteClientName)
                    .HasMaxLength(60)
                    .HasColumnName("quote_ClientName");

                entity.Property(e => e.QuoteConValue)
                    .HasColumnType("money")
                    .HasColumnName("quote_con_value");

                entity.Property(e => e.QuoteContactId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_contact_id");

                entity.Property(e => e.QuoteContactName)
                    .HasMaxLength(110)
                    .HasColumnName("quote_ContactName");

                entity.Property(e => e.QuoteContype)
                    .HasMaxLength(2)
                    .HasColumnName("quote_contype");

                entity.Property(e => e.QuoteConverted)
                    .HasMaxLength(1)
                    .HasColumnName("quote_converted");

                entity.Property(e => e.QuoteConvertedby)
                    .HasMaxLength(30)
                    .HasColumnName("quote_convertedby");

                entity.Property(e => e.QuoteCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("quote_created");

                entity.Property(e => e.QuoteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("quote_date");

                entity.Property(e => e.QuoteExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteFolder)
                    .HasMaxLength(254)
                    .HasColumnName("quote_folder");

                entity.Property(e => e.QuoteLocation01).HasColumnName("quote_location01");

                entity.Property(e => e.QuoteLocation02).HasColumnName("quote_location02");

                entity.Property(e => e.QuoteLocation03)
                    .HasMaxLength(60)
                    .HasColumnName("quote_location03");

                entity.Property(e => e.QuoteLocation04)
                    .HasMaxLength(60)
                    .HasColumnName("quote_location04");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(80)
                    .HasColumnName("quote_name");

                entity.Property(e => e.QuoteNetValue)
                    .HasColumnType("money")
                    .HasColumnName("quote_net_value");

                entity.Property(e => e.QuoteNotes).HasColumnName("quote_notes");

                entity.Property(e => e.QuotePrefix)
                    .HasMaxLength(1)
                    .HasColumnName("quote_prefix");

                entity.Property(e => e.QuoteRev)
                    .HasMaxLength(2)
                    .HasColumnName("quote_rev");

                entity.Property(e => e.QuoteScopeofworks).HasColumnName("quote_scopeofworks");

                entity.Property(e => e.QuoteStatus)
                    .HasMaxLength(40)
                    .HasColumnName("quote_status");

                entity.Property(e => e.QuoteSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteValue)
                    .HasColumnType("money")
                    .HasColumnName("quote_value");

                entity.Property(e => e.QuoteWhichInvoiceAddress)
                    .HasMaxLength(10)
                    .HasColumnName("quote_WhichInvoiceAddress")
                    .IsFixedLength(true);

                entity.Property(e => e.QuoteWorkgrp)
                    .HasMaxLength(6)
                    .HasColumnName("quote_workgrp");

                entity.Property(e => e.QuoteYear)
                    .HasMaxLength(2)
                    .HasColumnName("quote_year");

                entity.Property(e => e.QuotedBy)
                    .HasMaxLength(30)
                    .HasColumnName("quoted_by");

                entity.Property(e => e.Rating).HasMaxLength(40);

                entity.Property(e => e.ReasonToClose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonToCloseOther)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonToLostDeclined)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonToReOpen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Region).HasMaxLength(40);

                entity.Property(e => e.TermContractId)
                    .HasMaxLength(6)
                    .HasColumnName("TermContractID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkStreamSector).HasMaxLength(40);
            });

            modelBuilder.Entity<QuoteWork>(entity =>
            {
                entity.HasKey(e => e.WorkId);

                entity.ToTable("quote_work");

                entity.Property(e => e.WorkId).HasColumnName("work_id");

                entity.Property(e => e.BaseUnit)
                    .HasMaxLength(20)
                    .HasColumnName("base_unit");

                entity.Property(e => e.BoxBuilderLabour).HasColumnType("money");

                entity.Property(e => e.BoxBuilderMaterials).HasColumnType("money");

                entity.Property(e => e.BoxBuilderPlant).HasColumnType("money");

                entity.Property(e => e.CableGangLabour).HasColumnType("money");

                entity.Property(e => e.CableGangMaterials).HasColumnType("money");

                entity.Property(e => e.CableGangPlant).HasColumnType("money");

                entity.Property(e => e.ClientWorkItem).HasMaxLength(50);

                entity.Property(e => e.Copy2iPadcheck)
                    .HasMaxLength(20)
                    .HasColumnName("Copy2iPADcheck");

                entity.Property(e => e.FibreGangLabour).HasColumnType("money");

                entity.Property(e => e.FibreGangMaterials).HasColumnType("money");

                entity.Property(e => e.FibreGangPlant).HasColumnType("money");

                entity.Property(e => e.FinalMeasure).HasMaxLength(20);

                entity.Property(e => e.GangLabour).HasColumnType("money");

                entity.Property(e => e.GangMaterials).HasColumnType("money");

                entity.Property(e => e.GangPlant).HasColumnType("money");

                entity.Property(e => e.GrabLabour).HasColumnType("money");

                entity.Property(e => e.GrabMaterials).HasColumnType("money");

                entity.Property(e => e.GrabPlant).HasColumnType("money");

                entity.Property(e => e.Isvariation)
                    .HasMaxLength(1)
                    .HasColumnName("isvariation");

                entity.Property(e => e.Labour).HasColumnType("money");

                entity.Property(e => e.Materials).HasColumnType("money");

                entity.Property(e => e.Plant).HasColumnType("money");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.ReinstatingLabour).HasColumnType("money");

                entity.Property(e => e.ReinstatingMaterials).HasColumnType("money");

                entity.Property(e => e.ReinstatingPlant).HasColumnType("money");

                entity.Property(e => e.RiskAndBalancingItem).HasColumnType("money");

                entity.Property(e => e.SubContract).HasColumnType("money");

                entity.Property(e => e.SubbyLabourAndPlant).HasColumnType("money");

                entity.Property(e => e.SubbyLabourOnly).HasColumnType("money");

                entity.Property(e => e.SubbyMethod3).HasColumnType("money");

                entity.Property(e => e.SynCode)
                    .HasMaxLength(6)
                    .HasColumnName("syn_code");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tmchapter8)
                    .HasColumnType("money")
                    .HasColumnName("TMchapter8");

                entity.Property(e => e.VariationId)
                    .HasMaxLength(6)
                    .HasColumnName("variation_id");

                entity.Property(e => e.VmupliftCode)
                    .HasMaxLength(20)
                    .HasColumnName("VMupliftCode");

                entity.Property(e => e.WorkDesc).HasColumnName("work_desc");

                entity.Property(e => e.WorkHeader)
                    .HasMaxLength(20)
                    .HasColumnName("work_header");

                entity.Property(e => e.WorkPrefix)
                    .HasMaxLength(3)
                    .HasColumnName("work_prefix");

                entity.Property(e => e.WorkQty)
                    .HasColumnType("money")
                    .HasColumnName("work_qty");

                entity.Property(e => e.WorkRate01)
                    .HasColumnType("money")
                    .HasColumnName("work_rate_01");

                entity.Property(e => e.WorkRate02)
                    .HasColumnType("money")
                    .HasColumnName("work_rate_02");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(2)
                    .HasColumnName("work_type");
            });

            modelBuilder.Entity<QuotedBy>(entity =>
            {
                entity.ToTable("QuotedBy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.Property(e => e.BaseContractId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("BaseContractID");

                entity.Property(e => e.BaseUnit).HasMaxLength(50);

                entity.Property(e => e.BoxBuilderLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BoxBuilderMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BoxBuilderPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CableGangLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CableGangMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.CableGangPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.ClientWorkItem).HasMaxLength(50);

                entity.Property(e => e.FibreGangLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FibreGangMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FibreGangPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GangLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GangMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GangPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GrabLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GrabMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.GrabPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Labour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Materials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Plant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReinstatingLabour)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReinstatingMaterials)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReinstatingPlant).HasColumnType("money");

                entity.Property(e => e.RiskAndBalancingItem)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SubbyLabourAndPlant)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SubbyLabourOnly)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SubbyMethod3).HasColumnType("money");

                entity.Property(e => e.Subcontract)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TermContract)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tmchapter8)
                    .HasColumnType("money")
                    .HasColumnName("TMchapter8")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.WorkHeader).HasMaxLength(50);

                entity.Property(e => e.WorkRate).HasColumnType("money");
            });

            modelBuilder.Entity<ReInstatementMeasure>(entity =>
            {
                entity.Property(e => e.ContractReference).HasMaxLength(50);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaterialDescriptor).HasMaxLength(50);

                entity.Property(e => e.MaterialSize).HasMaxLength(50);

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RecruitmentSearchHistory>(entity =>
            {
                entity.ToTable("RecruitmentSearchHistory");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SearchDate).HasColumnType("datetime");

                entity.Property(e => e.SearchReference)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefCategory>(entity =>
            {
                entity.ToTable("RefCategory");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to item Name/Description.");
            });

            modelBuilder.Entity<ReferenceDatum>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.DataValue)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to the Data Value.");

                entity.Property(e => e.DisplaySequence).HasComment("Refers to the Display Sequence.");

                entity.Property(e => e.DisplayString)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to the Display String.");

                entity.Property(e => e.RefCategoryId)
                    .HasColumnName("RefCategoryID")
                    .HasComment("Refers to RefCategory information..");

                entity.HasOne(d => d.RefCategory)
                    .WithMany(p => p.ReferenceData)
                    .HasForeignKey(d => d.RefCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefData_RefCatagory_RefID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Region1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Region");
            });

            modelBuilder.Entity<RejectPlantDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RejectPlantData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TransferCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.TransferFromId)
                    .HasMaxLength(6)
                    .HasColumnName("TransferFromID");

                entity.Property(e => e.TransferFromName).HasMaxLength(60);

                entity.Property(e => e.TransferToId)
                    .HasMaxLength(6)
                    .HasColumnName("TransferToID");
            });

            modelBuilder.Entity<Repair>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.HoursOrMileage).HasMaxLength(10);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ResourceDatum>(entity =>
            {
                entity.HasIndex(e => e.JobId, "IX_ResourceData_Job");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GangId).HasColumnName("GangID");

                entity.Property(e => e.GangLeaderId).HasColumnName("GangLeaderID");

                entity.Property(e => e.GangOperativesId).HasColumnName("GangOperativesID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Status).HasDefaultValueSql("((100011))");
            });

            modelBuilder.Entity<ResourceProjConcurrency>(entity =>
            {
                entity.ToTable("ResourceProjConcurrency");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TimeStampValue)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ResourceWorkDate>(entity =>
            {
                entity.ToTable("ResourceWorkDate");

                entity.HasIndex(e => e.ResourceDataId, "IX_ResourceWorkDate");

                entity.HasIndex(e => e.WorkDate, "nci_wi_ResourceWorkDate_9062F17FD6847900EF9B028019300C03");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GangOperativesId).HasColumnName("GangOperativesID");

                entity.Property(e => e.ResourceDataId).HasColumnName("ResourceDataID");

                entity.Property(e => e.SupervisorsId).HasColumnName("SupervisorsID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RightToWorkDocumentType>(entity =>
            {
                entity.ToTable("RightToWorkDocumentType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasComment("It’s a primary key of table.");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to role name.");
            });

            modelBuilder.Entity<ScdCableStockAudit>(entity =>
            {
                entity.ToTable("SCD_CableStockAudit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CableDrumNo).HasMaxLength(255);

                entity.Property(e => e.CableType).HasMaxLength(255);
            });

            modelBuilder.Entity<ScdCableStockUse>(entity =>
            {
                entity.ToTable("SCD_CableStockUse");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CableType).HasMaxLength(225);

                entity.Property(e => e.ContractId)
                    .HasMaxLength(24)
                    .HasColumnName("ContractID");

                entity.Property(e => e.ContractName).HasMaxLength(200);

                entity.Property(e => e.CoreCount).HasMaxLength(100);

                entity.Property(e => e.EndReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpectedStartReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScdCableDrumNo).HasColumnName("SCD_CableDrumNo");

                entity.Property(e => e.StartReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsedById)
                    .HasMaxLength(6)
                    .HasColumnName("UsedByID");

                entity.Property(e => e.UsedByName).HasMaxLength(50);

                entity.Property(e => e.UsedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScheduledServicing>(entity =>
            {
                entity.ToTable("ScheduledServicing");

                entity.HasIndex(e => e.PlantId, "IX_ScheduledServicing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateType).HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted)
                    .HasColumnType("datetime")
                    .HasComment("The date that this service was entered onto the job centre by the web API");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantLocation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PlantMaintenanceCommentsId).HasColumnName("PlantMaintenanceCommentsID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Issue Reported From iPad')");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SdhMusReconciliationDefect>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationDefects");

                entity.Property(e => e.AcceptanceStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BtdefectAdminFee)
                    .HasColumnType("money")
                    .HasColumnName("BTDefectAdminFee");

                entity.Property(e => e.ChargeRef)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectChargeValue).HasColumnType("money");

                entity.Property(e => e.DefectRecieved).HasColumnType("money");

                entity.Property(e => e.DefectType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estimate)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionComments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionRef)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LaReference)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeRef)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderReference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContractor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDefectCharge).HasColumnType("money");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationDefects)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__68A8708A");
            });

            modelBuilder.Entity<SdhMusReconciliationJobMovement>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationJobMovement");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.X1).HasColumnType("money");

                entity.Property(e => e.X2).HasColumnType("money");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationJobMovements)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__699C94C3");
            });

            modelBuilder.Entity<SdhMusReconciliationMaterial>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationMaterials");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderedPrice).HasColumnType("money");

                entity.Property(e => e.PurchasingContract)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingDeliverto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingNotes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingOrderDate).HasColumnType("date");

                entity.Property(e => e.PurchasingRequestedByMorrison)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingSiteContactName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingSubContractor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingSupplier)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalOrderedPrice).HasColumnType("money");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationMaterials)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__6A90B8FC");
            });

            modelBuilder.Entity<SdhMusReconciliationNonStd>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationNonStds");

                entity.Property(e => e.AuthorisedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InvVoreference)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("InvVOReference");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Value).HasColumnType("money");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationNonStds)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__6B84DD35");
            });

            modelBuilder.Entity<SdhMusReconciliationS74andFpn>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationS74andFPNs");

                entity.Property(e => e.Acstatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACStatus");

                entity.Property(e => e.BtadminFee)
                    .HasColumnType("money")
                    .HasColumnName("BTAdminFee");

                entity.Property(e => e.ChargeAllocatedContractor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estimate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LaReference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContractor)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.RechargeValue).HasColumnType("money");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCharge).HasColumnType("money");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationS74andFpns)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__6C79016E");
            });

            modelBuilder.Entity<SdhMusReconciliationSummary>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationSummary");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubContractorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValidUpTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<SdhMusReconciliationWorksDatum>(entity =>
            {
                entity.ToTable("SDH_MUS_ReconciliationWorksData");

                entity.Property(e => e.CompletedSubconValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Exchange)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobItemLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MonthDayYearofEngCompDate).HasColumnType("datetime");

                entity.Property(e => e.Musarea)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MUSArea");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingSubconValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pcpref)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PCPRef");

                entity.Property(e => e.PlannedSubconValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Subbie)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubconItemRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Rec)
                    .WithMany(p => p.SdhMusReconciliationWorksData)
                    .HasForeignKey(d => d.RecId)
                    .HasConstraintName("FK__SDH_MUS_R__RecID__6D6D25A7");
            });

            modelBuilder.Entity<ServicesCrossedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("ContractID");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.GangLeaderId)
                    .HasMaxLength(6)
                    .HasColumnName("GangLeaderID");

                entity.Property(e => e.GangLeaderName).HasMaxLength(50);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("QuoteID");

                entity.Property(e => e.ServicesCrossedData).HasMaxLength(250);
            });

            modelBuilder.Entity<SharepointIssue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.CompletedBy).HasMaxLength(50);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.EstimatedTimeToComplete).HasColumnType("datetime");

                entity.Property(e => e.IssueRelatesTo).HasMaxLength(200);

                entity.Property(e => e.ReportedBy).HasMaxLength(200);
            });

            modelBuilder.Entity<SmallToolRequisition>(entity =>
            {
                entity.ToTable("SmallToolRequisition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CNumber");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OpRequiringMaterial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherDetails).HasMaxLength(100);

                entity.Property(e => e.ProjectAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequisitionDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisorLogOn)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<StatusChangeHistory>(entity =>
            {
                entity.ToTable("StatusChangeHistory");

                entity.Property(e => e.StatusChangeHistoryId).HasColumnName("StatusChangeHistoryID");

                entity.Property(e => e.Agent).HasMaxLength(50);

                entity.Property(e => e.ContractRef)
                    .HasMaxLength(24)
                    .IsFixedLength(true);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("QuoteID")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .HasMaxLength(6)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StatusLookup>(entity =>
            {
                entity.HasKey(e => e.CodeId);

                entity.ToTable("status_lookup");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.BelongTo)
                    .HasMaxLength(10)
                    .HasColumnName("belong_to");

                entity.Property(e => e.DisplayColour)
                    .HasMaxLength(20)
                    .HasColumnName("display_colour");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ShortDesc)
                    .HasMaxLength(10)
                    .HasColumnName("short_desc");

                entity.Property(e => e.Status)
                    .HasMaxLength(150)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.HasIndex(e => new { e.Id, e.ItemDescription, e.Qty }, "IX_Stock")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemDescription, e.Reference }, "IX_Stock_1");

                entity.HasIndex(e => e.Reference, "IX_Stock_Reference")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicableTo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("This ID is taken from PlantComponentCategories. It identifies the main and/or subcategories the item belongs to");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<StockControl>(entity =>
            {
                entity.HasKey(e => e.BarCode)
                    .HasName("PK_StockControl_1");

                entity.ToTable("StockControl");

                entity.HasIndex(e => e.ItemDescription, "IX_StockControl");

                entity.HasIndex(e => e.DatePurchased, "IX_StockControl_1");

                entity.Property(e => e.ApplicableTo)
                    .HasMaxLength(200)
                    .HasComment("for example: Fitters, Cablers etc");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("This ID is taken from PlantComponentCategories. It identifies the main and/or subcategories the item belongs to");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DatePurchased).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.PurchaseOrderNo).HasMaxLength(20);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sid).HasColumnName("SID");
            });

            modelBuilder.Entity<StockFuel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StockFuel");

                entity.Property(e => e.DateTimeOfDelivery).HasColumnType("date");

                entity.Property(e => e.EndReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageFileName).HasMaxLength(200);

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.SignatureFileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StartReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalLitres).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<StrikeClassificationChangeSet>(entity =>
            {
                entity.ToTable("StrikeClassificationChangeSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InputOn).HasColumnType("datetime");

                entity.Property(e => e.InvestigationId).HasColumnName("InvestigationID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.RiddornotificationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RIDDORNotificationDate");

                entity.Property(e => e.StrikeClassification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Investigation)
                    .WithMany(p => p.StrikeClassificationChangeSets)
                    .HasForeignKey(d => d.InvestigationId)
                    .HasConstraintName("FK_StrikeClassificationChangeSet_PublicUtilityDamageInvestigation");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.StrikeClassificationChangeSets)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_StrikeClassificationChangeSet_PublicUtilityDamage");
            });

            modelBuilder.Entity<SubContractorOperative>(entity =>
            {
                entity.HasKey(e => new { e.SubContractorId, e.OperativeId });

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.SubContractorOperatives)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubContractorOperatives_operative_file");

                entity.HasOne(d => d.SubContractor)
                    .WithMany(p => p.SubContractorOperatives)
                    .HasForeignKey(d => d.SubContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubContractorOperatives_ClientContractorFile");
            });

            modelBuilder.Entity<SubContractorTeam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.SubContractorTeams)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_SubContractorTeams_SubContractorTeams");
            });

            modelBuilder.Entity<SubContractorTeamOperative>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsTeamLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");

                entity.Property(e => e.SubContractorTeamId).HasColumnName("SubContractorTeamID");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.SubContractorTeamOperatives)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK_SubContractorTeamOperatives_operative_file");

                entity.HasOne(d => d.SubContractorTeam)
                    .WithMany(p => p.SubContractorTeamOperatives)
                    .HasForeignKey(d => d.SubContractorTeamId)
                    .HasConstraintName("FK_SubContractorTeamOperatives_SubContractorTeams");
            });

            modelBuilder.Entity<SubcontractorProject>(entity =>
            {
                entity.ToTable("SubcontractorProject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");
            });

            modelBuilder.Entity<SupSiteSafetyInspItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemCategory).HasMaxLength(1);

                entity.Property(e => e.LogRef).HasMaxLength(6);
            });

            modelBuilder.Entity<SupSiteSafetyInspLog>(entity =>
            {
                entity.ToTable("SupSiteSafetyInspLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Auditor).HasMaxLength(50);

                entity.Property(e => e.ClearedBy).HasMaxLength(50);

                entity.Property(e => e.ContractId)
                    .HasMaxLength(24)
                    .HasColumnName("ContractID");

                entity.Property(e => e.ContractName).HasMaxLength(50);

                entity.Property(e => e.ContractNumber).HasMaxLength(20);

                entity.Property(e => e.LoggedBy).HasMaxLength(50);

                entity.Property(e => e.LoggedDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewedBy).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TeamLeader).HasMaxLength(50);
            });

            modelBuilder.Entity<SupSiteSafetyInspLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SupSiteSafetyInspLookup");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<SupplierDetail>(entity =>
            {
                entity.ToTable("SupplierDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.AcceptCreditCardPayment).HasComment("Refers to do you accept credit card. (Add Supplier Screen 2).");

                entity.Property(e => e.Approval).HasComment("Refers to the Approval radio button (Add Supplier Screen 3).");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to account name. (Add Supplier Screen 2).");

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to account number. (Add Supplier Screen 2)");

                entity.Property(e => e.BankAccountSortCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to sort code. (Add Supplier Screen 2).");

                entity.Property(e => e.BankBranchAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Refers to branch address. (Add Supplier Screen 2).");

                entity.Property(e => e.BankBranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to branch name. (Add Supplier Screen 2).");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasComment("Refers to supplier id.");

                entity.Property(e => e.PercentageCharge)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Refers to %age charge. (Add Supplier Screen 2).");

                entity.Property(e => e.PurchaseOrderEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to purchase order email. (Add Supplier Screen 2).");

                entity.Property(e => e.PurchaseOrderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to purchase order name. (Add Supplier Screen 2).");

                entity.Property(e => e.PurchaseOrderTelephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to purchase order telephone. (Add Supplier Screen 2).");

                entity.Property(e => e.QuestionarieReceived).HasComment("Refers to the received questions.");

                entity.Property(e => e.RemittanceEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the remittance email.");

                entity.Property(e => e.RemittanceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the remittance name.");

                entity.Property(e => e.RemittanceTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to the remittance telephone.");

                entity.Property(e => e.SpeciallyApprovedToClient).HasComment("Refers to do you accept credit card. (Add Supplier Screen 3).");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("Refers to the time stamp.");

                entity.HasOne(d => d.ApprovalNavigation)
                    .WithMany(p => p.SupplierDetails)
                    .HasForeignKey(d => d.Approval)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplierDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierDetail_client_company_file_CompanyId");
            });

            modelBuilder.Entity<SupplierDetailReference>(entity =>
            {
                entity.ToTable("SupplierDetailReference");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasComment("Refers to the client.");

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("ProductTypeID")
                    .HasComment("Refers to Product Type multiselect dropdown. (Add supplier screen 3).");

                entity.Property(e => e.SupplierDetailId)
                    .HasColumnName("SupplierDetailID")
                    .HasComment("Refers to the supplier detail id.");

                entity.Property(e => e.SupplierDetailReferenceType).HasComment("Refers to supplier detail reference type i.e Product Type or Workstream.");

                entity.Property(e => e.WorkStreamId)
                    .HasColumnName("WorkStreamID")
                    .HasComment("Refers to Workstream multiselect dropdown. (Add supplier screen 3).");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SupplierDetailReferences)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.SupplierDetailReferences)
                    .HasForeignKey(d => d.ProductTypeId);

                entity.HasOne(d => d.SupplierDetail)
                    .WithMany(p => p.SupplierDetailReferences)
                    .HasForeignKey(d => d.SupplierDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierDetailReferences_SupplierDetail_SupplierDetailID");

                entity.HasOne(d => d.SupplierDetailReferenceTypeNavigation)
                    .WithMany(p => p.SupplierDetailReferences)
                    .HasForeignKey(d => d.SupplierDetailReferenceType)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkStream)
                    .WithMany(p => p.SupplierDetailReferences)
                    .HasForeignKey(d => d.WorkStreamId)
                    .HasConstraintName("FK_SupplierDetailReference_WorkStream_WorkStreamID");
            });

            modelBuilder.Entity<SupplierLookup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("supplier_lookup");

                entity.Property(e => e.SupplierAddress01)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_address01");

                entity.Property(e => e.SupplierAddress02)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_address02");

                entity.Property(e => e.SupplierAddress03)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_address03");

                entity.Property(e => e.SupplierAddress04)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_address04");

                entity.Property(e => e.SupplierDepot)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_depot");

                entity.Property(e => e.SupplierEmail)
                    .HasMaxLength(60)
                    .HasColumnName("supplier_email");

                entity.Property(e => e.SupplierFax)
                    .HasMaxLength(17)
                    .HasColumnName("supplier_fax");

                entity.Property(e => e.SupplierId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("supplier_id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(30)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.SupplierTel)
                    .HasMaxLength(17)
                    .HasColumnName("supplier_tel");

                entity.Property(e => e.SupplierWww)
                    .HasMaxLength(120)
                    .HasColumnName("supplier_www");
            });

            modelBuilder.Entity<SupplierPrice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComponentCategoryId).HasColumnName("ComponentCategoryID");

                entity.Property(e => e.DateDueIn).HasColumnType("datetime");

                entity.Property(e => e.DatePriceReceived).HasColumnType("datetime");

                entity.Property(e => e.DatePriceRequired).HasColumnType("datetime");

                entity.Property(e => e.DatePurchased).HasColumnType("datetime");

                entity.Property(e => e.DeliveryCost).HasMaxLength(100);

                entity.Property(e => e.DeliveryLocation).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EachUnit).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(50);

                entity.Property(e => e.ItemFullyReceived).HasMaxLength(3);

                entity.Property(e => e.Level1Category).HasMaxLength(100);

                entity.Property(e => e.Level2Category).HasMaxLength(100);

                entity.Property(e => e.Level3Category).HasMaxLength(100);

                entity.Property(e => e.Level4Category).HasMaxLength(100);

                entity.Property(e => e.LocationPriceValidFor).HasMaxLength(50);

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(20);

                entity.Property(e => e.Pofulfilled)
                    .HasMaxLength(3)
                    .HasColumnName("POfulfilled");

                entity.Property(e => e.PriceIssueBy).HasMaxLength(50);

                entity.Property(e => e.PriceRequestedBy).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderNo).HasMaxLength(20);

                entity.Property(e => e.PurchaseRequestFulfilled).HasMaxLength(3);

                entity.Property(e => e.Sid)
                    .HasMaxLength(50)
                    .HasColumnName("SID");

                entity.Property(e => e.StockReference).HasMaxLength(20);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.Property(e => e.SupplierAccountNo).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.ToTable("SupplierType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to the supplier name.");
            });

            modelBuilder.Entity<SurfaceType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SurveyAnswer>(entity =>
            {
                entity.Property(e => e.AnswerGiven).IsRequired();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.CompletedById).IsRequired();

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.QuestionId)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QuestionID");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StreetName).IsRequired();

                entity.Property(e => e.SubmittedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK_SurveyAnswers_Assignment");
            });

            modelBuilder.Entity<SurveyComment>(entity =>
            {
                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.FromAddress).IsRequired();

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.QuestionId).IsRequired();

                entity.Property(e => e.StreetName).IsRequired();

                entity.Property(e => e.SubmittedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.ToAddress).IsRequired();

                entity.Property(e => e.WorksIdForDelete).IsRequired();

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.SurveyComments)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyComments_Assignment");
            });

            modelBuilder.Entity<SurveyCommentLog>(entity =>
            {
                entity.ToTable("SurveyCommentLog");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SurveyComment)
                    .WithMany(p => p.SurveyCommentLogs)
                    .HasForeignKey(d => d.SurveyCommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyCommentLog_SurveyComments");
            });

            modelBuilder.Entity<SurveyPicture>(entity =>
            {
                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.OperativeId).IsRequired();

                entity.Property(e => e.Qnumber)
                    .IsRequired()
                    .HasColumnName("QNumber");

                entity.Property(e => e.QuestionId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reason).IsRequired();

                entity.Property(e => e.ResponseId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeTaken).HasColumnType("datetime");
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepthorRating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FurtherQuestionId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuestionId).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SystemTimeLog>(entity =>
            {
                entity.HasIndex(e => new { e.IsLogin, e.UserId, e.LoginDate }, "nci_wi_SystemTimeLogs_457E5541BDCC19640E08E462CF22BD19");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsLogin).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RegardingId).HasColumnName("RegardingID");

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Open')")
                    .HasComment("These values can be \"Open\" or \"Closed\"");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TotalTimeWorked).HasComment("This value is saved as minutes");
            });

            modelBuilder.Entity<TaskDetail>(entity =>
            {
                entity.ToTable("TaskDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dependency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LoneOperativeId).HasColumnName("LoneOperativeID");

                entity.Property(e => e.ParentTaskId).HasColumnName("ParentTaskID");

                entity.Property(e => e.Progress).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SeniorSupervisorId).HasColumnName("SeniorSupervisorID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.TaskCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskDescription).IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TeamType).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaskWeekendDetail>(entity =>
            {
                entity.ToTable("TaskWeekendDetail");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskWeekendDetails)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskWeekendDetail_TaskDetail");
            });

            modelBuilder.Entity<TeamDetail>(entity =>
            {
                entity.ToTable("TeamDetail");

                entity.Property(e => e.Id).HasComment("Its primary key.");

                entity.Property(e => e.AgeRetentionApplicable).HasComment("Refers whether age retention is applied or not?.");

                entity.Property(e => e.ContractorLiabilityInsExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to contractor liability expiry date.");

                entity.Property(e => e.ContractorLiabilityInsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to contractor liability number.");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Refers to date and time of creation.");

                entity.Property(e => e.Createdby).HasComment("Refers to created by.");

                entity.Property(e => e.EmployersLiabilityInsExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to employer liability expiry date.");

                entity.Property(e => e.EmployersLiabilityInsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to employer liability number.");

                entity.Property(e => e.IsActive).HasComment("Refers to whether it is active or not.");

                entity.Property(e => e.IsInsurance).HasComment("Refers to whether it is insurance or not?.");

                entity.Property(e => e.LastModifiedBy).HasComment("Refers to last modified by.");

                entity.Property(e => e.LastModifiedOn)
                    .HasColumnType("datetime")
                    .HasComment("Refers to date and time of last modified.");

                entity.Property(e => e.ProfIndemnityExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment(" Refers to prof indemnity expiry date.");

                entity.Property(e => e.ProfIndemnityNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to prof indemnity number.");

                entity.Property(e => e.PublicLiabilityExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("Refers to pub liability Expiry Date.");

                entity.Property(e => e.PublicLiabilityNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetentionPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Refers to retention %age.");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refers to name of team.");

                entity.Property(e => e.TimeStampFinancial)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStampGeneral)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasComment("Refers to timestamp.");

                entity.Property(e => e.TimeStampRates).IsUnicode(false);

                entity.Property(e => e.TimeStampTrade)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TeamOperative>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.OperativeId });

                entity.ToTable("TeamOperative");

                entity.Property(e => e.TeamId).HasComment("Its foreign key of TeamDetail Table. Refers to ID.");

                entity.Property(e => e.OperativeId).HasComment("Its foreign key of OperativeDetail Table. Refers to ID.");

                entity.Property(e => e.AddPermanent)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddUntill).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.FinancialSplit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTeamLead).HasComment("Refers to whether it is team lead or not");

                entity.Property(e => e.TempFinancialSplit).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.TeamOperatives)
                    .HasForeignKey(d => d.OperativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamOperative_OperativeDeatil_OperativeId");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamOperatives)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamOperative_TeamDetail");
            });

            modelBuilder.Entity<TeamProject>(entity =>
            {
                entity.ToTable("TeamProject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");
            });

            modelBuilder.Entity<TeamProjectPlantCost>(entity =>
            {
                entity.ToTable("TeamProjectPlantCost");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.WeeklyPlantCost).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TeamRegion>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.RegionId });

                entity.ToTable("TeamRegion");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TeamRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRegion_Region");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamRegions)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRegion_TeamDetail");
            });

            modelBuilder.Entity<TeamRole>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.RoleId });

                entity.ToTable("TeamRole");

                entity.Property(e => e.TeamId).HasComment("Its foreign key of TeamDetail Table. Refers to ID.");

                entity.Property(e => e.RoleId).HasComment("Its foreign key of Role Table. Refers to ID.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('1')")
                    .HasComment("Refers to whether it is active or not.");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TeamRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRole_Role");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamRoles)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamRole_TeamRole");
            });

            modelBuilder.Entity<TeamTrade>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.TradeId });

                entity.ToTable("TeamTrade");

                entity.Property(e => e.TeamId).HasComment("Its foreign key of TeamDetail Table. Refers to ID.");

                entity.Property(e => e.TradeId).HasComment("Its foreign key of Trade Table. Refers to ID.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('1')")
                    .HasComment("Refers to whether it is active or not.");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamTrades)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamTrade_TeamDetail");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.TeamTrades)
                    .HasForeignKey(d => d.TradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamTrade_Trade");
            });

            modelBuilder.Entity<TeamWorkStream>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.WorkStreamId });

                entity.ToTable("TeamWorkStream");

                entity.Property(e => e.TeamId).HasComment("Its foreign key of TeamDetail Table. Refers to ID.");

                entity.Property(e => e.WorkStreamId).HasComment("Its foreign key of WorkStream Table. Refers to ID.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('1')")
                    .HasComment("Refers to whether it is active or not.");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamWorkStreams)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamWorkStream_TeamDetail");

                entity.HasOne(d => d.WorkStream)
                    .WithMany(p => p.TeamWorkStreams)
                    .HasForeignKey(d => d.WorkStreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamWorkStream_Workstream");
            });

            modelBuilder.Entity<TermContract>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(6)
                    .HasColumnName("ClientID");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(6)
                    .HasColumnName("CompanyID");

                entity.Property(e => e.ContractRootId)
                    .HasMaxLength(6)
                    .HasColumnName("ContractRootID");

                entity.Property(e => e.Enabled).HasMaxLength(3);

                entity.Property(e => e.SharedFolderPath).HasMaxLength(100);

                entity.Property(e => e.Tcname)
                    .HasMaxLength(50)
                    .HasColumnName("TCname");
            });

            modelBuilder.Entity<TermContractWork>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasMaxLength(3);

                entity.Property(e => e.BaseUnit).HasMaxLength(20);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(6)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ContractRootId)
                    .HasMaxLength(6)
                    .HasColumnName("ContractRootID");

                entity.Property(e => e.WorkDesc).HasMaxLength(256);

                entity.Property(e => e.WorkHeader).HasMaxLength(50);

                entity.Property(e => e.WorkRate).HasMaxLength(12);
            });

            modelBuilder.Entity<TestTableForCordova>(entity =>
            {
                entity.ToTable("TestTableForCordova");

                entity.Property(e => e.Pword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pword");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<ThirdPartyRepair>(entity =>
            {
                entity.ToTable("ThirdPartyRepair");

                entity.HasIndex(e => e.PlantId, "IX_ThirdPartyRepair");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateBooked).HasColumnType("datetime");

                entity.Property(e => e.DateBookedInForRepair).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PurchaseOrderNo).HasMaxLength(20);
            });

            modelBuilder.Entity<ThirdPartyRepairCalendar>(entity =>
            {
                entity.ToTable("ThirdPartyRepairCalendar");

                entity.HasIndex(e => new { e.StartDateTime, e.EndDateTime }, "IX_ThirdPartyRepairCalendar");

                entity.HasIndex(e => e.ThirdPartyRepairId, "IX_ThirdPartyRepairCalendar_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DescriptionOfWork)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.ThirdPartyRepairId).HasColumnName("ThirdPartyRepairID");
            });

            modelBuilder.Entity<ThirdPartyRepairCompany>(entity =>
            {
                entity.ToTable("ThirdPartyRepairCompany");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.ToTable("TimeSheet");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateSubmitted)
                    .HasColumnType("datetime")
                    .HasComment("This date is only written to when the job has finished");

                entity.Property(e => e.JobCentreCalendarId).HasColumnName("JobCentreCalendarID");

                entity.Property(e => e.JobReference).HasMaxLength(50);

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");
            });

            modelBuilder.Entity<Timing>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.StopDateTime).HasColumnType("datetime");

                entity.Property(e => e.TimeInserted)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");
            });

            modelBuilder.Entity<ToolBoxTalk>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.DateLastDistributed).HasColumnType("datetime");

                entity.Property(e => e.DateOfUpload).HasColumnType("datetime");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.ToTable("Trade");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Its primary key.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to Trade name.");
            });

            modelBuilder.Entity<TrainingCategory>(entity =>
            {
                entity.ToTable("TrainingCategory");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingDetail>(entity =>
            {
                entity.ToTable("TrainingDetail");

                entity.Property(e => e.Attendees).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingCertificate).IsUnicode(false);

                entity.Property(e => e.TrainingCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrainingFor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingSubCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingRequest>(entity =>
            {
                entity.ToTable("TrainingRequest");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.InputDetails).IsUnicode(false);

                entity.Property(e => e.Request).IsUnicode(false);

                entity.HasOne(d => d.Operative)
                    .WithMany(p => p.TrainingRequests)
                    .HasForeignKey(d => d.OperativeId)
                    .HasConstraintName("FK__TrainingR__Opera__0A096455");
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.ToTable("UnitType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to the Unique Id of the table.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Refers to the name.");
            });

            modelBuilder.Entity<UserDailyProjectTime>(entity =>
            {
                entity.HasKey(e => e.ProjectTimeId);

                entity.Property(e => e.ProjectTimeId).HasColumnName("ProjectTimeID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DailyTimeId).HasColumnName("DailyTimeID");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.DailyTime)
                    .WithMany(p => p.UserDailyProjectTimes)
                    .HasForeignKey(d => d.DailyTimeId)
                    .HasConstraintName("FK_UserDailyProjectTimes_UserDailyTime");
            });

            modelBuilder.Entity<UserDailyTime>(entity =>
            {
                entity.HasKey(e => e.DailyTimeId);

                entity.ToTable("UserDailyTime");

                entity.Property(e => e.DailyTimeId).HasColumnName("DailyTimeID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserDailyTimeNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DailyTimeId).HasColumnName("DailyTimeID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.DailyTime)
                    .WithMany(p => p.UserDailyTimeNotes)
                    .HasForeignKey(d => d.DailyTimeId)
                    .HasConstraintName("FK_UserDailyTimeNotes_UserDailyTime");
            });

            modelBuilder.Entity<UserFavoriteProject>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFavoriteProjects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFavoriteProjects_operative_file");
            });

            modelBuilder.Entity<UserFriendlyName>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.ToTable("UserProfile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperativeId).HasColumnName("OperativeID");
            });

            modelBuilder.Entity<UserToolBoxTalk>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DistributionDate).HasColumnType("datetime");

                entity.Property(e => e.TimeTaken).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UtilityStrikeActionNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UtilityStrikeActionNotes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_UtilityStrikeActionNotes_OperativeFile");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.UtilityStrikeActionNotes)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_UtilityStrikeActionNotes_PublicUtilityDamage");
            });

            modelBuilder.Entity<UtilityStrikeActionTask>(entity =>
            {
                entity.ToTable("UtilityStrikeActionTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EventID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.RequiredByDate).HasColumnType("datetime");

                entity.Property(e => e.Requirements)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UtilityStrikeActionTasks)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_UtilityStrikeActionTask_OperativeFile");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UtilityStrikeActionTasks)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_UtilityStrikeActionTask_OperativeGroups");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.UtilityStrikeActionTasks)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_UtilityStrikeActionTask_PublicUtilityDamage");
            });

            modelBuilder.Entity<UtilityStrikeFinalReport>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UtilityStrikeFinalReports)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_UtilityStrikeFinalReports_operative_file");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.UtilityStrikeFinalReports)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UtilityStrikeFinalReports_PublicUtilityDamage");
            });

            modelBuilder.Entity<UtilityStrikeResponsible>(entity =>
            {
                entity.ToTable("UtilityStrikeResponsible");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DebitorCredit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PublicUtilityDamageId).HasColumnName("PublicUtilityDamageID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.ResponsibleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.PublicUtilityDamage)
                    .WithMany(p => p.UtilityStrikeResponsibles)
                    .HasForeignKey(d => d.PublicUtilityDamageId)
                    .HasConstraintName("FK_UtilityStrikeResponsible_PublicUtilityDamage");
            });

            modelBuilder.Entity<VOperativeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_OperativeGroups");
            });

            modelBuilder.Entity<VOperativeGroupsId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_OperativeGroupsID");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.ToTable("Vacancy");

                entity.Property(e => e.Id).HasComment("Primary key for Vacancy, also used as Vacancy Reference number");

                entity.Property(e => e.Benefits).IsUnicode(false);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FeesProposal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewPostcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewProcess).IsUnicode(false);

                entity.Property(e => e.Interviewer1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Interviewer2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Interviewer3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords).IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OurReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayFrequency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalaryTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalaryType)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TargetSalary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TheirReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VacancyConsultant).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacancyReference)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Vacancy_clients_file");
            });

            modelBuilder.Entity<VacancyAdvertising>(entity =>
            {
                entity.ToTable("VacancyAdvertising");

                entity.Property(e => e.AdvertDate).HasColumnType("datetime");

                entity.Property(e => e.AdvertisingDetails).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.VacancyAdvertisings)
                    .HasForeignKey(d => d.VacancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacancyAdvertising_Vacancy");
            });

            modelBuilder.Entity<VacancyAdvertisingMethod>(entity =>
            {
                entity.Property(e => e.AdvertiseId).HasComment("It is Foreign key from Vacancy Advertising Table");

                entity.Property(e => e.EstimatedCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Advertise)
                    .WithMany(p => p.VacancyAdvertisingMethods)
                    .HasForeignKey(d => d.AdvertiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacancyAdvertisingMethods_VacancyAdvertising");
            });

            modelBuilder.Entity<VacancyShortList>(entity =>
            {
                entity.ToTable("VacancyShortList");

                entity.Property(e => e.Feedback).IsUnicode(false);

                entity.Property(e => e.ShortlistedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.VacancyShortLists)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacancyShortList_Candidates");

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.VacancyShortLists)
                    .HasForeignKey(d => d.VacancyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacancyShortList_Vacancy");
            });

            modelBuilder.Entity<Valuation>(entity =>
            {
                entity.ToTable("Valuation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("It’s a primary key of table.");

                entity.Property(e => e.CostSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.CostSubmittedTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cviid).HasColumnName("CVIID");

                entity.Property(e => e.Cvino)
                    .HasColumnName("CVINo")
                    .HasComment("Its foreign key of CVI.Refers to ID");

                entity.Property(e => e.DateOfApplication).HasColumnType("datetime");

                entity.Property(e => e.EstimatedTimeDelay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("refers to esitimated time delay inputted by user.");

                entity.Property(e => e.ExpectedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("refers to expected percentage inputted by user.");

                entity.Property(e => e.Information)
                    .IsUnicode(false)
                    .HasComment("refers to information inputted by user.");

                entity.Property(e => e.RevisionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("refers to next revision name generated on submit");

                entity.Property(e => e.SubmittedOn)
                    .HasColumnType("datetime")
                    .HasComment("refers to date and time revision submitted");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CvinoNavigation)
                    .WithMany(p => p.Valuations)
                    .HasForeignKey(d => d.Cvino)
                    .HasConstraintName("FK_Valuation_CVI");
            });

            modelBuilder.Entity<ValuationDetail>(entity =>
            {
                entity.HasKey(e => e.ValuationId);

                entity.Property(e => e.ValuationId).HasColumnName("ValuationID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfActualPayment).HasColumnType("datetime");

                entity.Property(e => e.DateOfSubmission).HasColumnType("datetime");

                entity.Property(e => e.DatePaymentExpected).HasColumnType("datetime");

                entity.Property(e => e.Difference).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MainContractId).HasColumnName("MainContractID");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PaymentReference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.MainContract)
                    .WithMany(p => p.ValuationDetails)
                    .HasForeignKey(d => d.MainContractId)
                    .HasConstraintName("FK_ValuationDetails_contract_file");
            });

            modelBuilder.Entity<Variation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Variation");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(6)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(50)
                    .HasColumnName("ContractID");

                entity.Property(e => e.ContractReference).HasMaxLength(24);

                entity.Property(e => e.EstimatedCost).HasColumnType("money");

                entity.Property(e => e.LoggedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProjectName).HasMaxLength(250);

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(50)
                    .HasColumnName("QuoteID");

                entity.Property(e => e.TrueCost).HasColumnType("money");

                entity.Property(e => e.VariationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VariationID");

                entity.Property(e => e.WorkId)
                    .HasMaxLength(6)
                    .HasColumnName("WorkID");
            });

            modelBuilder.Entity<VersionDetail>(entity =>
            {
                entity.ToTable("VersionDetail");

                entity.Property(e => e.DeployedOn).HasColumnType("datetime");

                entity.Property(e => e.Feature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VersionErrorLog>(entity =>
            {
                entity.ToTable("VersionErrorLog");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VirginExtraInfo>(entity =>
            {
                entity.HasKey(e => e.ExtraInfoId);

                entity.ToTable("VirginExtraInfo");

                entity.Property(e => e.ExtraInfoId).HasColumnName("ExtraInfoID");

                entity.Property(e => e.AccountProjectCode).HasMaxLength(100);

                entity.Property(e => e.ContractRef)
                    .HasMaxLength(24)
                    .IsFixedLength(true);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DtifranchiseName)
                    .HasMaxLength(100)
                    .HasColumnName("DTIfranchiseName");

                entity.Property(e => e.IcomsfranchiseNumber)
                    .HasMaxLength(10)
                    .HasColumnName("ICOMSfranchiseNumber");

                entity.Property(e => e.IcomssiteId)
                    .HasMaxLength(50)
                    .HasColumnName("ICOMSsiteID");

                entity.Property(e => e.LocalAuthority).HasMaxLength(100);

                entity.Property(e => e.LocationOffice).HasMaxLength(100);

                entity.Property(e => e.OriginatorPlanner).HasMaxLength(50);

                entity.Property(e => e.PlannerContact).HasMaxLength(50);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .HasColumnName("POnumber");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("QuoteID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VisitorsLog>(entity =>
            {
                entity.ToTable("VisitorsLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateLogged).HasColumnType("datetime");

                entity.Property(e => e.Forename).HasMaxLength(50);

                entity.Property(e => e.GangLeader).HasMaxLength(50);

                entity.Property(e => e.OffSiteTime).HasColumnType("datetime");

                entity.Property(e => e.OnSiteTime).HasColumnType("datetime");

                entity.Property(e => e.Organisation).HasMaxLength(150);

                entity.Property(e => e.ScduserName)
                    .HasMaxLength(50)
                    .HasColumnName("SCDuserName");

                entity.Property(e => e.SignatureIn).HasMaxLength(70);

                entity.Property(e => e.SignatureOut).HasMaxLength(70);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.VehicleReg).HasMaxLength(10);
            });

            modelBuilder.Entity<VmL3cabDetail>(entity =>
            {
                entity.ToTable("VM_L3CabDetails");

                entity.Property(e => e.CabinetDetails).HasMaxLength(50);

                entity.Property(e => e.CityFibreRef)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingCab)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.L4total).HasColumnName("L4Total");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Number).HasMaxLength(30);

                entity.Property(e => e.OnOffsiteL4cabTotal).HasColumnName("On_OffsiteL4CabTotal");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.UcNc)
                    .HasMaxLength(3)
                    .HasColumnName("UC_NC")
                    .IsFixedLength(true);

                entity.Property(e => e.Vmnbunumber).HasColumnName("VMNBUnumber");
            });

            modelBuilder.Entity<VmL4cabDetail>(entity =>
            {
                entity.ToTable("VM_L4CabDetails");

                entity.Property(e => e.CabinetDetails).HasMaxLength(50);

                entity.Property(e => e.CityFibreRef)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Existing)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.L4number).HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.PreSiteStatus).HasMaxLength(20);

                entity.Property(e => e.PreSitedById)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.UcNc)
                    .HasMaxLength(3)
                    .HasColumnName("UC_NC")
                    .IsFixedLength(true);

                entity.Property(e => e.Vmnbunumber).HasColumnName("VMNBUnumber");
            });

            modelBuilder.Entity<VmL5cabDetail>(entity =>
            {
                entity.ToTable("VM_L5CabDetails");

                entity.Property(e => e.AssociatedL4number).HasMaxLength(50);

                entity.Property(e => e.L5number).HasMaxLength(20);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Vmnbunumber).HasColumnName("VMNBUnumber");
            });

            modelBuilder.Entity<VmnetworkExpansionReleaseDatum>(entity =>
            {
                entity.ToTable("VmnetworkExpansionReleaseDatum");

                entity.Property(e => e.BuildingName).HasMaxLength(100);

                entity.Property(e => e.BuildingNumber).HasMaxLength(100);

                entity.Property(e => e.BuildingStandard).HasMaxLength(50);

                entity.Property(e => e.BusinessName).HasMaxLength(50);

                entity.Property(e => e.Calibrated)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.CatvBb)
                    .HasMaxLength(50)
                    .HasColumnName("CATV_BB");

                entity.Property(e => e.CityFibreRef)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CpGisId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CP_GIS_ID");

                entity.Property(e => e.DateofTest).HasColumnType("date");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DnaaddressType)
                    .HasMaxLength(50)
                    .HasColumnName("DNAaddressType");

                entity.Property(e => e.DpGisId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DP_GIS_ID");

                entity.Property(e => e.DropLength).HasMaxLength(10);

                entity.Property(e => e.DuctLabel).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.L4cab).HasColumnName("L4Cab");

                entity.Property(e => e.L4number)
                    .HasMaxLength(50)
                    .HasColumnName("L4Number");

                entity.Property(e => e.L5cab)
                    .HasMaxLength(50)
                    .HasColumnName("L5Cab");

                entity.Property(e => e.PlotNumber).HasMaxLength(100);

                entity.Property(e => e.PnToTobyLen)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PN_TO_TOBY_LEN");

                entity.Property(e => e.Postcode).HasMaxLength(10);

                entity.Property(e => e.PressureTested)
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.ReleasedBy).HasMaxLength(50);

                entity.Property(e => e.ReleasedDate).HasColumnType("date");

                entity.Property(e => e.SnToTobyLen)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("SN_TO_TOBY_LEN");

                entity.Property(e => e.StreetName).HasMaxLength(150);

                entity.Property(e => e.SurfaceType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telco)
                    .HasMaxLength(50)
                    .HasColumnName("TELCO");

                entity.Property(e => e.TobyLength).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TobyToPremLen)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("TOBY_TO_PREM_LEN");

                entity.Property(e => e.TobyWidth).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TownCity)
                    .HasMaxLength(50)
                    .HasColumnName("Town_City");

                entity.Property(e => e.Uprn)
                    .HasMaxLength(20)
                    .HasColumnName("UPRN");

                entity.Property(e => e.Vmnbunumber).HasColumnName("VMNBUnumber");
            });

            modelBuilder.Entity<VmspecialReportCheck>(entity =>
            {
                entity.HasKey(e => e.CheckId);

                entity.ToTable("VMspecialReportCheck");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .IsFixedLength(true);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GangLeaderId)
                    .HasMaxLength(6)
                    .HasColumnName("GangLeaderID")
                    .IsFixedLength(true);

                entity.Property(e => e.IsItChecked).HasMaxLength(3);
            });

            modelBuilder.Entity<WagesHistory>(entity =>
            {
                entity.ToTable("WagesHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OldValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<WagesModification>(entity =>
            {
                entity.ToTable("WagesModification");

                entity.Property(e => e.WagesModificationId).HasColumnName("WagesModificationID");

                entity.Property(e => e.LabourId).HasColumnName("LabourID");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WeatherDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AfternoonWeather).HasMaxLength(25);

                entity.Property(e => e.DateOfCheck).HasColumnType("datetime");

                entity.Property(e => e.EndWeather).HasMaxLength(25);

                entity.Property(e => e.GangLeader)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.MorningWeather).HasMaxLength(25);

                entity.Property(e => e.PeriodEndTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Qnumber).HasColumnName("QNumber");

                entity.Property(e => e.StartWeather).HasMaxLength(25);

                entity.Property(e => e.TimeOfCheck)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Weather).HasMaxLength(25);
            });

            modelBuilder.Entity<WhoHasAccess>(entity =>
            {
                entity.HasKey(e => e.AccessId);

                entity.ToTable("WhoHasAccess");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IconPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkFile>(entity =>
            {
                entity.HasKey(e => e.WorkId);

                entity.ToTable("work_file");

                entity.Property(e => e.WorkId).HasColumnName("work_id");

                entity.Property(e => e.BaseUnit)
                    .HasMaxLength(20)
                    .HasColumnName("base_unit");

                entity.Property(e => e.BoxBuilderLabour).HasColumnType("money");

                entity.Property(e => e.BoxBuilderMaterials).HasColumnType("money");

                entity.Property(e => e.BoxBuilderPlant).HasColumnType("money");

                entity.Property(e => e.CableGangLabour).HasColumnType("money");

                entity.Property(e => e.CableGangMaterials).HasColumnType("money");

                entity.Property(e => e.CableGangPlant).HasColumnType("money");

                entity.Property(e => e.ClientReportFlag).HasMaxLength(3);

                entity.Property(e => e.ClientWorkItem).HasMaxLength(50);

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.Copy2iPadcheck)
                    .HasMaxLength(20)
                    .HasColumnName("Copy2iPADcheck");

                entity.Property(e => e.FibreGangLabour).HasColumnType("money");

                entity.Property(e => e.FibreGangMaterials).HasColumnType("money");

                entity.Property(e => e.FibreGangPlant).HasColumnType("money");

                entity.Property(e => e.GangLabour).HasColumnType("money");

                entity.Property(e => e.GangMaterials).HasColumnType("money");

                entity.Property(e => e.GangPlant).HasColumnType("money");

                entity.Property(e => e.GrabLabour).HasColumnType("money");

                entity.Property(e => e.GrabMaterials).HasColumnType("money");

                entity.Property(e => e.GrabPlant).HasColumnType("money");

                entity.Property(e => e.Isvariation)
                    .HasMaxLength(1)
                    .HasColumnName("isvariation");

                entity.Property(e => e.Labour).HasColumnType("money");

                entity.Property(e => e.Materials).HasColumnType("money");

                entity.Property(e => e.Plant).HasColumnType("money");

                entity.Property(e => e.QuoteId).HasColumnName("quote_id");

                entity.Property(e => e.ReinstatingLabour).HasColumnType("money");

                entity.Property(e => e.ReinstatingMaterials).HasColumnType("money");

                entity.Property(e => e.ReinstatingPlant).HasColumnType("money");

                entity.Property(e => e.RiskAndBalancingItem).HasColumnType("money");

                entity.Property(e => e.SubContract).HasColumnType("money");

                entity.Property(e => e.SubbyLabourAndPlant).HasColumnType("money");

                entity.Property(e => e.SubbyLabourOnly).HasColumnType("money");

                entity.Property(e => e.SubbyMethod3).HasColumnType("money");

                entity.Property(e => e.SynCode)
                    .HasMaxLength(6)
                    .HasColumnName("syn_code");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tmchapter8)
                    .HasColumnType("money")
                    .HasColumnName("TMchapter8");

                entity.Property(e => e.VariationId)
                    .HasMaxLength(6)
                    .HasColumnName("variation_id");

                entity.Property(e => e.WorkDesc).HasColumnName("work_desc");

                entity.Property(e => e.WorkFinalMeasure)
                    .HasMaxLength(10)
                    .HasColumnName("work_final_measure");

                entity.Property(e => e.WorkHeader)
                    .HasMaxLength(20)
                    .HasColumnName("work_header");

                entity.Property(e => e.WorkPrefix)
                    .HasMaxLength(3)
                    .HasColumnName("work_prefix");

                entity.Property(e => e.WorkQty)
                    .HasColumnType("money")
                    .HasColumnName("work_qty");

                entity.Property(e => e.WorkQtyAsAnInt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.WorkRate01)
                    .HasColumnType("money")
                    .HasColumnName("work_rate_01");

                entity.Property(e => e.WorkRate02)
                    .HasColumnType("money")
                    .HasColumnName("work_rate_02");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(2)
                    .HasColumnName("work_type");

                entity.Property(e => e.WorkType1).HasColumnName("WorkType");

                entity.Property(e => e.WorksListCheck).HasMaxLength(1);
            });

            modelBuilder.Entity<WorkFileDev>(entity =>
            {
                entity.HasKey(e => e.WorkId);

                entity.ToTable("work_fileDEV");

                entity.Property(e => e.WorkId).HasColumnName("work_id");

                entity.Property(e => e.BaseUnit)
                    .HasMaxLength(20)
                    .HasColumnName("base_unit");

                entity.Property(e => e.BoxBuilderLabour).HasColumnType("money");

                entity.Property(e => e.BoxBuilderMaterials).HasColumnType("money");

                entity.Property(e => e.BoxBuilderPlant).HasColumnType("money");

                entity.Property(e => e.CableGangLabour).HasColumnType("money");

                entity.Property(e => e.CableGangMaterials).HasColumnType("money");

                entity.Property(e => e.CableGangPlant).HasColumnType("money");

                entity.Property(e => e.ClientReportFlag).HasMaxLength(3);

                entity.Property(e => e.ClientWorkItem).HasMaxLength(50);

                entity.Property(e => e.ConPrefix)
                    .HasMaxLength(1)
                    .HasColumnName("con_prefix");

                entity.Property(e => e.ContractId)
                    .HasMaxLength(6)
                    .HasColumnName("contract_id");

                entity.Property(e => e.ContractReference)
                    .HasMaxLength(24)
                    .HasColumnName("contract_reference");

                entity.Property(e => e.Copy2iPadcheck)
                    .HasMaxLength(20)
                    .HasColumnName("Copy2iPADcheck");

                entity.Property(e => e.FibreGangLabour).HasColumnType("money");

                entity.Property(e => e.FibreGangMaterials).HasColumnType("money");

                entity.Property(e => e.FibreGangPlant).HasColumnType("money");

                entity.Property(e => e.GangLabour).HasColumnType("money");

                entity.Property(e => e.GangMaterials).HasColumnType("money");

                entity.Property(e => e.GangPlant).HasColumnType("money");

                entity.Property(e => e.GrabLabour).HasColumnType("money");

                entity.Property(e => e.GrabMaterials).HasColumnType("money");

                entity.Property(e => e.GrabPlant).HasColumnType("money");

                entity.Property(e => e.Isvariation)
                    .HasMaxLength(1)
                    .HasColumnName("isvariation");

                entity.Property(e => e.Labour).HasColumnType("money");

                entity.Property(e => e.Materials).HasColumnType("money");

                entity.Property(e => e.Plant).HasColumnType("money");

                entity.Property(e => e.QuoteId)
                    .HasMaxLength(6)
                    .HasColumnName("quote_id");

                entity.Property(e => e.ReinstatingLabour).HasColumnType("money");

                entity.Property(e => e.ReinstatingMaterials).HasColumnType("money");

                entity.Property(e => e.ReinstatingPlant).HasColumnType("money");

                entity.Property(e => e.RiskAndBalancingItem).HasColumnType("money");

                entity.Property(e => e.SubContract).HasColumnType("money");

                entity.Property(e => e.SubbyLabourAndPlant).HasColumnType("money");

                entity.Property(e => e.SubbyLabourOnly).HasColumnType("money");

                entity.Property(e => e.SynCode)
                    .HasMaxLength(6)
                    .HasColumnName("syn_code");

                entity.Property(e => e.Tmchapter8)
                    .HasColumnType("money")
                    .HasColumnName("TMchapter8");

                entity.Property(e => e.VariationId)
                    .HasMaxLength(6)
                    .HasColumnName("variation_id");

                entity.Property(e => e.WorkDesc)
                    .HasMaxLength(256)
                    .HasColumnName("work_desc");

                entity.Property(e => e.WorkFinalMeasure)
                    .HasMaxLength(10)
                    .HasColumnName("work_final_measure");

                entity.Property(e => e.WorkHeader)
                    .HasMaxLength(20)
                    .HasColumnName("work_header");

                entity.Property(e => e.WorkPrefix)
                    .HasMaxLength(3)
                    .HasColumnName("work_prefix");

                entity.Property(e => e.WorkQty)
                    .HasMaxLength(15)
                    .HasColumnName("work_qty");

                entity.Property(e => e.WorkQtyAsAnInt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.WorkRate01)
                    .HasMaxLength(15)
                    .HasColumnName("work_rate_01");

                entity.Property(e => e.WorkRate02)
                    .HasMaxLength(15)
                    .HasColumnName("work_rate_02");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(2)
                    .HasColumnName("work_type");

                entity.Property(e => e.WorksListCheck).HasMaxLength(1);
            });

            modelBuilder.Entity<WorkTypeLookup>(entity =>
            {
                entity.ToTable("WorkTypeLookup");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkingDay>(entity =>
            {
                entity.Property(e => e.CalendarYear)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Workstream>(entity =>
            {
                entity.ToTable("Workstream");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Refers to primary key of the table.");

                entity.Property(e => e.Workstream1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Workstream")
                    .HasComment("Refers to workstream information.");
            });

            modelBuilder.Entity<XmlLogging>(entity =>
            {
                entity.ToTable("XmlLogging");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasColumnName("data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Namespace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceivedTimestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);
            });

            modelBuilder.HasSequence<int>("VacancySequence")
                .StartsAt(3)
                .HasMin(3)
                .HasMax(999999)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
