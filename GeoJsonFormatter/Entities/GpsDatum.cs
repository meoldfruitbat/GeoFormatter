using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class GpsDatum
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public decimal GpsLatitude { get; set; }
        public decimal GpsLongitude { get; set; }
        public decimal GpsSpeed { get; set; }
        public decimal GpsHeading { get; set; }
        public int GpsFix { get; set; }
        public int GpsOdo { get; set; }
        public DateTime TimeUtc { get; set; }
        public DateTime TimeLocal { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public decimal SpeedLimit { get; set; }
        public int? DriverId { get; set; }
        public int? TagId { get; set; }
        public int? SiteCode { get; set; }
        public int? Authorised { get; set; }
        public int? Entered { get; set; }
        public int? JourneyIdle { get; set; }
        public int? JourneyDuration { get; set; }
        public int? JourneyDistance { get; set; }
        public bool? BusinessButton { get; set; }
        public string VehicleRegistration { get; set; }
        public decimal? VehicleTemperature { get; set; }
        public int? PoiId { get; set; }
        public string PoiName { get; set; }
        public int? PoiType { get; set; }
        public bool? PoiIn { get; set; }
        public int? PoiRadius { get; set; }
        public int? PoiLogType { get; set; }
        public string EventType { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public int Processed { get; set; }
        public DateTime InsertedTime { get; set; }
    }
}
