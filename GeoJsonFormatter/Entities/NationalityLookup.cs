using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class NationalityLookup
    {
        public NationalityLookup()
        {
            Candidates = new HashSet<Candidate>();
            OperativeFileLiveCopies = new HashSet<OperativeFileLiveCopy>();
            OperativeFiles = new HashSet<OperativeFile>();
        }

        public int Id { get; set; }
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string Nationality { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<OperativeFileLiveCopy> OperativeFileLiveCopies { get; set; }
        public virtual ICollection<OperativeFile> OperativeFiles { get; set; }
    }
}
