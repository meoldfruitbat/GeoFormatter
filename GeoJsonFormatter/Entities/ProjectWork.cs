using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class ProjectWork
    {
        public int Id { get; set; }
        public Guid? AssignmentId { get; set; }
        public long? QuoteId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public decimal? Qty { get; set; }
        public string BaseUnit { get; set; }
        public Guid? Identifier { get; set; }
        public long? RevisionId { get; set; }
        public Guid? WorksIdForDelete { get; set; }
        public string Category { get; set; }
        public bool? IsAdditionalWork { get; set; }
        public string DesignatorType { get; set; }
        public string CreatedFrom { get; set; }
        public long? Cvino { get; set; }
        public string Gps { get; set; }
        public string Shiftpattern { get; set; }

        public virtual Cvi CvinoNavigation { get; set; }
        public virtual Valuation Revision { get; set; }
    }
}
