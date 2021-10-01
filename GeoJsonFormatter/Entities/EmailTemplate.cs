using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public string Htmlbody { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }

        public virtual OperativeFile CreatedByNavigation { get; set; }
        public virtual OperativeFile ModifiedByNavigation { get; set; }
    }
}
