using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class UserFavoriteProject
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public long QuoteId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual OperativeFile User { get; set; }
    }
}
