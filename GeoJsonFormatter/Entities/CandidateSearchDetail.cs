using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class CandidateSearchDetail
    {
        public CandidateSearchDetail()
        {
            CandidateSearches = new HashSet<CandidateSearch>();
            InverseParent = new HashSet<CandidateSearchDetail>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public DateTime? SearchedDateTime { get; set; }
        public string SearchType { get; set; }
        public string SearchOperator { get; set; }
        public string SearchText { get; set; }

        public virtual CandidateSearchDetail Parent { get; set; }
        public virtual ICollection<CandidateSearch> CandidateSearches { get; set; }
        public virtual ICollection<CandidateSearchDetail> InverseParent { get; set; }
    }
}
