using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class OperativeFileLiveCopy
    {
        public long OperativeId { get; set; }
        public string Initials { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string GroupId { get; set; }
        public string Department { get; set; }
        public string Payroll { get; set; }
        public string ParentGroup { get; set; }
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
        public string HolidayPlanner { get; set; }
        public DateTime? EmploymentStarted { get; set; }
        public DateTime? EmploymentEnded { get; set; }
        public string EntitlementThisYear { get; set; }
        public string EntThisYearRemain { get; set; }
        public string EntitlementNextYear { get; set; }
        public string EntNextYearremain { get; set; }
        public string ThisYear { get; set; }
        public string NextYear { get; set; }
        public string PublicHolidaysThisYear { get; set; }
        public string PublicHolidaysNextYear { get; set; }
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
        public string CompanyEmail { get; set; }
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

        public virtual NationalityLookup NationalityNavigation { get; set; }
    }
}
