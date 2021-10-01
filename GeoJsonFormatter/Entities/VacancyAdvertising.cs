using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class VacancyAdvertising
    {
        public VacancyAdvertising()
        {
            VacancyAdvertisingMethods = new HashSet<VacancyAdvertisingMethod>();
        }

        public int Id { get; set; }
        public int VacancyId { get; set; }
        public DateTime AdvertDate { get; set; }
        public bool IsInternal { get; set; }
        public string AdvertisingDetails { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Vacancy Vacancy { get; set; }
        public virtual ICollection<VacancyAdvertisingMethod> VacancyAdvertisingMethods { get; set; }
    }
}
