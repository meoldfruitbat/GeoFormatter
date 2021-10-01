using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CustomerEnquiryDetail
    {
        public CustomerEnquiryDetail()
        {
            CustomerEnquiryActionNotes = new HashSet<CustomerEnquiryActionNote>();
            CustomerEnquiryActionTasks = new HashSet<CustomerEnquiryActionTask>();
            CustomerEnquiryAllocatedHistories = new HashSet<CustomerEnquiryAllocatedHistory>();
            CustomerEnquiryComments = new HashSet<CustomerEnquiryComment>();
            CustomerEnquiryPictures = new HashSet<CustomerEnquiryPicture>();
            CustomerEnquiryReferences = new HashSet<CustomerEnquiryReference>();
        }

        public int Id { get; set; }
        public long? RecordedBy { get; set; }
        public DateTime? RecordedDate { get; set; }
        public DateTime? IncidentDateTime { get; set; }
        public short? SourceOfComplaint { get; set; }
        public string ComplainantName { get; set; }
        public string ComplainantTelephone { get; set; }
        public string ComplainantEmail { get; set; }
        public string ComplainantAddress { get; set; }
        public long? AgreedBy { get; set; }
        public bool? Nctype { get; set; }
        public short? Status { get; set; }
        public short? Priority { get; set; }
        public long? AllocatedTo { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public byte[] Timestamp { get; set; }
        public long? DealWithBy { get; set; }
        public int? NonConformanceId { get; set; }
        public long? Closedoffby { get; set; }
        public bool? IsCustomerEnquiryClosed { get; set; }
        public string ComplainantStreet { get; set; }
        public string ComplainantTownCity { get; set; }
        public string ComplainantPostalcode { get; set; }

        public virtual OperativeFile AgreedByNavigation { get; set; }
        public virtual OperativeFile AllocatedToNavigation { get; set; }
        public virtual OperativeFile DealWithByNavigation { get; set; }
        public virtual ICollection<CustomerEnquiryActionNote> CustomerEnquiryActionNotes { get; set; }
        public virtual ICollection<CustomerEnquiryActionTask> CustomerEnquiryActionTasks { get; set; }
        public virtual ICollection<CustomerEnquiryAllocatedHistory> CustomerEnquiryAllocatedHistories { get; set; }
        public virtual ICollection<CustomerEnquiryComment> CustomerEnquiryComments { get; set; }
        public virtual ICollection<CustomerEnquiryPicture> CustomerEnquiryPictures { get; set; }
        public virtual ICollection<CustomerEnquiryReference> CustomerEnquiryReferences { get; set; }
    }
}
