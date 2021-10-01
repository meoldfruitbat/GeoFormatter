using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class WeatherDatum
    {
        public long Id { get; set; }
        public DateTime? DateOfCheck { get; set; }
        public string GangLeader { get; set; }
        public string StartWeather { get; set; }
        public string MorningWeather { get; set; }
        public string AfternoonWeather { get; set; }
        public string EndWeather { get; set; }
        public string Weather { get; set; }
        public string Notes { get; set; }
        public string TimeOfCheck { get; set; }
        public string PeriodEndTime { get; set; }
        public long? Qnumber { get; set; }
        public long? JobId { get; set; }
        public string Icon { get; set; }
    }
}
