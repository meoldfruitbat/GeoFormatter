using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ClientContractorFile
    {
        public ClientContractorFile()
        {
            ContractorDetailReferences = new HashSet<ContractorDetailReference>();
            ContractorDetails = new HashSet<ContractorDetail>();
            ContractorPartnerDetails = new HashSet<ContractorPartnerDetail>();
            SubContractorOperatives = new HashSet<SubContractorOperative>();
            SubContractorTeams = new HashSet<SubContractorTeam>();
        }

        public long Id { get; set; }
        public string ContractorName { get; set; }
        public string AccountNo { get; set; }
        public string ContractorAddress01 { get; set; }
        public string ContractorAddress02 { get; set; }
        public string ContractorAddress03 { get; set; }
        public string ContractorAddress04 { get; set; }
        public string ContractorCity { get; set; }
        public string ContractorCounty { get; set; }
        public string ContractorCountry { get; set; }
        public string ContractorPostcode { get; set; }
        public string ContractorOffice { get; set; }
        public string ContractorFax { get; set; }
        public string ContractorEmail { get; set; }
        public string ContractorWww { get; set; }
        public string LegalForm { get; set; }
        public string ContractorRegNo { get; set; }
        public bool? IsVatregistered { get; set; }
        public string Vatno { get; set; }
        public string Utrno { get; set; }
        public string Dunsno { get; set; }
        public string ParentCompanyName { get; set; }
        public string ParentCoRegNo { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string OfficeTitle { get; set; }
        public bool? IsAccountSuspended { get; set; }
        public bool? DisableAccount { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool IsParentCompany { get; set; }
        public string TimeStampRates { get; set; }
        public string TimeStampForOperatives { get; set; }

        public virtual ICollection<ContractorDetailReference> ContractorDetailReferences { get; set; }
        public virtual ICollection<ContractorDetail> ContractorDetails { get; set; }
        public virtual ICollection<ContractorPartnerDetail> ContractorPartnerDetails { get; set; }
        public virtual ICollection<SubContractorOperative> SubContractorOperatives { get; set; }
        public virtual ICollection<SubContractorTeam> SubContractorTeams { get; set; }
    }
}
