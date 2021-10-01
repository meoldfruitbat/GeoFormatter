using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public int ConfigurationType { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsEditable { get; set; }
        public bool? IsStatusEditable { get; set; }
        public bool IsDeletable { get; set; }
        public string Notes { get; set; }

        public virtual ConfigurationType ConfigurationTypeNavigation { get; set; }
    }
}
